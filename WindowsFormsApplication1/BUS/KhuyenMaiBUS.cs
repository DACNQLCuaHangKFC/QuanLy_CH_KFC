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
    public class KhuyenMaiBUS
    {
        private KhuyenMaiDAL khuyenMaiDAL;
        public KhuyenMaiBUS()
        {
            khuyenMaiDAL = new KhuyenMaiDAL();
        }

        public static DataTable hienThiKhuyenMai()
        {
            return KhuyenMaiDAL.hienThiKhuyenMai();
        }

        public static string taoMakmMoi()
        {
            return KhuyenMaiDAL.taoMaKmMoi();
        }

        public bool ThemKhuyenMai(string maKm, string tenKm, float ptkm, DateTime ngayBd, DateTime ngayKt)
        {
            return khuyenMaiDAL.ThemKhuyenMai(maKm,tenKm,ptkm,ngayBd,ngayKt);
        }

        public bool XoaKhuyenMai(string maKm)
        {
            return khuyenMaiDAL.XoaKhuyenMai(maKm);
        }

        public bool CapNhatKhuyenMai(string maKm, string tenKm, float ptkm, DateTime ngayBd, DateTime ngayKt)
        {
            return khuyenMaiDAL.CapNhatKhuyenMai(maKm, tenKm, ptkm, ngayBd, ngayKt);
        }
    }
}
