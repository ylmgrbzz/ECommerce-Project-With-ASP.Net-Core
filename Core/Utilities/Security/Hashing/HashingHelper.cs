using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key; // Key is a random generated key
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password)); // ComputeHash() takes a byte array

            }



        }
        public static void VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
        }
    }
}
