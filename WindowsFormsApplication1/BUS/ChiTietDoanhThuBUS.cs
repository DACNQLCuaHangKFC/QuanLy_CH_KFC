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
    public class ChiTietDoanhThuBUS
    {
        private ChiTietDoanhThuDAL doanhthuDAL;

        public static DataTable hienThiChiTietDoanhThu()
        {
            return ChiTietDoanhThuDAL.hienThiChiTietDoanhThu();
        }

        public ChiTietDoanhThuBUS()
        {
            doanhthuDAL = new ChiTietDoanhThuDAL();
        }

        public double LayDoanhThuTheoCa(string maCaLam, DateTime ngay)
        {
            return doanhthuDAL.GetDoanhThuTheoCa(maCaLam, ngay);
        }

        public bool ThemChiTietDoanhThu(string maDoanhThu, string maCaLam, double doanhThuTheoCa)
        {
            return doanhthuDAL.ThemChiTietDoanhThu(maDoanhThu,maCaLam,doanhThuTheoCa);
        }

        public bool XoaChiTietDoanhThu(string maDoanhThu, string maCaLam)
        {
            return doanhthuDAL.XoaChiTietDoanhThu(maDoanhThu, maCaLam);
        }
    }
}
