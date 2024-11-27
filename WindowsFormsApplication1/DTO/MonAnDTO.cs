using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.DTO
{
    public class MonAnDTO
    {
        public string MaMonAn { get; set; }    
        public string TenMonAn { get; set; }  
        public float GiaMonAn { get; set; }  
        public string HinhAnh { get; set; }
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }
        public string MoTa { get; set; }
        public string TrangThai { get; set; }

        public MonAnDTO(string maMonAn, string tenMonAn, float giaMonAn, string hinhAnh,string maLoai,string moTa)
        {
            MaMonAn = maMonAn; 
            TenMonAn = tenMonAn;
            GiaMonAn = giaMonAn;
            HinhAnh = hinhAnh;
            MaLoai = maLoai;
            MoTa = moTa;
        }
        public MonAnDTO()
        {

        }
    }
}
