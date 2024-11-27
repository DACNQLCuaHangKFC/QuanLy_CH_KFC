using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApplication1.BUS;
using WindowsFormsApplication1.DTO;

namespace WindowsFormsApplication1.GUI
{
    public partial class frmKhachHang : Form
    {
        private KhachHangBUS khachHangBUS = new KhachHangBUS();

        public frmKhachHang()
        {
            InitializeComponent();
            LoadDanhSachKhachHang();
            AutoResizeDataGridView(dgvDanhSachKhachHang);
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
        // Hàm tải dữ liệu lên DataGridView
        private void LoadDanhSachKhachHang()
        {
            try
            {
                List<KhachHangDTO> danhSach = khachHangBUS.GetAllKhachHang();
                dgvDanhSachKhachHang.DataSource = danhSach;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách khách hàng: " + ex.Message);
            }
        }

        // Hàm xóa trắng các ô nhập liệu
        private void ClearInputFields()
        {
            txtSDT.Text = "";
            txtTenKhachHang.Text = "";
            txtEmail.Text = "";
            txtDiemTichLuy.Text = "";
            dtpkDOB.Value = DateTime.Now;
        }

        // Xử lý sự kiện Thêm khách hàng
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!IsInputValid()) return; // Kiểm tra dữ liệu hợp lệ

            try
            {
                // Lấy số điện thoại từ input
                string soDienThoai = txtSDT.Text;

                // Kiểm tra xem số điện thoại đã tồn tại chưa
                if (khachHangBUS.IsSoDienThoaiTonTai(soDienThoai))
                {
                    MessageBox.Show("Số điện thoại này đã tồn tại trong hệ thống. Vui lòng kiểm tra lại!");
                    return;
                }

                // Tạo đối tượng KhachHangDTO từ input
                KhachHangDTO kh = new KhachHangDTO
                {
                    SoDienThoai = soDienThoai,
                    TenKhachHang = txtTenKhachHang.Text,
                    Email = txtEmail.Text,
                    NgaySinh = dtpkDOB.Value,
                    DiemTichLuy = 0
                };

                // Thêm khách hàng
                if (khachHangBUS.AddKhachHang(kh))
                {
                    MessageBox.Show("Thêm khách hàng thành công!");
                    LoadDanhSachKhachHang(); // Refresh danh sách khách hàng
                    ClearInputFields();     // Xóa dữ liệu input
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        // Xử lý sự kiện Cập nhật khách hàng
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachKhachHang.SelectedRows.Count > 0) // Kiểm tra có dòng nào được chọn hay không
            {
                // Lấy dòng được chọn từ DataGridView
                DataGridViewRow selectedRow = dgvDanhSachKhachHang.SelectedRows[0];

                if (!IsInputValid()) return; // Kiểm tra dữ liệu nhập

                try
                {
                    // Tạo đối tượng KhachHangDTO từ input
                    KhachHangDTO kh = new KhachHangDTO
                    {
                        TenKhachHang = txtTenKhachHang.Text,
                        Email = txtEmail.Text,
                        NgaySinh = dtpkDOB.Value,
                        DiemTichLuy = int.Parse(txtDiemTichLuy.Text),
                        SoDienThoai = selectedRow.Cells["SoDienThoai"].Value.ToString() // Lấy số điện thoại từ dòng được chọn
                    };

                    // Gọi hàm cập nhật từ lớp BUS
                    if (khachHangBUS.UpdateKhachHang(kh))
                    {
                        MessageBox.Show("Cập nhật khách hàng thành công!");
                        LoadDanhSachKhachHang(); // Refresh danh sách khách hàng
                        ClearInputFields();     // Xóa dữ liệu nhập
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật khách hàng thất bại!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng trong danh sách!");
            }
        }



        // Xử lý sự kiện tìm kiếm khách hàng
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtTimKiem.Text.ToLower();
                List<KhachHangDTO> danhSach = khachHangBUS.GetAllKhachHang();
                List<KhachHangDTO> ketQuaTimKiem = danhSach.FindAll(kh =>
                    kh.SoDienThoai.Contains(keyword) ||
                    kh.TenKhachHang.ToLower().Contains(keyword) ||
                    kh.Email.ToLower().Contains(keyword));

                dgvDanhSachKhachHang.DataSource = ketQuaTimKiem;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }

        // Sự kiện chọn dòng trong DataGridView
        private void dgvDanhSachKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDanhSachKhachHang.Rows[e.RowIndex];
                txtSDT.Text = row.Cells["SoDienThoai"].Value.ToString();
                txtTenKhachHang.Text = row.Cells["TenKhachHang"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString().Trim();
                dtpkDOB.Value = DateTime.Parse(row.Cells["NgaySinh"].Value.ToString());
                txtDiemTichLuy.Text = row.Cells["DiemTichLuy"].Value.ToString();
            }
        }
        // Kiểm tra số điện thoại hợp lệ (chỉ cho phép số và độ dài từ 10-15 ký tự)
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Loại bỏ khoảng trắng và định dạng khác
            phoneNumber = phoneNumber.Trim();

            // Biểu thức chính quy kiểm tra số điện thoại hợp lệ ở Việt Nam
            string pattern = @"^(0|\+84)(3[2-9]|5[6|8|9]|7[0|6-9]|8[1-5|8|9]|9[0-9])\d{7}$";
            return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, pattern);
        }

        // Kiểm tra email hợp lệ
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // Kiểm tra tất cả trường có được nhập đầy đủ
        private bool IsInputValid()
        {
            if (string.IsNullOrWhiteSpace(txtSDT.Text) || !IsValidPhoneNumber(txtSDT.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ! Vui lòng nhập số có từ 10-15 chữ số.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTenKhachHang.Text))
            {
                MessageBox.Show("Tên khách hàng không được để trống!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email không hợp lệ! Vui lòng nhập đúng định dạng email.");
                return false;
            }

            if (!int.TryParse(txtDiemTichLuy.Text, out int diemTichLuy) || diemTichLuy < 0)
            {
                MessageBox.Show("Điểm tích lũy phải là số nguyên không âm!");
                return false;
            }

            return true;
        }

    }
}
