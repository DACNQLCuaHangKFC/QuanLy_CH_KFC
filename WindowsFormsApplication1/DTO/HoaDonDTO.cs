using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.DTO
{
    // DTO for Invoice Details
    public class InvoiceDTO
    {
        public string InvoiceID { get; set; }
        public string EmployeeName { get; set; }
        public string PaymentMethod { get; set; }
        public decimal Total { get; set; }
        public decimal Tax { get; set; }
        public decimal Discount { get; set; }
        public decimal FinalAmount { get; set; }
        public string Date { get; set; }

    }

    // DTO for Invoice Item (either an item or a combo)
    public class InvoiceItemDTO
    {
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }

    // Combined DTO to encapsulate both Invoice and Items
    public class CombinedInvoiceDTO
    {
        public InvoiceDTO InvoiceDetails { get; set; }
        public List<InvoiceItemDTO> Items { get; set; }  // This will store items (food items and combos)
    }

}
