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
    public class DAL_Kho
    {
        private DBConnect dbConnect;
        public DAL_Kho()
        {
            dbConnect = new DBConnect();
        }
        public List<NguyenLieuDTO> HienThiDanhSachNguyenLieuKho()
        {
            List<NguyenLieuDTO> danhSachNguyenLieuKho = new List<NguyenLieuDTO>();
            string query = "sp_HienThiNguyenLieuKho";

            using (SqlDataReader reader = dbConnect.ExecuteReader(query))
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
                        danhSachNguyenLieuKho.Add(nguyenLieu);
                        
                    }
                }
            }
            return danhSachNguyenLieuKho;
        }
        public List<NguyenLieuDTO> HienThiDanhSachNguyenLieuBep()
        {
            List<NguyenLieuDTO> danhSachNguyenLieuBep = new List<NguyenLieuDTO>();
            string query = "sp_HienThiNguyenLieuBep";

            using (SqlDataReader reader = dbConnect.ExecuteReader(query))
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
                        danhSachNguyenLieuBep.Add(nguyenLieu);

                    }
                }
            }
            return danhSachNguyenLieuBep;
        }

        public List<NguyenLieuDTO> HienThiNguyenLieuBep()
        {
            List<NguyenLieuDTO> NguyenLieuBep = new List<NguyenLieuDTO>();
            string query = "sp_HienThiDanhSachNguyenLieuBep";

            using (SqlDataReader reader = dbConnect.ExecuteReader(query))
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
                        NguyenLieuBep.Add(nguyenLieu);

                    }
                }
            }
            return NguyenLieuBep;
        }

        public List<NguyenLieuDTO> HienThiDanhSachKhoCanNhap()
        {
            List<NguyenLieuDTO> nguyenLieuKho = new List<NguyenLieuDTO>();
            string query = "sp_HienThiDanhSachKhoCanNhap";

            try
            {
                using (SqlDataReader reader = dbConnect.ExecuteReader(query))
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
                            nguyenLieuKho.Add(nguyenLieu);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi, có thể log lỗi ra console hoặc hiển thị thông báo
                Console.WriteLine($"Lỗi khi lấy dữ liệu: {ex.Message}");
            }
            return nguyenLieuKho;
        }

        public List<NguyenLieuDTO> TimKiemNguyenLieuKho(string searchText)
        {
            List<NguyenLieuDTO> result = new List<NguyenLieuDTO>();
            string query = "sp_TimKiemNguyenLieuKho"; // Stored Procedure

            // Tạo danh sách tham số cho Stored Procedure
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@SearchText", searchText)
            };

            // Sử dụng dbConnect để thực thi truy vấn
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
                        result.Add(nguyenLieu);
                    }
                }
            }

            return result;
        }

        public int GetSoLuongTon(string maNguyenLieu)
        {
            int soLuongTon = 0; // Default value
            string query = "sp_GetSoLuongTon";

            // Tạo danh sách tham số cho Stored Procedure
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@MaNguyenLieu", maNguyenLieu),
        new SqlParameter("@SoLuongTon", SqlDbType.Int) { Direction = ParameterDirection.Output } // Đặt kiểu dữ liệu và hướng output
            };

            // Sử dụng dbConnect để thực thi truy vấn
            dbConnect.ExecuteNonQuery(query, parameters, CommandType.StoredProcedure);

            // Kiểm tra giá trị của tham số output trước khi ép kiểu
            if (parameters[1].Value != DBNull.Value)
            {
                soLuongTon = Convert.ToInt32(parameters[1].Value); // Sử dụng Convert.ToInt32
            }
            else
            {
                soLuongTon = 0; // Gán giá trị mặc định nếu là DBNull
            }

            return soLuongTon;
        }



        public void TruKho(string maNguyenLieu, int soLuongNhap)
        {
            string query = "sp_TruKho";

            // Tạo danh sách tham số cho Stored Procedure
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@MaNguyenLieu", maNguyenLieu),
        new SqlParameter("@SoLuongNhap", soLuongNhap)
            };

            // Sử dụng dbConnect để thực thi truy vấn
            dbConnect.ExecuteNonQuery(query, parameters, CommandType.StoredProcedure);
        }

        public void CongBep(string maNguyenLieu, int soLuongNhap)
        {
            string query = "sp_CongBep";

            // Tạo danh sách tham số cho Stored Procedure
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaNguyenLieu", maNguyenLieu),
                new SqlParameter("@SoLuongNhap", soLuongNhap)
            };

            // Sử dụng dbConnect để thực thi truy vấn
            dbConnect.ExecuteNonQuery(query, parameters, CommandType.StoredProcedure);
        }

        public void CapNhatBep(string maNguyenLieu, int soLuongNhap)
        {
            string query = "sp_CapNhatBep";

            // Tạo danh sách tham số cho Stored Procedure
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaNguyenLieu", maNguyenLieu),
                new SqlParameter("@SoLuongNhap", soLuongNhap)
            };

            // Sử dụng dbConnect để thực thi truy vấn
            dbConnect.ExecuteNonQuery(query, parameters, CommandType.StoredProcedure);
        }

        public void TaoLichSuXuat(string maXuatKho, string maNguyenLieu, string maDiaDiemXuat, string maDiaDiemNhap, int soLuong, DateTime ngayThucHien)
        {
            string query = "sp_TaoLichSuXuat";

            // Tạo danh sách tham số cho Stored Procedure
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaXuatKho", maXuatKho),
                new SqlParameter("@MaNguyenLieu", maNguyenLieu),
                new SqlParameter("@MaDiaDiemXuat", maDiaDiemXuat),
                new SqlParameter("@MaDiaDiemNhap", maDiaDiemNhap),
                new SqlParameter("@SoLuong", soLuong),
                new SqlParameter("@NgayThucHien", ngayThucHien)
            };

            // Sử dụng dbConnect để thực thi truy vấn
            dbConnect.ExecuteNonQuery(query, parameters, CommandType.StoredProcedure);
        }

        public DataTable TimNguyenLieuTheoLoai(string maLoaiNguyenLieu)
        {
            DataTable dt = new DataTable();
            string query = "sp_TimNguyenLieuTheoLoai";

            // Tạo danh sách tham số cho Stored Procedure
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaLoaiNguyenLieu", maLoaiNguyenLieu)
            };

            // Sử dụng SqlDataAdapter để điền DataTable
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, dbConnect.GetConnection()))
            {
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.AddRange(parameters);
                adapter.Fill(dt);
            }

            return dt;
        }

        public void TaoTonKho(string maNguyenLieu, string maDiaDiem, int soLuongTon, string trangThai)
        {
            using (SqlConnection connection = dbConnect.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_TaoTonKho", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaNguyenLieu", maNguyenLieu);
                    cmd.Parameters.AddWithValue("@MaDiaDiem", maDiaDiem);
                    cmd.Parameters.AddWithValue("@SoLuongTon", soLuongTon);
                    cmd.Parameters.AddWithValue("@TrangThai", trangThai);

                    connection.Open(); // Mở kết nối
                    cmd.ExecuteNonQuery(); // Thực thi câu lệnh
                }
            }
        }

        public DataTable HienThiLichSuXuatKho()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = dbConnect.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_HienThiLichSuXuatKho", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        da.Fill(dt); // Đổ dữ liệu vào DataTable
                    }
                }
            }

            return dt; // Trả về DataTable chứa dữ liệu
        }

        public bool CapNhatTrangThaiTonKhoBep(string maNguyenLieu, string trangThai)
        {
            using (SqlConnection connection = dbConnect.GetConnection())
            {
                if (connection == null) 
                {
                    return false; // Trả về false nếu không thể kết nối
                }

                using (SqlCommand command = new SqlCommand("sp_CapNhatTrangThaiTonKhoBep", connection))
                {   
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaNguyenLieu", maNguyenLieu);
                    command.Parameters.AddWithValue("@TrangThai", trangThai);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0; // Trả về true nếu cập nhật thành công
                }
            }
        }
        public bool ThemNguyenLieu(string maNguyenLieu, string maLoaiNguyenLieu, string tenNguyenLieu, string maDVT)
        {
            using (SqlConnection connection = dbConnect.GetConnection())
            {
                if (connection == null)
                {
                    return false; // Trả về false nếu không thể kết nối
                }

                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_TaoNguyenLieuMoi", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MaNguyenLieu", maNguyenLieu);
                        cmd.Parameters.AddWithValue("@MaLoaiNguyenLieu", maLoaiNguyenLieu);
                        cmd.Parameters.AddWithValue("@TenNguyenLieu", tenNguyenLieu);
                        cmd.Parameters.AddWithValue("@MaDVT", maDVT);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0; // Trả về true nếu có dòng được ảnh hưởng
                    }
                }
                catch (Exception ex)
                {
                    // Log lỗi nếu cần
                    Console.WriteLine("Lỗi: " + ex.Message);
                    return false; // Trả về false nếu có lỗi
                }
            }
        }
        public string GenerateNewMaNguyenLieu()
        {
            using (SqlConnection connection = dbConnect.GetConnection())
            {
                if (connection == null)
                {
                    return "NL001"; // Trả về mã mặc định nếu không thể kết nối
                }

                using (SqlCommand cmd = new SqlCommand("sp_TaoMaNguyenLieu", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    dbConnect.GetConnection(); // Mở kết nối
                    object result = cmd.ExecuteScalar(); // Thực thi procedure và lấy kết quả
                    dbConnect.CloseConnection(connection); // Đóng kết nối

                    return result != null ? result.ToString() : "NL001"; // Trả về mã mới hoặc mã mặc định
                }
            }
        }
        //public List<ChiTietPhieuNhapDTO> HienThiDanhSachChiTietPhieuNhap()
        //{
        //    List<ChiTietPhieuNhapDTO> chiTietPhieuNhaps = new List<ChiTietPhieuNhapDTO>();
        //    string query = "sp_HienThiDanhSachChiTietPhieuNhap"; // Stored Procedure

        //    using (SqlDataReader reader = dbConnect.ExecuteReader(query))
        //    {
        //        if (reader != null)
        //        {
        //            while (reader.Read())
        //            {
        //                ChiTietPhieuNhapDTO chiTietPhieuNhap = new ChiTietPhieuNhapDTO
        //                {
        //                    MaPhieuNhapHang = reader["MaPhieuNhapHang"].ToString(),
        //                    MaNguyenLieu = reader["MaNguyenLieu"].ToString(),
        //                    TenNguyenLieu = reader["TenNguyenLieu"].ToString(),
        //                    SoLuong = Convert.ToInt32(reader["SoLuong"]),
        //                    TenDVT = reader["TenDVT"].ToString(),
        //                    TongGia = Convert.ToSingle(reader["TongGia"]),
        //                    TrangThai = reader["TrangThai"].ToString(),
        //                };
        //                chiTietPhieuNhaps.Add(chiTietPhieuNhap);
        //            }
        //        }
        //    }

        //    return chiTietPhieuNhaps;
        //}
        public List<ChiTietPhieuNhapDTO> HienThiDanhSachChiTietPhieuNhap(string maPhieuNhapHang)
        {
            List<ChiTietPhieuNhapDTO> chiTietPhieuNhaps = new List<ChiTietPhieuNhapDTO>();

            string query = "sp_HienThiDanhSachChiTietPhieuNhap";  // Gọi Stored Procedure
            using (SqlCommand command = new SqlCommand(query, dbConnect.GetConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MaPhieuNhapHang", maPhieuNhapHang);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ChiTietPhieuNhapDTO chiTietPhieuNhap = new ChiTietPhieuNhapDTO
                        {
                            MaPhieuNhapHang = reader["MaPhieuNhapHang"].ToString(),
                            MaNguyenLieu = reader["MaNguyenLieu"].ToString(),
                            TenNguyenLieu = reader["TenNguyenLieu"].ToString(),
                            SoLuong = Convert.ToInt32(reader["SoLuong"]),
                            TenDVT = reader["TenDVT"].ToString(),
                            TongGia = Convert.ToSingle(reader["TongGia"]),
                            TrangThai = reader["TrangThai"].ToString()
                        };
                        chiTietPhieuNhaps.Add(chiTietPhieuNhap);
                    }
                }
            }

            return chiTietPhieuNhaps;
        }

        public bool UpdateTrangThai(string maPhieuNhapHang, string maNguyenLieu, string trangThai)
        {
            using (SqlConnection connection = dbConnect.GetConnection())
            {
                if (connection == null)
                {
                    return false; // Trả về false nếu không thể kết nối
                }

                using (SqlCommand command = new SqlCommand("sp_UpdateTrangThaiChiTietPhieuNhap", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaPhieuNhapHang", maPhieuNhapHang);
                    command.Parameters.AddWithValue("@MaNguyenLieu", maNguyenLieu);
                    command.Parameters.AddWithValue("@TrangThai", trangThai);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0; // Trả về true nếu cập nhật thành công
                }
            }
        }
        public List<PhieuNhapDTO> LayDanhSachPhieuNhap(string tenNCC, string trangThai)
        {
            List<PhieuNhapDTO> danhSachPhieuNhap = new List<PhieuNhapDTO>();

            // Giả sử dbConnect là đối tượng kết nối cơ sở dữ liệu
            using (SqlConnection connection = dbConnect.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_HienThiPhieuNhapTheoTrangThai", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TenNCC", tenNCC);
                    command.Parameters.AddWithValue("@TrangThai", trangThai);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PhieuNhapDTO phieuNhap = new PhieuNhapDTO
                            {
                                MaPhieuNhapHang = reader["MaPhieuNhapHang"].ToString(),
                                NgayNhap = Convert.ToDateTime(reader["NgayNhap"]),
                                TenNCC = reader["TenNCC"].ToString(),
                                TrangThaiPhieu = reader["TrangThaiPhieu"].ToString(),
                                TongGiaTri = Convert.ToSingle(reader["TongGiaTri"])
                            };

                            danhSachPhieuNhap.Add(phieuNhap);
                        }
                    }
                }
            }

            return danhSachPhieuNhap;
        }
        public List<NguyenLieuDTO> HienThiNguyenLieuKhoTheoTrangThai(string trangThai)
        {
            List<NguyenLieuDTO> khoList = new List<NguyenLieuDTO>();
            string query = "sp_HienThiNguyenLieuKhoTheoTrangThai";  // Tên stored procedure
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TrangThai", SqlDbType.NVarChar) { Value = trangThai }
            };

            using (SqlDataReader reader = dbConnect.ExecuteReader(query, parameters))
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        NguyenLieuDTO kho = new NguyenLieuDTO
                        {
                            MaNguyenLieu = reader["MaNguyenLieu"].ToString(),
                            TenNguyenLieu = reader["TenNguyenLieu"].ToString(),
                            TenDVT = reader["TenDVT"].ToString(),
                            SoLuongTon = Convert.ToInt32(reader["SoLuongTon"]),
                            TrangThai = reader["TrangThai"].ToString()
                        };
                        khoList.Add(kho);
                    }
                }
            }

            return khoList;
        }
        public bool UpdateTrangThaiNhapKho(string maPhieuNhapHang, string maNguyenLieu, int soLuong)
        {
            string query = "sp_UpdateTrangThaiNhapKho";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaPhieuNhapHang", maPhieuNhapHang),
                new SqlParameter("@MaNguyenLieu", maNguyenLieu),
                new SqlParameter("@SoLuong", soLuong),
            };

            int rowsAffected = dbConnect.ExecuteNonQuery(query, parameters, CommandType.StoredProcedure);

            // Return true if rows were affected, indicating a successful insert
            return rowsAffected > 0;
        }
        public DataTable GetHoaDonByDateAndStatus(DateTime selectedDate, string status)
        {
            using (SqlConnection conn = dbConnect.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetHoaDonByDateAndStatus", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SelectedDate", selectedDate);
                    cmd.Parameters.AddWithValue("@Status", status);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
        public DataTable LayChiTietHoaDon(string maHoaDon)
        {
            using (SqlConnection conn = dbConnect.GetConnection())
            {    
                SqlCommand cmd = new SqlCommand("sp_LayChiTietHoaDon", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }
        public bool CapNhatTrangThaiChiTietHoaDon(string maHoaDon, string maMonAn, string maComBo, string trangThai)
        {
            using (SqlConnection conn = dbConnect.GetConnection())
            {   
                SqlCommand cmd = new SqlCommand("sp_CapNhatTrangThaiChiTietHoaDon", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                cmd.Parameters.AddWithValue("@MaMonAn", maMonAn);
                cmd.Parameters.AddWithValue("@MaComBo", maComBo);
                cmd.Parameters.AddWithValue("@TrangThai", trangThai);

                int result = cmd.ExecuteNonQuery();

                return result > 0; // Trả về true nếu cập nhật thành công
            }
        }

    }
}
