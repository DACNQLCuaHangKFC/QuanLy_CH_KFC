using WindowsFormsApplication1.DAL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApplication1.DTO;

namespace WindowsFormsApplication1.DAL
{
    class BanAnDAL
    {
        private DBConnect db = new DBConnect();
        public bool ThemBanAn(BanAnDTO banAnDTO)
        {
            string query = "sp_InsertBanAn";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaBan", banAnDTO.MaBan),
                new SqlParameter("@SoChoNgoi", banAnDTO.SoChoNgoi),
                new SqlParameter("@TrangThai", banAnDTO.TrangThai)
            };

            int result = db.ExecuteNonQuery(query, parameters, CommandType.StoredProcedure);
            return result > 0; // Trả về true nếu thêm thành công
        }
        // Hàm kiểm tra xem hóa đơn mới nhất đã thanh toán chưa
        public bool CheckHoaDonThanhToan(string maBan)
        {
            string query = @"
        SELECT TOP 1 hd.TongTien
        FROM HoaDonThanhToan hd
        WHERE hd.MaBan = @MaBan
        ORDER BY hd.NgayThanhToan DESC"; // Lấy hóa đơn mới nhất theo ngày thanh toán

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@MaBan", maBan)
            };

            DataTable result = db.ExecuteQuery(query, parameters, CommandType.Text);

            // Trường hợp không có hóa đơn nào cho bàn
            if (result == null || result.Rows.Count == 0)
            {
                return true; 
            }

            // Trường hợp có hóa đơn, kiểm tra tổng tiền
            var tongTien = result.Rows[0]["TongTien"];
            if (tongTien == DBNull.Value || Convert.ToDouble(tongTien) <= 0)
            {
                return false; // Hóa đơn chưa thanh toán
            }

            return true; // Hóa đơn đã thanh toán
        }

        public bool CapNhatBanAn(BanAnDTO banAnDTO)
        {
            if (!CheckHoaDonThanhToan(banAnDTO.MaBan))
            {
                MessageBox.Show("Không thể thay đổi trạng thái bàn ăn vì hóa đơn chưa thanh toán!");
                return false;
            }
            try
            {
                string query = "sp_UpdateBanAn";
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@MaBan", banAnDTO.MaBan),
            new SqlParameter("@SoChoNgoi", banAnDTO.SoChoNgoi),
            new SqlParameter("@TrangThai", banAnDTO.TrangThai)
                };

                int rowsAffected = db.ExecuteNonQuery(query, parameters, CommandType.StoredProcedure);

                return rowsAffected > 0; // Trả về true nếu cập nhật thành công
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật bàn ăn: " + 
                    
                    ex.Message);
                return false;
            }
        }

        public string TaoMaBanAnMoi()
        {
            string query = "getMaBanAnLonNhat";
            SqlDataReader reader = db.ExecuteReader(query);

            if (reader != null && reader.Read())
            {
                string maBanHienTai = reader["MaBan"].ToString();
                reader.Close();

                // Tách phần số và tăng giá trị
                string phanSo = maBanHienTai.Substring(2); // BA001 -> 001
                if (int.TryParse(phanSo, out int soBan))
                {
                    soBan++;
                    return $"BA{soBan:D3}"; // Ghép lại mã mới, định dạng 3 chữ số
                }
            }

            // Trường hợp không có bàn nào trong database
            return "BA001";
        }
        public DataTable LayTatCaBanAn()
        {
            string query = "sp_GetAllBanAn";
            return db.ExecuteQuery(query, null, CommandType.StoredProcedure);
        }

    }
}
