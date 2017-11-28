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
        public static UserProfileModel ToModel(UserProfile entity)
        {
            return entity == null ? null : new UserProfileModel()
            {
                Id = entity.Id,
                Email = entity.Email,
                AvatarId = entity.AvatarId,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                City = entity.City,
                Address = entity.Address,
                UserId = entity.UserId,
                WasVerifiedEmail = entity.WasVerifiedEmail,
            };
        }

        public static List<UserProfileModel> ToModel(IEnumerable<UserProfile> entities)
        {
            return entities == null ? null : entities.Select(ToModel).ToList();
        }
    }
}
