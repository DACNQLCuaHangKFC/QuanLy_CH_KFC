using WindowsFormsApplication1.DAL;
using WindowsFormsApplication1.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace WindowsFormsApplication1.BUS
{
    class QuanLyMonAnBUS
    {
        private QuanLyMonAnDAL dalQuanLyMonAn = new QuanLyMonAnDAL();

        // Hiển thị danh sách món ăn
        public List<MonAnDTO> HienThiDanhSachMonAn()
        {
            return dalQuanLyMonAn.HienThiDanhSachMonAn();
        }
        public List<NguyenLieuDTO> HienThiDanhSachNguyenLieu()
        {
            return dalQuanLyMonAn.HienThiDanhSachNguyenLieu();
        }
        public List<CongThucDTO> HienThiCongThucTheoMonAn(string maMonAn)
        {
            return dalQuanLyMonAn.HienThiCongThucTheoMonAn(maMonAn);
        }
        public bool ThemCongThuc(CongThucDTO congThuc)
        {
            return dalQuanLyMonAn.ThemCongThuc(congThuc);
        }
        public bool ThemDinhLuongChoCongThuc(CongThucDTO congThuc)
        {
            return dalQuanLyMonAn.ThemDinhLuongChoCongThuc(congThuc);
        }
        public List<DonViTinhDTO> HienThiDanhMucDVT()
        {
            return dalQuanLyMonAn.HienThiDanhMucDVT();
        }
        public DataTable TimKiemNguyenLieu(string searchText)
        {
            // Có thể thực hiện kiểm tra hợp lệ hoặc xử lý dữ liệu ở đây nếu cần
            return dalQuanLyMonAn.TimKiemNguyenLieu(searchText);
        }
        public CongThucDTO LayNguyenLieuTheoMaMonAnVaMaNL(string maMonAn,string maNguyenLieu)
        {
            return dalQuanLyMonAn.LayNguyenLieuTheoMaMonAnVaMaNL(maMonAn, maNguyenLieu);
        }

        public void UpdateCongThuc(CongThucDTO congThuc)
        {
            dalQuanLyMonAn.UpdateCongThuc(congThuc);
        }

        public void DeleteCongThuc(string maMonAn, string maNguyenLieu)
        {
            dalQuanLyMonAn.DeleteCongThuc(maMonAn, maNguyenLieu);
        }
        public DataTable TimKiemTenNguyenLieuTrongCongThuc(string searchText,string maMonAn)
        {
            // Có thể thực hiện kiểm tra hợp lệ hoặc xử lý dữ liệu ở đây nếu cần
            return dalQuanLyMonAn.TimKiemTenNguyenLieuTrongCongThuc(searchText,maMonAn);
        }
        public DataTable LayDanhSachLoaiMonAn()
        {
            return dalQuanLyMonAn.LayDanhSachLoaiMonAn();
        }
        public MonAnDTO LayThongTinMonAn(string maMonAn)
        {
            return dalQuanLyMonAn.LayThongTinMonAn(maMonAn);
        }
        public string TaoMaMonAnMoi()
        {
            return dalQuanLyMonAn.TaoMaMonAnMoi();
        }

        public bool ThemMonAn(MonAnDTO monAn)
        {
            return dalQuanLyMonAn.ThemMonAn(monAn);
        }
        public void LuuGiaVaoLichSu(string maMonAn, float giaMoi)
        {
            dalQuanLyMonAn.LuuGiaVaoLichSu(maMonAn, giaMoi);
        }
        // Phương thức ngừng bán món ăn
        public bool NgungBanMonAn(string maMonAn)
        {
            return dalQuanLyMonAn.NgungBanMonAn(maMonAn);
        }

        // Phương thức đánh dấu món ăn còn bán
        public bool ConBanMonAn(string maMonAn)
        {
            return dalQuanLyMonAn.ConBanMonAn(maMonAn);
        }
        public DataTable LocDanhSachMonAn(string tenMonAn,string trangThai)
        {
            return dalQuanLyMonAn.LocDanhSachMonAn(tenMonAn, trangThai);
        }
        public bool UpdateMonAn(string maMonAn, string tenMonAn, float giaMonAn, string maLoai, string moTa, float giaCu, string hinhAnh)
        {
            return dalQuanLyMonAn.UpdateMonAn(maMonAn, tenMonAn, giaMonAn, maLoai, moTa, giaCu, hinhAnh);
        }

    }
}
