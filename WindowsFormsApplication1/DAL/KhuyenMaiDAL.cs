using WindowsFormsApplication1.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApplication1.BUS;
using WindowsFormsApplication1.DTO;


namespace WindowsFormsApplication1.DAL
{
    class KhuyenMaiDAL
    {
        private DBConnect db = new DBConnect();

        public static DataTable hienThiKhuyenMai()
        {
            string query = "SELECT * FROM KhuyenMai";
            DBConnect db = new DBConnect();
            db.Close();
            return db.TableRead(query);
        }

        public static string taoMaKmMoi()
        {
            string query = "SELECT TOP 1 MaKhuyenMai FROM KhuyenMai ORDER BY MaKhuyenMai DESC";
            DBConnect db = new DBConnect();
            SqlConnection connection = db.GetConnection();
            string newMaKm = "KM001";

            try
            {
                SqlDataReader reader = db.ExecuteReader(query);

                if (reader.Read())
                {
                    string lastMaKm = reader["MaKhuyenMai"].ToString();
                    int kq = int.Parse(lastMaKm.Substring(2)) + 1;
                    newMaKm = "KM" + kq.ToString("D3");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo mã khuyến mãi: " + ex.Message);
            }

            finally
            {
                db.CloseConnection(connection);
            }
            return newMaKm;

        }

        public bool ThemKhuyenMai(string maKm, string tenKm, float ptkm ,DateTime ngayBd, DateTime ngayKt)
        {
            db.Close();
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    if (connection == null)
                    {
                        MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu.");
                        return false;
                    }

                    SqlCommand command = new SqlCommand("sp_InsertKhuyenMai", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaKhuyenMai", maKm);
                    command.Parameters.AddWithValue("@TenKhuyenMai", tenKm);
                    command.Parameters.AddWithValue("@PhanTramKhuyenMai", ptkm);
                    command.Parameters.AddWithValue("@NgayBatDau", ngayBd);
                    command.Parameters.AddWithValue("@NgayKetThuc", ngayKt);
                    connection.Close();
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm khuyến mãi: " + ex.Message);
                return false;
            }
        }

        public bool XoaKhuyenMai(string maKm)
        {
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    if (connection == null)
                    {
                        MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu.");
                        return false;
                    }

                    SqlCommand command = new SqlCommand("sp_DeleteKhuyenMai", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaKhuyenMai", maKm);
                    connection.Close();
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khuyến mãi với mã: " + maKm);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa khuyến mãi: " + ex.Message);
                return false;
            }
        }

        public bool CapNhatKhuyenMai(string maKm, string tenKm, float ptkm, DateTime ngayBd, DateTime ngayKt)
        {
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    if (connection == null)
                    {
                        MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu.");
                        return false;
                    }

                    SqlCommand command = new SqlCommand("sp_UpdateKhuyenMai", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaKhuyenMai", maKm);
                    command.Parameters.AddWithValue("@TenKhuyenMai", tenKm);
                    command.Parameters.AddWithValue("@PhanTramKhuyenMai", ptkm);
                    command.Parameters.AddWithValue("@NgayBatDau", ngayBd);
                    command.Parameters.AddWithValue("@NgayKetThuc", ngayKt);
                    connection.Close();
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật khuyến mãi: " + ex.Message);
                return false;
            }
        }

    }
}
