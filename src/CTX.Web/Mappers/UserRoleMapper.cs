using Base.Entities;
using CTX.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CTX.Web.Mappers
{
    public partial class Mapper
    {
        public static UserRoleModel ToModel(UserRole entity)
        {
            return entity == null ? null : new UserRoleModel()
            {
                Id = entity.Id,
                RoleId = entity.RoleId.GetValueOrDefault(),
                UserId = entity.UserId.GetValueOrDefault(),
                Role = new RoleModel() { Id = entity.RoleId.GetValueOrDefault() },
                User = new UserModel() { Id = entity.UserId.GetValueOrDefault() }
            };
        }

        public static List<UserRoleModel> ToModel(IEnumerable<UserRole> entities)
        {
            return entities == null ? null : entities.Select(ToModel).ToList();
        }
    }
}
