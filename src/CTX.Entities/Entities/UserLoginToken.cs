using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CTX.Entities
{
    public class UserLoginToken
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        [StringLength(250)]
        public string Token { get; set; }
        public DateTime LastLoginDated { get; set; }
        public DateTime ExpiredDated { get; set; }
        public bool? IsRememberMe { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
