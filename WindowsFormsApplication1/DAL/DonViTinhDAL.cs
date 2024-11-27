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
    class DonViTinhDAL
    {
        private DBConnect db = new DBConnect();

        public static DataTable hienThiDonViTinh()
        {
            string query = "SELECT * FROM DanhMucDVT";
            DBConnect db = new DBConnect();
            db.Close();
            return db.TableRead(query);
        }

        public static string taoMDvtMoi()
        {
            string query = "SELECT TOP 1 MaDVT FROM DanhMucDVT ORDER BY MaDVT DESC";
            DBConnect db = new DBConnect();
            SqlConnection connection = db.GetConnection();
            string newMaDvt = "DVT001";

            try
            {
                SqlDataReader reader = db.ExecuteReader(query);

                if (reader.Read())
                {
                    string lastMdvt = reader["MaDVT"].ToString();
                    int kq = int.Parse(lastMdvt.Substring(3)) + 1;
                    newMaDvt = "DVT" + kq.ToString("D3");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo mã đơn vị tính: " + ex.Message);
            }

            finally
            {
                db.CloseConnection(connection);
            }
            return newMaDvt;

        }

        public bool ThemDonViTinh(string maDvt, string tenDvt)
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

                    SqlCommand command = new SqlCommand("sp_InsertDonViTinh", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaDVT", maDvt);
                    command.Parameters.AddWithValue("@TenDVT", tenDvt);   
                    connection.Close();
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm đơn vị tính: " + ex.Message);
                return false;
            }
        }

        public bool XoaDonViTinh(string maDvt)
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

                    SqlCommand command = new SqlCommand("sp_DeleteDonViTinh", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaDVT", maDvt);
                    connection.Close();
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy đơn vị tính với mã: " + maDvt);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa đơn vị tính: " + ex.Message);
                return false;
            }
        }

        public bool CapNhatDonViTinh(string maDvt, string tenDvt)
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

                    SqlCommand command = new SqlCommand("sp_UpdateDonViTinh", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaDVT", maDvt);
                    command.Parameters.AddWithValue("@TenDVT", tenDvt);
                    connection.Close();
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật đơn vị tính: " + ex.Message);
                return false;
            }
        }

    }
}
