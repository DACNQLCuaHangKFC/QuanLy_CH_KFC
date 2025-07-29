using WindowsFormsApplication1.DAL;
using WindowsFormsApplication1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApplication1.BUS
{
    class HoaDonBUS
    {
        HoaDonDAL dalHoaDon = new HoaDonDAL();
        public CombinedInvoiceDTO GetInvoiceDetails(string invoiceID)
        {
            return dalHoaDon.GetInvoiceDetails(invoiceID);
        }
        public DataTable GetHoaDonByStatus(string status, DateTime fromDate, DateTime toDate)
        {
            return dalHoaDon.GetHoaDonByStatus(status, fromDate, toDate);
        }
        public DataTable GetChiTietHoaDon(string maHoaDon)
        {
            return dalHoaDon.GetChiTietHoaDon(maHoaDon);
        }
        public CombinedInvoiceDTO GetInvoiceDetailsByInvoiceID(string invoiceID)
        {
            return dalHoaDon.GetInvoiceDetailsByInvoiceID(invoiceID);
        }
    }
}
