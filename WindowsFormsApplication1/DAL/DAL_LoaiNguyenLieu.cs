using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.DTO;

namespace WindowsFormsApplication1.DAL
{
    public class DAL_LoaiNguyenLieu
    {
        private DBConnect dbConnect;
        public DAL_LoaiNguyenLieu()
        {
            dbConnect = new DBConnect();
        }
        public List<LoaiNguyenLieuDTO> GetAllLoaiNguyenLieu()
        {
            List<LoaiNguyenLieuDTO> dsLoaiNguyenLieu = new List<LoaiNguyenLieuDTO>();
            string query = "SELECT MaLoaiNguyenLieu, TenLoaiNguyenLieu FROM LoaiNguyenLieu";

            using (SqlCommand cmd = new SqlCommand(query, dbConnect.GetConnection()))
            {
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        LoaiNguyenLieuDTO loaiNguyenLieu = new LoaiNguyenLieuDTO()
                        {
                            MaLoaiNguyenLieu = dr["MaLoaiNguyenLieu"].ToString(),
                            TenLoaiNguyenLieu = dr["TenLoaiNguyenLieu"].ToString()
                        };
                        dsLoaiNguyenLieu.Add(loaiNguyenLieu);
                    }
                }
            }

            return dsLoaiNguyenLieu; // Thêm câu lệnh return
        }

    }
}
