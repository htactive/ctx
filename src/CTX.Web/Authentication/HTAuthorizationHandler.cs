
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Diagnostics;
using HTActive.Web.Helpers;
using HTActive.Common;
using CTX.Repository;
using CTX.Common;
using CTX.Entities;

namespace CTX.Web.Authentication
{
    public class HTAuthorizeAttribute : AuthorizeAttribute
    {
        public HTAuthorizeAttribute()
        {
            ActiveAuthenticationSchemes = "ExternalCookiesAuthentication";
        }
        
    }

    public class HTAuthorizationHandler : IAuthorizationHandler
    {
        private CTXDBRepository CTXDBRepository;
        public HTAuthorizationHandler(CTXDBRepository _CTXDBRepository)
        {
            this.CTXDBRepository = _CTXDBRepository;
        }
        public Task HandleAsync(AuthorizationHandlerContext context)
        {
            var mvcContext = context.Resource as Microsoft.AspNetCore.Mvc.Filters.AuthorizationFilterContext;
            if (mvcContext == null) return Task.CompletedTask;

            string jwt = mvcContext.HttpContext.Request.Cookies["auth"];

            if (string.IsNullOrEmpty(jwt) || jwt == "null") return Task.CompletedTask;

            var payloadString = JwtHelper.Decode(jwt);

            if (string.IsNullOrEmpty(payloadString)) return Task.CompletedTask;

            var payLoad = JsonConvert.DeserializeObject<Dictionary<string, string>>(payloadString);
            var token = payLoad["token"];
            if (string.IsNullOrEmpty(token)) return Task.CompletedTask;

            var loginSession = CTXDBRepository.UserLoginTokenRepository.GetAll()
                .Include(x => x.User)
                .FirstOrDefault(x => x.Token == token);

            if (loginSession == null) return Task.CompletedTask;

            //Check if user was banned
            if (loginSession?.User?.UserStatusId == UserStatusEnums.Deactive) return Task.CompletedTask;
            
            if (loginSession.ExpiredDated < DateTimeHelper.GetDateTimeNow())
            {
                return Task.CompletedTask;
            }


            loginSession.LastLoginDated = DateTimeHelper.GetDateTimeNow();
            loginSession.ExpiredDated = DateTimeHelper.GetDateTimeNow().AddDays(loginSession.IsRememberMe.GetValueOrDefault() ? 14 : 1);

            CTXDBRepository.UserLoginTokenRepository.Save(loginSession);
            CTXDBRepository.Commit();
            var requireClaim = GetRequireClaimFromControllerAndActionName(mvcContext.RouteData.Values["controller"] + "", mvcContext.RouteData.Values["action"] + "");
            if (!CheckClaimExistsInDatabase(requireClaim))
            {
                this.CreateNewClaim(requireClaim);
            }
            if (!CheckClaims(requireClaim, loginSession.UserId))
            {
#if DEBUG
                var userRole = CTXDBRepository.UserRoleRepository.GetAll().Where(x => x.UserId.HasValue && x.UserId.Value == loginSession.UserId).Select(x => x.Role).OrderByDescending(x => x.RoleType).FirstOrDefault();
                var link = "/api/role/grant-access?c=" + requireClaim + "&r=" + (int)userRole.RoleType;
                Debugger.Break();
#endif
                return Task.CompletedTask;
            }
            foreach (var requirement in context.Requirements)
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }

        private string GetRequireClaimFromControllerAndActionName(string controllerName, string actionName)
        {
            var json = string.Empty;
            using (var file = new FileStream("Data/authorization.json", FileMode.Open, FileAccess.Read))
            {
                using (var reader = new StreamReader(file))
                {
                    json = reader.ReadToEnd();
                }
            }
            var list = JsonConvert.DeserializeObject<List<AuthorizationControllerJsonModel>>(json);
            var controller = list.FirstOrDefault(x => x.controller == controllerName);
            if (controller == null)
            {
                throw new Exception("Not found controller " + controllerName);
            }
            var claim = controller.actions
                .Where(x => x.name == actionName || x.name == "*")
                .OrderBy(x => x.name == actionName ? 0 : x.name == "*" ? 1 : 2).FirstOrDefault();
            if (claim == null)
            {
                throw new Exception(string.Format("Not found controller: {0} action: {1} ", controllerName, actionName));
            }
            return claim.claim;
        }

        private bool CheckClaimExistsInDatabase(string claim)
        {
            return CTXDBRepository.ClaimRepository.GetAll().Any(x => x.ClaimName == claim);
        }
        private void CreateNewClaim(string claim)
        {
            var entity = new Claim()
            {
                Id = 0,
                ClaimName = claim
            };
            CTXDBRepository.ClaimRepository.Save(entity);
            CTXDBRepository.Commit();
        }

        private bool CheckClaims(string requireClaim, int userId)
        {
            return CTXDBRepository.UserRoleRepository.GetAll()
                .Include("Role.RoleClaims.Claim")
                .Where(x => x.UserId.HasValue && x.UserId.Value == userId).Select(x => x.Role).SelectMany(x => x.RoleClaims).Select(x => x.Claim).Any(x => x.ClaimName == requireClaim);

        }
    }

    public class AuthorizationControllerJsonModel
    {
        public string controller { get; set; }
        public List<AuthorizationActionJsonModel> actions { get; set; }
    }

    public class AuthorizationActionJsonModel
    {
        public string name { get; set; }
        public string claim { get; set; }
    }
}
