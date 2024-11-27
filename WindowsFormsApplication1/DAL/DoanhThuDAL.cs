using WindowsFormsApplication1.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.DAL
{
    public class DoanhThuDAL
    {
        private DBConnect db = new DBConnect();

        public static DataTable hienThiDoanhThu()
        {
            string query = "SELECT * FROM DoanhThu";
            DBConnect db = new DBConnect();
            db.Close();
            return db.TableRead(query);
        }
        public DataTable LayChiTietDoanhThuTheoMaDoanhThu(string maDoanhThu)
        {
            try
            {
                DataTable dataTable = new DataTable();

                // Sử dụng using để đảm bảo kết nối được đóng đúng cách
                using (SqlConnection connection = db.GetConnection())
                {
                    if (connection == null)
                    {
                        MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu.");
                        return null;
                    }

                    string query = "SELECT * FROM ChiTietDoanhThu WHERE MaDoanhThu = @MaDoanhThu";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaDoanhThu", maDoanhThu);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }

                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy chi tiết doanh thu: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool UpdateTongDoanhThu(string maDoanhThu)
        {
            using (SqlConnection connection = db.GetConnection())
            {
                SqlCommand command = new SqlCommand("sp_UpdateTongDoanhThu", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MaDoanhThu", maDoanhThu);

                connection.Open();
                int result = command.ExecuteNonQuery();
                return result > 0;
            }
        }

        public bool KiemTraMaDoanhThuTonTai(string maDoanhThu)
        {
            string query = "SELECT COUNT(*) FROM DoanhThu WHERE MaDoanhThu = @MaDoanhThu";
            using (SqlConnection connection = db.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaDoanhThu", maDoanhThu);

                //connection.Open();  // Mở kết nối

                int count = (int)command.ExecuteScalar();  // Thực thi truy vấn và lấy kết quả
                return count > 0;
            }
        }

        public bool ThemDoanhThu(string maDoanhThu, DateTime ngayKetToan)
        {
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    SqlCommand command = new SqlCommand("sp_InsertDoanhThu", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@MaDoanhThu", maDoanhThu);
                    command.Parameters.AddWithValue("@NgayKetToan", ngayKetToan);
                    command.Parameters.AddWithValue("@TongDoanhThu", 0);

                    //connection.Open();
                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm doanh thu: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public DataTable LayDoanhThuTheoThang(int month, int year)
        {
            DataTable dtDoanhThu = new DataTable();

            using (SqlConnection connection = db.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_GetDoanhThuTheoThang", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Month", month);
                    command.Parameters.AddWithValue("@Year", year);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dtDoanhThu);
                }
            }

            return dtDoanhThu;
        }

        public DataTable SearchDoanhThuByDate(string searchTerm)
        {
            //DataTable dataTable = new DataTable();
            using (SqlConnection connection = db.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_SearchDoanhThuByDate", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SearchTerm", searchTerm);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                return dataTable;
            }
        }
    }
}
