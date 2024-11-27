using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.DAL
{
    internal class EnCryptDAL
    {
        //private static string key = "Khainguyen@2710";
        private static string key = "DoAnQuanLyCuaHangKFC2024";
        public static string EncryptMD5(string plainText)
        {
            string encrypted = null;

            try
            {
                // Dữ liệu đầu vào cần mã hóa
                byte[] inputBytes = Encoding.ASCII.GetBytes(plainText);

                // Tạo một TripleDES mới với key đã đủ 24 byte
                TripleDESCryptoServiceProvider tdesProvider = new TripleDESCryptoServiceProvider();

                // Sử dụng key gốc mà không cần MD5
                tdesProvider.Key = Encoding.ASCII.GetBytes(key); // Chuyển key thành byte array
                tdesProvider.Mode = CipherMode.ECB;

                // Thực hiện mã hóa
                encrypted = Convert.ToBase64String(tdesProvider.CreateEncryptor().TransformFinalBlock(inputBytes, 0, inputBytes.Length));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi mã hóa: " + ex.Message);
                throw;
            }

            return encrypted;
        }
    }
}
