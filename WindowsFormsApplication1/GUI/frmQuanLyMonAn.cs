using WindowsFormsApplication1.DTO;
using WindowsFormsApplication1.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Net.Http;

namespace WindowsFormsApplication1.GUI
{
    public partial class frmQuanLyMonAn : Form
    {
        ImgurUploader imgurUploader = new ImgurUploader();
        public frmQuanLyMonAn()
        {
            InitializeComponent();
        }

        private void frmQuanLyMonAn_Load(object sender, EventArgs e)
        {
            LoadDanhSachMonAn();
            LoadNguyenLieu();
            LoadDonViTinh();
            LoadcboLoaiMonAn();
            LoadTrangThaiComboBox();
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            AutoResizeDataGridView(dgvCongThuc);
            AutoResizeDataGridView(dgvDanhSachMonAn);
            AutoResizeDataGridView(dgvNguyenLieu);
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
        private void LoadTrangThaiComboBox()
        {
            // Xóa các mục hiện có (nếu có)
            cboTimKiemTrangThai.Items.Clear();

            // Thêm các mục vào ComboBox
            cboTimKiemTrangThai.Items.Add("Tất cả");
            cboTimKiemTrangThai.Items.Add("Còn bán");
            cboTimKiemTrangThai.Items.Add("Ngừng bán");

            // Đặt mục mặc định là "Tất cả"
            cboTimKiemTrangThai.SelectedIndex = 0;
        }

        private void LoadcboLoaiMonAn()
        {
            QuanLyMonAnBUS bus = new QuanLyMonAnBUS();
            DataTable dtLoaiMonAn = bus.LayDanhSachLoaiMonAn();

            cboLoaiMonAn.DataSource = dtLoaiMonAn;
            cboLoaiMonAn.DisplayMember = "TenLoai"; // Hiển thị tên loại
            cboLoaiMonAn.ValueMember = "MaLoai";   // Giá trị là mã loại
        }
        public void LoadDanhSachMonAn()
        {
            // Tạo đối tượng BUS để lấy danh sách món ăn
            QuanLyMonAnBUS busQuanLyMonAn = new QuanLyMonAnBUS();

            // Lấy danh sách món ăn từ BUS
            List<MonAnDTO> danhSachMonAn = busQuanLyMonAn.HienThiDanhSachMonAn();

            // Gán danh sách món ăn cho DataGridView
            dgvDanhSachMonAn.DataSource = danhSachMonAn;

            // Nếu cần thiết, bạn có thể cấu hình thêm cho DataGridView
            dgvDanhSachMonAn.Columns["MaMonAn"].HeaderText = "Mã Món Ăn";
            dgvDanhSachMonAn.Columns["TenMonAn"].HeaderText = "Tên Món Ăn";
            dgvDanhSachMonAn.Columns["GiaMonAn"].HeaderText = "Giá Món Ăn (VNĐ)";
            dgvDanhSachMonAn.Columns["TenLoai"].HeaderText = "Tên Loại";
            dgvDanhSachMonAn.Columns["TrangThai"].HeaderText = "Trạng Thái";

            // Ẩn các cột không cần thiết
            dgvDanhSachMonAn.Columns["TenLoai"].Visible = false;
            dgvDanhSachMonAn.Columns["HinhAnh"].Visible = false;
            dgvDanhSachMonAn.Columns["MaLoai"].Visible = false;
            dgvDanhSachMonAn.Columns["MoTa"].Visible = false;

            btnNgungBan.Enabled = false;
            btnConBan.Enabled = false;
        }
        private void LoadNguyenLieu()
        {
            // Tạo đối tượng BUS để lấy danh sách nguyên liệu
            QuanLyMonAnBUS busQuanLyNguyenLieu = new QuanLyMonAnBUS();

            // Lấy danh sách nguyên liệu từ BUS
            List<NguyenLieuDTO> danhSachNguyenLieu = busQuanLyNguyenLieu.HienThiDanhSachNguyenLieu();

            // Gán danh sách nguyên liệu cho DataGridView
            dgvNguyenLieu.DataSource = danhSachNguyenLieu;

            // Nếu cần thiết, bạn có thể cấu hình thêm cho DataGridView
            dgvNguyenLieu.Columns["MaNguyenLieu"].HeaderText = "Mã Nguyên Liệu";
            dgvNguyenLieu.Columns["TenNguyenLieu"].HeaderText = "Tên Nguyên Liệu";
            dgvNguyenLieu.Columns["TenDVT"].HeaderText = "Tên Đơn Vị Tính";
            dgvNguyenLieu.Columns["TenLoaiNguyenLieu"].HeaderText = "Tên Loại Nguyên Liệu";
            dgvNguyenLieu.Columns["TrangThai"].Visible = false;
            dgvNguyenLieu.Columns["SoLuongTon"].Visible = false;

            // Ẩn các cột không cần thiết nếu có
            dgvNguyenLieu.Columns["MaDVT"].Visible = false; // Nếu không cần hiển thị mã DVT
            dgvNguyenLieu.Columns["MaLoaiNguyenLieu"].Visible = false; // Nếu không cần hiển thị mã loại nguyên liệu
        }
        public void LoadDonViTinh()
        {
            // Tạo đối tượng BUS để lấy danh sách đơn vị tính
            QuanLyMonAnBUS busQuanLyMonAn = new QuanLyMonAnBUS();

            // Lấy danh sách đơn vị tính từ BUS
            List<DonViTinhDTO> danhMucDVTList = busQuanLyMonAn.HienThiDanhMucDVT();

            // Gán danh sách đơn vị tính cho ComboBox
            cboDonViTinh.DataSource = danhMucDVTList;
            cboDonViTinh.DisplayMember = "TenDVT";
            cboDonViTinh.ValueMember = "MaDVT";
        }
        private async Task LoadImageToPictureBoxAsync(string imageUrl)
        {
            try
            {
                if (!string.IsNullOrEmpty(imageUrl))
                {
                    using (HttpClient client = new HttpClient())
                    {
                        // Tải ảnh từ URL
                        var imageBytes = await client.GetByteArrayAsync(imageUrl);

                        // Chuyển đổi dữ liệu ảnh thành MemoryStream và hiển thị
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            pbMonAn.Image = Image.FromStream(ms);
                        }
                    }
                }
                else
                {
                    LoadDefaultImage();
                }
            }
            catch
            {
                LoadDefaultImage();
            }
            pbMonAn.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void LoadDefaultImage()
        {
            try
            {
                string defaultImagePath = Path.Combine(Application.StartupPath, @"..\..\Images\themanh.png");
                if (File.Exists(defaultImagePath))
                {
                    pbMonAn.Image = Image.FromFile(defaultImagePath);
                }
                else
                {
                    pbMonAn.Image = null; // Hoặc để PictureBox trống nếu không tìm thấy ảnh dự phòng
                }
            }
            catch
            {
                pbMonAn.Image = null; // Đảm bảo không gây lỗi nếu không tải được ảnh
            }
        }

        private void LoadMonAn(string maMonAn)
        {
            QuanLyMonAnBUS bus = new QuanLyMonAnBUS();
            MonAnDTO monAn = bus.LayThongTinMonAn(maMonAn);

            if (monAn != null)
            {
                txtTenMonAn.Text = monAn.TenMonAn;
                txtGiaMonAn.Text = monAn.GiaMonAn.ToString("N0");

                // Chọn loại món ăn trong ComboBox
                cboLoaiMonAn.SelectedValue = monAn.MaLoai; // Nếu bạn đã thiết lập SelectedValue cho ComboBox với MaLoai
                txtMoTa.Text = monAn.MoTa;
            }
            else
            {
                MessageBox.Show("Không tìm thấy món ăn!");
            }
        }


        private async void btnThemMonAn_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường không được để trống
            if (string.IsNullOrWhiteSpace(txtTenMonAn.Text))
            {
                MessageBox.Show("Tên món ăn không được để trống!");
                txtTenMonAn.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGiaMonAn.Text) || !float.TryParse(txtGiaMonAn.Text, out float giaMonAn) || giaMonAn <= 0)
            {
                MessageBox.Show("Giá món ăn không được để trống và phải lớn hơn 0!");
                txtGiaMonAn.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMoTa.Text))
            {
                MessageBox.Show("Mô tả món ăn không được để trống!");
                txtMoTa.Focus();
                return;
            }

