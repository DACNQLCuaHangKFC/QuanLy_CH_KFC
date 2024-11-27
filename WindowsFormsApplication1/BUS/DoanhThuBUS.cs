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
    public class DoanhThuBUS
    {
        private DoanhThuDAL doanhThuDAL;
        public DoanhThuBUS()
        {
            doanhThuDAL  = new DoanhThuDAL();
        }

        public static DataTable hienThiDoanhThu()
        {
            return DoanhThuDAL.hienThiDoanhThu();
        }
        public DataTable LayChiTietDoanhThuTheoMaDoanhThu(string maDoanhThu)
        {
            return doanhThuDAL.LayChiTietDoanhThuTheoMaDoanhThu(maDoanhThu);
        }

        public DataTable LayDoanhThuTheoThang(int month, int year)
        {
            return doanhThuDAL.LayDoanhThuTheoThang(month,year);
        }

        public bool UpdateTongDoanhThu(string maDoanhThu)
        {
            return doanhThuDAL.UpdateTongDoanhThu(maDoanhThu);
        }

        public bool KiemTraMaDoanhThuTonTai(string maDoanhThu)
        {
            return doanhThuDAL.KiemTraMaDoanhThuTonTai(maDoanhThu);
        }

        public bool ThemDoanhThu(string maDoanhThu, DateTime ngayKetToan)
        {
            return doanhThuDAL.ThemDoanhThu(maDoanhThu, ngayKetToan);
        }

        public DataTable TimDoanhThuTheoNgay(string searchTerm)
        {
            return doanhThuDAL.SearchDoanhThuByDate(searchTerm);
        }
    }
}
