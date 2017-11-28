using CTX.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CTX.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [StringLength(250)]
        public string UserName { get; set; }
        [StringLength(250)]
        public string Password { get; set; }
        public UserStatusEnums? UserStatusId { get; set; }
        [StringLength(250)]
        public string ProviderKey { get; set; }
        [StringLength(250)]
        public string ProviderName { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public List<UserProfile> UserProfiles { get; set; }
        public List<UserRole> UserRoles { get; set; }
        public List<UserLoginToken> UserLoginTokens { get; set; }
    }
}