            if (pbMonAn.Image == null)
            {
                MessageBox.Show("Cần chọn 1 hình ảnh!");
                return;
            }

            // Tạo mã món ăn mới
            QuanLyMonAnBUS busQuanLyMonAn = new QuanLyMonAnBUS();
            string maMonAnMoi = busQuanLyMonAn.TaoMaMonAnMoi();
            if (maMonAnMoi == null)
            {
                MessageBox.Show("Không thể tạo mã món ăn mới!");
                return;
            }

            // Xử lý ảnh: lưu ảnh tạm nếu ImageLocation == null
            string imagePath = pbMonAn.ImageLocation ?? Path.GetTempFileName();
            if (pbMonAn.ImageLocation == null)
            {
                pbMonAn.Image.Save(imagePath, System.Drawing.Imaging.ImageFormat.Jpeg);
            }

            // Upload ảnh lên Imgur
            string imgurUrl = "";
            try
            {
                imgurUrl = imgurUploader.UploadImageToImgur(imagePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi upload ảnh: " + ex.Message);
                return;
            }

            // Tạo đối tượng món ăn với URL hình ảnh từ Imgur
            MonAnDTO monAn = new MonAnDTO(
                maMonAnMoi,
                txtTenMonAn.Text,
                giaMonAn,
                imgurUrl, // URL ảnh từ Imgur
                cboLoaiMonAn.SelectedValue.ToString(),
                txtMoTa.Text
            );

            // Gọi phương thức lưu vào cơ sở dữ liệu
            QuanLyMonAnBUS bus = new QuanLyMonAnBUS();
            bool isSuccess = bus.ThemMonAn(monAn);

            if (isSuccess)
            {
                MessageBox.Show("Thêm món ăn thành công!");
                bus.LuuGiaVaoLichSu(monAn.MaMonAn, monAn.GiaMonAn);
                MessageBox.Show("Đã cập nhật lịch sử");
                LoadDanhSachMonAn();
            }
            else
            {
                MessageBox.Show("Thêm món ăn thất bại!");
            }
        }


