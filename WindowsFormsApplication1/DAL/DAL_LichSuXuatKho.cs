using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.DTO;
using WindowsFormsApplication1.DAL;

namespace WindowsFormsApplication1.DAL
{
    class DAL_LichSuXuatKho
    {
        private DBConnect dbConnect;
        public DAL_LichSuXuatKho()
        {
            dbConnect = new DBConnect();
        }
        public DataTable HienThiLichSuXuatKho()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = dbConnect.GetConnection())
            {
                if (connection == null)
                {
                    return dt; // Trả về DataTable rỗng nếu không thể kết nối
                }

                using (SqlCommand command = new SqlCommand("sp_HienThiLichSuXuatKho", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }

        public DataTable TimKiemLichSuXuatTheoNgay(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = dbConnect.GetConnection())
            {
                if (connection == null)
                {
                    return dataTable; // Trả về DataTable rỗng nếu không thể kết nối
                }

                using (SqlCommand command = new SqlCommand("sp_TimKiemLichSuXuatTheoNgay", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NgayBatDau", ngayBatDau);
                    command.Parameters.AddWithValue("@NgayKetThuc", ngayKetThuc);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable; // Trả về kết quả dưới dạng DataTable
        }

    }
}
