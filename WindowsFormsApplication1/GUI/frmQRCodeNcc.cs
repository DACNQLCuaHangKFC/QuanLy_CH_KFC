using Newtonsoft.Json;
using Octokit.Internal;
using WindowsFormsApplication1.DTO;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.GUI
{
    public partial class frmQRCodeNcc : Form
    {
        string ten;
        public frmQRCodeNcc(string tenNCC,string tenNganHang, string soTaiKhoan, float soTien)
        {
            InitializeComponent();
            txtTenTaiKhoan.Text = tenNCC;
            txtSTK.Text = soTaiKhoan;
            txtSoTien.Text = soTien.ToString();
            ten = tenNganHang;


        }

        private void frmQRCode_Load(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                var htmlData = client.DownloadData("https://api.vietqr.io/v2/banks");
                var bankRawJson = Encoding.UTF8.GetString(htmlData);
                var listBankData = JsonConvert.DeserializeObject<Bank>(bankRawJson);

                cb_nganhang.DataSource = listBankData.data;   // list banks
                cb_nganhang.DisplayMember = "short_name";
                cb_nganhang.ValueMember = "bin";
                cb_nganhang.SelectedValue = listBankData.data.FirstOrDefault()?.bin;
                cb_template.SelectedIndex = 0;
                foreach (var item in cb_nganhang.Items)
                {
                    var bank = item as Datum; // Replace 'YourBankDataType' with the actual type of the items
                    if (bank != null && bank.custom_name.Contains(ten))
                    {
                        cb_nganhang.SelectedItem = item;
                        break;
                    }
                }
            }
        }
        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }

        private void btnTaoMa_Click(object sender, EventArgs e)
        {
            //"accountNo": 113366668888,
            //"accountName": "QUY VAC XIN PHONG CHONG COVID",
            //"acqId": 970415,
            //"amount": 79000,
            //"addInfo": "Ung Ho Quy Vac Xin",
            //"format": "text",
            //"template": "compact"
            var apiRequest = new ApiRequest();
            apiRequest.acqId = Convert.ToInt32(cb_nganhang.SelectedValue);
            apiRequest.accountNo = long.Parse(txtSTK.Text);
            apiRequest.accountName = txtTenTaiKhoan.Text;
            apiRequest.amount = Convert.ToInt32(txtSoTien.Text);
            apiRequest.format = "text";
            apiRequest.template = cb_template.Text;
            apiRequest.addInfo = txtInfo.Text;
            var jsonRequest = JsonConvert.SerializeObject(apiRequest);
            // use restsharp for request api.
            var client = new RestClient("https://api.vietqr.io/v2/generate");
            var request = new RestRequest();

            request.Method = Method.POST;
            request.AddHeader("Accept", "application/json");

            request.AddParameter("application/json", jsonRequest, ParameterType.RequestBody);

            var response = client.Execute(request);
            var content = response.Content;
            Console.WriteLine(apiRequest.acqId);
            var dataResult = JsonConvert.DeserializeObject<ApiResponse>(content);


            var image = Base64ToImage(dataResult.data.qrDataURL.Replace("data:image/png;base64,", ""));
            pictureBox1.Image = image;

        }

    }
}
