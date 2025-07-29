using WindowsFormsApplication1.BUS;
using WindowsFormsApplication1.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.GUI;

namespace WindowsFormsApplication1.GUI
{
    public partial class frmDatHang : Form
    {
        BUS_Kho BUS_Kho = new BUS_Kho();
        BUS_DATHANG bus = new BUS_DATHANG();
        private string maNV;
        public frmDatHang(string maNV)
        {
            InitializeComponent();
            LoadComboBoxNhaCungCap();
            InitializedgvCTPN();
            InitializedgvPN();
            InitializedgvLN();
            LoadDgvKho();
            LoadTrangThaiComboBox();
            dgvPhieuNhap.CellClick += dgvPhieuNhap_CellClick;
            btnHuyPhieu.Enabled = false;
            btnInHoaDon.Enabled = false;
            btnThanhToan.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnXacNhan.Enabled = false;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            this.maNV = maNV;
            txtMaNV.Text = maNV;
        }
        private void InitializedgvCTPN()
        {
            // Xóa tất cả các cột hiện tại (nếu có)
            dgvChiTietPhieuNhap.Columns.Clear();

            // Thêm cột cho DataGridView
            dgvChiTietPhieuNhap.Columns.Add("MaPhieuNhapHang", "Mã Phiếu Nhập");
            dgvChiTietPhieuNhap.Columns.Add("MaNguyenLieu", "Mã Nguyên Liệu");
            dgvChiTietPhieuNhap.Columns.Add("TenNguyenLieu", "Tên Nguyên Liệu");
            dgvChiTietPhieuNhap.Columns.Add("SoLuong", "Số Lượng");
            dgvChiTietPhieuNhap.Columns.Add("TenDVT", "Đơn Vị Tính");
            dgvChiTietPhieuNhap.Columns.Add("DonGia", "Đơn Giá");
            dgvChiTietPhieuNhap.Columns.Add("TongGia", "Tổng Giá");
            dgvChiTietPhieuNhap.Columns.Add("TrangThai", "Trạng Thái");

            // Bạn có thể tùy chỉnh thêm thuộc tính cho các cột ở đây nếu cần
        }
        private void InitializedgvPN()
        {
            // Xóa tất cả các cột hiện tại (nếu có)
            dgvPhieuNhap.Columns.Clear();


            dgvPhieuNhap.Columns.Add("MaPhieuNhapHang", "Mã Phiếu Nhập");
            dgvPhieuNhap.Columns.Add("MaNhanVien", "Mã Nhân Viên");
            dgvPhieuNhap.Columns.Add("MaNCC", "Mã Nhà Cung Cấp");
            dgvPhieuNhap.Columns.Add("NgayNhap", "Ngày Nhập");
            dgvPhieuNhap.Columns.Add("TongTienNhap", "Tổng Tiền Nhập");

            // Bạn có thể tùy chỉnh thêm thuộc tính cho các cột ở đây nếu cần
        }
        private void InitializedgvLN()
        {
            // Xóa tất cả các cột hiện tại (nếu có)
            dgvNguyenLieu.Columns.Clear();


            dgvNguyenLieu.Columns.Add("MaNguyenLieu", "Mã Nguyên Liệu");
            dgvNguyenLieu.Columns.Add("TenNguyenLieu", "Tên Nguyên Liệu");
            dgvNguyenLieu.Columns.Add("TenDVT", "Đơn Vị Tính");
            dgvNguyenLieu.Columns.Add("TenLoaiNguyenLieu", "Tên Loại Nguyên Liệu");
            dgvNguyenLieu.Columns.Add("DonGia", "Đơn Giá");
            dgvNguyenLieu.Columns.Add("TrangThai", "Trạng Thái");

            // Bạn có thể tùy chỉnh thêm thuộc tính cho các cột ở đây nếu cần
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtTimKiem.Text; // TextBox để nhập từ khóa tìm kiếm
            string trangThai = cmbTrangThai.SelectedItem.ToString(); // Lấy trạng thái từ ComboBox

            // Gọi BLL để tìm kiếm và lọc theo trạng thái
            List<NguyenLieuDTO> nguyenLieuList = bus.TimKiemNguyenLieu(searchText, trangThai);

            // Hiển thị dữ liệu lên DataGridView
            dgvKho.DataSource = nguyenLieuList;
        }
        private void LoadComboBoxNhaCungCap()
        {
            DataTable dtNhaCungCap = bus.GetAllNhaCungCap(); // Method to get all suppliers
            cmbNhaCungCap.DataSource = dtNhaCungCap;
            cmbNhaCungCap.DisplayMember = "TenNCC"; // Display supplier name
            cmbNhaCungCap.ValueMember = "MaNCC"; // Use MaNCC as value
        }
        
