using WindowsFormsApplication1.DAL;
using WindowsFormsApplication1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.BUS
{
    class BanAnBUS
    {
        private BanAnDAL BanAnDAL = new BanAnDAL();
        public bool ThemBanAn(BanAnDTO banAnDTO)
        {
            // Kiểm tra tính hợp lệ của dữ liệu
            if (banAnDTO == null || string.IsNullOrEmpty(banAnDTO.TrangThai) || banAnDTO.SoChoNgoi <= 0)
            {
                throw new ArgumentException("Thông tin bàn ăn không hợp lệ.");
            }

            // Gọi đến DAL để thêm mới
            return BanAnDAL.ThemBanAn(banAnDTO);
        }

        public bool CapNhatBanAn(BanAnDTO banAnDTO)
        {
            // Kiểm tra tính hợp lệ của dữ liệu
            if (banAnDTO == null || string.IsNullOrEmpty(banAnDTO.MaBan) || string.IsNullOrEmpty(banAnDTO.TrangThai) || banAnDTO.SoChoNgoi <= 0)
            {
                throw new ArgumentException("Thông tin bàn ăn không hợp lệ.");
            }

            // Gọi DAL để cập nhật bàn ăn
            return BanAnDAL.CapNhatBanAn(banAnDTO);
        }

        public string TaoMaBanAnMoi()
        {
            return BanAnDAL.TaoMaBanAnMoi();
        }
        public DataTable LayTatCaBanAn()
        {
            return BanAnDAL.LayTatCaBanAn();
        }
    }
}
