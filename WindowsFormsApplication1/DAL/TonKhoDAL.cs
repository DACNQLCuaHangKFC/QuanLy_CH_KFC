using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.BUS;
using WindowsFormsApplication1.DTO;

namespace WindowsFormsApplication1.DAL
{
    public class TonKhoDAL
    {
        private DBConnect db = new DBConnect();

        public DataTable LayThongKeTonKho(string maDiaDiem, string trangThai)
        {
            DataTable dt = new DataTable();
            //string query = "sp_ThongKeTonKho";

            using (SqlConnection connection = db.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_ThongKeTonKho", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaDiaDiem", maDiaDiem);
                cmd.Parameters.AddWithValue("@TrangThai", trangThai);

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }

            return dt;
        }

    }
}
