using WindowsFormsApplication1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.DAL
{
    class HoaDonDAL
    {
        private DBConnect dbConnect;

        public HoaDonDAL()
        {
            dbConnect = new DBConnect();
        }
        public CombinedInvoiceDTO GetInvoiceDetails(string invoiceID)
        {
            CombinedInvoiceDTO combinedInvoice = new CombinedInvoiceDTO();
            combinedInvoice.Items = new List<InvoiceItemDTO>();

            // First, get the main invoice details (first query)
            string query = "GetInvoiceDetails";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@InvoiceID", SqlDbType.VarChar) { Value = invoiceID }
            };

            using (SqlDataReader reader = dbConnect.ExecuteReader(query, parameters))
            {
                if (reader != null)
                {
                    // Get Invoice Details (First result set)
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            combinedInvoice.InvoiceDetails = new InvoiceDTO
                            {
                                InvoiceID = reader["InvoiceID"].ToString(),
                                EmployeeName = reader["EmployeeName"].ToString(),
                                PaymentMethod = reader["PaymentMethod"].ToString(),
                                Total = Convert.ToDecimal(reader["Total"]),
                            };
                        }
                    }

                    // Move to the second result set (Items and Combos)
                    if (reader.NextResult())
                    {
                        while (reader.Read())
                        {
                            InvoiceItemDTO item = new InvoiceItemDTO
                            {
                                ItemID = reader["ItemID"].ToString(),
                                ItemName = reader["ItemName"].ToString(),
                                Quantity = Convert.ToInt32(reader["Quantity"]),
                                UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                                TotalPrice = Convert.ToDecimal(reader["TotalPrice"])
                            };
                            if (item.ItemID != "MA000" && item.ItemID != "CB000")
                            {
                                combinedInvoice.Items.Add(item);
                            }    
                        }
                    }
                }
            }

            return combinedInvoice;
        }

    }
}
