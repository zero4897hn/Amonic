using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Utilities
{
    public class Encryption
    {
        public static string ConvertToMD5(string password)
        {
            MD5CryptoServiceProvider cryptoServiceProvider = new MD5CryptoServiceProvider();
            cryptoServiceProvider.ComputeHash(ASCIIEncoding.ASCII.GetBytes(password));
            byte[] result = cryptoServiceProvider.Hash;
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++) stringBuilder.Append(result[i].ToString("x2"));
            return stringBuilder.ToString();
        }
    }
}
