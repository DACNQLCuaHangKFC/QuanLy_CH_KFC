using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using WindowsFormsApplication1.BUS;
using System.Globalization;
using WindowsFormsApplication1.DAL;
using System.Windows.Media;


namespace WindowsFormsApplication1.GUI
{
    public partial class frmThongKeTonKho : Form
    {
        private TonKhoBUS tonKhoBUS;
        private string tenNhanVien;
        public frmThongKeTonKho(string tenNhanVien)
        {
            InitializeComponent();
            tonKhoBUS = new TonKhoBUS();
            this.tenNhanVien = tenNhanVien;
            AutoResizeDataGridView(dgvTonKho);
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
        void loadCboTrangThai()
        {
            //cboTrangThai.Items.Add("Tất cả");
            cboTrangThai.Items.Add("Còn Hàng");
            cboTrangThai.Items.Add("Cần Nhập");
            cboTrangThai.SelectedIndex = 0;
        }

        private void frmThongKeTonKho_Load(object sender, EventArgs e)
        {
            loadCboTrangThai();
        }

        private void cboTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cboTrangThai.SelectedItem.ToString();
            TonKhoBUS tonKhoBUS = new TonKhoBUS();
            DataTable dt = tonKhoBUS.LayThongKeTonKho("DD001", trangThai);
            dgvTonKho.DataSource = dt;
        }

        private void ExportToExcel(DataTable dt, string filePath, string companyName, int totalQuantity, string employeeName)
        {
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (var package = new ExcelPackage())
            {
                // Tạo worksheet
                var worksheet = package.Workbook.Worksheets.Add("Thong Ke Ton Kho");

                // Thiết lập thông tin công ty và tiêu đề
                worksheet.Cells[1, 1].Value = companyName;
                worksheet.Cells[2, 1].Value = "Thống Kê Tồn Kho";
                worksheet.Cells[3, 1].Value = $"Ngày xuất: {DateTime.Now:dd/MM/yyyy}";

                // Thêm tên nhân viên
                worksheet.Cells[4, 1].Value = $"Người xuất phiếu: {employeeName}";  // In tên nhân viên

                // Đặt tiêu đề cột
                worksheet.Cells[5, 1].Value = "Mã Nguyên Liệu";
                worksheet.Cells[5, 2].Value = "Tên Nguyên Liệu";
                worksheet.Cells[5, 3].Value = "Số Lượng Tồn";
                worksheet.Cells[5, 4].Value = "Trạng Thái";

                // Đổ dữ liệu vào Excel
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    worksheet.Cells[i + 6, 1].Value = dt.Rows[i]["MaNguyenLieu"];
                    worksheet.Cells[i + 6, 2].Value = dt.Rows[i]["TenNguyenLieu"];
                    worksheet.Cells[i + 6, 3].Value = dt.Rows[i]["SoLuongTon"];
                    worksheet.Cells[i + 6, 4].Value = dt.Rows[i]["TrangThai"];
                }

                // Thêm tổng số lượng tồn kho
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                // Định dạng tiêu đề
                using (var range = worksheet.Cells[5, 1, 5, 4])
                {
                    range.Style.Font.Bold = true;
                    range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);
                }

                // Lưu file
                FileInfo fi = new FileInfo(filePath);
                package.SaveAs(fi);
            }
        }


        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string selectedTrangThai = cboTrangThai.SelectedItem?.ToString() ?? "Tất cả";
            string trangThai = selectedTrangThai == "Tất cả" ? null : selectedTrangThai;

            TonKhoBUS tonKhoBUS = new TonKhoBUS();
            DataTable dtThongKe = tonKhoBUS.LayThongKeTonKho("DD001", trangThai);

            string employeeName = tenNhanVien.Replace("Xin chào: ", "").Trim();

            if (dtThongKe.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu tồn kho theo trạng thái được chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Tổng số lượng tồn
            string companyName = "CÔNG TY LIÊN DOANH TNHH KFC VIỆT NAM";
            int totalQuantity = dtThongKe.AsEnumerable()
                                        .Where(row => !row.IsNull("SoLuongTon")) // Loại bỏ các dòng có giá trị null
                                        .Sum(row => Convert.ToInt32(row["SoLuongTon"]));

            // Chọn nơi lưu file Excel
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel File (*.xlsx)|*.xlsx",
                Title = "Lưu File Excel",
                FileName = $"ThongKeTonKho_{DateTime.Now:yyyyMMdd}.xlsx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportToExcel(dtThongKe, saveFileDialog.FileName, companyName, totalQuantity, employeeName);
                    MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi xuất file Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
