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
    public class DonViTinhBUS
    {
        private DonViTinhDAL donViTinhDAL;
        public DonViTinhBUS()
        {
            donViTinhDAL = new DonViTinhDAL();
        }

        public static DataTable hienThiDonViTinh()
        {
            return DonViTinhDAL.hienThiDonViTinh();
        }

        public static string taoMDvtMoi()
        {
            return DonViTinhDAL.taoMDvtMoi();
        }

        public bool ThemDonViTinh(string maDvt, string tenDvt)
        {
            return donViTinhDAL.ThemDonViTinh(maDvt,tenDvt);
        }

        public bool XoaDonViTinh(string maDvt)
        {
            return donViTinhDAL.XoaDonViTinh(maDvt);
        }

        public bool CapNhatDonViTinh(string maDvt, string tenDvt)
        {
            return donViTinhDAL.CapNhatDonViTinh(maDvt,tenDvt);
        }
    }
}
