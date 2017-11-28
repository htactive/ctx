using CTX.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CTX.Web.Models
{
    public class UserProfileModel
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string Email { get; set; }
        public bool? WasVerifiedEmail { get; set; }
        public int? AvatarId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public UserModel User { get; set; }
        public ImageModel Image { get; set; }
    }

    public class ChangePassModel
    {
        public string oldPass { get; set; }
        public string newPass { get; set; }
        public string confirmPass { get; set; }
    }
}
