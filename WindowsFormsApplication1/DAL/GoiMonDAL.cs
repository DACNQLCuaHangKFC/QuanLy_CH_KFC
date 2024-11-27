using System.Collections.Generic;
using WindowsFormsApplication1.DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1.DAL
{
    class GoiMonDAL
    {
        private DBConnect dbConnect;

        public GoiMonDAL()
        {
            dbConnect = new DBConnect();
        }
        // Phương thức lấy danh sách món ăn còn bán với số lượng có thể bán
        public DataTable LayDanhSachMonAnConBan()
        {
            using (SqlConnection connection = dbConnect.GetConnection())
            {
                if (connection == null)
                {
                    return null; // Trả về null nếu không thể kết nối
                }

                DataTable dtMonAnCombo = new DataTable(); // Sử dụng DataTable để lưu kết quả
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_HienThiDanhSachMonAnConBan", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dtMonAnCombo); // Điền dữ liệu vào DataTable
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi khi lấy danh sách món ăn còn bán: " + ex.Message);
                }
                return dtMonAnCombo;
            }
        }

        public DataTable TimKiemMonAn(string tenMonAn)
        {
            string query = "sp_TimKiemMonAnGoiMon";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TenMonAn", tenMonAn)
            };

            return dbConnect.ExecuteQuery(query, parameters, CommandType.StoredProcedure);
        }
        public List<KhachHangDTO> LayTatCaKhachHang()
        {
            List<KhachHangDTO> danhSachKhachHang = new List<KhachHangDTO>();

            using (SqlConnection connection = dbConnect.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_LayTatCaKhachHang", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            KhachHangDTO khachHang = new KhachHangDTO
                            {
                                SoDienThoai = reader["SoDienThoai"].ToString(),
                                TenKhachHang = reader["TenKhachHang"].ToString()
                            };
                            danhSachKhachHang.Add(khachHang);
                        }
                    }
                }
            }

            return danhSachKhachHang;
        }
        public KhachHangDTO LayThongTinKhachHang(string soDienThoai)
        {
            KhachHangDTO khachHang = null;

            using (SqlConnection connection = dbConnect.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_LayThongTinKhachHang", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@SoDienThoai", soDienThoai);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        khachHang = new KhachHangDTO
                        {
                            SoDienThoai = reader["SoDienThoai"].ToString(),
                            TenKhachHang = reader["TenKhachHang"].ToString(),
                            Email = reader["Email"] as string,
                            NgaySinh = reader["NgaySinh"] as DateTime?,
                            DiemTichLuy = Convert.ToInt32(reader["DiemTichLuy"])
                        };
                    }
                }
            }

            return khachHang;
        }
        public List<KhuyenMaiDTO> GetAllKhuyenMaiConHan()
        {
            var danhSachKhuyenMai = new List<KhuyenMaiDTO>();

            using (SqlConnection connection = dbConnect.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("spLayTatCaKhuyenMaiConHan", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var khuyenMai = new KhuyenMaiDTO
                            {
                                MaKhuyenMai = reader["MaKhuyenMai"].ToString(),
                                TenKhuyenMai = reader["TenKhuyenMai"].ToString(),
                                PhanTramKhuyenMai = float.Parse(reader["PhanTramKhuyenMai"].ToString()),
                                NgayBatDau = DateTime.Parse(reader["NgayBatDau"].ToString()),
                                NgayKetThuc = DateTime.Parse(reader["NgayKetThuc"].ToString())
                            };
                            danhSachKhuyenMai.Add(khuyenMai);
                        }
                    }
                }
            }
            return danhSachKhuyenMai;
        }
        public float LayPhanTramKhuyenMai(string maKhuyenMai)
        {
            float phanTram = 0;

            using (SqlConnection connection = dbConnect.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("spLayPhanTramKhuyenMai", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaKhuyenMai", maKhuyenMai);

                    var result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        phanTram = Convert.ToSingle(result);
                    }
                }
            }

            return phanTram;
        }
        public void TruNguyenLieu(string maMonAn, int soLuong)
        {
            using (SqlConnection connection = dbConnect.GetConnection())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_TruNguyenLieu", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@MaMonAn", maMonAn);
                        cmd.Parameters.AddWithValue("@SoLuong", soLuong);

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Log hoặc xử lý lỗi tại đây
                    throw new Exception("Lỗi khi trừ nguyên liệu", ex);
                }
            }
        }
        public void ThemNguyenLieukhiBoChon(string maMonAn, int soLuong)
        {
            using (SqlConnection connection = dbConnect.GetConnection())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ThemNguyenLieuKhiBoChon", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@MaMonAn", maMonAn);
                        cmd.Parameters.AddWithValue("@SoLuong", soLuong);

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Log hoặc xử lý lỗi tại đây
                    throw new Exception("Lỗi khi thêm nguyên liệu", ex);
                }
            }
        }
        public string TaoMaHoaDonMoi()
        {
            // Lấy ngày hiện tại
            string ngay = DateTime.Now.ToString("dd");
            string thang = DateTime.Now.ToString("MM");
            string nam = DateTime.Now.ToString("yy");

            // Kết hợp ngày tháng năm
            string maHoaDonPrefix = $"HD{ngay}{thang}{nam}";

            // Tạo kết nối đến cơ sở dữ liệu
            using (SqlConnection conn = dbConnect.GetConnection())
            {
                // Mở kết nối

                // Gọi stored procedure sp_LayMaHoaDonMoi
                using (SqlCommand command = new SqlCommand("sp_LayMaHoaDonMoi", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaHoaDonPrefix", maHoaDonPrefix);

                    var result = command.ExecuteScalar();

                    // Nếu không có mã hóa đơn nào, bắt đầu từ 001
                    if (result == null)
                    {
                        return maHoaDonPrefix + "001";
                    }
                    else
                    {
                        // Lấy số thứ tự từ mã hóa đơn mới nhất
                        string maHoaDonMoi = result.ToString();
                        string soThuTuCu = maHoaDonMoi.Substring(maHoaDonPrefix.Length);

                        // Tăng số thứ tự lên 1
                        int soThuTuMoi = int.Parse(soThuTuCu) + 1;

                        // Đảm bảo số thứ tự có 3 chữ số
                        string soThuTuMoiString = soThuTuMoi.ToString("D3");

                        // Trả về mã hóa đơn mới
                        return maHoaDonPrefix + soThuTuMoiString;
                    }
                }
            }
        }
        public bool LuuHoaDon(string maHoaDon, string maNhanVien, string soDienThoai, string maBan, string maKhuyenMai, DateTime ngayThanhToan, decimal tongTien, string phuongThucThanhToan)
        {
            using (SqlConnection conn = dbConnect.GetConnection())
            {
                // Kiểm tra và mở kết nối nếu cần
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                // Khai báo câu lệnh stored procedure
                using (SqlCommand command = new SqlCommand("sp_LuuHoaDon", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số cho stored procedure
                    command.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                    command.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                    command.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                    command.Parameters.AddWithValue("@MaBan", maBan);
                    command.Parameters.AddWithValue("@MaKhuyenMai", maKhuyenMai);
                    command.Parameters.AddWithValue("@NgayThanhToan", ngayThanhToan);
                    command.Parameters.AddWithValue("@TongTien", tongTien);
                    command.Parameters.AddWithValue("@PhuongThucThanhToan", phuongThucThanhToan);

                    // Thực thi câu lệnh
                    int result = command.ExecuteNonQuery();

                    // Trả về true nếu insert thành công, false nếu không thành công
                    return result > 0;
                }
            }
        }


        // Lưu chi tiết hóa đơn vào bảng ChiTietHoaDon
        public bool LuuChiTietHoaDon(string maHoaDon, string maMonAn, string maCombo, int soLuong, string trangThai)
        {
            using (SqlConnection conn = dbConnect.GetConnection())
            {
                // Mở kết nối nếu chưa mở
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                // Sử dụng stored procedure sp_LuuChiTietHoaDon
                using (SqlCommand command = new SqlCommand("sp_LuuChiTietHoaDon", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số cho stored procedure
                    command.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                    command.Parameters.AddWithValue("@MaMonAn", maMonAn);
                    command.Parameters.AddWithValue("@MaCombo", maCombo);
                    command.Parameters.AddWithValue("@SoLuong", soLuong);
                    command.Parameters.AddWithValue("@TrangThai", trangThai);
                    // Thực thi câu lệnh
                    int result = command.ExecuteNonQuery();

                    // Trả về true nếu insert thành công, false nếu thất bại
                    return result > 0;
                }
            }
        }
        // Phương thức gọi stored procedure
        public void CaiLaiDiemTichLuyChoKhachHang(string soDienThoai)
        {
            using (SqlConnection connection = dbConnect.GetConnection())
            {
                // Đảm bảo kết nối mở trước khi thực hiện lệnh
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand("sp_CaiLaiDiemTichLuyChoKhachHang", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số truyền vào
                    command.Parameters.AddWithValue("@SoDienThoai", soDienThoai);

                    try
                    {
                        // Thực thi stored procedure
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        // Log lỗi hoặc thông báo lỗi
                        Console.WriteLine($"Lỗi: {ex.Message}");
                        throw; // Tùy vào yêu cầu, bạn có thể ném ngoại lệ hoặc xử lý lỗi tại đây
                    }
                }
            }
        }
        public void CongDiemTichLuyChoKhachHang(string soDienThoai, int soDiem)
        {
            using (SqlConnection connection = dbConnect.GetConnection())
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand("sp_CongDiemTichLuyChoKhachHang", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Truyền tham số
                    command.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                    command.Parameters.AddWithValue("@SoDiem", soDiem);

                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine($"Lỗi khi cộng điểm: {ex.Message}");
                        throw; // Có thể ném ngoại lệ để xử lý tiếp
                    }
                }
            }
        }
        // Phương thức lấy mã hóa đơn mới nhất
        public string GetLatestInvoice()
        {
            // Chuẩn bị câu truy vấn gọi Stored Procedure
            string query = "GetLatestInvoice";

            // Tạo tham số nếu cần (trong trường hợp này không cần)
            SqlParameter[] parameters = null;

            // Thực thi Stored Procedure và trả về kết quả
            DataTable result = dbConnect.ExecuteQuery(query, parameters, CommandType.StoredProcedure);

            // Kiểm tra kết quả và trả về mã hóa đơn mới nhất
            if (result != null && result.Rows.Count > 0)
            {
                return result.Rows[0]["MaHoaDon"].ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã hóa đơn mới nhất.");
                return null;
            }
        }
    }
}
