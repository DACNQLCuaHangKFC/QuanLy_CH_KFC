using WindowsFormsApplication1.BUS;
using WindowsFormsApplication1.DTO;
using Newtonsoft.Json;
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
    public partial class frmTaoNhaCungCap : Form
    {

        private BUS_NhaCungCap bus = new BUS_NhaCungCap();
        private BUS_LoaiNguyenLieu BUS_Loai = new BUS_LoaiNguyenLieu();
        public frmTaoNhaCungCap()
        {
            InitializeComponent();
            //LoadDgvNhaCungCap();
            dgvNhaCungCap.CellClick += dgvNhaCungCap_CellClick;
            LoadLoaiNguyenLieuComboBox();
            LoadLoaiNguyenLieudsComboBox();
            InitializeComboBox();
            dgvCungUng.CellClick += dgvCungUng_CellClick;
            using (WebClient client = new WebClient())
            {
                var htmlData = client.DownloadData("https://api.vietqr.io/v2/banks");
                var bankRawJson = Encoding.UTF8.GetString(htmlData);
                var listBankData = JsonConvert.DeserializeObject<Bank>(bankRawJson);

                cb_NganHang.DataSource = listBankData.data;   // list banks
                cb_NganHang.DisplayMember = "short_name";
                cb_NganHang.ValueMember = "bin";
                cb_NganHang.SelectedValue = listBankData.data.FirstOrDefault()?.bin;
                cb_NganHang.SelectedIndex = 0;
                
            }
        }
        private void frmTaoNhaCungCap_Load(object sender, EventArgs e)
        {

            // Default: Load all suppliers when form is loaded
            LoadNhaCungCapData("Tất cả");
            LoadDataNguyenLieu();
        }
        private void LoadDgvNhaCungCap()
        {
            List<NhaCungCapDTO> nhaCungCaps = bus.HienThiDanhSachNhaCungCap();

            dgvNhaCungCap.DataSource = nhaCungCaps;

            // Thiết lập tiêu đề cột
            dgvNhaCungCap.Columns["MaNCC"].HeaderText = "Mã NCC";
            dgvNhaCungCap.Columns["TenNCC"].HeaderText = "Tên Nhà Cung Cấp";
            dgvNhaCungCap.Columns["SDT"].HeaderText = "Số Điện Thoại";
            dgvNhaCungCap.Columns["Email"].HeaderText = "Email";
            dgvNhaCungCap.Columns["TenNganHang"].HeaderText = "Tên Ngân Hàng";
            dgvNhaCungCap.Columns["SoTaiKhoan"].HeaderText = "Số Tài Khoản";

            // Điều chỉnh độ rộng cột nếu cần
            dgvNhaCungCap.Columns["MaNCC"].Width = 100;
            dgvNhaCungCap.Columns["TenNCC"].Width = 200;
        }
        private bool isCreatingNewMaNCC = false;
        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (isCreatingNewMaNCC)
            {
                // Hiển thị thông báo xác nhận
                DialogResult result = MessageBox.Show("Bạn muốn dừng hoạt động không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Nếu người dùng chọn Yes, thực hiện các hành động tạo mã mới
                if (result == DialogResult.Yes)
                {
                    if (e.RowIndex >= 0)
                    {
                        string maNCC = dgvNhaCungCap.Rows[e.RowIndex].Cells["MaNCC"].Value.ToString();

                        // Lấy dữ liệu cung ứng từ BUS
                        List<CungUngDTO> cungUngList = bus.GetCungUngByMaNCC(maNCC);
                        // Lấy dòng hiện tại
                        DataGridViewRow row = dgvNhaCungCap.Rows[e.RowIndex];
                        dgvCungUng.DataSource = cungUngList;
                        dgvCungUng.Columns["MaNCC"].HeaderText = "Mã NCC";
                        dgvCungUng.Columns["MaNguyenLieu"].HeaderText = "Mã Nguyên Liệu";
                        dgvCungUng.Columns["TenNguyenLieu"].HeaderText = "Tên Nguyên Liệu";
                        dgvCungUng.Columns["TenDVT"].HeaderText = "Tên DVT";
                        dgvCungUng.Columns["DonGia"].HeaderText = "Đơn Giá";
                        dgvCungUng.Columns["TrangThai"].HeaderText = "Trạng Thái";
                        // Fill dữ liệu vào các TextBox
                        txtMaNCC.Text = row.Cells["MaNCC"].Value.ToString();
                        txtTenNCC.Text = row.Cells["TenNCC"].Value.ToString();
                        txtSDT.Text = row.Cells["SDT"].Value.ToString();
                        txtEmail.Text = row.Cells["Email"].Value.ToString();
                        cb_NganHang.Text = row.Cells["TenNganHang"].Value.ToString();
                        txtSTK.Text = row.Cells["SoTaiKhoan"].Value.ToString();
                        txtDonGia.Clear();
                        isCreatingNewMaNCC = false;
                    }
                }
                else
                {
                    // Nếu người dùng chọn No, hủy bỏ thao tác
                    isCreatingNewMaNCC = true; // Tắt flag
                }
            }
            else
            {
                // Các hành động xử lý bình thường khi không tạo mã mới
                // Ví dụ: mở chi tiết nhà cung cấp đã chọn
                if (e.RowIndex >= 0)
                {

                    string maNCC = dgvNhaCungCap.Rows[e.RowIndex].Cells["MaNCC"].Value.ToString();

                    // Lấy dữ liệu cung ứng từ BUS
                    List<CungUngDTO> cungUngList = bus.GetCungUngByMaNCC(maNCC);
                    // Lấy dòng hiện tại
                    DataGridViewRow row = dgvNhaCungCap.Rows[e.RowIndex];
                    dgvCungUng.DataSource = cungUngList;
                    dgvCungUng.DataSource = cungUngList;
                    dgvCungUng.Columns["MaNCC"].HeaderText = "Mã NCC";
                    dgvCungUng.Columns["MaNguyenLieu"].HeaderText = "Mã Nguyên Liệu";
                    dgvCungUng.Columns["TenNguyenLieu"].HeaderText = "Tên Nguyên Liệu";
                    dgvCungUng.Columns["TenDVT"].HeaderText = "Tên DVT";
                    dgvCungUng.Columns["DonGia"].HeaderText = "Đơn Giá";
                    dgvCungUng.Columns["TrangThai"].HeaderText = "Trạng Thái";
                    // Fill dữ liệu vào các TextBox
                    txtMaNCC.Text = row.Cells["MaNCC"].Value.ToString();
                    txtTenNCC.Text = row.Cells["TenNCC"].Value.ToString();
                    txtSDT.Text = row.Cells["SDT"].Value.ToString();
                    txtEmail.Text = row.Cells["Email"].Value.ToString();
                    cb_NganHang.Text = row.Cells["TenNganHang"].Value.ToString();
                    txtSTK.Text = row.Cells["SoTaiKhoan"].Value.ToString();
                    txtDonGia.Clear();
                }
            }

        }
        private void LoadLoaiNguyenLieuComboBox()
        {
            List<LoaiNguyenLieuDTO> loaiNguyenLieus = BUS_Loai.GetAllLoaiNguyenLieu();
            loaiNguyenLieus.Insert(0, new LoaiNguyenLieuDTO { MaLoaiNguyenLieu = "Tất cả", TenLoaiNguyenLieu = "Tất cả" });

            cmbTenLoai.DataSource = loaiNguyenLieus;
            cmbTenLoai.DisplayMember = "TenLoaiNguyenLieu";
            cmbTenLoai.ValueMember = "MaLoaiNguyenLieu";
        }

        private void LoadNhaCungCapData(string maLoaiNguyenLieu)
        {
            List<NhaCungCapDTO> nhaCungCaps = bus.LayNhaCungCapTheoLoaiNguyenLieu(maLoaiNguyenLieu);
            dgvNhaCungCap.DataSource = nhaCungCaps;
        }
        private void cmbTenLoai_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string maLoaiNguyenLieu = cmbTenLoai.SelectedValue.ToString();
            LoadNhaCungCapData(maLoaiNguyenLieu);
        }
        private void LoadLoaiNguyenLieudsComboBox()
        {
            List<LoaiNguyenLieuDTO> loaiNguyenLieus = BUS_Loai.GetAllLoaiNguyenLieu();
            loaiNguyenLieus.Insert(0, new LoaiNguyenLieuDTO { MaLoaiNguyenLieu = "Tất cả", TenLoaiNguyenLieu = "Tất cả" });

            cmbLoaiNL.DataSource = loaiNguyenLieus;
            cmbLoaiNL.DisplayMember = "TenLoaiNguyenLieu";
            cmbLoaiNL.ValueMember = "MaLoaiNguyenLieu";
        }
        private void LoadDataNguyenLieu()
        {
            string maLoaiNguyenLieu = cmbLoaiNL.SelectedValue.ToString();  // Get selected value from ComboBox
            string searchText = txtTenNguyenLieu.Text.Trim();  // Get text from TextBox
            List<NguyenLieuDTO> dsNguyenLieu = bus.TimNguyenLieu(maLoaiNguyenLieu, searchText);

            dgvNguyenLieu.DataSource = dsNguyenLieu;
            dgvNguyenLieu.AutoGenerateColumns = true;

            // Hide unnecessary columns
            dgvNguyenLieu.Columns["MaDVT"].Visible = false;
            dgvNguyenLieu.Columns["SoLuongTon"].Visible = false;
            dgvNguyenLieu.Columns["TrangThai"].Visible = false;

            // Optionally, adjust column headers to be more user-friendly
            dgvNguyenLieu.Columns["MaNguyenLieu"].HeaderText = "Mã Nguyên Liệu";
            dgvNguyenLieu.Columns["TenNguyenLieu"].HeaderText = "Tên Nguyên Liệu";
            dgvNguyenLieu.Columns["MaLoaiNguyenLieu"].HeaderText = "Mã Loại Nguyên Liệu";
            dgvNguyenLieu.Columns["TenLoaiNguyenLieu"].HeaderText = "Tên Loại Nguyên Liệu";
            dgvNguyenLieu.Columns["TenDVT"].HeaderText = "Đơn Vị Tính";
        }

        private void txtTenNguyenLieu_TextChanged(object sender, EventArgs e)
        {
            LoadDataNguyenLieu();
        }

        private void cmbLoaiNL_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataNguyenLieu();
        }
        private void ResetForm()
        {
            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            cb_NganHang.SelectedIndex = 0;
            txtSTK.Clear();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            string maNCC = bus.GenerateMaNCC(); // Get the new MaNCC

            // Set the generated MaNCC into the TextBox
            txtMaNCC.Text = maNCC;

            isCreatingNewMaNCC = true;

            txtTenNCC.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtSTK.Clear();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string maNCC = bus.GenerateMaNCC(); // Get the next MaNCC

            // Set the generated MaNCC into the TextBox
            txtMaNCC.Text = maNCC;

            // Now proceed with creating the supplier using the generated MaNCC
            if (ValidateSupplierInfo()) // Ensure the required fields are filled in
            {
                // Collect the necessary supplier information from the form
                string tenNCC = txtTenNCC.Text;
                string sdt = txtSDT.Text;
                string email = txtEmail.Text;
                string tenNganHang = cb_NganHang.Text.ToString();
                string soTaiKhoan = txtSTK.Text;

                // Create a new supplier using the CreateSupplier method in BUS
                bool isCreated = bus.CreateSupplier(maNCC, tenNCC, sdt, email, tenNganHang, soTaiKhoan);

                if (isCreated)
                {
                    MessageBox.Show("Nhà cung cấp đã được tạo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetForm(); // Optionally clear the form after creating
                }
                else
                {
                    MessageBox.Show("Có lỗi khi tạo nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private bool ValidateSupplierInfo()
        {
            // Check if all required fields are filled in
            if (string.IsNullOrWhiteSpace(txtTenNCC.Text))
            {
                MessageBox.Show("Tên nhà cung cấp không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNCC.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSDT.Text) || !IsValidPhoneNumber(txtSDT.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            

            if (string.IsNullOrWhiteSpace(txtSTK.Text))
            {
                MessageBox.Show("Số tài khoản không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSTK.Focus();
                return false;
            }

            // If all fields are valid, return true
            return true;
        }

        // Helper method to check valid phone number (basic validation)
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Check if the phone number starts with '0', is at least 10 digits long, and contains only digits
            return phoneNumber.StartsWith("0") && phoneNumber.Length >= 10 && phoneNumber.All(char.IsDigit);
        }


        // Helper method to check valid email format
        private bool IsValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return mail.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnHuyTao_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy việc tạo nhà cung cấp?",
                                         "Xác nhận",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Đặt lại flag isCreatingNewMaNCC để ngừng tạo mã mới
                isCreatingNewMaNCC = false;

                // Reset form về trạng thái ban đầu
                ResetForm();

                // Thông báo cho người dùng rằng quá trình tạo nhà cung cấp đã bị hủy
                MessageBox.Show("Quá trình tạo nhà cung cấp đã bị hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Nếu người dùng chọn "No", không làm gì cả
                return;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem txtMaNCC có giá trị hay không (nghĩa là đã chọn nhà cung cấp từ dgvNhaCungCap)
            if (!string.IsNullOrEmpty(txtMaNCC.Text))
            {
                var selectedRow = dgvNguyenLieu.CurrentRow;
                if (selectedRow != null)
                {
                    // Lấy mã nguyên liệu từ dòng được chọn
                    string maNCC = txtMaNCC.Text;  // Mã nhà cung cấp đã được chọn
                    string maNguyenLieu = selectedRow.Cells["MaNguyenLieu"]?.Value?.ToString();
                    string tenNguyenLieu = selectedRow.Cells["TenNguyenLieu"]?.Value?.ToString();
                    string tenDVT = selectedRow.Cells["TenDVT"]?.Value?.ToString();

                    // Kiểm tra giá trị DonGia trong TextBox
                    if (float.TryParse(txtDonGia.Text, out float donGia) && donGia > 0)
                    {
                        // Kiểm tra nguyên liệu đã tồn tại trong dgvCungUng chưa
                        bool isExist = false;
                        foreach (DataGridViewRow row in dgvCungUng.Rows)
                        {
                            if (row.Cells["MaNguyenLieu"].Value.ToString() == maNguyenLieu)
                            {
                                MessageBox.Show("Nguyên liệu này đã tồn tại trong danh sách cung ứng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                isExist = true;
                                break;
                            }
                        }

                        // Nếu nguyên liệu chưa tồn tại, thêm mới vào dgvCungUng
                        if (!isExist)
                        {
                            // Lấy danh sách cung ứng hiện có từ DataGridView
                            List<CungUngDTO> cungUngList = (List<CungUngDTO>)dgvCungUng.DataSource;

                            // Nếu danh sách rỗng, khởi tạo mới
                            if (cungUngList == null)
                            {
                                cungUngList = new List<CungUngDTO>();
                            }

                            // Tạo đối tượng CungUngDTO mới
                            CungUngDTO newCungUng = new CungUngDTO
                            {
                                MaNCC = maNCC,
                                MaNguyenLieu = maNguyenLieu,
                                TenNguyenLieu = tenNguyenLieu,
                                DonGia = donGia,
                                TenDVT = tenDVT,
                                TrangThai = "Hoạt Động"
                            };

                            // Thêm nguyên liệu mới vào danh sách cung ứng
                            cungUngList.Add(newCungUng);

                            // Cập nhật lại DataGridView với dữ liệu mới
                            dgvCungUng.DataSource = null;  // Clear current binding
                            dgvCungUng.DataSource = cungUngList;  // Rebind new data

                            // Reset TextBox DonGia sau khi thêm
                            txtDonGia.Text = string.Empty;

                            MessageBox.Show("Thêm nguyên liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập đơn giá hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn nguyên liệu trước khi thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp trước khi thêm nguyên liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvCungUng.SelectedRows.Count > 0)
            {
                // Lấy thông tin của dòng đã chọn
                string maNCC = dgvCungUng.SelectedRows[0].Cells["MaNCC"].Value.ToString();
                string maNguyenLieu = dgvCungUng.SelectedRows[0].Cells["MaNguyenLieu"].Value.ToString();

                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin cung ứng này?",
                                                      "Xác nhận xóa",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Gọi phương thức xóa từ BUS để xóa dữ liệu
                    bool isSuccess = bus.XoaCungUng(maNCC, maNguyenLieu);

                    if (isSuccess)
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Xóa dòng khỏi DataGridView
                        dgvCungUng.DataSource = bus.GetCungUngByMaNCC(maNCC);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại! Đã có lỗi xảy ra.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Nếu người dùng chọn No, không thực hiện xóa
                    MessageBox.Show("Xóa đã bị hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCungUng_Click(object sender, EventArgs e)
        {
            if (dgvCungUng.Rows.Count > 0)
            {
                bool isSuccess = true; // Biến để kiểm tra xem có lỗi xảy ra không

                foreach (DataGridViewRow row in dgvCungUng.Rows)
                {
                    if (row.Cells["MaNCC"].Value != null && row.Cells["MaNguyenLieu"].Value != null)
                    {
                        string maNCC = row.Cells["MaNCC"].Value.ToString();
                        string maNguyenLieu = row.Cells["MaNguyenLieu"].Value.ToString();
                        float donGia = float.TryParse(row.Cells["DonGia"].Value.ToString(), out donGia) ? donGia : 0;
                        string trangThai = row.Cells["TrangThai"].Value.ToString();

                        // Kiểm tra giá trị TrangThai trước khi thêm
                        if (trangThai != "Hoạt Động" && trangThai != "Ngừng Cung Cấp")
                        {
                            MessageBox.Show("Trạng thái không hợp lệ! Chỉ được phép: Hoạt Động, Ngừng Cung Cấp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Gọi stored procedure để thêm nguyên liệu vào cung ứng
                        bool addedSuccessfully = bus.ThemCungUng(maNCC, maNguyenLieu, donGia, trangThai);

                        if (!addedSuccessfully)
                        {
                            isSuccess = false; // Đánh dấu có lỗi
                        }
                        if (addedSuccessfully)
                        {
                            isSuccess = true; // Đánh dấu có lỗi
                            dgvCungUng.DataSource = bus.GetCungUngByMaNCC(maNCC);
                        }
                    }
                }

                if (isSuccess)
                {
                    MessageBox.Show("Dữ liệu đã được xác nhận và thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      // Reset lại DataGridView
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi thêm dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu trong danh sách cung ứng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvCungUng_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvCungUng_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCungUng.Rows[e.RowIndex];
                txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
                cmbTTCU.SelectedItem = row.Cells["TrangThai"].Value.ToString();
            }
        }
        private void InitializeComboBox()
        {
            cmbTTCU.Items.Add("Hoạt Động");
            cmbTTCU.Items.Add("Ngừng Cung Cấp");

            // Đặt giá trị mặc định nếu cần
            cmbTTCU.SelectedIndex = 0;  // Chọn "Hoạt Động" làm mặc định (hoặc bạn có thể để trống)
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dgvCungUng.SelectedRows.Count > 0)
            {
                // Lấy thông tin từ dòng đã chọn
                string maNguyenLieu = dgvCungUng.SelectedRows[0].Cells["MaNguyenLieu"].Value.ToString();
                string maNCC = dgvCungUng.SelectedRows[0].Cells["MaNCC"].Value.ToString();
                float donGia = 0;
                string trangThai = cmbTTCU.SelectedItem.ToString();

                // Kiểm tra và lấy giá trị DonGia từ TextBox
                if (float.TryParse(txtDonGia.Text, out donGia))
                {
                    // Gọi procedure cập nhật thông tin cung ứng
                    bool isSuccess = bus.CapNhatCungUng(maNCC, maNguyenLieu, donGia, trangThai);

                    if (isSuccess)
                    {
                        MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Cập nhật lại DataGridView (hoặc reload lại dữ liệu)
                        dgvCungUng.DataSource= bus.GetCungUngByMaNCC(maNCC);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Giá trị đơn giá không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cb_NganHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
