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
    class BUS_Kho
    {
        private DAL_Kho dal = new DAL_Kho();
        public List<NguyenLieuDTO> LayDanhSachNguyenLieuKho()
        {
            return dal.HienThiDanhSachNguyenLieuKho();
        }
        public List<NguyenLieuDTO> LayDanhSachNguyenLieuBep()
        {
            return dal.HienThiDanhSachNguyenLieuBep();
        }
        public List<NguyenLieuDTO> LayNguyenLieuBep()
        {
            return dal.HienThiNguyenLieuBep();
        }
        public List<NguyenLieuDTO> HienThiDanhSachKhoCanNhap()
        {
            return dal.HienThiDanhSachKhoCanNhap();
        }
        public List<NguyenLieuDTO> TimKiemNguyenLieuKho(string searchText)
        {
            return dal.TimKiemNguyenLieuKho(searchText);
        }
        public int GetSoLuongTon(string maNguyenLieu)
        {
            return dal.GetSoLuongTon(maNguyenLieu);
        }

        public void TruKho(string maNguyenLieu, int soLuongNhap)
        {
            dal.TruKho(maNguyenLieu, soLuongNhap);
        }

        public void CongBep(string maNguyenLieu, int soLuongNhap)
        {
            dal.CongBep(maNguyenLieu, soLuongNhap);
        }
        public void CapNhatBep(string maNguyenLieu, int soLuongNhap)
        {
            dal.CapNhatBep(maNguyenLieu, soLuongNhap);
        }

        public void TaoLichSuXuat(string maXuatKho, string maNguyenLieu, string maDiaDiemXuat, string maDiaDiemNhap, int soLuong, DateTime ngayThucHien)
        {
            dal.TaoLichSuXuat(maXuatKho, maNguyenLieu, maDiaDiemXuat, maDiaDiemNhap, soLuong, ngayThucHien);
        }
        public DataTable TimNguyenLieuTheoLoai(string maLoaiNguyenLieu)
        {
            return dal.TimNguyenLieuTheoLoai(maLoaiNguyenLieu);
        }
        private string connectionString;

        public BUS_Kho(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public BUS_Kho()
        {
        }
        public List<LichSuXuatKhoDTO> LichSuXuatKho()
        {
            DataTable dt = dal.HienThiLichSuXuatKho();
            List<LichSuXuatKhoDTO> lstLichSuXuatKho = new List<LichSuXuatKhoDTO>();

            foreach (DataRow row in dt.Rows)
            {
                LichSuXuatKhoDTO lichSu = new LichSuXuatKhoDTO
                {
                    MaXuatKho = row["MaXuatKho"].ToString(),
                    MaNguyenLieu = row["MaNguyenLieu"].ToString(),
                    MaDiaDiemXuat = row["MaDiaDiemXuat"].ToString(),
                    MaDiaDiemNhap = row["MaDiaDiemNhap"].ToString(),
                    SoLuong = int.Parse(row["SoLuong"].ToString()),
                    NgayThucHien = DateTime.Parse(row["NgayThucHien"].ToString())
                };

                lstLichSuXuatKho.Add(lichSu);
            }

            return lstLichSuXuatKho;
        }
        public bool CapNhatTrangThaiTonKhoBep(string maNguyenLieu, string trangThai)
        {
            return dal.CapNhatTrangThaiTonKhoBep(maNguyenLieu, trangThai);
        }
        public bool CapNhatTrangThaiTonKhoKho(string maNguyenLieu, string trangThai)
        {
            return dal.CapNhatTrangThaiTonKhoKho(maNguyenLieu, trangThai);
        }
        public bool NhapNguyenLieuVaoBep(string maNguyenLieu, int soLuongNhap, out string message)
        {
            // Lấy số lượng tồn kho của nguyên liệu từ kho
            int soLuongTonKho = dal.GetSoLuongTon(maNguyenLieu);

            // Kiểm tra nếu số lượng nhập nhiều hơn số lượng tồn kho
            if (soLuongNhap > soLuongTonKho)
            {
                message = "Số lượng nhập không được lớn hơn số lượng tồn kho!";
                return false;
            }

            // Trừ số lượng ở kho
            dal.TruKho(maNguyenLieu, soLuongNhap);

            // Cộng số lượng vào Bếp
            dal.CapNhatBep(maNguyenLieu, soLuongNhap);

            // Chèn lịch sử xuất nguyên liệu
            string maXuatKho = GenerateMaXuatKho(); // Tạo mã xuất kho
            string maDiaDiemXuat = "DD001"; // Địa điểm xuất
            string maDiaDiemNhap = "DD002"; // Địa điểm nhập
            DateTime ngayThucHien = DateTime.Now; // Ngày thực hiện

            dal.TaoLichSuXuat(maXuatKho, maNguyenLieu, maDiaDiemXuat, maDiaDiemNhap, soLuongNhap, ngayThucHien);

            message = "Cập nhật thành công!";
            return true;
        }

        private string GenerateMaXuatKho()
        {
            DateTime now = DateTime.Now;

            // Tạo mã theo định dạng YYMMDDHHMMSS
            string maXuatKho = "XK" + now.ToString("yyMMddHHmmss");

            return maXuatKho;
        }
        public bool TaoNguyenLieu(string tenNguyenLieu, string maLoaiNguyenLieu, string maDVT)
        {
            string maNguyenLieu = dal.GenerateNewMaNguyenLieu();
            return dal.ThemNguyenLieu(maNguyenLieu, maLoaiNguyenLieu, tenNguyenLieu, maDVT);
        }
        //public List<ChiTietPhieuNhapDTO> HienThiDanhSachChiTietPhieuNhap()
        //{
        //    return dal.HienThiDanhSachChiTietPhieuNhap();
        //}
        public List<ChiTietPhieuNhapDTO> HienThiDanhSachChiTietPhieuNhap(string maPhieuNhapHang)
        {
            return dal.HienThiDanhSachChiTietPhieuNhap(maPhieuNhapHang);
        }

        public bool UpdateTrangThai(string maPhieuNhapHang, string maNguyenLieu, string trangThai)
        {
            return dal.UpdateTrangThai(maPhieuNhapHang, maNguyenLieu, trangThai);
        }
        public List<PhieuNhapDTO> LayDanhSachPhieuNhap(string tenNCC, string trangThai)
        {
            return dal.LayDanhSachPhieuNhap(tenNCC, trangThai);
        }
        public List<NguyenLieuDTO> HienThiNguyenLieuKhoTheoTrangThai(string trangThai)
        {
            return dal.HienThiNguyenLieuKhoTheoTrangThai(trangThai);
        }
        public bool NhapHangVaoKho(string maPhieuNhapHang, string maNguyenLieu, int soLuong)
        {
            return dal.UpdateTrangThaiNhapKho(maPhieuNhapHang, maNguyenLieu, soLuong);
        }
        public DataTable GetHoaDonFiltered(DateTime selectedDate, string status)
        {
            return dal.GetHoaDonByDateAndStatus(selectedDate, status);
        }
        public DataTable LayChiTietHoaDon(string maHoaDon)
        {
            return dal.LayChiTietHoaDon(maHoaDon);
        }
        public bool CapNhatTrangThaiChiTietHoaDon(string maHoaDon, string maMonAn, string maComBo, string trangThai)
        {
            return dal.CapNhatTrangThaiChiTietHoaDon(maHoaDon, maMonAn,maComBo, trangThai);
        }
    }
}
