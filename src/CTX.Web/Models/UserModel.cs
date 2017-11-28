using CTX.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CTX.Web.Models
{
    public class LoginRequestModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsRememberMe { get; set; }
        public string Captcha { get; set; }
    }

    public class RegisterViewModel
    {
        public string Password { get; set; }
        public string Email { get; set; }
        public string ConfirmPassword { get; set; }
        public string Captcha { get; set; }
        public bool IsError { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class UserModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool? IsAnonymous { get; set; }
        public UserStatusEnums? UserStatusId { get; set; }
        public string ProviderKey { get; set; }
        public string ProviderName { get; set; }
        public List<UserProfileModel> UserProfiles { get; set; }
        public List<UserRoleModel> UserRoles { get; set; }
        public DateTime? CreateDate { get; set; }
    }

    public class UserVerifyModel
    {
        public int Id { get; set; }
        public bool WasVerified { get; set; }
    }
}
