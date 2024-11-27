using Microsoft.Reporting.WinForms;
using Newtonsoft.Json;
using WindowsFormsApplication1.BUS;
using WindowsFormsApplication1.DTO;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.GUI
{
    public partial class frmHoaDon : Form
    {
        NganHangBUS nganHangBUS = new NganHangBUS();
        public frmHoaDon(DataSet dulieu)
        {
            InitializeComponent();

            // Kiểm tra nếu cột "PaymentMethod" tồn tại và hàng đầu tiên có giá trị
            if (dulieu.Tables[1].Rows.Count > 0 && dulieu.Tables[1].Columns.Contains("PaymentMethod"))
            {
                string paymentMethod = dulieu.Tables[1].Rows[0]["PaymentMethod"].ToString();

                // Kiểm tra nếu phương thức thanh toán là "chuyển khoản"
                if (paymentMethod.Equals("Chuyển Khoản", StringComparison.OrdinalIgnoreCase))
                {
                    WebClient client = new WebClient();
                    var htmlData = client.DownloadData("https://api.vietqr.io/v2/banks");
                    var bankRawJson = Encoding.UTF8.GetString(htmlData);
                    var listBankData = JsonConvert.DeserializeObject<Bank>(bankRawJson);

                    // Truy cập bảng đầu tiên trong DataSet
                    DataTable table = dulieu.Tables[1];
                    string finalAmount = string.Empty;
                    string info = "THANH TOAN HOA DON ";

                    // Lấy giá trị cột "FinalAmount" từ hàng đầu tiên
                    if (table.Rows.Count > 0) // Kiểm tra xem bảng có dữ liệu không
                    {
                        finalAmount = table.Rows[0]["FinalAmount"].ToString();
                        info = info + table.Rows[0]["InvoiceID"].ToString();
                    }

                    List<NganHangDTO> nganHang = nganHangBUS.GetAllNganHang();

                    var apiRequest = new ApiRequest();
                    apiRequest.acqId = Convert.ToInt32(nganHang[0].MaNganHang);
                    apiRequest.accountNo = long.Parse(nganHang[0].SoTaiKhoan);
                    apiRequest.accountName = nganHang[0].TenChuThe;
                    apiRequest.amount = Convert.ToInt32(finalAmount);
                    apiRequest.format = "text";
                    apiRequest.template = "qr_only";
                    apiRequest.addInfo = info;
                    var jsonRequest = JsonConvert.SerializeObject(apiRequest);

                    // Gửi yêu cầu đến API VietQR
                    var client2 = new RestClient("https://api.vietqr.io/v2/generate");
                    var request = new RestRequest();

                    request.Method = Method.POST;
                    request.AddHeader("Accept", "application/json");
                    request.AddParameter("application/json", jsonRequest, ParameterType.RequestBody);

                    var response = client2.Execute(request);
                    var content = response.Content;

                    var dataResult = JsonConvert.DeserializeObject<ApiResponse>(content);

                    if (response.IsSuccessful && dataResult != null && dataResult.data != null)
                    {
                        // Chuyển đổi Base64 thành Image
                        var qrImage = Base64ToImage(dataResult.data.qrDataURL.Replace("data:image/png;base64,", ""));

                        // Gán byte[] cho cột QRCode
                        dulieu.Tables[1].Rows[0]["QRCode"] = ImageToByteArray(qrImage);
                    }
                    else
                    {
                        MessageBox.Show("Không thể tạo mã QR từ API VietQR.");
                    }
                }
                else
                {
                    //MessageBox.Show("Phương thức thanh toán không phải là chuyển khoản, không tạo mã QR.");
                }
            }


            // Tạo đối tượng ReportViewer và thiết lập đường dẫn đến file RDLC
            ReportViewer report = new ReportViewer();
            report.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.GUI.ReportHoaDon.rdlc"; // Đảm bảo rằng đường dẫn đúng với namespace và tên file RDLC của bạn

            // Xóa mọi dữ liệu trong ReportViewer
            report.LocalReport.DataSources.Clear();

            // Thêm các DataTable vào DataSource của báo cáo
            report.LocalReport.DataSources.Add(new ReportDataSource("DataSetDetails", dulieu.Tables[0])); // Thêm chi tiết hóa đơn
            report.LocalReport.DataSources.Add(new ReportDataSource("DataSetHeader", dulieu.Tables[1]));    // Thêm thông tin hóa đơn

            // Thêm ReportViewer vào form
            this.Controls.Add(report);

            // Thiết lập vị trí và kích thước cho ReportViewer
            report.Dock = DockStyle.Fill;

            // Làm mới báo cáo
            report.RefreshReport();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            
        }
        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }
        public byte[] ImageToByteArray(Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // Đảm bảo định dạng PNG
                return ms.ToArray();
            }
        }

    }
}


