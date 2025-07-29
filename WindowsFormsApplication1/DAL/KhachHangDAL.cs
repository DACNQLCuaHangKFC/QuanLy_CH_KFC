using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Sdk.Sfc;
using WindowsFormsApplication1.DTO;

namespace WindowsFormsApplication1.DAL
{
    class KhachHangDAL
    {
        private DBConnect dbConnect = new DBConnect();

        // Lấy danh sách tất cả khách hàng (vẫn dùng stored procedure như trước)
        public List<KhachHangDTO> GetAllKhachHang()
        {
            List<KhachHangDTO> danhSachKhachHang = new List<KhachHangDTO>();
            string query = "sp_HienThiTatCaKhachHang"; // Gọi Stored Procedure
            using (SqlDataReader reader = dbConnect.ExecuteReader(query))
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        KhachHangDTO khachHang = new KhachHangDTO()
                        {
                            SoDienThoai = reader["SoDienThoai"].ToString(),
                            TenKhachHang = reader["TenKhachHang"].ToString(),
                            Email = reader["Email"].ToString(),
                            NgaySinh = reader["NgaySinh"] as DateTime?,
                            DiemTichLuy = Convert.ToInt32(reader["DiemTichLuy"])
                        };
                        danhSachKhachHang.Add(khachHang);
                    }
                }
            }
            return danhSachKhachHang;
        }

        // Thêm khách hàng (gọi procedure sp_InsertKhachHang)
        public bool AddKhachHang(KhachHangDTO khachHang)
        {
            string query = "sp_InsertKhachHang";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@SoDienThoai", khachHang.SoDienThoai),
                new SqlParameter("@TenKhachHang", khachHang.TenKhachHang),
                new SqlParameter("@Email", khachHang.Email),
                new SqlParameter("@NgaySinh", (object)khachHang.NgaySinh ?? DBNull.Value),
                new SqlParameter("@DiemTichLuy", khachHang.DiemTichLuy)
            };
            return dbConnect.ExecuteNonQuery(query, parameters, CommandType.StoredProcedure) > 0;
        }

        // Sửa thông tin khách hàng (gọi procedure sp_UpdateKhachHang)
        public bool UpdateKhachHang(KhachHangDTO khachHang)
        {
            string query = "sp_UpdateKhachHang";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@SoDienThoai", khachHang.SoDienThoai),
                new SqlParameter("@TenKhachHang", khachHang.TenKhachHang),
                new SqlParameter("@Email", khachHang.Email),
                new SqlParameter("@NgaySinh", (object)khachHang.NgaySinh ?? DBNull.Value),
                new SqlParameter("@DiemTichLuy", khachHang.DiemTichLuy)
            };
            return dbConnect.ExecuteNonQuery(query, parameters, CommandType.StoredProcedure) > 0;
        }

        public bool KiemTraTonTaiSoDienThoai(string soDienThoai)
        {
            string query = "SELECT 1 FROM KhachHang WHERE SoDienThoai = @SoDienThoai";
            SqlParameter[] parameters = {
        new SqlParameter("@SoDienThoai", soDienThoai)
    };

            using (SqlConnection connection = dbConnect.GetConnection())
            {
                if (connection == null)
                {
                    return false; // Không thể kết nối với cơ sở dữ liệu
                }

                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddRange(parameters);

                    // Sử dụng ExecuteReader để thực hiện truy vấn và lấy dữ liệu
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Kiểm tra xem có bản ghi nào trả về không
                        return reader.HasRows; // Nếu có dòng dữ liệu trả về, nghĩa là số điện thoại đã tồn tại
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực thi truy vấn: " + ex.Message);
                    return false; // Trả về false nếu có lỗi
                }
            }
        }
        public bool AddKhachHangWithDefaultDiemTichLuy(string soDienThoai, string tenKhachHang)
        {
            string query = "INSERT INTO KhachHang (SoDienThoai, TenKhachHang, DiemTichLuy) VALUES (@SoDienThoai, @TenKhachHang, 0)";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@SoDienThoai", soDienThoai),
        new SqlParameter("@TenKhachHang", tenKhachHang)
            };

            return dbConnect.ExecuteNonQuery(query, parameters, CommandType.Text) > 0;
        }

    }
}