        private void dgvDanhSachMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra rằng hàng được nhấn là hợp lệ
            {
                // Lấy đường dẫn hình ảnh từ hàng được chọn
                string relativePath = dgvDanhSachMonAn.Rows[e.RowIndex].Cells["HinhAnh"].Value.ToString();
                LoadImageToPictureBoxAsync(relativePath);
                string maMonAn = dgvDanhSachMonAn.Rows[e.RowIndex].Cells["MaMonAn"].Value.ToString();
                string trangThai = dgvDanhSachMonAn.Rows[e.RowIndex].Cells["TrangThai"].Value.ToString();
                if (trangThai == "Còn Bán")
                {
                    btnNgungBan.Enabled = true;
                    btnConBan.Enabled = false;
                }
                else
                {
                    btnNgungBan.Enabled = false;
                    btnConBan.Enabled = true;
                }
                LoadCongThuc(maMonAn);
                LoadMonAn(maMonAn);
            }
        }
        private void LoadCongThuc(string maMonAn)
        {
            QuanLyMonAnBUS busQuanLyCongThuc = new QuanLyMonAnBUS();
            List<CongThucDTO> danhSachCongThuc = busQuanLyCongThuc.HienThiCongThucTheoMonAn(maMonAn);

            // Gán danh sách công thức cho DataGridView
            dgvCongThuc.DataSource = danhSachCongThuc;

            // Cấu hình cột cho DataGridView
            dgvCongThuc.Columns["MaMonAn"].HeaderText = "Mã Món Ăn";
            dgvCongThuc.Columns["MaNguyenLieu"].HeaderText = "Mã Nguyên Liệu";
            dgvCongThuc.Columns["DinhLuong"].HeaderText = "Định Lượng";
            dgvCongThuc.Columns["TenDVT"].HeaderText = "Tên Đơn Vị Tính";
            dgvCongThuc.Columns["TenNguyenLieu"].HeaderText = "Tên Nguyên Liệu"; // Thêm tiêu đề cho tên nguyên liệu

            dgvCongThuc.Columns["MaMonAn"].Visible = false;
            dgvCongThuc.Columns["MaNguyenLieu"].Visible = false;
            dgvCongThuc.Columns["MaDVT"].Visible = false;

            // Đăng ký sự kiện CellFormatting
            dgvCongThuc.CellFormatting += dgvCongThuc_CellFormatting;
        }
        private void dgvCongThuc_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra xem có phải cột DinhLuong
            if (e.ColumnIndex == dgvCongThuc.Columns["DinhLuong"].Index && e.Value != null)
            {
                // Kiểm tra và chuyển đổi giá trị
                if (float.TryParse(e.Value.ToString(), out float dinhLuong))
                {
                    // Định dạng số với 3 chữ số thập phân
                    e.Value = dinhLuong.ToString("N2");
                    e.FormattingApplied = true; // Đánh dấu là đã định dạng
                }
            }
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn món ăn và nguyên liệu chưa
            if (dgvDanhSachMonAn.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn món ăn.");
                return;
            }

            if (dgvNguyenLieu.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu.");
                return;
            }

            // Lấy thông tin từ DataGridView và các điều khiển
            string maMonAn = dgvDanhSachMonAn.CurrentRow.Cells["MaMonAn"].Value.ToString();
            string maNguyenLieu = dgvNguyenLieu.CurrentRow.Cells["MaNguyenLieu"].Value.ToString();
            string maDVT = cboDonViTinh.SelectedValue.ToString();
            float dinhLuong;

            // Kiểm tra và lấy giá trị định lượng từ TextBox
            if (!float.TryParse(txtDinhLuong.Text, out dinhLuong))
            {
                MessageBox.Show("Định lượng không hợp lệ.");
                return;
            }

            // Tạo đối tượng DTO cho công thức
            CongThucDTO congThuc = new CongThucDTO
            {
                MaMonAn = maMonAn,
                MaNguyenLieu = maNguyenLieu,
                MaDVT = maDVT,
                DinhLuong = dinhLuong
            };

            // Gọi BUS để thêm định lượng cho công thức
            QuanLyMonAnBUS busCongThuc = new QuanLyMonAnBUS();
            bool result = busCongThuc.ThemDinhLuongChoCongThuc(congThuc);

            if (result)
            {
                MessageBox.Show("Thêm định lượng thành công!");
                // Cập nhật lại danh sách công thức nếu cần
                LoadCongThuc(maMonAn);
            }
            else
            {
                MessageBox.Show("Thêm định lượng thất bại!");
            }
        }


        private void dgvNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra rằng hàng được nhấn là hợp lệ
            {
                // Lấy thông tin từ hàng được chọn
                DataGridViewRow row = dgvNguyenLieu.Rows[e.RowIndex];

                // Lấy tên nguyên liệu từ cột TenNguyenLieu
                txtTenNguyenLieu.Text = row.Cells["TenNguyenLieu"].Value.ToString();

                // Lấy mã đơn vị tính từ cột MaDVT (hoặc tên nếu bạn đã cấu hình đúng)
                string maDVT = row.Cells["MaDVT"].Value.ToString();

                // Chọn giá trị tương ứng trong cboDonViTinh
                cboDonViTinh.SelectedValue = maDVT;
                btnCapNhat.Enabled = false;
                btnXoa.Enabled = false;
                btnChuyen.Enabled = true;
            }
        }

        private void txtDinhLuong_TextChanged(object sender, EventArgs e)
        {
            // Lưu giá trị hiện tại của TextBox
            string input = txtDinhLuong.Text;

            // Kiểm tra xem có phải là số thực dương hay không
            if (!IsValidNumber(input))
            {
                txtDinhLuong.Text = string.Empty; // Xóa nội dung nếu không hợp lệ
            }
        }

        // Hàm kiểm tra giá trị nhập vào
        private bool IsValidNumber(string input)
        {
            // Kiểm tra nếu chuỗi rỗng
            if (string.IsNullOrWhiteSpace(input))
            {
                return false; // Không hợp lệ nếu chuỗi rỗng
            }

            // Thử chuyển đổi chuỗi thành số thực
            if (float.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out float result))
            {
                return result >= 0; // Hợp lệ nếu là số dương
            }

            return false; // Không hợp lệ nếu không thể chuyển đổi
        }


        private void txtTimKiemNguyenLieu_TextChanged(object sender, EventArgs e)
        {
            // Lấy giá trị từ TextBox
            string searchText = txtTimKiemNguyenLieu.Text;

            QuanLyMonAnBUS busQuanLyMonAn = new QuanLyMonAnBUS();

            // Gọi hàm tìm kiếm nguyên liệu
            DataTable dtNguyenLieu = busQuanLyMonAn.TimKiemNguyenLieu(searchText);

            dgvNguyenLieu.DataSource = dtNguyenLieu;

            // Đảm bảo các cột được hiển thị đúng
            dgvNguyenLieu.Columns["MaNguyenLieu"].HeaderText = "Mã Nguyên Liệu";
            dgvNguyenLieu.Columns["TenNguyenLieu"].HeaderText = "Tên Nguyên Liệu";
            dgvNguyenLieu.Columns["TenDVT"].HeaderText = "Đơn Vị Tính";
            dgvNguyenLieu.Columns["TenLoaiNguyenLieu"].HeaderText = "Loại Nguyên Liệu";
        }

        private void dgvCongThuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu chỉ số dòng hoặc cột là hợp lệ
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Kiểm tra xem có dòng nào được chọn không
                if (dgvCongThuc.SelectedRows.Count > 0)
                {
                    // Lấy dòng được chọn
                    DataGridViewRow selectedNguyenLieuRow = dgvCongThuc.Rows[e.RowIndex];
                    DataGridViewRow selectedMonAnRow = dgvDanhSachMonAn.SelectedRows[0];
                    // Lấy mã nguyên liệu từ dòng đã chọn
                    string maNguyenLieu = selectedNguyenLieuRow.Cells["MaNguyenLieu"].Value.ToString();
                    string maMonAn = selectedMonAnRow.Cells["MaMonAn"].Value.ToString();

                    // Lấy thông tin nguyên liệu từ BUS
                    QuanLyMonAnBUS busQuanLyMonAn = new QuanLyMonAnBUS();
                    CongThucDTO nguyenLieu = busQuanLyMonAn.LayNguyenLieuTheoMaMonAnVaMaNL(maMonAn, maNguyenLieu);

                    if (nguyenLieu != null)
                    {
                        // Hiển thị thông tin lên các ô nhập liệu
                        txtTenNguyenLieu.Text = nguyenLieu.TenNguyenLieu;
                        txtDinhLuong.Text = nguyenLieu.DinhLuong.ToString();

                        // Tìm và chọn đúng đơn vị tính trong ComboBox
                        cboDonViTinh.SelectedValue = nguyenLieu.MaDVT;
                    }
                }
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
                btnChuyen.Enabled = false;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            float temp = float.Parse(txtDinhLuong.Text);
            if (temp == 0)
            {
                MessageBox.Show("Không thể cập nhật thành 0, Hãy ấn nút xóa");
                return;
            }
            // Lấy dòng được chọn từ DataGridView món ăn
            DataGridViewRow selectedMonAnRow = dgvDanhSachMonAn.SelectedRows[0];

            // Lấy dòng được chọn từ DataGridView công thức
            if (dgvCongThuc.SelectedRows.Count > 0) // Kiểm tra nếu có dòng nào được chọn không
            {
                DataGridViewRow selectedNguyenLieuRow = dgvCongThuc.SelectedRows[0]; // Sử dụng SelectedRows thay vì e.RowIndex

                // Khởi tạo đối tượng CongThucDTO và gán giá trị
                CongThucDTO congthuc = new CongThucDTO
                {
                    MaMonAn = selectedMonAnRow.Cells["MaMonAn"].Value.ToString(),
                    MaNguyenLieu = selectedNguyenLieuRow.Cells["MaNguyenLieu"].Value.ToString(),
                    DinhLuong = float.TryParse(txtDinhLuong.Text, out float dinhLuong) ? dinhLuong : 0 // Chuyển đổi và gán giá trị cho DinhLuong
                };

                // Gọi phương thức cập nhật từ BUS
                QuanLyMonAnBUS bus = new QuanLyMonAnBUS();
                bus.UpdateCongThuc(congthuc);
                LoadCongThuc(selectedMonAnRow.Cells["MaMonAn"].Value.ToString());
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nguyên liệu trong công thức để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Lấy dòng được chọn từ DataGridView món ăn
            DataGridViewRow selectedMonAnRow = dgvDanhSachMonAn.SelectedRows[0];
            // Kiểm tra xem có dòng nào được chọn trong dgvCongThuc không
            if (dgvCongThuc.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn từ DataGridView
                DataGridViewRow selectedNguyenLieuRow = dgvCongThuc.SelectedRows[0];

                // Lấy thông tin cần thiết từ dòng được chọn
                string maMonAn = selectedNguyenLieuRow.Cells["MaMonAn"].Value.ToString();
                string maNguyenLieu = selectedNguyenLieuRow.Cells["MaNguyenLieu"].Value.ToString();

                // Hiển thị hộp thoại xác nhận
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa nguyên liệu này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Khởi tạo đối tượng BUS để thực hiện xóa
                    QuanLyMonAnBUS bus = new QuanLyMonAnBUS();
                    bus.DeleteCongThuc(maMonAn, maNguyenLieu);

                    // Cập nhật danh sách công thức và gán lại cho DataGridView
                    var danhSachCongThuc = bus.HienThiCongThucTheoMonAn(maMonAn);
                    dgvCongThuc.DataSource = danhSachCongThuc;

                    // Hiển thị thông báo thành công
                    MessageBox.Show("Nguyên liệu đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCongThuc(selectedMonAnRow.Cells["MaMonAn"].Value.ToString());
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nguyên liệu trong công thức để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTimKiemCongThuc_TextChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedMonAnRow = dgvDanhSachMonAn.SelectedRows[0];
            // Lấy giá trị từ TextBox
            string searchText = txtTimKiemCongThuc.Text;

            QuanLyMonAnBUS busQuanLyMonAn = new QuanLyMonAnBUS();

            // Gọi hàm tìm kiếm nguyên liệu
            DataTable dtCongThuc = busQuanLyMonAn.TimKiemTenNguyenLieuTrongCongThuc(searchText, selectedMonAnRow.Cells["MaMonAn"].Value.ToString());

            dgvCongThuc.DataSource = dtCongThuc;

            // Đảm bảo các cột được hiển thị đúng
            dgvCongThuc.Columns["TenNguyenLieu"].HeaderText = "Tên Nguyên Liệu";
            dgvCongThuc.Columns["TenDVT"].HeaderText = "Đơn Vị Tính";
            dgvCongThuc.Columns["DinhLuong"].HeaderText = "Định Lượng";
        }

        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbMonAn.Image = Image.FromFile(ofd.FileName); // Gán hình ảnh
                    pbMonAn.ImageLocation = ofd.FileName;         // Lưu đường dẫn ảnh
                }
            }
        }

        private void txtGiaMonAn_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu ô nhập liệu rỗng
            if (string.IsNullOrWhiteSpace(txtGiaMonAn.Text))
            {
                return;
            }

            // Thử chuyển đổi nội dung thành số thực
            if (float.TryParse(txtGiaMonAn.Text, out float gia))
            {
                // Kiểm tra nếu giá trị <= 0
                if (gia <= 0)
                {
                    MessageBox.Show("Giá món ăn phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGiaMonAn.Clear(); // Xóa nội dung không hợp lệ
                }
            }
            else
            {
                // Nếu giá trị không thể chuyển đổi thành số
                MessageBox.Show("Vui lòng nhập một số hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaMonAn.Clear(); // Xóa nội dung không hợp lệ
            }
        }

        private void btnNgungBan_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn trong DataGridView không
            if (dgvDanhSachMonAn.SelectedRows.Count > 0)
            {
                // Lấy mã món ăn từ cột "MaMonAn" của dòng được chọn
                string maMonAn = dgvDanhSachMonAn.SelectedRows[0].Cells["MaMonAn"].Value.ToString();
                QuanLyMonAnBUS bus = new QuanLyMonAnBUS();

                // Gọi hàm ngừng bán món ăn từ lớp BUS
                if (bus.NgungBanMonAn(maMonAn))
                {
                    MessageBox.Show("Đã ngừng bán món ăn.");
                    LoadDanhSachMonAn();
                }
                else
                {
                    MessageBox.Show("Không thể ngừng bán món ăn.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một món ăn trong danh sách.");
            }
        }

        private void btnConBan_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn trong DataGridView không
            if (dgvDanhSachMonAn.SelectedRows.Count > 0)
            {
                // Lấy mã món ăn từ cột "MaMonAn" của dòng được chọn
                string maMonAn = dgvDanhSachMonAn.SelectedRows[0].Cells["MaMonAn"].Value.ToString();
                QuanLyMonAnBUS bus = new QuanLyMonAnBUS();

                // Gọi hàm ngừng bán món ăn từ lớp BUS
                if (bus.ConBanMonAn(maMonAn))
                {
                    MessageBox.Show("Món ăn đã được đánh dấu còn bán.");
                    LoadDanhSachMonAn();
                }
                else
                {
                    MessageBox.Show("Không thể đánh dấu món ăn còn bán.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một món ăn trong danh sách.");
            }
        }

        private void txtTimKiemMonAn_TextChanged(object sender, EventArgs e)
        {
            string tenMonAn = txtTimKiemMonAn.Text.Trim();
            string trangThai = cboTimKiemTrangThai.SelectedItem?.ToString();
            QuanLyMonAnBUS bus = new QuanLyMonAnBUS();
            // Gọi phương thức lọc danh sách
            DataTable dt = bus.LocDanhSachMonAn(tenMonAn, trangThai);

            // Hiển thị kết quả trong DataGridView
            dgvDanhSachMonAn.DataSource = dt;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachMonAn.SelectedRows.Count > 0)
            {
                string maMonAn = dgvDanhSachMonAn.CurrentRow.Cells["MaMonAn"].Value.ToString();
                string tenMonAn = txtTenMonAn.Text.Trim();
                string giaMonAnText = txtGiaMonAn.Text.Trim();
                string moTa = txtMoTa.Text.Trim();

                if (string.IsNullOrEmpty(tenMonAn) || string.IsNullOrEmpty(giaMonAnText) || string.IsNullOrEmpty(moTa))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin tên món ăn, giá món ăn và mô tả.");
                    return;
                }

                if (!float.TryParse(giaMonAnText, out float giaMonAn))
                {
                    MessageBox.Show("Giá món ăn phải là số.");
                    return;
                }

                string maLoai = cboLoaiMonAn.SelectedValue.ToString();
                float giaCu = float.Parse(dgvDanhSachMonAn.CurrentRow.Cells["GiaMonAn"].Value.ToString());

                QuanLyMonAnBUS bus = new QuanLyMonAnBUS();

                string originalFileName = dgvDanhSachMonAn.CurrentRow.Cells["HinhAnh"].Value.ToString(); // Lấy tên ảnh cũ từ cơ sở dữ liệu

                // Chỉ lưu hình ảnh nếu người dùng đã chọn ảnh mới
                if (pbMonAn.Image != null && !string.IsNullOrEmpty(pbMonAn.ImageLocation))
                {
                    // Kiểm tra xem ảnh có thay đổi hay không
                    if (!pbMonAn.ImageLocation.EndsWith(originalFileName, StringComparison.OrdinalIgnoreCase))
                    {
                        try
                        {
                            // Upload ảnh mới lên Imgur
                            string newImageUrl = imgurUploader.UploadImageToImgur(pbMonAn.ImageLocation);

                            // Nếu upload thành công, cập nhật URL
                            if (!string.IsNullOrEmpty(newImageUrl))
                            {
                                originalFileName = newImageUrl;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Không thể tải ảnh lên Imgur: " + ex.Message);
                            return;
                        }
                    }
                }

                // Cập nhật món ăn
                if (bus.UpdateMonAn(maMonAn, tenMonAn, giaMonAn, maLoai, moTa, giaCu, originalFileName))
                {
                    MessageBox.Show("Cập nhật thông tin món ăn thành công.");
                    LoadDanhSachMonAn(); // Cập nhật danh sách món ăn
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật thông tin món ăn.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một món ăn để sửa.");
            }
        }
    }
}
