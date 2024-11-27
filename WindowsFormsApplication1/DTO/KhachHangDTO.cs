using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.DTO
{
    class KhachHangDTO
    {
        public string SoDienThoai { get; set; }
        public string TenKhachHang { get; set; }
        public string Email { get; set; }
        public DateTime? NgaySinh { get; set; }
        public int DiemTichLuy { get; set; }

    }
}
