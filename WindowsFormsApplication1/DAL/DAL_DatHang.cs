using WindowsFormsApplication1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Data.Common;

namespace WindowsFormsApplication1.DAL
{
    class DAL_DatHang
    {
        private DBConnect dbConnect;
        public DAL_DatHang()
        {
            dbConnect = new DBConnect();
        }
        public DataTable LayNguyenLieuTheoNhaCungCap(string maNCC)
        {
            DataTable dt = new DataTable();
            string query = "sp_LayNguyenLieuTheoNhaCungCap"; // Tên stored procedure

            // Tạo danh sách tham số cho stored procedure
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaNCC", maNCC)
            };

            // Sử dụng SqlDataAdapter để điền DataTable
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, dbConnect.GetConnection()))
            {
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.AddRange(parameters);

                adapter.Fill(dt); // Điền dữ liệu vào DataTable
            }

            return dt; // Trả về DataTable chứa dữ liệu
        }
        public DataTable GetAllNhaCungCap()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = dbConnect.GetConnection())
            {
                if (connection == null)
                {
                    return dt; // Trả về DataTable rỗng nếu không thể kết nối
                }

                using (SqlCommand command = new SqlCommand("SELECT * FROM NhaCungCap", connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt); // Lấy dữ liệu vào DataTable
                    }
                }
            }

            return dt; // Trả về DataTable chứa danh sách loại nguyên liệu
        }
        public DataTable layNhaCungCapTheoMa(string maNCC)
        {
            DataTable dt = new DataTable();
            string query = "sp_layNhaCungCapTheoMa"; // Stored Procedure để lấy thông tin nhà cung cấp

            using (SqlCommand cmd = new SqlCommand(query, dbConnect.GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNCC", maNCC);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }
        public bool InsertPhieuNhap(string maPhieuNhap, string maNhanVien, string maNCC, DateTime ngayNhap, float tongTienNhap)
        {
            string query = "sp_InsertPhieuNhapHang";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@MaPhieuNhapHang", maPhieuNhap),
            new SqlParameter("@MaNhanVien", maNhanVien),
            new SqlParameter("@MaNCC", maNCC),
            new SqlParameter("@NgayNhap", ngayNhap),
            new SqlParameter("@TongTienNhap", tongTienNhap)
            };
            // Execute the stored procedure and check if rows were affected
            int rowsAffected = dbConnect.ExecuteNonQuery(query, parameters, CommandType.StoredProcedure);

            // Return true if rows were affected, indicating a successful insert
            return rowsAffected > 0;

        }
        public bool InsertChiTietPhieuNhap(string maPhieuNhap, string maNguyenLieu, int soLuong, float tongGia,string trangThai)
        {
            string query = "sp_InsertChiTietPhieuNhap";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaPhieuNhapHang", maPhieuNhap),
                new SqlParameter("@MaNguyenLieu", maNguyenLieu),
                new SqlParameter("@SoLuong", soLuong),
                new SqlParameter("@TongGia", tongGia),
                new SqlParameter("@TrangThai", trangThai)
            };

            // Execute the stored procedure and check if rows were affected
            int rowsAffected = dbConnect.ExecuteNonQuery(query, parameters, CommandType.StoredProcedure);

            // Return true if rows were affected, indicating a successful insert
            return rowsAffected > 0;
        }
        public DataTable SearchPhieuNhap(DateTime startDate, DateTime endDate)
        {
            string query = "sp_SearchPhieuNhap";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@StartDate", startDate),
                new SqlParameter("@EndDate", endDate)
            };

            // Ensure you're calling the correct method that returns a DataTable
            return dbConnect.ExecuteQuery(query, parameters, CommandType.StoredProcedure);
        }

        public DataTable LayChiTietPhieuNhapTheoMa(string maPhieuNhapHang,string maNCC)
        {
            string query = "sp_LayChiTietPhieuNhapTheoMa";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaPhieuNhapHang", maPhieuNhapHang),
                new SqlParameter("@MaNCC", maNCC)
            };

            return dbConnect.ExecuteQuery(query, parameters, CommandType.StoredProcedure);
        }
        public List<NguyenLieuDTO> TimKiemNguyenLieuTheoTrangThai(string searchText, string trangThai)
        {
            List<NguyenLieuDTO> nguyenLieuList = new List<NguyenLieuDTO>();
            string query = "sp_TimKiemNguyenLieuTheoTrangThai"; // Tên stored procedure

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@SearchText", searchText),
                new SqlParameter("@TrangThai", trangThai)
            };

            using (SqlDataReader reader = dbConnect.ExecuteReader(query, parameters))
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        NguyenLieuDTO nguyenLieu = new NguyenLieuDTO
                        {
                            MaNguyenLieu = reader["MaNguyenLieu"].ToString(),
                            TenNguyenLieu = reader["TenNguyenLieu"].ToString(),
                            TenDVT = reader["TenDVT"].ToString(),
                            SoLuongTon = Convert.ToInt32(reader["SoLuongTon"]),
                            TrangThai = reader["TrangThai"].ToString(),
                        };
                        nguyenLieuList.Add(nguyenLieu);
                    }
                }
            }

            return nguyenLieuList;
        }

        public List<NguyenLieuDTO> HienThiNguyenLieuTheoTrangThai(string trangThai)
        {
            List<NguyenLieuDTO> nguyenLieuList = new List<NguyenLieuDTO>();
            string query = "sp_HienThiNguyenLieuKhoTheoTrangThai"; // Tên stored procedure

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TrangThai", trangThai)
            };

            using (SqlDataReader reader = dbConnect.ExecuteReader(query, parameters))
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        NguyenLieuDTO nguyenLieu = new NguyenLieuDTO
                        {
                            MaNguyenLieu = reader["MaNguyenLieu"].ToString(),
                            TenNguyenLieu = reader["TenNguyenLieu"].ToString(),
                            TenDVT = reader["TenDVT"].ToString(),
                            SoLuongTon = Convert.ToInt32(reader["SoLuongTon"]),
                            TrangThai = reader["TrangThai"].ToString(),
                        };
                        nguyenLieuList.Add(nguyenLieu);
                    }
                }
            }

            return nguyenLieuList;
        }

    }
}
