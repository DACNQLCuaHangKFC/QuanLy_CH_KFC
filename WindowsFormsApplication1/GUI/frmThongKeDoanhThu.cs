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
        public frmThongKeDoanhThu()
        {
            InitializeComponent();
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
            txtTongdoanhthu.Clear();
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
                txtTongdoanhthu.Text = "0";
                dgrvKettoan.DataSource = null;
            }
        }

        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            loadCboCa();
            cboCa.SelectedValue = -1;
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

        private void ExportToExcel(DataTable dt, string filePath, string companyName, double totalRevenue)
        {
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (var package = new ExcelPackage())
            {
                // Tạo một worksheet
                var worksheet = package.Workbook.Worksheets.Add("Doanh Thu");

                // Thêm thông tin công ty, người lập báo cáo và tổng doanh thu tháng
                worksheet.Cells[1, 1].Value = "Tên Công Ty:";
                worksheet.Cells[1, 2].Value = companyName;

               

                // Định dạng tiêu đề thông tin báo cáo
                using (var range = worksheet.Cells[1, 1, 3, 2])
                {
                    range.Style.Font.Bold = true;
                    range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                }

                // Đặt tiêu đề cho các cột dữ liệu
                int dataStartRow = 3; // Bắt đầu từ hàng thứ 3
                worksheet.Cells[dataStartRow, 1].Value = "Mã Doanh Thu";
                worksheet.Cells[dataStartRow, 2].Value = "Ngày Kết Toán";
                worksheet.Cells[dataStartRow, 3].Value = "Tổng Doanh Thu";

                // Định dạng tiêu đề bảng dữ liệu
                using (var range = worksheet.Cells[dataStartRow, 1, dataStartRow, 3])
                {
                    range.Style.Font.Bold = true;
                    range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);
                }

                // Thêm dữ liệu từ DataTable vào Excel
                int rowIndex = dataStartRow + 1; // Bắt đầu từ hàng ngay sau tiêu đề
                foreach (DataRow row in dt.Rows)
                {
                    worksheet.Cells[rowIndex, 1].Value = row["MaDoanhThu"];
                    worksheet.Cells[rowIndex, 2].Value = Convert.ToDateTime(row["NgayKetToan"]).ToShortDateString();
                    worksheet.Cells[rowIndex, 3].Value = Convert.ToDouble(row["TongDoanhThu"]);
                    rowIndex++;
                }
                worksheet.Cells[rowIndex + 1, 1].Value = "Tổng Doanh Thu Tháng:";
                worksheet.Cells[rowIndex + 1, 2].Value = totalRevenue.ToString("C0", new System.Globalization.CultureInfo("vi-VN"));
                // Tự động căn chỉnh kích thước cột
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

                // Kiểm tra và gán giá trị doanh thu nếu có
                if (dgrvKettoan.Rows.Count > index && dgrvKettoan.Rows[index].Cells[2].Value != DBNull.Value)
                {
                    double tongDoanhThu = 0;
                    var cellValue = dgrvKettoan.Rows[index].Cells[2].Value;

                    if (cellValue != DBNull.Value && cellValue != null)
                    {
                        tongDoanhThu = Convert.ToDouble(cellValue);
                    }

                    // Định dạng tiền Việt Nam
                    CultureInfo vietnamCulture = new CultureInfo("vi-VN");
                    txtTongdoanhthu.Text = tongDoanhThu.ToString("C0", vietnamCulture);
                }
                else
                {
                    // Nếu không có giá trị doanh thu, gán giá trị mặc định là 0
                    txtTongdoanhthu.Text = "0";
                }
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            DoanhThuBUS dthu = new DoanhThuBUS();
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm đơn vị tính này không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
            string companyName = "Công Ty ABC";
            double totalRevenue = dtThongKe.AsEnumerable().Sum(row => row.Field<double>("TongDoanhThu"));
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
                        ExportToExcel(dtThongKe, saveFileDialog.FileName,companyName,totalRevenue);
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
            string searchQuery = txtTimkiem.Text.Trim();

            if (string.IsNullOrEmpty(searchQuery))
            {
                loadDoanhThu();
            }
            else
            {
                DoanhThuBUS dt = new DoanhThuBUS();
                dt.TimDoanhThuTheoNgay(searchQuery);
                dgrvDoanhthu.DataSource = dt;
            }
        }
    }
}
