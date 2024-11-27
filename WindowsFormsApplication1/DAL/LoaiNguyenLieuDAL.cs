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
    class LoaiNguyenLieuDAL
    {
        private DBConnect db = new DBConnect();

        public static DataTable hienThiLoaiNguyenLieu()
        {
            string query = "SELECT * FROM LoaiNguyenLieu";
            DBConnect db = new DBConnect();
            db.Close();
            return db.TableRead(query);
        }

        public static string taoMaLnlMoi()
        {
            string query = "SELECT TOP 1 MaLoaiNguyenLieu FROM LoaiNguyenLieu ORDER BY MaLoaiNguyenLieu DESC";
            DBConnect db = new DBConnect();
            SqlConnection connection = db.GetConnection();
            string newMaLnl = "LNL001";

            try
            {
                SqlDataReader reader = db.ExecuteReader(query);

                if (reader.Read())
                {
                    string lastMaLnl = reader["MaLoaiNguyenLieu"].ToString();
                    int kq = int.Parse(lastMaLnl.Substring(3)) + 1;
                    newMaLnl = "LNL" + kq.ToString("D3");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo mã loại nguyên liệu: " + ex.Message);
            }

            finally
            {
                db.CloseConnection(connection);
            }
            return newMaLnl;

        }

        public bool ThemLoaiNguyenLieu(string maLnl, string tenLnl)
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

                    SqlCommand command = new SqlCommand("sp_InsertLoaiNguyenLieu", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaLoaiNguyenLieu", maLnl);
                    command.Parameters.AddWithValue("@TenLoaiNguyenLieu", tenLnl);   
                    connection.Close();
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm loại nguyên liệu: " + ex.Message);
                return false;
            }
        }

        public bool XoaLoaiNguyenLieu(string maLnl)
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

                    SqlCommand command = new SqlCommand("sp_DeleteLoaiNguyenLieu", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaLoaiNguyenLieu", maLnl);
                    connection.Close();
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy loại nguyên liệu với mã: " + maLnl);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa loại nguyên liệu: " + ex.Message);
                return false;
            }
        }

        public bool CapNhatLoaiNguyenLieu(string maLnl, string tenLnl)
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

                    SqlCommand command = new SqlCommand("sp_UpdateLoaiNguyenLieu", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaLoaiNguyenLieu", maLnl);
                    command.Parameters.AddWithValue("@TenLoaiNguyenLieu", tenLnl);
                    connection.Close();
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật loại nguyên liệu: " + ex.Message);
                return false;
            }
        }
    }
}
