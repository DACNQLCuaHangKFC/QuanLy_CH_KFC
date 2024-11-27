using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.DTO
{
    class ComboDTO
    {
        public string MaCombo { get; set; }
        public string TenCombo { get; set; }
        public float GiaCombo { get; set; }
        public string HinhAnh { get; set; }
        public string MoTa { get; set; }
        public string TrangThai { get; set; }
        // Hàm khởi tạo với 6 tham số
        public ComboDTO(string maCombo, string tenCombo, float giaCombo, string hinhAnh, string moTa, string trangThai)
        {
            MaCombo = maCombo;
            TenCombo = tenCombo;
            GiaCombo = giaCombo;
            HinhAnh = hinhAnh;
            MoTa = moTa;
            TrangThai = trangThai;
        }
        public ComboDTO()
        {

        }
    }
}
