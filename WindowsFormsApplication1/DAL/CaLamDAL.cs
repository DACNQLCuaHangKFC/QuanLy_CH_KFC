using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.DAL;

namespace WindowsFormsApplication1.DAL
{
    public class CaLamDAL
    {
        private DBConnect db = new DBConnect();
        public DataTable LayDanhSachCaLam()
        {
            db.Close();
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    string query = "SELECT MaCaLam, ThoiGianBatDau, ThoiGianKetThuc FROM CaLam";
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy danh sách ca làm: " + ex.Message);
            }
            return dt;
        }
    }
}
