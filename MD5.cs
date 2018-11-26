using System.Text;
using System.Security.Cryptography;

namespace md5
{
    public class Converter
    {
        public class hash
        {
            public static string stringMD5(string Input)
            {
                using (MD5 _hash = MD5.Create())
                    return GetMd5Hash(_hash, Input);
            }

            static string GetMd5Hash(MD5 _hash, string input)
            {
                byte[] data = _hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder sBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }
                return sBuilder.ToString();
            }
        }
    }
}
