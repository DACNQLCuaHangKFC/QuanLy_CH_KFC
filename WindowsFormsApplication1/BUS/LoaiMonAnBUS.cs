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
    public class LoaiMonAnBUS
    {
        private LoaiMonAnDAL loaiMonAnDAL;
        public LoaiMonAnBUS()
        {
            loaiMonAnDAL = new LoaiMonAnDAL();
        }

        public static DataTable hienThiLoaiMonAn()
        {
            return LoaiMonAnDAL.hienThiLoaiMonAn();
        }

        public static string taoMaLmaMoi()
        {
            return LoaiMonAnDAL.taoMaLmaMoi();
        }

        public bool ThemLoaiMonAn(string maLma, string tenLma)
        {
            return loaiMonAnDAL.ThemLoaiMonAn(maLma, tenLma);
        }

        public bool XoaLoaiMonAn(string maLma)
        {
            return loaiMonAnDAL.XoaLoaiMonAn(maLma);
        }

        public bool CapNhatLoaiMonAn(string maLma, string tenLma)
        {
            return loaiMonAnDAL.CapNhatLoaiMonAn(maLma, tenLma);
        }
    }
}
