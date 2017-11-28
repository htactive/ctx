
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CTX.Entities
{
    public class RoleClaim
    {
        [Key]
        public int Id { get; set; }
        public int? RoleId { get; set; }
        public int? ClaimId { get; set; }

        [ForeignKey("ClaimId")]
        public Claim Claim { get; set; }

        [ForeignKey("RoleId")]
        public Role Role { get; set; }
    }
}
