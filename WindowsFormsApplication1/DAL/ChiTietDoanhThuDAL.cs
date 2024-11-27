using WindowsFormsApplication1.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.DAL
{
    public class ChiTietDoanhThuDAL
    {
        private DBConnect db = new DBConnect();

        public static DataTable hienThiChiTietDoanhThu()
        {
            string query = "SELECT * FROM ChiTietDoanhThu";
            DBConnect db = new DBConnect();
            db.Close();
            return db.TableRead(query);
        }
        public double GetDoanhThuTheoCa(string maCaLam, DateTime ngay)
        {
            //db.Close();
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    using (SqlCommand command = new SqlCommand("sp_ThongKeDoanhThuTheoCa", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MaCaLam", maCaLam);
                        command.Parameters.AddWithValue("@Ngay", ngay.Date);

                        // Thực thi lệnh và lấy kết quả
                        var result = command.ExecuteScalar();
                        return result != DBNull.Value ? Convert.ToDouble(result) : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy doanh thu: " + ex.Message);
                return 0;
            }
        }

        public bool ThemChiTietDoanhThu(string maDoanhThu, string maCaLam, double doanhThuTheoCa)
        {
            try
            {
                using (SqlConnection connection = db.GetConnection())  // Sử dụng using để đảm bảo kết nối được đóng đúng cách
                {
                    // Kiểm tra kết nối
                    if (connection == null || connection.State != System.Data.ConnectionState.Open)
                    {
                        MessageBox.Show("Kết nối không thành công!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    SqlCommand command = new SqlCommand("sp_InsertChiTietDoanhThu", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaDoanhThu", maDoanhThu);
                    command.Parameters.AddWithValue("@MaCaLam", maCaLam);
                    command.Parameters.AddWithValue("@DoanhThuTheoCa", doanhThuTheoCa);

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        SqlCommand updateCommand = new SqlCommand("sp_UpdateTongDoanhThu", connection);
                        updateCommand.CommandType = CommandType.StoredProcedure;
                        updateCommand.Parameters.AddWithValue("@MaDoanhThu", maDoanhThu);

                        int updateResult = updateCommand.ExecuteNonQuery();
                        
                        return updateResult > 0;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm chi tiết doanh thu: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool XoaChiTietDoanhThu(string maDoanhThu, string maCaLam)
        {
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    if (connection == null || connection.State != System.Data.ConnectionState.Open)
                    {
                        MessageBox.Show("Kết nối không thành công!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    SqlCommand command = new SqlCommand("sp_DeleteChiTietDoanhThu", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaDoanhThu", maDoanhThu);
                    command.Parameters.AddWithValue("@MaCaLam", maCaLam);

                    //connection.Open();
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        SqlCommand updateCommand = new SqlCommand("sp_UpdateTongDoanhThu", connection);
                        updateCommand.CommandType = CommandType.StoredProcedure;
                        updateCommand.Parameters.AddWithValue("@MaDoanhThu", maDoanhThu);

                        int updateResult = updateCommand.ExecuteNonQuery();

                        return updateResult > 0;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa chi tiết doanh thu: " + ex.Message);
                return false;
            }
        }


    }
}
