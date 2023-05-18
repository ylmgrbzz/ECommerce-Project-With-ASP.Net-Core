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
        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            // We need to use the same key to verify the password
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                // ComputeHash() takes a byte array
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                // Compare the computedHash with the passwordHash
                for (int i = 0; i < computedHash.Length; i++)
                {
                    // If the password is wrong, return false
                    if (computedHash[i] != passwordHash[i])
                    {
                        //throw new Exception("Password is wrong!");
                        return false;
                    }
                }
            }
            // If the password is correct, return true
            return true;

        }
    }
}
