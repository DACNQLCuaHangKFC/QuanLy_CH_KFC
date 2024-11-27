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
    class LoaiMonAnDAL
    {
        private DBConnect db = new DBConnect();

        public static DataTable hienThiLoaiMonAn()
        {
            string query = "SELECT * FROM LoaiMonAn";
            DBConnect db = new DBConnect();
            db.Close();
            return db.TableRead(query);
        }

        public static string taoMaLmaMoi()
        {
            string query = "SELECT TOP 1 MaLoai FROM LoaiMonAn ORDER BY MaLoai DESC";
            DBConnect db = new DBConnect();
            SqlConnection connection = db.GetConnection();
            string newMaLma = "LMA001";

            try
            {
                SqlDataReader reader = db.ExecuteReader(query);

                if (reader.Read())
                {
                    string lastMaLma = reader["MaLoai"].ToString();
                    int kq = int.Parse(lastMaLma.Substring(3)) + 1;
                    newMaLma = "LMA" + kq.ToString("D3");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo mã loại món ăn: " + ex.Message);
            }

            finally
            {
                db.CloseConnection(connection);
            }
            return newMaLma;

        }

        public bool ThemLoaiMonAn(string maLma, string tenLma)
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

                    SqlCommand command = new SqlCommand("sp_InsertLoaiMonAn", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaLoai", maLma);
                    command.Parameters.AddWithValue("@TenLoai", tenLma);
                    connection.Close();
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm loại món ăn: " + ex.Message);
                return false;
            }
        }

        public bool XoaLoaiMonAn(string maLma)
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

                    SqlCommand command = new SqlCommand("sp_DeleteLoaiMonAn", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaLoai", maLma);
                    connection.Close();
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy loại món ăn với mã: " + maLma);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa loại món ăn: " + ex.Message);
                return false;
            }
        }

        public bool CapNhatLoaiMonAn(string maLma, string tenLma)
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

                    SqlCommand command = new SqlCommand("sp_UpdateLoaiMonAn", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaLoai", maLma);
                    command.Parameters.AddWithValue("@TenLoai", tenLma);
                    connection.Close();
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật loại món ăn: " + ex.Message);
                return false;
            }
        }
    }
}
