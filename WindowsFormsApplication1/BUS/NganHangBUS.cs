using WindowsFormsApplication1.DAL;
using WindowsFormsApplication1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.BUS
{
    class NganHangBUS
    {
        private readonly NganHangDAL _nganHangDAL = new NganHangDAL();

        // Lấy danh sách tất cả ngân hàng
        public List<NganHangDTO> GetAllNganHang()
        {
            return _nganHangDAL.GetAllNganHang();
        }

        // Thêm ngân hàng mới
        public bool AddNganHang(NganHangDTO nganHang)
        {
            // Kiểm tra dữ liệu đầu vào (ví dụ: số tài khoản không được trống)
            if (string.IsNullOrEmpty(nganHang.SoTaiKhoan) || string.IsNullOrEmpty(nganHang.TenChuThe))
            {
                throw new ArgumentException("Số tài khoản và tên chủ thẻ không được để trống.");
            }
            return _nganHangDAL.AddNganHang(nganHang);
        }

        // Xóa ngân hàng theo số tài khoản và tên chủ thẻ
        public bool DeleteNganHang(string soTaiKhoan, string tenChuThe)
        {
            if (string.IsNullOrEmpty(soTaiKhoan) || string.IsNullOrEmpty(tenChuThe))
            {
                throw new ArgumentException("Số tài khoản và tên chủ thẻ không được để trống.");
            }
            return _nganHangDAL.DeleteNganHang(soTaiKhoan, tenChuThe);
        }

        public bool KiemTraTaiKhoanDaTonTai()
        {
           return  _nganHangDAL.KiemTraTaiKhoanDaTonTai();
        }
    }
}
