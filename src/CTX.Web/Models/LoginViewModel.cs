using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CTX.Web.Models
{
    public class LoginViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsRememberMe { get; set; }
        public bool IsError { get; set; }
        public string ErrorMessage { get; set; }
        public string Captcha { get; set; }
        public string RedirectUrl { get; set; }
    }
}
