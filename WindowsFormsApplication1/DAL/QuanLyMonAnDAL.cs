using Microsoft.SqlServer.Management.Sdk.Sfc;
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
    class QuanLyMonAnDAL
    {
        private DBConnect dbConnect;

        public QuanLyMonAnDAL()
        {
            dbConnect = new DBConnect();
        }
        public List<MonAnDTO> HienThiDanhSachMonAn()
        {
            List<MonAnDTO> danhSachMonAn = new List<MonAnDTO>();
            string query = "sp_HienThiDanhSachMonAn";

            using (SqlDataReader reader = dbConnect.ExecuteReader(query))
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        MonAnDTO monAn = new MonAnDTO
                        {
                            MaMonAn = reader["MaMonAn"].ToString(),
                            TenMonAn = reader["TenMonAn"].ToString(),
                            GiaMonAn = reader["GiaMonAn"] != DBNull.Value ? Convert.ToSingle(reader["GiaMonAn"]) : 0, // Gán 0 nếu giá trị null
                            HinhAnh = reader["HinhAnh"].ToString(),
                            TenLoai = reader["TenLoai"].ToString(),
                            MaLoai = reader["MaLoai"].ToString(),
                            MoTa = reader["MoTa"].ToString(),
                            TrangThai = reader["TrangThai"].ToString()
                        };
                        danhSachMonAn.Add(monAn);
                    }
                }
            }

            return danhSachMonAn;
        }
        public List<NguyenLieuDTO> HienThiDanhSachNguyenLieu()
        {
            List<NguyenLieuDTO> danhSachNguyenLieu = new List<NguyenLieuDTO>();
            string query = "sp_HienThiDanhSachNguyenLieu";

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
                            MaDVT = reader["MaDVT"].ToString(),
                            TenDVT = reader["TenDVT"].ToString(),
                            MaLoaiNguyenLieu = reader["MaLoaiNguyenLieu"].ToString(),
                            TenLoaiNguyenLieu = reader["TenLoaiNguyenLieu"].ToString()
                        };
                        danhSachNguyenLieu.Add(nguyenLieu);
                    }
                }
            }

            return danhSachNguyenLieu;
        }
        public List<CongThucDTO> HienThiCongThucTheoMonAn(string maMonAn)
        {
            List<CongThucDTO> danhSachCongThuc = new List<CongThucDTO>();
            string query = "sp_HienThiCongThucTheoMonAn";

            using (SqlCommand cmd = new SqlCommand(query, dbConnect.GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaMonAn", maMonAn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CongThucDTO congThuc = new CongThucDTO
                        {
                            DinhLuong = Convert.ToSingle(reader["DinhLuong"]),
                            TenDVT = reader["TenDVT"].ToString(),
                            TenNguyenLieu = reader["TenNguyenLieu"].ToString(),
                            MaMonAn = reader["MaMonAn"].ToString(),
                            MaNguyenLieu = reader["MaNguyenLieu"].ToString(),
                            MaDVT = reader["MaDVT"].ToString()
                        };
                        danhSachCongThuc.Add(congThuc);
                    }
                }
            }

            return danhSachCongThuc;
        }
        public bool ThemCongThuc(CongThucDTO congThuc)
        {
            string query = "sp_ThemCongThuc"; // Tên của stored procedure

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaMonAn", congThuc.MaMonAn),
                new SqlParameter("@MaNguyenLieu", congThuc.MaNguyenLieu),
                new SqlParameter("@MaDVT", congThuc.MaDVT),
                new SqlParameter("@DinhLuong", congThuc.DinhLuong)
            };

            return dbConnect.ExecuteNonQuery(query, parameters, CommandType.StoredProcedure) > 0; // Trả về true nếu thêm thành công
        }
        public List<DonViTinhDTO> HienThiDanhMucDVT()
        {
            List<DonViTinhDTO> danhMucDVTList = new List<DonViTinhDTO>();
            string query = "sp_HienThiDanhMucDVT"; // Tên stored procedure

            // Tạo mảng tham số nếu cần, nếu không thì có thể để null
            SqlParameter[] parameters = null;

            using (SqlDataReader reader = dbConnect.ExecuteReader(query, parameters))
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        DonViTinhDTO dvt = new DonViTinhDTO
                        {
                            MaDVT = reader["MaDVT"].ToString(),
                            TenDVT = reader["TenDVT"].ToString()
                        };
                        danhMucDVTList.Add(dvt);
                    }
                }
            }
            return danhMucDVTList;
        }
        public bool ThemDinhLuongChoCongThuc(CongThucDTO congThuc)
        {
            string query = "sp_ThemDinhLuongChoCongThuc";

            // Tạo danh sách tham số cho Stored Procedure
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@MaMonAn", congThuc.MaMonAn),
        new SqlParameter("@MaNguyenLieu", congThuc.MaNguyenLieu),
        new SqlParameter("@MaDVT", congThuc.MaDVT),
        new SqlParameter("@DinhLuong", congThuc.DinhLuong)
            };

            // Sử dụng dbConnect để thực thi truy vấn
            int rowsAffected = dbConnect.ExecuteNonQuery(query, parameters, CommandType.StoredProcedure);
            return rowsAffected > 0; // Trả về true nếu có ít nhất 1 dòng bị ảnh hưởng
        }
        public DataTable TimKiemNguyenLieu(string searchText)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = dbConnect.GetConnection())
            {
                if (connection == null)
                {
                    return dataTable; // Trả về DataTable rỗng nếu không thể kết nối
                }

                using (SqlCommand command = new SqlCommand("sp_TimKiemNguyenLieu", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@SearchText", searchText);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable; // Trả về kết quả dưới dạng DataTable
        }

        public CongThucDTO LayNguyenLieuTheoMaMonAnVaMaNL(string maMonAn, string maNguyenLieu)
        {
            CongThucDTO congThuc = null; // Khởi tạo đối tượng công thức là null

            string query = "sp_LayNguyenLieuTheoMaMonAnVaMaNL";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@MaMonAn", maMonAn),
        new SqlParameter("@MaNguyenLieu", maNguyenLieu)
            };

            using (SqlConnection connection = dbConnect.GetConnection())
            {
                if (connection == null || connection.State != ConnectionState.Open)
                {
                    Console.WriteLine("Không thể kết nối với cơ sở dữ liệu.");
                    return null; // Trả về null nếu không thể kết nối
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(parameters);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Đọc một dòng duy nhất
                        if (reader.Read())
                        {
                            congThuc = new CongThucDTO
                            {
                                MaMonAn = reader["MaMonAn"].ToString(),
                                MaNguyenLieu = reader["MaNguyenLieu"].ToString(),
                                TenNguyenLieu = reader["TenNguyenLieu"].ToString(),
                                MaDVT = reader["MaDVT"].ToString(),
                                TenDVT = reader["TenDVT"].ToString(),
                                DinhLuong = Convert.ToSingle(reader["DinhLuong"])
                            };
                        }
                        else
                        {
                            Console.WriteLine("Không tìm thấy nguyên liệu theo mã đã cho.");
                        }
                    }
                }
            }

            return congThuc; // Trả về đối tượng công thức hoặc null nếu không tìm thấy
        }
        public void UpdateCongThuc(CongThucDTO congThuc)
        {
            using (SqlConnection connection = dbConnect.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_UpdateCongThuc", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaMonAn", congThuc.MaMonAn);
                    command.Parameters.AddWithValue("@MaNguyenLieu", congThuc.MaNguyenLieu);
                    command.Parameters.AddWithValue("@DinhLuong", congThuc.DinhLuong);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteCongThuc(string maMonAn, string maNguyenLieu)
        {
            using (SqlConnection connection = dbConnect.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_DeleteCongThuc", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaMonAn", maMonAn);
                    command.Parameters.AddWithValue("@MaNguyenLieu", maNguyenLieu);
                    command.ExecuteNonQuery();
                }
            }
        }
        public DataTable TimKiemTenNguyenLieuTrongCongThuc(string searchText,string maMonAn)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = dbConnect.GetConnection())
            {
                if (connection == null)
                {
                    return dataTable; // Trả về DataTable rỗng nếu không thể kết nối
                }

                using (SqlCommand command = new SqlCommand("sp_TimKiemNguyenLieuTrongCongThuc", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TenNguyenLieu", searchText);
                    command.Parameters.AddWithValue("@MaMonAn", maMonAn);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }
        public DataTable LayDanhSachLoaiMonAn()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = dbConnect.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_LayDanhSachLoaiMonAn", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        public MonAnDTO LayThongTinMonAn(string maMonAn)
        {
            MonAnDTO monAn = null;

            using (SqlConnection connection = dbConnect.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_LayThongTinMonAn", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaMonAn", maMonAn);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            monAn = new MonAnDTO
                            {
                                MaMonAn = reader["MaMonAn"].ToString(),
                                TenMonAn = reader["TenMonAn"].ToString(),
                                GiaMonAn = float.Parse(reader["GiaMonAn"].ToString()),
                                HinhAnh = reader["HinhAnh"].ToString(),
                                MaLoai = reader["MaLoai"].ToString(),
                                TenLoai = reader["TenLoai"].ToString(),
                                MoTa = reader["MoTa"].ToString(),
                                TrangThai = reader["TrangThai"].ToString()
                            };
                        }
                    }
                }
            }

            return monAn; // Trả về thông tin món ăn
        }

        // Phương thức thêm món ăn mới
        public bool ThemMonAn(MonAnDTO monAn)
        {
            string query = "sp_InsertMonAn"; // Tên stored procedure thêm món ăn
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaMonAn", monAn.MaMonAn),
                new SqlParameter("@TenMonAn", monAn.TenMonAn),
                new SqlParameter("@GiaMonAn", monAn.GiaMonAn),
                new SqlParameter("@HinhAnh", monAn.HinhAnh),
                new SqlParameter("@MaLoai", monAn.MaLoai),
                new SqlParameter("@MoTa", monAn.MoTa)
            };

            int result = dbConnect.ExecuteNonQuery(query, parameters, CommandType.StoredProcedure);
            return result > 0; // Trả về true nếu thêm thành công
        }

        // Phương thức tạo mã món ăn mới
        public string TaoMaMonAnMoi()
        {
            string query = "sp_TaoMaMonAn";
            using (SqlDataReader reader = dbConnect.ExecuteReader(query))
            {
                if (reader != null && reader.Read())
                {
                    return reader["MaMonAnMoi"].ToString();
                }
            }
            return null; // Trả về null nếu không tạo được mã
        }

        public void LuuGiaVaoLichSu(string maMonAn, float giaMoi)
        {
            string query = "sp_CapNhatGiaMonAn";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@MaMonAn", maMonAn),
            new SqlParameter("@GiaMoi", giaMoi)
            };

            dbConnect.ExecuteNonQuery(query, parameters, CommandType.StoredProcedure);
        }

        // Ngừng bán món ăn
        public bool NgungBanMonAn(string maMonAn)
        {
            string query = "sp_NgungBanMonAn";
            SqlParameter[] parameters = {
                new SqlParameter("@MaMonAn", SqlDbType.VarChar) { Value = maMonAn }
            };

            return dbConnect.ExecuteNonQuery(query, parameters, CommandType.StoredProcedure) > 0;
        }

        // Đánh dấu món ăn còn bán
        public bool ConBanMonAn(string maMonAn)
        {
            string query = "sp_ConBanMonAn";
            SqlParameter[] parameters = {
                new SqlParameter("@MaMonAn", SqlDbType.VarChar) { Value = maMonAn }
            };

            return dbConnect.ExecuteNonQuery(query, parameters, CommandType.StoredProcedure) > 0;
        }
        public DataTable LocDanhSachMonAn(string tenMonAn, string trangThai)
        {
            string query = "sp_LocDanhSachMonAn";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@TenMonAn", tenMonAn),
        new SqlParameter("@TrangThai", string.IsNullOrEmpty(trangThai) || trangThai == "Tất cả" ? (object)DBNull.Value : trangThai)
            };

            return dbConnect.ExecuteQuery(query, parameters, CommandType.StoredProcedure);
        }
        public bool UpdateMonAn(string maMonAn, string tenMonAn, float giaMonAn, string maLoai, string moTa, float giaCu, string hinhAnh)
        {
            // Kiểm tra xem giá có thay đổi không
            if (giaMonAn != giaCu)
            {
                // Gọi stored procedure cập nhật lịch sử giá
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@MaMonAn", maMonAn),
                    new SqlParameter("@GiaMoi", giaMonAn)
                };
                if (dbConnect.ExecuteNonQuery("sp_CapNhatGiaMonAn", parameters, CommandType.StoredProcedure) < 0)
                {
                    return false; // Nếu có lỗi xảy ra
                }
            }

            // Cập nhật thông tin món ăn
            SqlParameter[] updateParameters = new SqlParameter[]
            {
                new SqlParameter("@HinhAnh", hinhAnh),
                new SqlParameter("@MaMonAn", maMonAn),
                new SqlParameter("@TenMonAn", tenMonAn),
                new SqlParameter("@MaLoai", maLoai),
                new SqlParameter("@MoTa", moTa)
            };
            return dbConnect.ExecuteNonQuery("sp_UpdateMonAn", updateParameters, CommandType.StoredProcedure) >= 0;
        }
        
    }
}
