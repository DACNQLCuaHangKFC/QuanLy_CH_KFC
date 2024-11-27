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
    public class LoaiNguyenLieuBUS
    {
        private LoaiNguyenLieuDAL loaiNguyenLieuDAL;
        public LoaiNguyenLieuBUS()
        {
            loaiNguyenLieuDAL = new LoaiNguyenLieuDAL();
        }

        public static DataTable hienThiLoaiNguyenLieu()
        {
            return LoaiNguyenLieuDAL.hienThiLoaiNguyenLieu();
        }

        public static string taoMaLnlMoi()
        {
            return LoaiNguyenLieuDAL.taoMaLnlMoi();
        }

        public bool ThemLoaiNguyenLieu(string maLnl, string tenLnl)
        {
            return loaiNguyenLieuDAL.ThemLoaiNguyenLieu(maLnl, tenLnl);
        }

        public bool XoaLoaiNguyenLieu(string maLnl)
        {
            return loaiNguyenLieuDAL.XoaLoaiNguyenLieu(maLnl);
        }

        public bool CapNhatLoaiNguyenLieu(string maLnl, string tenLnl)
        {
            return loaiNguyenLieuDAL.CapNhatLoaiNguyenLieu(maLnl, tenLnl);
        }
    }
}
