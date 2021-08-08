using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
    public class DataToHash
    {
        public string DataHash(string dt)
        {
            SHA1 sha = SHA1.Create();
            byte[] bts = sha.ComputeHash(Encoding.Default.GetBytes(dt));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < bts.Length; i++)
            {
                sb.Append(bts[i]);
            }
            return sb.ToString();
        }
    }
}
