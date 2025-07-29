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
    public partial class frmThongKeDoanhThu : Form
    {
        public static string maDoanhThu;
        private string tenNhanVien;
        public frmThongKeDoanhThu(string tenNhanVien)
        {
            InitializeComponent();
            this.tenNhanVien = tenNhanVien;
            AutoResizeDataGridView(dgrvDoanhthu);
            AutoResizeDataGridView(dgrvKettoan);
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
        void loadDoanhThu()
        {
            DataTable dtDoanhThu = DoanhThuDAL.hienThiDoanhThu();

            // Kiểm tra xem dữ liệu có hợp lệ không
            if (dtDoanhThu != null)
            {
                // Gán dữ liệu vào DataGridView dgrvDoanhThu
                dgrvDoanhthu.DataSource = dtDoanhThu;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu doanh thu.");
            }
        }

        void xoaNoiDung()
        {
            txtMadoanhthu.Clear();
            dtpNgaydt.Value = DateTime.Now;
        }

        void xoaNoiDungChiTiet()
        {
            cboCa.SelectedValue = -1;
            txtDoanhthu.Text = "0";
        }
        void loadChiTietDoanhThu()
        {
            dgrvKettoan.DataSource = ChiTietDoanhThuBUS.hienThiChiTietDoanhThu();
            dgrvKettoan.AllowUserToAddRows = false;
        }

        void loadCboCa()
        {
            CaLamBUS caLamBUS = new CaLamBUS();
            DataTable dt = caLamBUS.LayDanhSachCaLam();
            if (dt != null)
            {
                cboCa.DataSource = dt;
                cboCa.DisplayMember = "MaCaLam";  // Hiển thị MaCaLam
                cboCa.ValueMember = "MaCaLam";    // Giá trị sẽ lấy MaCaLam
            }
            cboCa.SelectedIndex = 0;
        }

        void loadChiTietDoanhThu(string maDoanhThu)
        {
            DoanhThuBUS doanhThuBUS = new DoanhThuBUS();
            DataTable dt = doanhThuBUS.LayChiTietDoanhThuTheoMaDoanhThu(maDoanhThu);
            if (dt != null && dt.Rows.Count > 0)
            {
                dgrvKettoan.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không có chi tiết doanh thu nào được tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgrvKettoan.DataSource = null;
            }
        }

        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            loadCboCa();
            loadDoanhThu();
            FormatDataGridView();
            dtpNgaykt.Enabled = false;
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            BUS.ChiTietDoanhThuBUS dt = new BUS.ChiTietDoanhThuBUS();
            CultureInfo vietnamCulture = new CultureInfo("vi-VN");
            if (cboCa.SelectedItem != null)
            {
                string maCaLam = cboCa.SelectedValue.ToString();
                DateTime ngay = dtpNgaykt.Value;

                double doanhThu = dt.LayDoanhThuTheoCa(maCaLam, ngay);
                txtDoanhthu.Text = doanhThu.ToString("C0", vietnamCulture);
                string maDt = txtMadoanhthu.Text.Trim();
                string maCa = cboCa.SelectedValue.ToString();
                bool kq = dt.ThemChiTietDoanhThu(maDt, maCa, doanhThu);
                if (kq)
                {
                    loadChiTietDoanhThu(maDt);
                    loadDoanhThu();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ca làm!");
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            //using (SaveFileDialog sfd = new SaveFileDialog())
            //{
            //    sfd.Filter = "Excel Files|*.xlsx";
            //    sfd.Title = "Lưu báo cáo doanh thu";
            //    if (sfd.ShowDialog() == DialogResult.OK)
            //    {
            //        ExportToExcel((DataTable)dgrvDoanhthu.DataSource, sfd.FileName);
            //    }
            //}
        }

        private void ExportToExcel(DataTable dt, string filePath, string companyName, double totalRevenue, string employeeName)
        {
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (var package = new ExcelPackage())
            {
                // Tạo worksheet
                var worksheet = package.Workbook.Worksheets.Add("Doanh Thu");

                // Thêm thông tin công ty, ngày xuất, người lập báo cáo
                worksheet.Cells[1, 1].Value = "Tên Công Ty:";
                worksheet.Cells[1, 2].Value = companyName;
                worksheet.Cells[2, 1].Value = $"Ngày xuất:";
                worksheet.Cells[2, 2].Value = DateTime.Now.ToString("dd/MM/yyyy");
                worksheet.Cells[3, 1].Value = $"Người xuất phiếu:";
                worksheet.Cells[3, 2].Value = employeeName;

                // Định dạng thông tin công ty và tiêu đề
                using (var range = worksheet.Cells[1, 1, 3, 2])
                {
                    range.Style.Font.Bold = true;
                    range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                }

                // Đặt tiêu đề cho bảng dữ liệu
                int dataStartRow = 5; // Dòng đầu tiên của bảng dữ liệu
                worksheet.Cells[dataStartRow, 1].Value = "Mã Doanh Thu";
                worksheet.Cells[dataStartRow, 2].Value = "Ngày Kết Toán";
                worksheet.Cells[dataStartRow, 3].Value = "Tổng Doanh Thu (VND)";

                // Định dạng tiêu đề bảng
                using (var headerRange = worksheet.Cells[dataStartRow, 1, dataStartRow, 3])
                {
                    headerRange.Style.Font.Bold = true;
                    headerRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    headerRange.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    headerRange.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    headerRange.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);
                }

                // Thêm dữ liệu từ DataTable
                int currentRow = dataStartRow + 1; // Hàng bắt đầu ghi dữ liệu
                foreach (DataRow row in dt.Rows)
                {
                    worksheet.Cells[currentRow, 1].Value = row["MaDoanhThu"];
                    worksheet.Cells[currentRow, 2].Value = Convert.ToDateTime(row["NgayKetToan"]).ToString("dd/MM/yyyy");
                    worksheet.Cells[currentRow, 3].Value = Convert.ToDouble(row["TongDoanhThu"]).ToString("C0", new System.Globalization.CultureInfo("vi-VN"));
                    currentRow++;
                }

                // Thêm tổng doanh thu
                worksheet.Cells[currentRow, 2].Value = "Tổng Doanh Thu Tháng:";
                worksheet.Cells[currentRow, 3].Value = totalRevenue.ToString("C0", new System.Globalization.CultureInfo("vi-VN"));

                // Định dạng tổng doanh thu
                using (var totalRange = worksheet.Cells[currentRow, 2, currentRow, 3])
                {
                    totalRange.Style.Font.Bold = true;
                    totalRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                }

                // Định dạng toàn bộ bảng dữ liệu
                using (var dataRange = worksheet.Cells[dataStartRow, 1, currentRow, 3])
                {
                    dataRange.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                    dataRange.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                    dataRange.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                    dataRange.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                }

                // Tự động điều chỉnh độ rộng cột
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                // Lưu file
                FileInfo fi = new FileInfo(filePath);
                package.SaveAs(fi);
            }
        }

        private void dgrvDoanhthu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int index = dgrvDoanhthu.CurrentRow.Index;
                string maDoanhThu = dgrvDoanhthu.Rows[index].Cells[0].Value.ToString();
                loadChiTietDoanhThu(maDoanhThu);
                txtMadoanhthu.Text = maDoanhThu;

                // Kiểm tra và gán giá trị ngày nếu hợp lệ
                if (DateTime.TryParse(dgrvDoanhthu.Rows[index].Cells[1].Value.ToString(), out DateTime ngayKetToan))
                {
                    dtpNgaydt.Value = ngayKetToan;
                }
                else
                {
                    MessageBox.Show("Ngày không hợp lệ.");
                }

               
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            DoanhThuBUS dthu = new DoanhThuBUS();
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm thống kê doanh thu này không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                DateTime selectedDate = dtpNgaydt.Value;
                string maDoanhThu = "DT" + selectedDate.ToString("ddMMyy");
                txtMadoanhthu.Text = maDoanhThu;
                if (dthu.KiemTraMaDoanhThuTonTai(maDoanhThu))
                {
                    MessageBox.Show("Mỗi ngày chỉ được tạo duy nhất 1 doanh thu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMadoanhthu.Clear();
                }  
                else
                {
                    DateTime ngayTao = dtpNgaydt.Value;
                    bool kq = dthu.ThemDoanhThu(maDoanhThu, ngayTao);
                    if (kq)
                    {
                        MessageBox.Show("Thêm doanh thu mới thành công.");
                        loadDoanhThu();
                        xoaNoiDung();
                    }
                    else
                    {
                        MessageBox.Show("Thêm doanh thu mới thất bại.");
                    }
                }    
            }
        }
        private void FormatDataGridView()
        {
            dgrvKettoan.Columns[2].DefaultCellStyle.Format = "C0";  
            dgrvKettoan.Columns[2].DefaultCellStyle.FormatProvider = new CultureInfo("vi-VN");
            dgrvDoanhthu.Columns[2].DefaultCellStyle.Format = "C0";
            dgrvDoanhthu.Columns[2].DefaultCellStyle.FormatProvider = new CultureInfo("vi-VN");
        }

        private void dgrvKettoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgrvKettoan.CurrentRow.Index;
            cboCa.SelectedValue = dgrvKettoan.Rows[index].Cells[1].Value.ToString();
            if (txtDoanhthu.Text != string.Empty)
            {
                double doanhThu = Convert.ToDouble(dgrvKettoan.Rows[index].Cells[2].Value);
                CultureInfo vietnamCulture = new CultureInfo("vi-VN");
                txtDoanhthu.Text = doanhThu.ToString("C0", vietnamCulture);
            }
            else
            {
                txtDoanhthu.Text = "0";
            }    
        }

        private void txtDoanhthu_TextChanged(object sender, EventArgs e)
        {
            //if (double.TryParse(txtDoanhthu.Text, out double doanhThu))
            //{
            //    // Định dạng lại số tiền theo tiền tệ Việt Nam (không có phần thập phân)
            //    txtDoanhthu.Text = string.Format("{0:C0}", doanhThu);
            //    // Đặt con trỏ chuột về cuối sau khi định dạng lại nội dung
            //    txtDoanhthu.SelectionStart = txtDoanhthu.Text.Length;
            //}
            //else
            //{
            //    // Nếu giá trị không hợp lệ, xóa nội dung trong TextBox hoặc hiển thị thông báo lỗi
            //    txtDoanhthu.Clear();
            //}
        }

        private void dtpNgaydt_ValueChanged(object sender, EventArgs e)
        {
            dtpNgaykt.Value = dtpNgaydt.Value;
        }

        private void btnXoakettoan_Click(object sender, EventArgs e)
        {
            if (cboCa.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn 1 chi tiết doanh thu ở bảng dưới để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BUS.ChiTietDoanhThuBUS dt = new BUS.ChiTietDoanhThuBUS();
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa chi tiết doanh thu này không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string maDoanhThu = txtMadoanhthu.Text;
                    string maCa = cboCa.SelectedValue.ToString();
                    bool kq = dt.XoaChiTietDoanhThu(maDoanhThu, maCa);
                    if (kq)
                    {
                        MessageBox.Show("Xóa chi tiết doanh thu thành công");
                        loadChiTietDoanhThu(maDoanhThu);
                        loadDoanhThu();
                        xoaNoiDungChiTiet();
                    }
                    else
                    {
                        MessageBox.Show("Xóa chi tiết doanh thu thất bại");
                    }
                }
            }
        }

        private void btnThongke_Click_1(object sender, EventArgs e)
        {
            // Lấy tháng và năm từ DateTimePicker
            DateTime selectedDate = dtpNgaydt.Value;
            int month = selectedDate.Month;
            int year = selectedDate.Year;
            

            // Gọi DAL để lấy dữ liệu
            DoanhThuBUS dt = new DoanhThuBUS();
            DataTable dtThongKe = dt.LayDoanhThuTheoThang(month, year);
            string companyName = "CÔNG TY LIÊN DOANH TNHH KFC VIỆT NAM";
            double totalRevenue = dtThongKe.AsEnumerable().Sum(row => row.Field<double>("TongDoanhThu"));
            string employeeName = tenNhanVien.Replace("Xin chào: ", "").Trim();
            if (dtThongKe.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu doanh thu trong tháng được chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Chọn nơi lưu file Excel
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel File (*.xlsx)|*.xlsx",
                    Title = "Lưu File Excel",
                    FileName = $"DoanhThu_Thang{month}_Nam{year}.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ExportToExcel(dtThongKe, saveFileDialog.FileName,companyName,totalRevenue,employeeName);
                        MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi xuất file Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            //string searchQuery = txtTimkiem.Text.Trim();

            //if (string.IsNullOrEmpty(searchQuery))
            //{
            //    loadDoanhThu();
            //}
            //else
            //{
            //    DoanhThuBUS dt = new DoanhThuBUS();
            //    dt.TimDoanhThuTheoNgay(searchQuery);
            //    dgrvDoanhthu.DataSource = dt;
            //}
        }
    }
}
