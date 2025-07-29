using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApplication1.DAL
{
    public class KiemTraKetNoiDAL
    {
        public static bool kiemTraKetNoi()
        {
            string projectRoot = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)?.Parent?.Parent?.FullName;
            string configFilePath = Path.Combine(projectRoot, "Config", "config.env");

            if (!File.Exists(configFilePath))
            {
                Console.WriteLine($"Không tìm thấy tệp cấu hình tại: {configFilePath}");
                return false;
            }

            string connectionString;
            try
            {
                connectionString = File.ReadAllText(configFilePath).Trim();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi đọc tệp cấu hình: {ex.Message}");
                return false;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi khi kết nối với cơ sở dữ liệu: {ex.Message}");
                    return false;
                }
            }
        }
    }
}
