using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.DTO
{
    public class HoaDonDHDTO
    {
        public DateTime NgayDat { get; set; }
        public string MaHD { get; set; }
        public string TenNCC { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public string NganHang { get; set; }
        public string STK { get; set; }
        public string TenNV { get; set; }
        public string QR { get; set; }
        public decimal TongTien { get; set; }
    }
    public class HoaDonChitietDTO
    {
        public string TenNguyenLieu { get; set; }
        public int STT { get; set; }
        public string DVT { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get;set; }
    }
    public class HoaDonDatHang
    {
        public HoaDonDHDTO hoaDonDHDTO { get; set; }
        public List<HoaDonChitietDTO> hd { get; set; } 
    }
}
