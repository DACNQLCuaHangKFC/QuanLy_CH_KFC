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
    public class TonKhoBUS
    {
        TonKhoDAL tonKhoDAL;

        public TonKhoBUS()
        {
            tonKhoDAL = new TonKhoDAL();
        }
        public DataTable LayThongKeTonKho(string maDiaDiem, string trangThai)
        {
            return tonKhoDAL.LayThongKeTonKho(maDiaDiem, trangThai);
        }
    }
}
