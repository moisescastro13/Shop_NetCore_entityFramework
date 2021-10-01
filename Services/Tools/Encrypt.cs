using System.Security.Cryptography;
using System.Text;

namespace Services.Tools
{
    public class Encrypt
    {
        public static string GetSha256(string str)
        {
            SHA256 shas256 = SHA256.Create();
            ASCIIEncoding encodig = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = shas256.ComputeHash(encodig.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
    }
}