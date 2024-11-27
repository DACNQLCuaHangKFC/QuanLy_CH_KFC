using Newtonsoft.Json;
using WindowsFormsApplication1.BUS;
using WindowsFormsApplication1.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.GUI
{
    public partial class frmTaiKhoanNganHang : Form
    {
        private NganHangBUS nganHangBUS = new NganHangBUS();
        public frmTaiKhoanNganHang()
        {
            InitializeComponent();
            LoadDanhSachTaiKhoan();
        }

        private void frmTaiKhoanNganHang_Load(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                var htmlData = client.DownloadData("https://api.vietqr.io/v2/banks");
                var bankRawJson = Encoding.UTF8.GetString(htmlData);
                var listBankData = JsonConvert.DeserializeObject<Bank>(bankRawJson);

                cboNganHang.DataSource = listBankData.data;   // list banks
                cboNganHang.DisplayMember = "shortName";
                cboNganHang.ValueMember = "bin";
                cboNganHang.SelectedValue = listBankData.data.FirstOrDefault()?.bin;
            }

            AutoResizeDataGridView(dgvDanhSachTaiKhoan); // Resize columns to fill the view
        }
        // Hiển thị danh sách tài khoản ngân hàng
        private void LoadDanhSachTaiKhoan()
        {
            var danhSachTaiKhoan = nganHangBUS.GetAllNganHang();
            dgvDanhSachTaiKhoan.DataSource = danhSachTaiKhoan;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem bảng NganHang đã có tài khoản nào chưa
                if (nganHangBUS.KiemTraTaiKhoanDaTonTai())
                {
                    MessageBox.Show("Chỉ được phép có một tài khoản duy nhất trong hệ thống.");
                    return; // Nếu đã có tài khoản, dừng lại và không thêm tài khoản mới
                }

                // Nếu chưa có tài khoản, tiếp tục thêm tài khoản mới
                NganHangDTO nganHang = new NganHangDTO
                {
                    MaNganHang = int.Parse(cboNganHang.SelectedValue.ToString()),
                    TenNganHang = cboNganHang.Text,
                    SoTaiKhoan = txtSTK.Text,
                    TenChuThe = txtTenTaiKhoan.Text
                };

                if (nganHangBUS.AddNganHang(nganHang))
                {
                    MessageBox.Show("Thêm tài khoản thành công.");
                    LoadDanhSachTaiKhoan();
                }
                else
                {
                    MessageBox.Show("Thêm tài khoản thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachTaiKhoan.SelectedRows.Count > 0)
            {
                string soTaiKhoan = dgvDanhSachTaiKhoan.SelectedRows[0].Cells["SoTaiKhoan"].Value.ToString();
                string tenChuThe = dgvDanhSachTaiKhoan.SelectedRows[0].Cells["TenChuThe"].Value.ToString();

                if (nganHangBUS.DeleteNganHang(soTaiKhoan, tenChuThe))
                {
                    MessageBox.Show("Xóa tài khoản thành công.");
                    LoadDanhSachTaiKhoan();
                }
                else
                {
                    MessageBox.Show("Xóa tài khoản thất bại.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa.");
            }
        }
        public void AutoResizeDataGridView(DataGridView dgv)
        {
            // Set the AutoSizeColumnsMode to Fill to have columns adjust to fill the entire width
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Additionally, you can specify minimum widths or other settings for individual columns if needed
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.MinimumWidth = 50; // Set a minimum width as an example, adjust as needed
            }
        }
       
    }
}
