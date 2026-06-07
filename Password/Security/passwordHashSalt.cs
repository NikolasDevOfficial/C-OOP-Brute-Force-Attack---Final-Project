using System;
using System.Security.Cryptography;
using System.Text;

namespace CsharpBruteForceFinal
{
    public class PasswordHashSalt
    {
        private const string FixedSalt = "aVerySecurePasswordSalt";
        public static byte[] ComputeSHA256Hash(string input)
        {
            string hashedAndSaltedPassword = input + FixedSalt;
            using (SHA256 sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(Encoding.UTF8.GetBytes(hashedAndSaltedPassword));
            }
        }

    }
}