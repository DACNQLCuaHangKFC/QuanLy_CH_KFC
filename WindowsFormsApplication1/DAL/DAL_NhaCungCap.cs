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
    public class DAL_NhaCungCap
    {
        private DBConnect dbConnect;
        public DAL_NhaCungCap()
        {
            dbConnect = new DBConnect();
        }
        public List<NhaCungCapDTO> LayDanhSachNhaCungCap()
        {
            List<NhaCungCapDTO> nhaCungCaps = new List<NhaCungCapDTO>();
            string query = "sp_HienThiNhaCungCap";

            using (SqlDataReader reader = dbConnect.ExecuteReader(query))
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        NhaCungCapDTO nhaCungCap = new NhaCungCapDTO
                        {
                            MaNCC = reader["MaNCC"].ToString(),
                            TenNCC = reader["TenNCC"].ToString(),
                            SDT = reader["SDT"].ToString(),
                            Email = reader["Email"].ToString(),
                            TenNganHang = reader["TenNganHang"].ToString(),
                            SoTaiKhoan = reader["SoTaiKhoan"].ToString()
                        };
                        nhaCungCaps.Add(nhaCungCap);
                    }
                }
            }

            return nhaCungCaps;
        }
        public List<NhaCungCapDTO> LayNhaCungCapTheoLoaiNguyenLieu(string maLoaiNguyenLieu)
        {
            List<NhaCungCapDTO> dsNhaCungCap = new List<NhaCungCapDTO>();
            string query = "sp_LayNhaCungCapTheoLoaiNguyenLieu";

            using (SqlCommand cmd = new SqlCommand(query, dbConnect.GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaLoaiNguyenLieu", maLoaiNguyenLieu);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        NhaCungCapDTO nhaCungCap = new NhaCungCapDTO()
                        {
                            MaNCC = dr["MaNCC"].ToString(),
                            TenNCC = dr["TenNCC"].ToString(),
                            SDT = dr["SDT"].ToString(),
                            Email = dr["Email"].ToString(),
                            TenNganHang = dr["TenNganHang"].ToString(),
                            SoTaiKhoan = dr["SoTaiKhoan"].ToString()
                        };
                        dsNhaCungCap.Add(nhaCungCap);
                    }
                }
            }

            return dsNhaCungCap;
        }
        public List<NguyenLieuDTO> TimNguyenLieu(string maLoaiNguyenLieu, string searchText)
        {
            List<NguyenLieuDTO> dsNguyenLieu = new List<NguyenLieuDTO>();
            string query = "sp_TimNguyenLieu"; // Stored procedure name

            using (SqlConnection conn = dbConnect.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaLoaiNguyenLieu", maLoaiNguyenLieu);
                    cmd.Parameters.AddWithValue("@SearchText", searchText);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            NguyenLieuDTO nguyenLieu = new NguyenLieuDTO()
                            {
                                MaNguyenLieu = dr["MaNguyenLieu"].ToString(),
                                TenNguyenLieu = dr["TenNguyenLieu"].ToString(),
                                MaLoaiNguyenLieu = dr["MaLoaiNguyenLieu"].ToString(),
                                TenLoaiNguyenLieu = dr["TenLoaiNguyenLieu"].ToString(),
                                TenDVT = dr["TenDVT"].ToString()
                            };
                            dsNguyenLieu.Add(nguyenLieu);
                        }
                    }
                }
            }

            return dsNguyenLieu;
        }
        public string GenerateMaNCC()
        {
            string maNCC = string.Empty;
            string query = "sp_GetNextMaNCC"; // Stored procedure to get the next MaNCC

            using (SqlConnection conn = dbConnect.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Execute the query and get the new MaNCC
                    maNCC = cmd.ExecuteScalar()?.ToString() ?? string.Empty;
                }
            }

            return maNCC;
        }
        public bool CreateSupplier(string maNCC, string tenNCC, string sdt, string email, string tenNganHang, string soTaiKhoan)
        {
            string query = "sp_CreateNhaCungCap"; // Stored procedure to insert new supplier
            bool isSuccess = false;

            using (SqlConnection conn = dbConnect.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MaNCC", maNCC);
                    cmd.Parameters.AddWithValue("@TenNCC", tenNCC);
                    cmd.Parameters.AddWithValue("@SDT", sdt);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@TenNganHang", tenNganHang);
                    cmd.Parameters.AddWithValue("@SoTaiKhoan", soTaiKhoan);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    isSuccess = rowsAffected > 0; // If rows are affected, the insert was successful
                }
            }

            return isSuccess;
        }
        public List<CungUngDTO> GetCungUngByMaNCC(string maNCC)
        {
            List<CungUngDTO> cungUngList = new List<CungUngDTO>();

            using (SqlConnection conn = dbConnect.GetConnection()) // Sử dụng phương thức GetConnection() từ dbConnect
            {
                SqlCommand cmd = new SqlCommand("sp_GetCungUngByMaNCC", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@MaNCC", maNCC);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    CungUngDTO cungUng = new CungUngDTO
                    {
                        MaNCC = reader["MaNCC"].ToString(),
                        MaNguyenLieu = reader["MaNguyenLieu"].ToString(),
                        TenNguyenLieu = reader["TenNguyenLieu"].ToString(),
                        TenDVT = reader["TenDVT"].ToString(),
                        DonGia = Convert.ToSingle(reader["DonGia"]),
                        TrangThai = reader["TrangThai"].ToString()
                    };
                    cungUngList.Add(cungUng);
                }
            }

            return cungUngList;
        }
        public bool ThemCungUng(string maNCC, string maNguyenLieu, float donGia, string trangThai)
        {
            try
            {
                using (SqlConnection conn = dbConnect.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ThemCungUng", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số vào stored procedure
                        cmd.Parameters.AddWithValue("@MaNCC", maNCC);
                        cmd.Parameters.AddWithValue("@MaNguyenLieu", maNguyenLieu);
                        cmd.Parameters.AddWithValue("@DonGia", donGia);
                        cmd.Parameters.AddWithValue("@TrangThai", trangThai);

                        // Thực thi stored procedure
                        int result = cmd.ExecuteNonQuery();

                        // Nếu kết quả trả về là số bản ghi bị ảnh hưởng
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log lỗi hoặc xử lý ngoại lệ
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool CapNhatCungUng(string maNCC, string maNguyenLieu, float donGia, string trangThai)
        {
            try
            {
                // Lấy kết nối từ dbConnect
                using (SqlConnection connection = dbConnect.GetConnection())
                {
                    // Tạo câu lệnh SQL gọi stored procedure
                    using (SqlCommand cmd = new SqlCommand("sp_CapNhatCungUng", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaNCC", maNCC);
                        cmd.Parameters.AddWithValue("@MaNguyenLieu", maNguyenLieu);
                        cmd.Parameters.AddWithValue("@DonGia", donGia);
                        cmd.Parameters.AddWithValue("@TrangThai", trangThai);

                        // Thực thi câu lệnh và lấy số lượng dòng bị ảnh hưởng
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Kiểm tra nếu có dòng bị ảnh hưởng
                        if (rowsAffected > 0)
                        {
                            return true;  // Thành công
                        }
                        else
                        {
                            return false;  // Không có dữ liệu để cập nhật
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi và hiển thị thông báo
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool XoaCungUng(string maNCC, string maNguyenLieu)
        {
            try
            {
                using (SqlConnection conn = dbConnect.GetConnection())
                {

                    using (SqlCommand cmd = new SqlCommand("sp_XoaCungUng", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaNCC", maNCC);
                        cmd.Parameters.AddWithValue("@MaNguyenLieu", maNguyenLieu);

                        // Thực thi câu lệnh và kiểm tra số dòng bị ảnh hưởng
                        int rowsAffected = cmd.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message);
                return false;
            }
        }


    }
}
