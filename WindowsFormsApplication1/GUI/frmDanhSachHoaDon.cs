using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.BUS;
using WindowsFormsApplication1.DTO;

namespace WindowsFormsApplication1.GUI
{
    public partial class frmDanhSachHoaDon : Form
    {
        HoaDonBUS hoaDonBUS = new HoaDonBUS();
        public frmDanhSachHoaDon()
        {
            InitializeComponent();
            dtpTuNgay.Value = DateTime.Now.Date.AddDays(-1);
            dtpDenNgay.Value = DateTime.Now.Date.AddDays(1);
            
            LoadFilteredData();

            AutoResizeDataGridView(dgvDanhSachHoaDon);
            AutoResizeDataGridView(dgvChiTietHoaDon);
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
        private DataSet LoadInvoiceReport(string maHoaDon)
        {
            // Lấy dữ liệu hóa đơn từ bussiness layer
            CombinedInvoiceDTO dulieu = hoaDonBUS.GetInvoiceDetailsByInvoiceID(maHoaDon);

            // Tạo DataTable cho chi tiết hóa đơn
            DataTable invoiceDetails = new DataTable();
            // Tạo DataTable cho thông tin hóa đơn
            DataTable invoiceInfo = new DataTable();

            if (dulieu != null && dulieu.InvoiceDetails != null && dulieu.Items.Count > 0)
            {
                // Cấu trúc cột cho chi tiết hóa đơn
                invoiceDetails.Columns.Add("ProductName", typeof(string));
                invoiceDetails.Columns.Add("Quantity", typeof(int));
                invoiceDetails.Columns.Add("Price", typeof(decimal));
                invoiceDetails.Columns.Add("SubTotal", typeof(decimal));

                // Cấu trúc cột cho thông tin hóa đơn
                invoiceInfo.Columns.Add("EmployeeName", typeof(string));
                invoiceInfo.Columns.Add("PaymentMethod", typeof(string));
                invoiceInfo.Columns.Add("InvoiceID", typeof(string));
                invoiceInfo.Columns.Add("Total", typeof(decimal));
                invoiceInfo.Columns.Add("Tax", typeof(decimal));
                invoiceInfo.Columns.Add("Discount", typeof(decimal));
                invoiceInfo.Columns.Add("FinalAmount", typeof(decimal));
                invoiceInfo.Columns.Add("ReceivedPoints", typeof(int)); 
                invoiceInfo.Columns.Add("Date", typeof(string));
                invoiceInfo.Columns.Add("QRCode", typeof(byte[]));

                // Thêm dữ liệu vào bảng chi tiết hóa đơn
                foreach (var item in dulieu.Items)
                {
                    invoiceDetails.Rows.Add(item.ItemName, item.Quantity, item.UnitPrice, item.TotalPrice);
                }

                // Tính số điểm nhận được từ FinalAmount
                int receivedPoints = (int)(dulieu.InvoiceDetails.FinalAmount / 1000); // Chia FinalAmount cho 1000 và ép về kiểu int
                decimal discount = (decimal)(dulieu.InvoiceDetails.FinalAmount* dulieu.InvoiceDetails.Discount/100);
                // Thêm dữ liệu vào bảng thông tin hóa đơn
                invoiceInfo.Rows.Add(
                    dulieu.InvoiceDetails.EmployeeName,
                    dulieu.InvoiceDetails.PaymentMethod,
                    dulieu.InvoiceDetails.InvoiceID,
                    dulieu.InvoiceDetails.Total,
                    dulieu.InvoiceDetails.Tax,
                    discount,
                    dulieu.InvoiceDetails.FinalAmount % 1 == 0  // Kiểm tra xem FinalAmount có phần thập phân không
                        ? ((int)dulieu.InvoiceDetails.FinalAmount).ToString()  // Nếu không có phần thập phân, chỉ lấy phần nguyên
                        : dulieu.InvoiceDetails.FinalAmount.ToString("0.##"), // Nếu có, định dạng số với 2 chữ số thập phân
                    receivedPoints, // Thêm điểm nhận được
                    dulieu.InvoiceDetails.Date
                );

                // Tạo DataSet và thêm các bảng
                DataSet invoiceDataSet = new DataSet();
                invoiceDataSet.Tables.Add(invoiceDetails);   // Thêm chi tiết hóa đơn
                invoiceDataSet.Tables.Add(invoiceInfo);      // Thêm thông tin hóa đơn

                return invoiceDataSet;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu hóa đơn");
                return null;
            }
        }
        private void btnLoc_Click(object sender, EventArgs e)
        {
            LoadFilteredData();
        }
        private void LoadFilteredData()
        {
            string status = "";
            if (radTatCa.Checked==true)
            {
                status = radTatCa.Text;
            }
            else if (radDaThucHien.Checked == true)
            {
                status = radDaThucHien.Text;
            }    
            else
            {
                status = radChoThucHien.Text;
            }
            DateTime tungay, denngay;
            tungay = dtpTuNgay.Value;
            denngay = dtpDenNgay.Value;

            DataTable dt = hoaDonBUS.GetHoaDonByStatus(status,tungay,denngay);
            dgvDanhSachHoaDon.DataSource = dt;

            dgvDanhSachHoaDon.Columns["MaHoaDon"].HeaderText = "Mã Hóa Đơn";
            dgvDanhSachHoaDon.Columns["NgayThanhToan"].HeaderText = "Ngày Thanh Toán";
            dgvDanhSachHoaDon.Columns["TongTien"].HeaderText = "Tổng tiền";
            dgvDanhSachHoaDon.Columns["TrangThai"].HeaderText = "Trạng Thái";
            dgvDanhSachHoaDon.Columns["TongTien"].DefaultCellStyle.Format = "N0";
        }
        private void LoadChiTietHoaDon(string maHoaDon)
        {
            DataTable dtChiTietHD = hoaDonBUS.GetChiTietHoaDon(maHoaDon);
            dgvChiTietHoaDon.DataSource = dtChiTietHD;

            dgvChiTietHoaDon.Columns["MaHoaDon"].HeaderText = "Mã Hóa Đơn";
            dgvChiTietHoaDon.Columns["TenMonAn"].HeaderText = "Tên Món Ăn";
            dgvChiTietHoaDon.Columns["Gia"].HeaderText = "Giá";
            dgvChiTietHoaDon.Columns["SoLuong"].HeaderText = "Số Lượng";
            dgvChiTietHoaDon.Columns["TrangThai"].HeaderText = "Trạng Thái";
        }
        private void dgvDanhSachHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDanhSachHoaDon.CurrentRow != null)
            {
                string maHoaDon = dgvDanhSachHoaDon.CurrentRow.Cells["MaHoaDon"].Value.ToString();
                LoadChiTietHoaDon(maHoaDon);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachHoaDon.CurrentRow != null)
            {
                // Lấy giá trị tổng tiền từ cột "TongTien"
                var tongTien = dgvDanhSachHoaDon.CurrentRow.Cells["TongTien"].Value;

                // Kiểm tra nếu tổng tiền là null hoặc bằng 0
                if (tongTien == DBNull.Value || Convert.ToDecimal(tongTien) == 0)
                {
                    MessageBox.Show("Tổng tiền không hợp lệ hoặc là 0. Không thể in hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng lại và không tiếp tục in hóa đơn
                }

                string maHoaDon = dgvDanhSachHoaDon.CurrentRow.Cells["MaHoaDon"].Value.ToString();
                DataSet dulieu = LoadInvoiceReport(maHoaDon);
                frmHoaDon frm = new frmHoaDon(dulieu);
                frm.ShowDialog();
            }
        }

    }
}
