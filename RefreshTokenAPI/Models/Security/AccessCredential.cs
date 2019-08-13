using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RefreshTokenAPI.Models.Security
{
    public class AccessCredential
    {
        public string UserID { get; set; }
        public string AccessKey { get; set; }
        public string RefreshToken { get; set; }
        public string GrantType { get; set; }
    }
}
