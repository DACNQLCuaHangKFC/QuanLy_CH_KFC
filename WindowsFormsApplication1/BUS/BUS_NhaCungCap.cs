using WindowsFormsApplication1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.DAL;
using System.Windows.Forms;

namespace WindowsFormsApplication1.BUS
{
    public class BUS_NhaCungCap
    {
        private DAL_NhaCungCap nc = new DAL_NhaCungCap();

        public List<NhaCungCapDTO> HienThiDanhSachNhaCungCap()
        {
            return nc.LayDanhSachNhaCungCap();
        }
        public List<NhaCungCapDTO> LayNhaCungCapTheoLoaiNguyenLieu(string maLoaiNguyenLieu)
        {
            return nc.LayNhaCungCapTheoLoaiNguyenLieu(maLoaiNguyenLieu);
        }
        public List<NguyenLieuDTO> TimNguyenLieu(string maLoaiNguyenLieu, string searchText)
        {
            return nc.TimNguyenLieu(maLoaiNguyenLieu, searchText);
        }
        public string GenerateMaNCC()
        {
            return nc.GenerateMaNCC();
        }
        public bool CreateSupplier(string maNCC, string tenNCC, string sdt, string email, string tenNganHang, string soTaiKhoan)
        {
            return nc.CreateSupplier(maNCC,tenNCC, sdt, email, tenNganHang, soTaiKhoan);
        }
        public List<CungUngDTO> GetCungUngByMaNCC(string maNCC)
        {
            return nc.GetCungUngByMaNCC(maNCC);
        }
        public bool ThemCungUng(string maNCC, string maNguyenLieu, float donGia, string trangThai)
        {
            return nc.ThemCungUng(maNCC, maNguyenLieu, donGia, trangThai);
        }
        public bool CapNhatCungUng(string maNCC, string maNguyenLieu, float donGia, string trangThai)
        {
            // Kiểm tra dữ liệu trước khi gọi DAL
            if (string.IsNullOrEmpty(maNCC) || string.IsNullOrEmpty(maNguyenLieu) || donGia <= 0 || string.IsNullOrEmpty(trangThai))
            {
                MessageBox.Show("Vui lòng kiểm tra lại dữ liệu nhập vào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Gọi DAL để cập nhật dữ liệu
            return nc.CapNhatCungUng(maNCC, maNguyenLieu, donGia, trangThai);
        }
        public bool XoaCungUng(string maNCC, string maNguyenLieu)
        {
            try
            {
                // Gọi phương thức trong DAL để thực hiện xóa
                return nc.XoaCungUng(maNCC, maNguyenLieu);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi xóa: " + ex.Message);
                return false;
            }
        }

    }
}
