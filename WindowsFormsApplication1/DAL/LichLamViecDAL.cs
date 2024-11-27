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
    class LichLamViecDAL
    {
        private DBConnect db = new DBConnect();
        public static DataTable hienThiLichLamViec()
        {
            string query = "SELECT * FROM LichLamViec";
            DBConnect db = new DBConnect();
            db.Close();
            return db.TableRead(query);
        }


        public bool ThemLichLamViec(string maCa, string maNv, DateTime ngayLam)
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

                    SqlCommand command = new SqlCommand("sp_InsertLichLamViec", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaCaLam", maCa);
                    command.Parameters.AddWithValue("@MaNhanVien", maNv);
                    command.Parameters.AddWithValue("@NgayLamViec",ngayLam);
                    connection.Close();
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm lịch làm việc: " + ex.Message);
                return false;
            }
        }

        public bool XoaLichLamViec(string maCa, string maNv)
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

                    SqlCommand command = new SqlCommand("sp_DeleteLichLamViec", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaCaLam",maCa);
                    command.Parameters.AddWithValue("@MaNhanVien",maNv);
                    connection.Close();
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy lịch làm việc với mã: " + maCa);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa lịch làm việc: " + ex.Message);
                return false;
            }
        }

        public bool CapNhatLichLamViec(string maCa, string maNv, DateTime ngayLam)
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

                    SqlCommand command = new SqlCommand("sp_UpdateLichLamViec", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaCaLam", maCa);
                    command.Parameters.AddWithValue("@MaNhanVien", maNv);
                    command.Parameters.AddWithValue("@NgayLamViec", ngayLam);
                    connection.Close();
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật lịch làm việc: " + ex.Message);
                return false;
            }
        }
    }
}
