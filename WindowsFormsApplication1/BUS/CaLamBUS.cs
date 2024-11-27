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
    public class CaLamBUS
    {
        private CaLamDAL caLamDAL = new CaLamDAL();
        public DataTable LayDanhSachCaLam()
        {
            return caLamDAL.LayDanhSachCaLam();
        }
    }
}
