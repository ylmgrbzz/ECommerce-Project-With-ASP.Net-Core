using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.JWT
{
    public class AccessToken
    {
        // AccessToken nesnesi, kullanıcıya verilen JWT
        public string Token { get; set; }
        // AccessToken nesnesi, kullanıcıya verilen JWT'nin geçerlilik süresi
        public DateTime Expiration { get; set; }
    }
}
