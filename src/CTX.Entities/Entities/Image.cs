using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CTX.Entities
{
    public class Image
    {
        [Key]
        public int Id { get; set; }
        [StringLength(250)]
        public string Url { get; set; }
        [StringLength(250)]
        public string S3FileKey { get; set; }
    }
}
