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
    class QuanLyComboBUS
    {
        private QuanLyComboDAL quanLyCombo = new QuanLyComboDAL();

        // Hiển thị danh sách món ăn
        public List<ComboDTO> HienThiDanhSachCombo()
        {
            return quanLyCombo.HienThiDanhSachCombo();
        }

        public List<ChiTietComboDTO> HienThiMonAnMonAnTheoCombo(string MaCombo)
        {
            return quanLyCombo.HienThiMonAnMonAnTheoCombo(MaCombo);
        }
        public DataTable LocDanhSachCombo(string tenCombo, string trangThai)
        {
            return quanLyCombo.LocDanhSachCombo(tenCombo,trangThai);
        }
        public ComboDTO LayThongTinCombo(string maCombo)
        {
            return quanLyCombo.LayThongTinCombo(maCombo);
        }
        public DataTable TimKiemMonAnTrongChiTietCombo(string searchText, string maCombo)
        {
            return quanLyCombo.TimKiemMonAnTrongChiTietCombo(searchText, maCombo);
        }
        public ChiTietComboDTO LayMonAnTheoMaMonAnVaMaCombo(string maCombo, string maMonAn)
        {
            return quanLyCombo.LayMonAnTheoMaMonAnVaMaCombo(maCombo, maMonAn);
        }
        public void UpdateChiTietCombo(ChiTietComboDTO chiTietCombo)
        {
           quanLyCombo.UpdateChiTietCombo(chiTietCombo);
        }
        public void DeleteChiTietCombo(string maCombo, string maMonAn)
        {
            quanLyCombo.DeleteChiTietCombo(maCombo, maMonAn);
        }
        public bool ThemMonAnChoChiTietCombo(ChiTietComboDTO chiTietCombo)
        {
            return quanLyCombo.ThemMonAnChoChiTietCombo(chiTietCombo);
        }
        public void KiemTraMonAnTrongCombo()
        {
            quanLyCombo.KiemTraMonAnTrongCombo();
        }
        public bool CapNhatTrangThaiComboConBan(string maCombo)
        {
            int result = quanLyCombo.CapNhatTrangThaiComboConBan(maCombo);
            return result > 0; // Nếu result > 0, tức là có ít nhất 1 dòng bị thay đổi
        }
        public bool CapNhatTrangThaiComboNgungBan(string maCombo)
        {
            int result = quanLyCombo.CapNhatTrangThaiComboNgungBan(maCombo);
            return result > 0; // Nếu result > 0, tức là có ít nhất 1 dòng bị thay đổi
        }
        public string TaoMaComboMoi()
        {
           return quanLyCombo.TaoMaComboMoi();
        }
        public bool ThemCombo(ComboDTO combo)
        {
            return quanLyCombo.ThemCombo(combo);
        }
        public bool UpdateCombo(string maCombo, string tenCombo, float giaCombo, string moTa, float giaCu, string hinhAnh)
        {
            return quanLyCombo.UpdateCombo(maCombo, tenCombo, giaCombo, moTa, giaCu, hinhAnh);
        }
    }
}
