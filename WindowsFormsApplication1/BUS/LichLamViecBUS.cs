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
    public class LichLamViecBUS
    {
        private LichLamViecDAL dal = new LichLamViecDAL();

        public DataTable GetLichLamViecByNgay(DateTime ngayLamViec)
        {
            return dal.LayLichLamViecTheoNgay(ngayLamViec);
        }

        public bool ThemLichLamViec(string maCa, string maNv, DateTime ngayLam)
        {
            return dal.ThemLichLamViec(maCa,maNv,ngayLam);
        }

        public bool XoaLichLamViec(string maCa, string maNv)
        {
            return dal.XoaLichLamViec(maCa,maNv);
        }

        public bool KiemTraLichLam(string maNhanVien, DateTime ngayLamViec)
        {
            return dal.KiemTraLichLam(maNhanVien, ngayLamViec);
        }
    }
}
