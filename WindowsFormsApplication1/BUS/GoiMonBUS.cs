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
    class GoiMonBUS
    {
        GoiMonDAL dalGoiMon = new GoiMonDAL();

        public DataTable LayDanhSachMonAnConBan()
        {
            return dalGoiMon.LayDanhSachMonAnConBan();
        }
        public DataTable TimKiemMonAn(string tenMonAn)
        {
            return dalGoiMon.TimKiemMonAn(tenMonAn);
        }
        public List<KhachHangDTO> LayTatCaKhachHang()
        {
            return dalGoiMon.LayTatCaKhachHang();
        }
        public KhachHangDTO LayThongTinKhachHang(string soDienThoai)
        {
            return dalGoiMon.LayThongTinKhachHang(soDienThoai);
        }
        public List<KhuyenMaiDTO> GetAllKhuyenMaiConHan()
        {

            return dalGoiMon.GetAllKhuyenMaiConHan();
        }
        public float LayPhanTramKhuyenMai(string maKhuyemMai)
        {
            return dalGoiMon.LayPhanTramKhuyenMai(maKhuyemMai);
        }
        public void TruNguyenLieu(string maMonAn, int soLuong)
        {
            try
            {
                // Kiểm tra điều kiện hoặc xử lý nghiệp vụ trước khi gọi DAL
                if (string.IsNullOrEmpty(maMonAn) || soLuong <= 0)
                {
                    throw new ArgumentException("Mã món ăn và số lượng không hợp lệ.");
                }

                // Gọi DAL để thực hiện việc trừ nguyên liệu
                dalGoiMon.TruNguyenLieu(maMonAn, soLuong);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                throw new Exception("Lỗi khi trừ nguyên liệu", ex);
            }
        }
        public void ThemNguyenLieuKhiBoChon(string maMonAn, int soLuong)
        {
            try
            {
                // Kiểm tra điều kiện hoặc xử lý nghiệp vụ trước khi gọi DAL
                if (string.IsNullOrEmpty(maMonAn) || soLuong <= 0)
                {
                    throw new ArgumentException("Mã món ăn và số lượng không hợp lệ.");
                }

                // Gọi DAL để thực hiện việc trừ nguyên liệu
                dalGoiMon.ThemNguyenLieukhiBoChon(maMonAn, soLuong);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                throw new Exception("Lỗi khi thêm lại nguyên liệu", ex);
            }
        }
        public bool LuuHoaDon(string maHoaDon, string maNhanVien, string soDienThoai, string maBan, string maKhuyenMai, DateTime ngayThanhToan, decimal tongTien, string phuongThucThanhToan)
        {
            return dalGoiMon.LuuHoaDon(maHoaDon, maNhanVien, soDienThoai, maBan, maKhuyenMai, ngayThanhToan, tongTien, phuongThucThanhToan);
        }
        public bool LuuChiTietHoaDon(string maHoaDon, string maMonAn, string maCombo, int soLuong, string trangThai)
        {
            return dalGoiMon.LuuChiTietHoaDon(maHoaDon, maMonAn, maCombo, soLuong, trangThai);
        }
        public string TaoMaHoaDonMoi()
        {
            return dalGoiMon.TaoMaHoaDonMoi();
        }
        public void CaiLaiDiemTichLuyChoKhachHang(string soDienThoai)
        {
           dalGoiMon.CaiLaiDiemTichLuyChoKhachHang(soDienThoai);
        }
        public void CongDiemTichLuyChoKhachHang(string soDienThoai, int soDiem)
        {
            dalGoiMon.CongDiemTichLuyChoKhachHang(soDienThoai, soDiem);
        }
        public string GetLatestInvoice()
        {
            return dalGoiMon.GetLatestInvoice();
        }
    }
}
