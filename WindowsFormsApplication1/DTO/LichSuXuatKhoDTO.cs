using System;
using System.Collections.Generic;
using System.Linq;  
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.DTO
{
    public class LichSuXuatKhoDTO
    {
        public string MaXuatKho { get; set; }
        public string MaNguyenLieu { get; set; }
        public string MaDiaDiemXuat {  get; set; }
        public string MaDiaDiemNhap {  get; set; }
        public int SoLuong {  get; set; }
        public DateTime NgayThucHien { get; set; }
    }
}
