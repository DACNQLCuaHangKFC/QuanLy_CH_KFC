using WindowsFormsApplication1.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.BUS;
using WindowsFormsApplication1.DTO;

namespace WindowsFormsApplication1.DAL
{
    public class NhanVienDAL
    {
        private DBConnect db = new DBConnect();
        public static string kiemDangNhap(string username, string password)
        {
            string MaNhanVien = null;
            string query = string.Format("SELECT MaNhanVien FROM NhanVien WHERE MaNhanVien = '{0}' and MatKhau = '{1}'", username, password);
            DBConnect db = new DBConnect();
            DataTable dt = db.TableRead(query);
            if (dt.Rows.Count > 0)
            {
                MaNhanVien = dt.Rows[0]["MaNhanVien"].ToString();
                return MaNhanVien;
            }

            return "ERROR";
        }

        public NhanVienDTO GetNhanVienByMaNV(string maNV)
        {
            NhanVienDTO nhanVien = null;
            string query = "SELECT MaNhanVien, TenNhanVien, MaLoaiNhanVien FROM NhanVien WHERE MaNhanVien = @MaNV";

            using (SqlConnection connection = db.GetConnection())
            {
                if (connection == null)
                {
                    MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu.");
                    return null;
                }

                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaNV", maNV);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        nhanVien = new NhanVienDTO
                        {
                            MaNhanVien = reader["MaNhanVien"].ToString(),
                            TenNhanVien = reader["TenNhanVien"].ToString(),
                            MaLoaiNhanVien = reader["MaLoaiNhanVien"].ToString()
                        };
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lấy thông tin nhân viên: " + ex.Message);
                }
                finally
                {
                    db.CloseConnection(connection);
                }
            }

            return nhanVien;
        }

        public static bool doiMatKhau(string password, string id)
        {
            try
            {
                DBConnect db=new DBConnect();
                string query = string.Format("UPDATE NhanVien SET MatKhau = '{0}' WHERE MaNhanVien = '{1}'", password, id);
                db.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool kiemTraMatKhau(string password, string id)
        {
            DBConnect db = new DBConnect();
            string query = string.Format("SELECT MatKhau FROM NhanVien WHERE MaNhanVien = '{0}'", id);
            DataTable dt = db.TableRead(query);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy nhân viên với mã: " + id);
                return false;
            }
            string pass = dt.Rows[0]["MatKhau"].ToString();
            if (pass != password)
            {
                return false;
            }
            return true;
        }

        public static DataTable hienThiNhanVien()
        {
            string query = "SELECT * FROM NhanVien";
            DBConnect db = new DBConnect();
            db.Close();
            return db.TableRead(query);
            
        }

        public static DataTable hienThiNhanVienPhanQuyen()
        {
            string query = "SELECT MaNhanVien,TenNhanVien,MaLoaiNhanVien FROM NhanVien";
            DBConnect db = new DBConnect();
            db.Close();
            return db.TableRead(query);
            
        }


        public static DataTable layLoaiNhanVien()
        {
            string query = "SELECT * FROM LoaiNhanVien";
            DBConnect db = new DBConnect();
            return db.TableRead(query);
        }

        public static string taoMaNvMoi()
        {
            string query = "SELECT TOP 1 MaNhanVien FROM NhanVien ORDER BY MaNhanVien DESC";
            DBConnect db = new DBConnect();
            SqlConnection connection = db.GetConnection();
            string newMaChiTiet = "NV001";

            try
            {
                SqlDataReader reader = db.ExecuteReader(query);

                if (reader.Read())
                {
                    string lastMnv = reader["MaNhanVien"].ToString();
                    int kq = int.Parse(lastMnv.Substring(2)) + 1;  
                    newMaChiTiet = "NV" + kq.ToString("D3"); 
                }

                reader.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo mã nhân viên: " + ex.Message);
            }

            finally
            {
                db.CloseConnection(connection);
            }
            return newMaChiTiet;
            
        }

        public bool ThemNhanVien(string maNV, string tenNV, string soDienThoai, string diaChi, string hinhThucLam, string maLoaiNV, float luong)
        {
            db.Close();
            try
            {
                string matKhau = DAL.EnCryptDAL.EncryptMD5("123");
                using (SqlConnection connection = db.GetConnection())
                {
                    if (connection == null)
                    {
                        MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu.");
                        return false;
                    }

                    SqlCommand command = new SqlCommand("sp_InsertNhanVien", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaNhanVien", maNV);
                    command.Parameters.AddWithValue("@TenNhanVien", tenNV);
                    command.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                    command.Parameters.AddWithValue("@DiaChi", diaChi);
                    command.Parameters.AddWithValue("@HinhThucLam", hinhThucLam);
                    if (string.IsNullOrEmpty(maLoaiNV))
                    {
                        command.Parameters.AddWithValue("@MaLoaiNhanVien", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@MaLoaiNhanVien", maLoaiNV);
                    }
                    command.Parameters.AddWithValue("@Luong", luong);
                    command.Parameters.AddWithValue("@MatKhau", matKhau);
                    connection.Close();
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                    return true;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhân viên: " + ex.Message);
                return false;
            }
        }

        public bool XoaNhanVien(string maNV)
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

                    SqlCommand command = new SqlCommand("sp_DeleteNhanVien", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaNhanVien", maNV);
                    connection.Close();
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        return true; // Xóa thành công
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhân viên với mã: " + maNV);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message);
                return false;
            }
        }

        public bool CapNhatNhanVien(string maNV, string tenNV, string soDienThoai, string diaChi, string hinhThucLam, string maLoaiNV, float luong)
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

                    SqlCommand command = new SqlCommand("sp_UpdateNhanVien", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaNhanVien", maNV);
                    command.Parameters.AddWithValue("@TenNhanVien", tenNV);
                    command.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                    command.Parameters.AddWithValue("@DiaChi", diaChi);
                    command.Parameters.AddWithValue("@HinhThucLam", hinhThucLam);

                    if (string.IsNullOrEmpty(maLoaiNV))
                    {
                        command.Parameters.AddWithValue("@MaLoaiNhanVien", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@MaLoaiNhanVien", maLoaiNV);
                    }

                    command.Parameters.AddWithValue("@Luong", luong);
                    connection.Close();
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật nhân viên: " + ex.Message);
                return false;
            }
        }

        public DataTable TimKiemNhanVien(string tenNhanVien)
        {
            using (SqlConnection connection = db.GetConnection())
            {
                if (connection == null)
                {
                    return null; 
                }

                try
                {
                    SqlCommand command = new SqlCommand("sp_TimKiemNhanVien", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TenNhanVien", tenNhanVien);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm kiếm nhân viên: " + ex.Message);
                    return null;
                }
            }
        }

        public bool CapNhatMaLoaiNhanVien(string maNV, string maLoaiNV)
        {
            using (SqlConnection connection = db.GetConnection())
            {
                if (connection == null)
                {
                    MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu.");
                    return false;
                }

                try
                {
                    SqlCommand command = new SqlCommand("sp_UpdateMaLoaiNhanVien", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaNhanVien", maNV);
                    command.Parameters.AddWithValue("@MaLoaiNhanVien", maLoaiNV);
                    connection.Close();
                    connection.Open();
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật loại nhân viên: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
