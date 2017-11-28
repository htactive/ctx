using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTActive.Web.Helpers
{
    public static class MD5Helper
    {
        public static string Encode(string input)
        {
            var bytes = Encoding.UTF8.GetBytes(input);
            var md5Crypto = System.Security.Cryptography.MD5.Create();
            var result = md5Crypto.ComputeHash(bytes);
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < (result.Length); i++)
            {
                sBuilder.Append(result[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}
