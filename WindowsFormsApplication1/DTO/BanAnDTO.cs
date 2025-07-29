using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.DTO
{
    public class BanAnDTO
    {
        // Thuộc tính mã bàn ăn
        public string MaBan { get; set; }

        // Thuộc tính số chỗ ngồi
        public int SoChoNgoi { get; set; }

        // Thuộc tính trạng thái bàn ăn
        public string TrangThai { get; set; }

        // Constructor không tham số
        public BanAnDTO()
        {
        }

        // Constructor có tham số
        public BanAnDTO(string maBan, int soChoNgoi, string trangThai)
        {
            MaBan = maBan;
            SoChoNgoi = soChoNgoi;
            TrangThai = trangThai;
        }
    }
}
