using WindowsFormsApplication1.DAL;
using WindowsFormsApplication1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.BUS
{
    class HoaDonBUS
    {
        HoaDonDAL dalHoaDon = new HoaDonDAL();
        public CombinedInvoiceDTO GetInvoiceDetails(string invoiceID)
        {
            return dalHoaDon.GetInvoiceDetails(invoiceID);
        }
    }
}
