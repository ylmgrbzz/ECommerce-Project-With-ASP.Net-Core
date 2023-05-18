using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Encryption
{
    public class SigningCredentialsHelper
    {
        // CreateSigningCredentials() methodu, appsettings.json dosyasındaki SecurityKey değerini ve SecurityAlgorithms.HmacSha512Signature değerini kullanarak SigningCredentials nesnesi oluşturur
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)
        {
            // SigningCredentials nesnesi, JWT'nin doğruluğunu doğrulamak için kullanılır
            return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);
        }
    }
}
