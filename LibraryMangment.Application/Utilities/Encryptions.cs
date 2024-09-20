using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace LibraryMangment.Application.Utilities
{
    internal static class Encryptions
    {
        private const string MiddlewareKey = "-dfdkafjdafjdjerieorje/";
        public static string Hash(string key)
        {
            Byte[] KeyBytes = Encoding.UTF8.GetBytes(key);
            SHA256 sHA256 = SHA256.Create();
            Byte[] HasehedKey = sHA256.ComputeHash(KeyBytes);
            return Convert.ToBase64String(HasehedKey);
        }
        public static string HashWithSalt(string key)
        {
            var HashKey  = Hash(key);
            var RandomKey = Guid.NewGuid();
            return HashKey + MiddlewareKey + RandomKey;
        }
        public static string HashedOnly(string key)
        {
            var Split = key.Split(MiddlewareKey);
            return Split[0];
        }
    }
}
