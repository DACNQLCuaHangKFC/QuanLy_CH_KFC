using WindowsFormsApplication1.DTO;
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
    class NganHangDAL
    {
        private readonly DBConnect _dbConnect = new DBConnect();

        // Phương thức lấy tất cả các bản ghi
        public List<NganHangDTO> GetAllNganHang()
        {
            var nganHangList = new List<NganHangDTO>();
            string storedProcedure = "spHienThiTatCaNganHang";

            SqlParameter[] parameters = { }; // Không cần tham số cho phương thức này

            using (SqlDataReader reader = _dbConnect.ExecuteReader(storedProcedure, parameters))
            {
                while (reader.Read())
                {
                    nganHangList.Add(new NganHangDTO
                    {
                        MaNganHang = Convert.ToInt32(reader["MaNganHang"]),
                        TenNganHang = reader["TenNganHang"].ToString(),
                        SoTaiKhoan = reader["SoTaiKhoan"].ToString(),
                        TenChuThe = reader["TenChuThe"].ToString()
                    });
                }
            }
            return nganHangList;
        }

        // Phương thức thêm bản ghi mới
        public bool AddNganHang(NganHangDTO nganHang)
        {
            string storedProcedure = "spThemNganHang";  // Stored Procedure thêm ngân hàng

            SqlParameter[] parameters = {
            new SqlParameter("@MaNganHang", nganHang.MaNganHang),
            new SqlParameter("@TenNganHang", nganHang.TenNganHang),
            new SqlParameter("@SoTaiKhoan", nganHang.SoTaiKhoan),
            new SqlParameter("@TenChuThe", nganHang.TenChuThe)
        };

            return _dbConnect.ExecuteNonQuery(storedProcedure, parameters, CommandType.StoredProcedure) > 0;
        }

        // Phương thức xóa bản ghi
        public bool DeleteNganHang(string soTaiKhoan, string tenChuThe)
        {
            string storedProcedure = "spXoaNganHang";  // Stored Procedure xóa ngân hàng

            SqlParameter[] parameters = {
            new SqlParameter("@SoTaiKhoan", soTaiKhoan),
            new SqlParameter("@TenChuThe", tenChuThe)
        };

            return _dbConnect.ExecuteNonQuery(storedProcedure, parameters, CommandType.StoredProcedure) > 0;
        }
        public bool KiemTraTaiKhoanDaTonTai()
        {
            string query = "SELECT COUNT(*) FROM NganHang"; // Kiểm tra số lượng dòng trong bảng NganHang

            using (SqlConnection connection = _dbConnect.GetConnection())
            {
                if (connection == null)
                {
                    return false; // Không thể kết nối với cơ sở dữ liệu
                }

                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    int count = (int)command.ExecuteScalar();

                    // Nếu số dòng lớn hơn 0, có tài khoản tồn tại trong hệ thống rồi
                    return count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi kiểm tra tài khoản: " + ex.Message);
                    return false; // Trả về false nếu có lỗi
                }
            }
        }


    }
}