        private void LoadDgvKho()
        {
            List<NguyenLieuDTO> nguyenLieu = BUS_Kho.HienThiDanhSachKhoCanNhap();
            dgvKho.DataSource = nguyenLieu;
            dgvKho.Columns["MaNguyenLieu"].HeaderText = "Mã Nguyên Liệu";
            dgvKho.Columns["TenNguyenLieu"].HeaderText = "Tên Nguyên Liệu";
            dgvKho.Columns["TenDVT"].HeaderText = "Đơn Vị Tính";
            dgvKho.Columns["SoLuongTon"].HeaderText = "Số Lượng Tồn";
            dgvKho.Columns["TrangThai"].HeaderText = "Trạng Thái";
            dgvKho.Columns["MaDVT"].Visible = false;
            dgvKho.Columns["MaLoaiNguyenLieu"].Visible = false;
            dgvKho.Columns["TenLoaiNguyenLieu"].Visible = false;
        }
        private void cmbNhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNhaCungCap.SelectedValue != null)
            {
                string maNCC = cmbNhaCungCap.SelectedValue.ToString(); // Lấy mã nhà cung cấp được chọn

                // Lấy nguyên liệu theo nhà cung cấp và cập nhật DataGridView
                DataTable dtNguyenLieu = bus.LayNguyenLieuTheoNhaCungCap(maNCC);

                // Xóa các cột hiện tại và thiết lập lại cột nếu cần
                dgvNguyenLieu.Columns.Clear();
                InitializedgvLN(); // Khởi tạo lại các cột cho DataGridView

                // Kiểm tra xem DataTable có dữ liệu không
                if (dtNguyenLieu != null && dtNguyenLieu.Rows.Count > 0)
                {
                    foreach (DataRow row in dtNguyenLieu.Rows)
                    {
                        int rowIndex = dgvNguyenLieu.Rows.Add();  // Thêm một dòng mới vào DataGridView

                        dgvNguyenLieu.Rows[rowIndex].Cells["MaNguyenLieu"].Value = row["MaNguyenLieu"];
                        dgvNguyenLieu.Rows[rowIndex].Cells["TenNguyenLieu"].Value = row["TenNguyenLieu"];
                        dgvNguyenLieu.Rows[rowIndex].Cells["TenDVT"].Value = row["TenDVT"];
                        dgvNguyenLieu.Rows[rowIndex].Cells["TenLoaiNguyenLieu"].Value = row["TenLoaiNguyenLieu"];
                        dgvNguyenLieu.Rows[rowIndex].Cells["DonGia"].Value = row["DonGia"];
                        dgvNguyenLieu.Rows[rowIndex].Cells["TrangThai"].Value = row["TrangThai"];
                    }
                }

                // Lấy thông tin nhà cung cấp dựa trên mã nhà cung cấp và điền vào các TextBox
                DataTable dtNhaCungCap = bus.layNhaCungCapTheoMa(maNCC); // Giả sử có phương thức này trong BUS

                if (dtNhaCungCap.Rows.Count > 0)
                {
                    // Giả sử chỉ có một dòng dữ liệu
                    DataRow row = dtNhaCungCap.Rows[0];
                    txtMaNCC.Text = row["MaNCC"].ToString();
                    txtTenNCC.Text = row["TenNCC"].ToString();
                    txtSDT.Text = row["SDT"].ToString();
                    txtEmail.Text = row["Email"].ToString();
                    txtNganHang.Text = row["TenNganHang"].ToString();
                    txtSTK.Text = row["SoTaiKhoan"].ToString();
                }
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmDatHang_Load(object sender, EventArgs e)
        {
            cmbNhaCungCap.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem mã phiếu nhập đã được nhập chưa
            if (string.IsNullOrEmpty(txtMaPhieuNhap.Text))
            {
                MessageBox.Show("Vui lòng tạo mã phiếu nhập trước khi thêm nguyên liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng thực hiện nếu mã phiếu chưa được nhập
            }

            var selectedRow = dgvNguyenLieu.CurrentRow;
            if (selectedRow != null)
            {
                // Lấy giá trị trạng thái nguyên liệu từ dòng được chọn
                string trangThai = selectedRow.Cells["TrangThai"]?.Value?.ToString()?.Trim();

                // Hiển thị thông báo và dừng nếu trạng thái là "Ngừng Cung Cấp"
                if (trangThai == "Ngừng Cung Cấp")
                {
                    MessageBox.Show("Nguyên liệu này đã ngưng cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSoLuong.Text = string.Empty;
                    return; // Dừng thực hiện nếu nguyên liệu đang ngưng cung cấp
                }

                // Lấy mã phiếu nhập từ TextBox
                string maPhieuNhapHang = txtMaPhieuNhap.Text;

                // Lấy mã nguyên liệu từ dòng được chọn
                string maNguyenLieu = selectedRow.Cells["MaNguyenLieu"]?.Value?.ToString();
                string tenNguyenLieu = selectedRow.Cells["TenNguyenLieu"]?.Value?.ToString();
                string DVT = selectedRow.Cells["TenDVT"]?.Value?.ToString();
                float donGia = float.TryParse(selectedRow.Cells["DonGia"]?.Value?.ToString(), out float parsedDonGia) ? parsedDonGia : 0;

                // Lấy số lượng từ TextBox
                if (int.TryParse(txtSoLuong.Text, out int soLuong) && soLuong > 0)
                {
                    // Kiểm tra nếu nguyên liệu đã có trong dgvChiTietPhieuNhap
                    bool found = false;
                    foreach (DataGridViewRow row in dgvChiTietPhieuNhap.Rows)
                    {
                        if (row.Cells["MaNguyenLieu"]?.Value?.ToString() == maNguyenLieu)
                        {
                            // Cộng dồn số lượng và tính lại tổng giá
                            int currentQuantity = int.TryParse(row.Cells["SoLuong"]?.Value?.ToString(), out int parsedQuantity) ? parsedQuantity : 0;
                            currentQuantity += soLuong; // Cộng dồn số lượng
                            row.Cells["SoLuong"].Value = currentQuantity; // Cập nhật số lượng

                            // Tính tổng giá mới
                            float tongGia = currentQuantity * donGia;
                            row.Cells["TongGia"].Value = tongGia; // Cập nhật tổng giá

                            found = true;
                            break;
                        }
                    }

                    // Nếu nguyên liệu chưa có trong DataGridView, thêm mới
                    if (!found)
                    {
                        float tongGia = soLuong * donGia;
                        // Thêm dòng mới với trạng thái mặc định là "Đang đặt hàng"
                        dgvChiTietPhieuNhap.Rows.Add(maPhieuNhapHang, maNguyenLieu,tenNguyenLieu, soLuong, DVT, donGia, tongGia, "Đang đặt hàng");
                    }

                    // Reset số lượng sau khi thêm thành công
                    txtSoLuong.Text = string.Empty; // Hoặc bạn có thể đặt thành 0: txtSoLuong.Text = "0";
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số lượng hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu trước khi thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Cập nhật trạng thái ComboBox nếu cần
            UpdateComboBoxState();
        }




        private void UpdateComboBoxState()
        {
            // Kiểm tra xem dgvChiTietPhieuNhap có dữ liệu hay không
            if (dgvChiTietPhieuNhap.Rows.Count > 0)
            {
                // Nếu có dữ liệu, khóa ComboBox
                cmbNhaCungCap.Enabled = false;
            }
            else
            {
                // Nếu không có dữ liệu, mở khóa ComboBox
                cmbNhaCungCap.Enabled = true;
            }
        }


        private void dgvChiTietPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvChiTietPhieuNhap.SelectedRows.Count > 0)
            {
                // Xóa dòng được chọn
                dgvChiTietPhieuNhap.Rows.RemoveAt(dgvChiTietPhieuNhap.SelectedRows[0].Index);

                // Cập nhật trạng thái ComboBox
                UpdateComboBoxState();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc muốn hủy tất cả các dòng trong danh sách chi tiết phiếu nhập không?",
                                         "Xác nhận hủy",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            // Kiểm tra nếu người dùng chọn "Yes"
            if (confirmResult == DialogResult.Yes)
            {
                // Xóa tất cả các dòng trong DataGridView
                dgvChiTietPhieuNhap.Rows.Clear();

                // Cập nhật trạng thái ComboBox nếu cần
                UpdateComboBoxState();

                // Thông báo người dùng
                MessageBox.Show("Đã xóa tất cả các dòng trong danh sách chi tiết phiếu nhập!");
            }
            else
            {
                // Thông báo nếu không có hành động nào xảy ra
                MessageBox.Show("Hủy thao tác xóa!");
            }
            
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu dgvChiTietPhieuNhap có dữ liệu
            if (dgvChiTietPhieuNhap.Rows.Count > 0)
            {
                // Kiểm tra nếu ComboBox nhà cung cấp được chọn
                if (cmbNhaCungCap.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn nhà cung cấp!");
                    return; // Dừng phương thức nếu không có nhà cung cấp được chọn
                }

                // Lấy mã phiếu nhập từ TextBox
                string maPhieuNhapHang = txtMaPhieuNhap.Text;
                string maNCC = cmbNhaCungCap.SelectedValue.ToString(); // Lấy mã nhà cung cấp
                DateTime ngayNhap = DateTime.Now; // Ngày nhập hiện tại
                //string maNV = txtMaNV.Text;

                // Tính tổng tiền nhập cho từng dòng
                float tongTienNhap = 0;

                // Tạo danh sách để lưu tổng từng dòng
                foreach (DataGridViewRow row in dgvChiTietPhieuNhap.Rows)
                {
                    if (row.Cells["TongGia"].Value != null) // Kiểm tra nếu ô không null
                    {
                        // Cộng dồn tổng giá cho từng dòng
                        tongTienNhap += float.Parse(row.Cells["TongGia"].Value.ToString());
                    }
                }

                // Thêm dòng mới vào dgvPhieuNhap
                dgvPhieuNhap.Rows.Add(maPhieuNhapHang,maNV, maNCC, ngayNhap, tongTienNhap);

                // Có thể thêm logic để lưu vào cơ sở dữ liệu nếu cần
                MessageBox.Show("Phiếu nhập đã được xác nhận và thêm vào danh sách!");
                btnInHoaDon.Enabled = true;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xác nhận!");
            }
        }
        private bool isCreated = false;
        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dữ liệu trong dgvChiTietPhieuNhap không
            if (dgvChiTietPhieuNhap.Rows.Count > 1)
            {
                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy và tạo mới phiếu nhập không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return; // Nếu người dùng chọn No, thoát ra không làm gì
                }
            }

            // Nếu có dữ liệu trong dgv hoặc người dùng chọn Yes
            txtMaPhieuNhap.Text = bus.GenerateMaPhieuNhap();
            dtpNgayNhap.Value = DateTime.Now;

            // Reset dgvChiTietPhieuNhap nếu cần
            dgvChiTietPhieuNhap.Rows.Clear(); // Xóa tất cả các dòng trong dgvChiTietPhieuNhap nếu bạn muốn bắt đầu một phiếu mới
            dgvPhieuNhap.Rows.Clear();

            isCreated = true; // Đặt trạng thái là đã tạo
            btnHuyPhieu.Enabled = true; // Kích hoạt nút Hủy Phiếu
            cmbNhaCungCap.Enabled = true; // Mở khóa ComboBox Nhà Cung Cấp
            dtpNgayNhap.Enabled = false;
            btnHuy.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnXacNhan.Enabled = true;
            btnInHoaDon.Enabled = false;
            isFiltered = false;
        }


        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string maPhieuNhapHang = txtMaPhieuNhap.Text;
            string maNhanVien = maNV; // Ensure this is filled correctly in your form
            string maNCC = cmbNhaCungCap.SelectedValue.ToString(); // Assuming this returns the correct ID
            DateTime ngayNhap = dtpNgayNhap.Value;

            // Calculate total money
            float tongTienNhap = 0;
            List<Tuple<string, int, float, string>> chiTietList = new List<Tuple<string, int, float, string>>(); // Removed DonGia

            // Check if dgvChiTietPhieuNhap has data
            if (dgvChiTietPhieuNhap.Rows.Count == 0 || dgvChiTietPhieuNhap.Rows.Cast<DataGridViewRow>().All(r => r.Cells["MaNguyenLieu"].Value == null))
            {
                MessageBox.Show("Không có chi tiết phiếu nhập. Bạn phải thêm ít nhất một nguyên liệu để thanh toán.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop further execution
            }
            if (dgvPhieuNhap.Rows.Count == 0 || dgvPhieuNhap.Rows.Cast<DataGridViewRow>().All(r => r.Cells["MaPhieuNhapHang"].Value == null))
            {
                MessageBox.Show("Không có phiếu nhập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop further execution
            }

            // Iterate through dgvChiTietPhieuNhap to gather details
            foreach (DataGridViewRow row in dgvChiTietPhieuNhap.Rows)
            {
                if (row.Cells["MaNguyenLieu"].Value != null)
                {
                    string maNguyenLieu = row.Cells["MaNguyenLieu"].Value.ToString();
                    int soLuong = int.Parse(row.Cells["SoLuong"].Value.ToString());
                    float tongGia = float.Parse(row.Cells["TongGia"].Value.ToString()); // Use total price instead of DonGia
                    string trangThai = row.Cells["TrangThai"].Value.ToString();
                    // Add to the list without DonGia
                    chiTietList.Add(new Tuple<string, int, float, string>(maNguyenLieu, soLuong, tongGia, trangThai));

                    tongTienNhap += tongGia; // Accumulate total price
                }
            }

            // Chuyển sang frmQR và điền thông tin
            

            // Payment confirmation dialog
            string tenNhaCungCap = txtTenNCC.Text;
            string tenNganHang = txtNganHang.Text;
            string soTaiKhoan = txtSTK.Text;
            string message = $"Nhà cung cấp yêu cầu thanh toán qua ngân hàng:\n\n" +
                             $"Tên ngân hàng: {tenNganHang}\n" +
                             $"Số tài khoản: {soTaiKhoan}\n\n" +
                             "Bạn có chắc chắn đã thanh toán không?";
            
            DialogResult result = MessageBox.Show(message, "Xác nhận thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Insert PhieuNhapHang using the stored procedure
                    bool phieuNhapSuccess = bus.InsertPhieuNhap(maPhieuNhapHang, maNhanVien, maNCC, ngayNhap, tongTienNhap);

                    if (phieuNhapSuccess)
                    {
                        // Here, insert ChiTietPhieuNhap with the modified list that does not include DonGia
                        bool chiTietSuccess = bus.InsertChiTietPhieuNhap(maPhieuNhapHang, chiTietList);

                        if (chiTietSuccess)
                        {
                            MessageBox.Show("Phiếu nhập và chi tiết đã được tạo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Đã xảy ra lỗi khi tạo chi tiết phiếu nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi tạo phiếu nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Thanh toán đã bị hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void LoadData()
        {
            dgvChiTietPhieuNhap.Rows.Clear();
            dgvPhieuNhap.Rows.Clear();
            LoadComboBoxNhaCungCap(); // Load any additional data as necessary
            txtMaPhieuNhap.Text = " "; // Generate new invoice number
            dtpNgayNhap.Value = DateTime.Now; // Reset date to current date
            txtMaNCC.Text = " ";
            txtTenNCC.Text = " ";
            txtSDT.Text = " ";
            txtEmail.Text = " ";    
            txtNganHang.Text = " ";
            txtSTK.Text = " ";
            txtMaNV.Text = maNV;
            btnInHoaDon.Enabled = false;
        }

        private void btnHuyPhieu_Click(object sender, EventArgs e)
        {
            if (dgvPhieuNhap.Rows.Count == 0 || dgvPhieuNhap.Rows.Cast<DataGridViewRow>().All(r => r.Cells["MaPhieuNhapHang"].Value == null))
            {
                MessageBox.Show("Không có phiếu nhập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop further execution
            }
            if (isCreated)
            {
                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy phiếu không?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Clear DataGridView
                    dgvPhieuNhap.Rows.Clear();


                    // Vô hiệu hóa nút Hủy Phiếu

                    // Focus lại vào DataGridView
                    dgvChiTietPhieuNhap.Focus();

                    MessageBox.Show("Phiếu đã được hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                btnInHoaDon.Enabled = false;
                btnThanhToan.Enabled = false;
            }
            else
            {
                MessageBox.Show("Chưa có phiếu nào để hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpTuNgay.Value;
            DateTime endDate = dtpDenNgay.Value;

            // Get search results
            DataTable searchResults = bus.SearchPhieuNhap(startDate, endDate);

            // Clear existing rows
            dgvPhieuNhap.Rows.Clear();
            btnThanhToan.Enabled = false;
            btnHuyPhieu.Enabled = false;
            btnInHoaDon.Enabled = false;
            isFiltered = true;
            

            // Ensure DataTable has the correct columns for MaPhieuNhapHang, MaNhanVien, MaNCC, NgayNhap, TongTienNhap
            foreach (DataRow row in searchResults.Rows)
            {
                int rowIndex = dgvPhieuNhap.Rows.Add();  // Add a new row to the DataGridView
                dgvPhieuNhap.Rows[rowIndex].Cells["MaPhieuNhapHang"].Value = row["MaPhieuNhapHang"];
                dgvPhieuNhap.Rows[rowIndex].Cells["MaNhanVien"].Value = row["MaNhanVien"];
                dgvPhieuNhap.Rows[rowIndex].Cells["MaNCC"].Value = row["MaNCC"];
                dgvPhieuNhap.Rows[rowIndex].Cells["NgayNhap"].Value = row["NgayNhap"];
                dgvPhieuNhap.Rows[rowIndex].Cells["TongTienNhap"].Value = row["TongTienNhap"];
            }
        }

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng nhấp vào một dòng hợp lệ
            if (e.RowIndex >= 0 && dgvPhieuNhap.Rows[e.RowIndex].Cells["MaPhieuNhapHang"].Value != null)
            {
                // Lấy mã phiếu nhập từ dòng đã chọn
                string maPhieuNhap = dgvPhieuNhap.Rows[e.RowIndex].Cells["MaPhieuNhapHang"].Value.ToString();
                string maNhaCC = dgvPhieuNhap.Rows[e.RowIndex].Cells["MaNCC"].Value.ToString();
                // Fill mã phiếu nhập vào TextBox
                txtMaPhieuNhap.Text = maPhieuNhap;
                cmbNhaCungCap.SelectedValue = maNhaCC;

                // Lấy ngày nhập từ dòng đã chọn và fill vào DateTimePicker
                DateTime ngayNhap;
                if (DateTime.TryParse(dgvPhieuNhap.Rows[e.RowIndex].Cells["NgayNhap"].Value.ToString(), out ngayNhap))
                {
                    dtpNgayNhap.Value = ngayNhap;
                }
                else
                {
                    MessageBox.Show("Không thể đọc được ngày nhập từ phiếu nhập này.");
                }

                // Gọi phương thức lấy chi tiết phiếu nhập từ BUS
                DataTable chiTietTable = bus.LayChiTietPhieuNhapTheoMa(maPhieuNhap,maNhaCC);

                // Kiểm tra xem chiTietTable có dữ liệu không
                if (chiTietTable != null && chiTietTable.Rows.Count > 0)
                {
                    // Xóa các dòng cũ trong dgvChiTietPhieuNhap
                    dgvChiTietPhieuNhap.Rows.Clear();

                    // Điền dữ liệu mới vào dgvChiTietPhieuNhap
                    foreach (DataRow row in chiTietTable.Rows)
                    {
                        int index = dgvChiTietPhieuNhap.Rows.Add();
                        dgvChiTietPhieuNhap.Rows[index].Cells["MaPhieuNhapHang"].Value = row["MaPhieuNhapHang"];
                        dgvChiTietPhieuNhap.Rows[index].Cells["MaNguyenLieu"].Value = row["MaNguyenLieu"];
                        dgvChiTietPhieuNhap.Rows[index].Cells["TenNguyenLieu"].Value = row["TenNguyenLieu"];
                        dgvChiTietPhieuNhap.Rows[index].Cells["SoLuong"].Value = row["SoLuong"];
                        dgvChiTietPhieuNhap.Rows[index].Cells["TenDVT"].Value = row["TenDVT"];
                        dgvChiTietPhieuNhap.Rows[index].Cells["DonGia"].Value = row["DonGia"];
                        dgvChiTietPhieuNhap.Rows[index].Cells["TongGia"].Value = row["TongGia"];
                        dgvChiTietPhieuNhap.Rows[index].Cells["TrangThai"].Value = row["TrangThai"];
                    }
                }
                else
                {
                    MessageBox.Show("Không có chi tiết phiếu nhập nào cho mã phiếu này.");
                }
                btnInHoaDon.Enabled = true;
            }
        }

        private void cmbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cmbTrangThai.SelectedItem.ToString(); // Lấy trạng thái từ ComboBox

            // Gọi BLL để lấy dữ liệu
            List<NguyenLieuDTO> nguyenLieuList = bus.LayDanhSachNguyenLieuTheoTrangThai(trangThai);

            // Hiển thị dữ liệu lên DataGridView
            dgvKho.DataSource = nguyenLieuList;
        }
        private void LoadTrangThaiComboBox()
        {
            List<string> trangThaiList = new List<string> { "Tất cả", "Còn Hàng", "Cần Nhập"};
            cmbTrangThai.DataSource = trangThaiList;
        }
        private bool isFiltered = false;  // Biến cờ để theo dõi trạng thái lọc

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            HoaDonDatHang hoaDonDatHang = LayHoaDonDatHang();

            // Truyền dữ liệu vào DataSet hoặc thực hiện các thao tác in ấn
            DataSet dsHoaDon = LayDuLieuHoaDon(hoaDonDatHang); // Ví dụ: chuyển sang DataSet nếu cần
            frmRPHoaDonDatHang frm = new frmRPHoaDonDatHang(dsHoaDon, txtNganHang.Text,txtSTK.Text, txtTenNCC.Text);
            frm.ShowDialog();
            if (!isFiltered)
            {
                btnThanhToan.Enabled = true;  // Chỉ kích hoạt lại nếu chưa lọc
            }
        }
        public DataSet LayDuLieuHoaDon(HoaDonDatHang hoaDonDatHang)
        {
            DataSet ds = new DataSet();

            // Tạo bảng cho thông tin hóa đơn chính (HoaDonDHDTO)
            DataTable dtHoaDon = new DataTable("HoaDon");
            dtHoaDon.Columns.Add("NgayDat", typeof(DateTime));
            dtHoaDon.Columns.Add("MaHD", typeof(string));
            dtHoaDon.Columns.Add("TenNCC", typeof(string));
            dtHoaDon.Columns.Add("Email", typeof(string));
            dtHoaDon.Columns.Add("SDT", typeof(string));
            dtHoaDon.Columns.Add("NganHang", typeof(string));
            dtHoaDon.Columns.Add("STK", typeof(string));
            dtHoaDon.Columns.Add("TenNV", typeof(string));
            dtHoaDon.Columns.Add("QR", typeof(byte[]));
            dtHoaDon.Columns.Add("TongTien", typeof(decimal));

            // Thêm dữ liệu cho bảng HoaDon
            DataRow rowHD = dtHoaDon.NewRow();
            rowHD["NgayDat"] = hoaDonDatHang.hoaDonDHDTO.NgayDat;
            rowHD["MaHD"] = hoaDonDatHang.hoaDonDHDTO.MaHD;
            rowHD["TenNCC"] = hoaDonDatHang.hoaDonDHDTO.TenNCC;
            rowHD["Email"] = hoaDonDatHang.hoaDonDHDTO.Email;
            rowHD["SDT"] = hoaDonDatHang.hoaDonDHDTO.SDT;
            rowHD["NganHang"] = hoaDonDatHang.hoaDonDHDTO.NganHang;
            rowHD["STK"] = hoaDonDatHang.hoaDonDHDTO.STK;
            rowHD["TenNV"] = hoaDonDatHang.hoaDonDHDTO.TenNV;
            rowHD["TongTien"] = hoaDonDatHang.hoaDonDHDTO.TongTien;

            dtHoaDon.Rows.Add(rowHD);
            ds.Tables.Add(dtHoaDon);

            // Tạo bảng cho chi tiết hóa đơn (List<HoaDonChitietDTO>)
            DataTable dtChiTietHD = new DataTable("ChiTietHoaDon");
            dtChiTietHD.Columns.Add("STT", typeof(int)); // Thêm cột STT
            dtChiTietHD.Columns.Add("TenNguyenLieu", typeof(string));
            dtChiTietHD.Columns.Add("DVT", typeof(string));
            dtChiTietHD.Columns.Add("SoLuong", typeof(int));
            dtChiTietHD.Columns.Add("DonGia", typeof(decimal));
            dtChiTietHD.Columns.Add("ThanhTien", typeof(decimal));

            // Thêm dữ liệu vào bảng ChiTietHoaDon, kèm số thứ tự (STT)
            int stt = 1; // Bắt đầu số thứ tự từ 1
            foreach (var chiTiet in hoaDonDatHang.hd)
            {
                DataRow rowCT = dtChiTietHD.NewRow();
                rowCT["STT"] = stt++; // Tăng dần số thứ tự
                rowCT["TenNguyenLieu"] = chiTiet.TenNguyenLieu;
                rowCT["DVT"] = chiTiet.DVT;
                rowCT["SoLuong"] = chiTiet.SoLuong;
                rowCT["DonGia"] = chiTiet.DonGia;
                rowCT["ThanhTien"] = chiTiet.ThanhTien;

                dtChiTietHD.Rows.Add(rowCT);
            }
            ds.Tables.Add(dtChiTietHD);

            return ds;
        }
        public HoaDonDatHang LayHoaDonDatHang()
        {
            HoaDonDatHang hoaDonDatHang = new HoaDonDatHang();
            NhanVienBUS nhanVienBUS = new NhanVienBUS();
            NhanVienDTO TenNV = nhanVienBUS.GetNhanVienByMaNV(txtMaNV.Text);
            // Phần thông tin của HoaDonDHDTO từ TextBox hoặc các control khác
            HoaDonDHDTO hoaDonDH = new HoaDonDHDTO
            {
                NgayDat = dtpNgayNhap.Value,
                MaHD = txtMaPhieuNhap.Text, // Ví dụ: Lấy mã hóa đơn từ TextBox
                TenNCC = txtTenNCC.Text,
                Email = txtEmail.Text,
                SDT = txtSDT.Text,
                NganHang = txtNganHang.Text,
                STK = txtSTK.Text,
                TenNV = TenNV.TenNhanVien,  // Ví dụ: Lấy mã nhân viên từ TextBox
                TongTien = 0 // Giá trị này sẽ tính toán dựa trên các chi tiết dưới đây
            };

            // Khởi tạo danh sách chi tiết hóa đơn
            List<HoaDonChitietDTO> chiTietList = new List<HoaDonChitietDTO>();

            // Lấy dữ liệu từ DataGridView dgvChiTietPhieuNhap
            foreach (DataGridViewRow row in dgvChiTietPhieuNhap.Rows)
            {
                if (row.Cells["TenNguyenLieu"].Value != null)
                {
                    HoaDonChitietDTO chiTiet = new HoaDonChitietDTO
                    {
                        TenNguyenLieu = row.Cells["TenNguyenLieu"].Value.ToString(),
                        DVT = row.Cells["TenDVT"].Value.ToString(),
                        SoLuong = Convert.ToInt32(row.Cells["SoLuong"].Value),
                        DonGia = Convert.ToDecimal(row.Cells["DonGia"].Value),
                        ThanhTien = Convert.ToDecimal(row.Cells["TongGia"].Value)
                    };

                    // Tính tổng tiền cho hóa đơn
                    hoaDonDH.TongTien += chiTiet.ThanhTien;

                    // Thêm chi tiết vào danh sách
                    chiTietList.Add(chiTiet);
                }
            }

            // Gán thông tin hóa đơn và chi tiết vào đối tượng hoaDonDatHang
            hoaDonDatHang.hoaDonDHDTO = hoaDonDH;
            hoaDonDatHang.hd = chiTietList;

            return hoaDonDatHang;
        }

    }
}
