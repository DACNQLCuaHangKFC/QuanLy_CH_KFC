using WindowsFormsApplication1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.DAL
{
    class QuanLyComboDAL
    {
        private DBConnect dbConnect;

        public QuanLyComboDAL()
        {
            dbConnect = new DBConnect();
        }
        public List<ComboDTO> HienThiDanhSachCombo()
        {
            List<ComboDTO> danhSachMonAn = new List<ComboDTO>();
            string query = "sp_HienThiDanhSachCombo";

            using (SqlDataReader reader = dbConnect.ExecuteReader(query))
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        ComboDTO monAn = new ComboDTO
                        {
                            MaCombo = reader["MaCombo"].ToString(),
                            TenCombo = reader["TenCombo"].ToString(),
                            GiaCombo = reader["GiaCombo"] != DBNull.Value ? Convert.ToSingle(reader["GiaCombo"]) : 0, // Gán 0 nếu giá trị null
                            HinhAnh = reader["HinhAnh"].ToString(),
                            MoTa = reader["MoTa"].ToString(),
                            TrangThai = reader["TrangThai"].ToString()
                        };
                        danhSachMonAn.Add(monAn);
                    }
                }
            }

            return danhSachMonAn;
        }
        public List<ChiTietComboDTO> HienThiMonAnMonAnTheoCombo(string maCombo)
        {
            List<ChiTietComboDTO> danhSachMonAn = new List<ChiTietComboDTO>();
            string query = "sp_HienThiDanhSachMonAnTrongCombo";

            using (SqlCommand cmd = new SqlCommand(query, dbConnect.GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaCombo", maCombo);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ChiTietComboDTO MonAn = new ChiTietComboDTO
                        {
                            MaMonAn = reader["MaMonAn"].ToString(),
                            TenMonAn = reader["TenMonAn"].ToString(),
                            SoLuong = int.Parse(reader["SoLuong"].ToString()),
                            TrangThai = reader["TrangThai"].ToString()
                            
                        };
                        danhSachMonAn.Add(MonAn);
                    }
                }
            }

            return danhSachMonAn;
        }
        public DataTable LocDanhSachCombo(string tenCombo, string trangThai)
        {
            string query = "sp_LocDanhSachCombo";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@TenCombo", tenCombo),
        new SqlParameter("@TrangThai", string.IsNullOrEmpty(trangThai) || trangThai == "Tất cả" ? (object)DBNull.Value : trangThai)
            };

            return dbConnect.ExecuteQuery(query, parameters, CommandType.StoredProcedure);
        }
        public ComboDTO LayThongTinCombo(string maCombo)
        {
            ComboDTO combo = null;

            using (SqlConnection connection = dbConnect.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_LayThongTinCombo", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaCombo", maCombo);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            combo = new ComboDTO
                            {
                                MaCombo = reader["MaCombo"].ToString(),
                                TenCombo = reader["TenCombo"].ToString(),
                                GiaCombo = float.Parse(reader["GiaCombo"].ToString()),
                                HinhAnh = reader["HinhAnh"].ToString(),
                                MoTa = reader["MoTa"].ToString(),
                                TrangThai = reader["TrangThai"].ToString()
                            };
                        }
                    }
                }
            }

            return combo; // Trả về thông tin món ăn
        }
        public DataTable TimKiemMonAnTrongChiTietCombo(string searchText, string maCombo)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = dbConnect.GetConnection())
            {
                if (connection == null)
                {
                    return dataTable; // Trả về DataTable rỗng nếu không thể kết nối
                }

                using (SqlCommand command = new SqlCommand("sp_TimTenMonAnTrongChiTietCombo", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Keyword", searchText);
                    command.Parameters.AddWithValue("@MaCombo", maCombo);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }
        public ChiTietComboDTO LayMonAnTheoMaMonAnVaMaCombo(string maCombo, string maMonAn)
        {
            ChiTietComboDTO monAn = null; 

            string query = "sp_LayMonAnTheoMaMonAnVaMaCombo";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@MaMonAn", maMonAn),
        new SqlParameter("@MaCombo", maCombo)
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
                            monAn = new ChiTietComboDTO
                            {
                                TenMonAn = reader["TenMonAn"].ToString(),
                                SoLuong = int.Parse(reader["SoLuong"].ToString()),
                                TrangThai = reader["TrangThai"].ToString()
                            };
                        }
                        else
                        {
                            Console.WriteLine("Không tìm thấy món ăn theo mã đã cho.");
                        }
                    }
                }
            }

            return monAn; // Trả về đối tượng công thức hoặc null nếu không tìm thấy
        }
        public void UpdateChiTietCombo(ChiTietComboDTO chiTietCombo)
        {
            using (SqlConnection connection = dbConnect.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_UpdateChiTietCombo", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaCombo", chiTietCombo.MaCombo);
                    command.Parameters.AddWithValue("@MaMonAn", chiTietCombo.MaMonAn);
                    command.Parameters.AddWithValue("@SoLuong", chiTietCombo.SoLuong);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void DeleteChiTietCombo(string maCombo, string maMonAn)
        {
            using (SqlConnection connection = dbConnect.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_DeleteChiTietCombo", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaCombo", maCombo);
                    command.Parameters.AddWithValue("@MaMonAn", maMonAn);
                    command.ExecuteNonQuery();
                }
            }
        }
        public bool ThemMonAnChoChiTietCombo(ChiTietComboDTO chiTietCombo)
        {
            string query = "sp_ThemMonAnChoChiTietCombo";

            // Tạo danh sách tham số cho Stored Procedure
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@MaCombo", chiTietCombo.MaCombo),
            new SqlParameter("@MaMonAn", chiTietCombo.MaMonAn),
            new SqlParameter("@SoLuong", chiTietCombo.SoLuong)
            };

            // Sử dụng dbConnect để thực thi truy vấn
            int rowsAffected = dbConnect.ExecuteNonQuery(query, parameters, CommandType.StoredProcedure);
            return rowsAffected > 0; // Trả về true nếu có ít nhất 1 dòng bị ảnh hưởng
        }
        public void KiemTraMonAnTrongCombo()
        {
            using (SqlConnection connection = dbConnect.GetConnection())
            {
                    SqlCommand command = new SqlCommand("sp_KiemTraMonAnTrongCombo", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    // Thực thi stored procedure
                    command.ExecuteNonQuery();
            }
        }
        public int CapNhatTrangThaiComboConBan(string maCombo)
        {
            string query = "sp_CapNhatTrangThaiComboConBan";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@MaCombo", maCombo)
            };

            return dbConnect.ExecuteNonQuery(query, parameters, CommandType.StoredProcedure);
        }
        public int CapNhatTrangThaiComboNgungBan(string maCombo)
        {
            string query = "sp_CapNhatTrangThaiComboNgungBan";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@MaCombo", maCombo)
            };

            return dbConnect.ExecuteNonQuery(query, parameters, CommandType.StoredProcedure);
        }
        public string TaoMaComboMoi()
        {
            string query = "sp_TaoMaComboMoi";
            using (SqlDataReader reader = dbConnect.ExecuteReader(query))
            {
                if (reader != null && reader.Read())
                {
                    return reader["MaComboMoi"].ToString();
                }
            }
            return null; // Trả về null nếu không tạo được mã
        }
        public bool ThemCombo(ComboDTO combo)
        {
            string query = "sp_ThemCombo";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@MaCombo", combo.MaCombo),
        new SqlParameter("@TenCombo", combo.TenCombo),
        new SqlParameter("@GiaCombo", combo.GiaCombo),
        new SqlParameter("@HinhAnh", combo.HinhAnh),
        new SqlParameter("@MoTa", combo.MoTa),
        new SqlParameter("@TrangThai", combo.TrangThai)
            };
            return dbConnect.ExecuteNonQuery(query, parameters, CommandType.StoredProcedure) > 0;
        }
        public bool UpdateCombo(string maCombo, string tenCombo, float giaCombo, string moTa, float giaCu, string hinhAnh)
        {
            // Kiểm tra xem giá có thay đổi không
            if (giaCombo != giaCu)
            {
                // Gọi stored procedure cập nhật lịch sử giá
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@MaMonAn", maCombo),
                    new SqlParameter("@GiaMoi", giaCombo)
                };
                if (dbConnect.ExecuteNonQuery("sp_CapNhatGiaMonAn", parameters, CommandType.StoredProcedure) < 0)
                {
                    return false; // Nếu có lỗi xảy ra
                }
            }

            // Cập nhật thông tin Combo 
            SqlParameter[] updateParameters = new SqlParameter[]
            {
                new SqlParameter("@HinhAnh", hinhAnh),
                new SqlParameter("@MaCombo", maCombo),
                new SqlParameter("@TenCombo", tenCombo),
                new SqlParameter("@MoTa", moTa)
            };
            return dbConnect.ExecuteNonQuery("sp_UpdateComboNoMoney", updateParameters, CommandType.StoredProcedure) >= 0;
        }
    }
}
