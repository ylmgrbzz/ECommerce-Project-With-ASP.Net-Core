using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Encryption
{
    public class SecurityKeyHelper
    {
        // CreateSecurityKey() methodu, appsettings.json dosyasındaki SecurityKey değerini byte array'e çevirir
        public static SecurityKey CreateSecurityKey(string securityKey)
        {
            // Encoding.UTF8.GetBytes() methodu, string'i byte array'e çevirir
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
        }
    }
}
