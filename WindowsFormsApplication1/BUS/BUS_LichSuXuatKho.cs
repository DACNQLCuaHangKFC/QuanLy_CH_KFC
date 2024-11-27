using WindowsFormsApplication1.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.BUS
{
    class BUS_LichSuXuatKho
    {
        private DAL_LichSuXuatKho lsx = new DAL_LichSuXuatKho();
        public DataTable TimKiemLichSuXuatTheoNgay(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            return lsx.TimKiemLichSuXuatTheoNgay(ngayBatDau, ngayKetThuc);
        }
    }
}
