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
        public DataTable GetHoaDonByStatus(string status, DateTime fromDate, DateTime toDate)
        {
            using (SqlConnection conn = dbConnect.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_HienThiDanhSachHoaDonTheoTrangThai", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số cho stored procedure
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@FromDate", fromDate);
                    cmd.Parameters.AddWithValue("@ToDate", toDate);

                    // Sử dụng SqlDataAdapter để điền dữ liệu vào DataTable
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    return dt;
                }
            }
        }
        public DataTable GetChiTietHoaDon(string maHoaDon)
        {
            using (SqlConnection conn = dbConnect.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetChiTietHoaDon", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public CombinedInvoiceDTO GetInvoiceDetailsByInvoiceID(string invoiceID)
        {
            using (SqlConnection conn = dbConnect.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetInvoiceDetailsByInvoiceID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@InvoiceID", invoiceID);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    // Tạo đối tượng DTO cho Invoice
                    var invoiceDetails = new InvoiceDTO();
                    var invoiceInfoTable = ds.Tables[0];
                    var itemsTable = ds.Tables[1];

                    // Kiểm tra xem bảng hóa đơn có dữ liệu không
                    if (invoiceInfoTable.Rows.Count > 0)
                    {
                        DataRow row = invoiceInfoTable.Rows[0];

                        invoiceDetails.InvoiceID = row["InvoiceID"].ToString();
                        invoiceDetails.EmployeeName = row["EmployeeName"].ToString();
                        invoiceDetails.PaymentMethod = row["PaymentMethod"].ToString();
                        invoiceDetails.Total = Convert.ToDecimal(row["Total"]);
                        invoiceDetails.Tax = Convert.ToDecimal(row["Tax"]);
                        invoiceDetails.Discount = Convert.ToDecimal(row["Discount"]);
                        invoiceDetails.FinalAmount = Convert.ToDecimal(row["FinalAmount"]);
                        invoiceDetails.Date = row["Date"].ToString();
                    }

                    // Tạo danh sách các Item
                    List<InvoiceItemDTO> items = new List<InvoiceItemDTO>();
                    foreach (DataRow row in itemsTable.Rows)
                    {
                        var item = new InvoiceItemDTO
                        {
                            ItemName = row["ItemName"].ToString(),
                            Quantity = Convert.ToInt32(row["Quantity"]),
                            UnitPrice = Convert.ToDecimal(row["UnitPrice"]),
                            TotalPrice = Convert.ToDecimal(row["TotalPrice"])
                        };
                        items.Add(item);
                    }

                    // Trả về CombinedInvoiceDTO chứa thông tin hóa đơn và danh sách items
                    return new CombinedInvoiceDTO
                    {
                        InvoiceDetails = invoiceDetails,
                        Items = items
                    };
                }
            }
        }



    }
}
