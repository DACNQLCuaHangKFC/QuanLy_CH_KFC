using WindowsFormsApplication1.DAL;
using WindowsFormsApplication1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.BUS
{
    class BUS_DATHANG
    {
        private DAL_DatHang dh;

        public BUS_DATHANG()
        {
            dh = new DAL_DatHang();
        }
        public List<NguyenLieuDTO> TimKiemNguyenLieu(string searchText, string trangThai)
        {
            return dh.TimKiemNguyenLieuTheoTrangThai(searchText, trangThai);
        }

        public DataTable LayNguyenLieuTheoNhaCungCap(string maNCC)
        {
            return dh.LayNguyenLieuTheoNhaCungCap(maNCC);
        }
        public DataTable GetAllNhaCungCap()
        {
            return dh.GetAllNhaCungCap();
        }
        public DataTable layNhaCungCapTheoMa(string maNCC)
        {
            return dh.layNhaCungCapTheoMa(maNCC);
        }
        public string GenerateMaPhieuNhap()
        {
            DateTime now = DateTime.Now;

            // Tạo mã theo định dạng YYMMDDHHMMSS
            string maPhieuNhap = "PN" + now.ToString("yyMMddHHmmss");

            return maPhieuNhap;
        }
        public bool InsertPhieuNhap(string maPhieuNhap, string maNhanVien, string maNCC, DateTime ngayNhap, float tongTienNhap)
        {
            return dh.InsertPhieuNhap(maPhieuNhap, maNhanVien, maNCC, ngayNhap, tongTienNhap);
        }
        public bool InsertChiTietPhieuNhap(string maPhieuNhap, List<Tuple<string, int, float,string>> chiTietList)
        {
            bool allSuccess = true;

            foreach (var detail in chiTietList)
            {
                string maNguyenLieu = detail.Item1;
                int soLuong = detail.Item2;
                float tongGia = detail.Item3;
                string trangThai = detail.Item4;

                // Call the DAL method to insert each detail
                allSuccess = allSuccess && dh.InsertChiTietPhieuNhap(maPhieuNhap, maNguyenLieu, soLuong, tongGia, trangThai);
            }

            return allSuccess;
        }
        public DataTable SearchPhieuNhap(DateTime startDate, DateTime endDate)
        {
            return dh.SearchPhieuNhap(startDate, endDate);
        }
        public DataTable LayChiTietPhieuNhapTheoMa(string maPhieuNhapHang)
        {
            return dh.LayChiTietPhieuNhapTheoMa(maPhieuNhapHang);
        }
        public List<NguyenLieuDTO> LayDanhSachNguyenLieuTheoTrangThai(string trangThai)
        {
            return dh.HienThiNguyenLieuTheoTrangThai(trangThai);
        }

    }
}
