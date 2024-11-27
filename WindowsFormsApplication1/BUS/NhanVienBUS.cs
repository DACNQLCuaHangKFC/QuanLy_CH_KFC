using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.DAL;
using WindowsFormsApplication1.DTO;

namespace WindowsFormsApplication1.BUS
{
    public class NhanVienBUS
    {
        private NhanVienDAL nhanvienDAL;
        public NhanVienBUS()
        {
            nhanvienDAL = new NhanVienDAL();
        }

        public string CheckLogin(string username,string password)
        {
            return NhanVienDAL.kiemDangNhap(username, password);
        }

        public NhanVienDTO GetNhanVienByMaNV(string maNV)
        {
            return nhanvienDAL.GetNhanVienByMaNV(maNV);
        }

        public bool ThemNhanVien(string maNV, string tenNV, string soDienThoai, string diaChi, string hinhThucLam, string maLoaiNV, float luong)
        {
            return nhanvienDAL.ThemNhanVien(maNV,tenNV,soDienThoai,diaChi,hinhThucLam,maLoaiNV,luong);
        }

        public bool XoaNhanVien(string maNV)
        {
            return nhanvienDAL.XoaNhanVien(maNV);
        }

        public bool CapNhatNhanVien(string maNV, string tenNV, string soDienThoai, string diaChi, string hinhThucLam, string maLoaiNV, float luong)
        {
            return nhanvienDAL.CapNhatNhanVien(maNV, tenNV, soDienThoai, diaChi, hinhThucLam, maLoaiNV, luong);
        }

        public DataTable TimKiemNhanVien (string tenNhanVien)
        {
            return nhanvienDAL.TimKiemNhanVien(tenNhanVien);
        }
    }
}
