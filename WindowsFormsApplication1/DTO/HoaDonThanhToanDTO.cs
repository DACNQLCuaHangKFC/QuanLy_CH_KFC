using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.DTO
{
    public class HoaDonThanhToanDTO
    {
        public string MaHoaDon { get; set; }  // Primary Key
        public string MaNhanVien { get; set; }  // Foreign Key to NhanVien
        public string SoDienThoai { get; set; }  // Foreign Key to KhachHang
        public string MaBan { get; set; }  // Foreign Key to BanAn
        public string MaKhuyenMai { get; set; }  // Foreign Key to KhuyenMai
        public DateTime NgayThanhToan { get; set; }  // Payment Date
        public float TongTien { get; set; }  // Total Amount
        public string PhuongThucThanhToan { get; set; }  // Payment Method (Cash/Transfer)
    }
}
