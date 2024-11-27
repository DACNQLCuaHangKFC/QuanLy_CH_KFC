using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.DTO
{
    public class PhieuNhapDTO
    {
        public string MaPhieuNhapHang { get; set; }  // Mã phiếu nhập
        public DateTime NgayNhap { get; set; }       // Ngày nhập hàng
        public string TenNCC { get; set; }           // Tên nhà cung cấp
        public string TrangThaiPhieu { get; set; }
        public float TongGiaTri { get; set; }        // Tổng giá trị của phiếu nhập
    }
}
