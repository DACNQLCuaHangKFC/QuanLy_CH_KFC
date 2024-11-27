using System;
using System.Collections.Generic;
using WindowsFormsApplication1.DAL;
using WindowsFormsApplication1.DTO;

namespace WindowsFormsApplication1.BUS
{
    class KhachHangBUS
    {
        private KhachHangDAL khachHangDAL = new KhachHangDAL();

        // Lấy danh sách tất cả khách hàng
        public List<KhachHangDTO> GetAllKhachHang()
        {
            return khachHangDAL.GetAllKhachHang();
        }

        // Thêm khách hàng
        public bool AddKhachHang(KhachHangDTO khachHang)
        {
            // Kiểm tra logic nghiệp vụ trước khi thêm
            if (string.IsNullOrWhiteSpace(khachHang.SoDienThoai) || string.IsNullOrWhiteSpace(khachHang.TenKhachHang))
            {
                throw new Exception("Số điện thoại và tên khách hàng không được để trống!");
            }

            if (khachHang.SoDienThoai.Length > 15)
            {
                throw new Exception("Số điện thoại không được dài hơn 15 ký tự!");
            }

            return khachHangDAL.AddKhachHang(khachHang);
        }

        // Sửa thông tin khách hàng
        public bool UpdateKhachHang(KhachHangDTO khachHang)
        {
            return khachHangDAL.UpdateKhachHang(khachHang);
        }

        public bool IsSoDienThoaiTonTai(string soDienThoai)
        {
            return khachHangDAL.KiemTraTonTaiSoDienThoai(soDienThoai);
        }

    }
}
