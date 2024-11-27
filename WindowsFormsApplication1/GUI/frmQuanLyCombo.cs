using WindowsFormsApplication1.BUS;
using WindowsFormsApplication1.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.GUI
{
    public partial class frmQuanLyCombo : Form
    {
        ImgurUploader imgurUploader = new ImgurUploader();
        QuanLyComboBUS busQuanLyCombo = new QuanLyComboBUS();
        QuanLyMonAnBUS busQuanLyMonAn = new QuanLyMonAnBUS();
        public frmQuanLyCombo()
        {
            InitializeComponent();
            KiemTraVaCapNhatTrangThai();
        }
        public void KiemTraVaCapNhatTrangThai()
        {
            busQuanLyCombo.KiemTraMonAnTrongCombo();
            LoadDanhSachCombo();
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
        private void frmQuanLyCombo_Load(object sender, EventArgs e)
        {
            LoadDanhSachCombo();
            LoadDanhSachMonAn();
            LoadTrangThaiMonAn();
            LoadTrangThaiComboBox();
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            AutoResizeDataGridView(dgvDanhSachCombo);
            AutoResizeDataGridView(dgvChiTietCombo);
            AutoResizeDataGridView(dgvDanhSachMonAn);
        }
        public void LoadTrangThaiMonAn()
        {
            var trangThaiList = new List<string>
            {
                "Còn Bán",
                "Dừng Bán"
            };
            cboTrangThai.DataSource = trangThaiList;
        }

        private void LoadDanhSachMonAn()
        {

            // Lấy danh sách nguyên liệu từ BUS
            List<MonAnDTO> danhSachMonAn = busQuanLyMonAn.HienThiDanhSachMonAn();

            // Gán danh sách nguyên liệu cho DataGridView
            dgvDanhSachMonAn.DataSource = danhSachMonAn;

            // Ẩn các cột không cần thiết nếu có
            dgvDanhSachMonAn.Columns["MaMonAn"].Visible = false;
            dgvDanhSachMonAn.Columns["GiaMonAn"].Visible = false;
            dgvDanhSachMonAn.Columns["HinhAnh"].Visible = false;
            dgvDanhSachMonAn.Columns["MaLoai"].Visible = false;
            dgvDanhSachMonAn.Columns["TenLoai"].Visible = false;
            dgvDanhSachMonAn.Columns["MoTa"].Visible = false;
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

        public void LoadDanhSachCombo()
        {
            // Tạo đối tượng BUS để lấy danh sách món ăn


            // Lấy danh sách món ăn từ BUS
            List<ComboDTO> danhSachMonAn = busQuanLyCombo.HienThiDanhSachCombo();

            // Gán danh sách món ăn cho DataGridView
            dgvDanhSachCombo.DataSource = danhSachMonAn;

            // Nếu cần thiết, bạn có thể cấu hình thêm cho DataGridView
            dgvDanhSachCombo.Columns["MaCombo"].HeaderText = "Mã Combo";
            dgvDanhSachCombo.Columns["TenCombo"].HeaderText = "Tên Combo";
            dgvDanhSachCombo.Columns["GiaCombo"].HeaderText = "Giá Combo (VNĐ)";
            dgvDanhSachCombo.Columns["TrangThai"].HeaderText = "Trạng Thái";

            dgvDanhSachCombo.Columns["GiaCombo"].DefaultCellStyle.Format = "N0";
            // Ẩn các cột không cần thiết
            dgvDanhSachCombo.Columns["HinhAnh"].Visible = false;
            dgvDanhSachCombo.Columns["MoTa"].Visible = false;

            btnNgungBan.Enabled = false;
            btnConBan.Enabled = false;
        }

        private void txtTimKiemMonAn_TextChanged(object sender, EventArgs e)
        {
            string tenCombo = txtTimKiemCombo.Text.Trim();
            string trangThai = cboTimKiemTrangThai.SelectedItem?.ToString();
            // Gọi phương thức lọc danh sách
            DataTable dt = busQuanLyCombo.LocDanhSachCombo(tenCombo, trangThai);

            // Hiển thị kết quả trong DataGridView
            dgvDanhSachCombo.DataSource = dt;
        }

        private void txtTimMonAn_TextChanged(object sender, EventArgs e)
        {
            string tenMonAn = txtTimMonAn.Text.Trim();
            string trangThai = null;
            // Gọi phương thức lọc danh sách
            DataTable dt = busQuanLyMonAn.LocDanhSachMonAn(tenMonAn, trangThai);

            // Hiển thị kết quả trong DataGridView
            dgvDanhSachMonAn.DataSource = dt;
        }

        private void dgvDanhSachCombo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra rằng hàng được nhấn là hợp lệ
            {
                // Lấy đường dẫn hình ảnh hoặc URL từ hàng được chọn
                string imagePathOrUrl = dgvDanhSachCombo.Rows[e.RowIndex].Cells["HinhAnh"].Value.ToString();
                LoadImageToPictureBoxAsync(imagePathOrUrl);

                string maCombo = dgvDanhSachCombo.Rows[e.RowIndex].Cells["MaCombo"].Value.ToString();
                string trangThai = dgvDanhSachCombo.Rows[e.RowIndex].Cells["TrangThai"].Value.ToString();

                // Cập nhật trạng thái nút
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

                LoadChiTietCombo(maCombo);
                LoadCombo(maCombo);
            }
        }


        private void LoadCombo(string maCombo)
        {
            ComboDTO comBo = busQuanLyCombo.LayThongTinCombo(maCombo);

            if (comBo != null)
            {
                txtTenCombo.Text = comBo.TenCombo;
                txtGiaCombo.Text = comBo.GiaCombo.ToString("N0");

                // Chọn loại món ăn trong ComboBox
                txtMoTa.Text = comBo.MoTa;
            }
            else
            {
                MessageBox.Show("Không tìm thấy combo!");
            }
        }
        private void LoadChiTietCombo(string maMonAn)
        {
            List<ChiTietComboDTO> danhSachMonAn = busQuanLyCombo.HienThiMonAnMonAnTheoCombo(maMonAn);

            // Gán danh sách công thức cho DataGridView
            dgvChiTietCombo.DataSource = danhSachMonAn;

            // Cấu hình cột cho DataGridView
            dgvChiTietCombo.Columns["MaCombo"].Visible = false;
            dgvChiTietCombo.Columns["MaMonAn"].Visible = false;
            dgvChiTietCombo.Columns["TenMonAn"].HeaderText = "Tên Món Ăn";
            dgvChiTietCombo.Columns["SoLuong"].HeaderText = "Số Lượng";
            dgvChiTietCombo.Columns["TrangThai"].HeaderText = "Trạng Thái";


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
                            pbCombo.Image = Image.FromStream(ms);
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
            pbCombo.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void LoadDefaultImage()
        {
            try
            {
                string defaultImagePath = Path.Combine(Application.StartupPath, @"..\..\Images\themanh.png");
                if (File.Exists(defaultImagePath))
                {
                    pbCombo.Image = Image.FromFile(defaultImagePath);
                }
                else
                {
                    pbCombo.Image = null; // Hoặc để PictureBox trống nếu không tìm thấy ảnh dự phòng
                }
            }
            catch
            {
                pbCombo.Image = null; // Đảm bảo không gây lỗi nếu không tải được ảnh
            }
        }

        private void txtTimKiemChiTietCombo_TextChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedMonAnRow = dgvDanhSachCombo.SelectedRows[0];
            //Lấy giá trị từ TextBox
            string searchText = txtTimKiemChiTietCombo.Text;

            //Gọi hàm tìm kiếm nguyên liệu
            DataTable dtCongThuc = busQuanLyCombo.TimKiemMonAnTrongChiTietCombo(searchText, selectedMonAnRow.Cells["MaCombo"].Value.ToString());

            dgvChiTietCombo.DataSource = dtCongThuc;

            //Đảm bảo các cột được hiển thị đúng
            dgvChiTietCombo.Columns["MaCombo"].Visible = false;
            dgvChiTietCombo.Columns["MaMonAn"].Visible = false;
            dgvChiTietCombo.Columns["TenMonAn"].HeaderText = "Tên Món Ăn";
            dgvChiTietCombo.Columns["SoLuong"].HeaderText = "Số Lượng";
            dgvChiTietCombo.Columns["TrangThai"].HeaderText = "Trạng Thái";
        }

        private void dgvChiTietCombo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu chỉ số dòng hoặc cột là hợp lệ
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Kiểm tra xem có dòng nào được chọn không
                if (dgvChiTietCombo.SelectedRows.Count > 0)
                {

                    // Lấy dòng được chọn
                    DataGridViewRow selectedMonAnRow = dgvChiTietCombo.Rows[e.RowIndex];
                    DataGridViewRow selectedComboRow = dgvDanhSachCombo.SelectedRows[0];
                    // Lấy mã nguyên liệu từ dòng đã chọn
                    string maMonAn = selectedMonAnRow.Cells["MaMonAn"].Value.ToString();
                    string maCombo = selectedComboRow.Cells["MaCombo"].Value.ToString();

                    // Lấy thông tin nguyên liệu từ BUS
                    ChiTietComboDTO monAn = busQuanLyCombo.LayMonAnTheoMaMonAnVaMaCombo(maCombo, maMonAn);

                    if (monAn != null)
                    {
                        // Hiển thị thông tin lên các ô nhập liệu
                        txtTenMonAn.Text = monAn.TenMonAn;
                        txtSoLuong.Text = monAn.SoLuong.ToString();

                        // Tìm và chọn đúng đơn vị tính trong ComboBox
                        cboTrangThai.SelectedItem = monAn.TrangThai;
                    }
                }
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
                btnChuyen.Enabled = false;
            }
        }
        private bool KiemTraSoLuongNguyen()
        {
            // Kiểm tra giá trị nhập vào có phải số nguyên hay không
            if (int.TryParse(txtSoLuong.Text, out _))
            {
                return true; // Là số nguyên
            }
            else
            {

                return false; // Không phải số nguyên
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!KiemTraSoLuongNguyen())
            {
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int temp = int.Parse(txtSoLuong.Text);
            if (temp == 0)
            {
                MessageBox.Show("Không thể cập nhật thành 0, Hãy ấn nút xóa");
                return;
            }
            // Lấy dòng được chọn từ DataGridView món ăn
            DataGridViewRow selectedComboRow = dgvDanhSachCombo.SelectedRows[0];

            // Lấy dòng được chọn từ DataGridView chi tiết
            if (dgvChiTietCombo.SelectedRows.Count > 0) // Kiểm tra nếu có dòng nào được chọn không
            {
                DataGridViewRow selectedMonAnRow = dgvChiTietCombo.SelectedRows[0]; // Sử dụng SelectedRows thay vì e.RowIndex

                // Khởi tạo đối tượng CongThucDTO và gán giá trị
                ChiTietComboDTO chiTietCombo = new ChiTietComboDTO
                {
                    MaCombo = selectedComboRow.Cells["MaCombo"].Value.ToString(),
                    MaMonAn = selectedMonAnRow.Cells["MaMonAn"].Value.ToString(),
                    SoLuong = int.TryParse(txtSoLuong.Text, out int dinhLuong) ? dinhLuong : 0 // Chuyển đổi và gán giá trị cho DinhLuong
                };
                busQuanLyCombo.UpdateChiTietCombo(chiTietCombo);
                LoadChiTietCombo(selectedComboRow.Cells["MaCombo"].Value.ToString());
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một món ăn trong chi tiết combo để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Lấy dòng được chọn từ DataGridView combo
            DataGridViewRow selectedComboRow = dgvDanhSachCombo.SelectedRows[0];
            // Kiểm tra xem có dòng nào được chọn trong dgvCongThuc không
            if (dgvChiTietCombo.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn từ DataGridView
                DataGridViewRow selectedMonAnRow = dgvChiTietCombo.SelectedRows[0];

                // Lấy thông tin cần thiết từ dòng được chọn
                string maCombo = selectedComboRow.Cells["MaComBo"].Value.ToString();
                string maMonAn = selectedMonAnRow.Cells["MaMonAn"].Value.ToString();

                // Hiển thị hộp thoại xác nhận
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa món ăn này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    busQuanLyCombo.DeleteChiTietCombo(maCombo, maMonAn);

                    // Hiển thị thông báo thành công
                    MessageBox.Show("Món ăn đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadChiTietCombo(selectedComboRow.Cells["MaCombo"].Value.ToString());
                    txtTimKiemChiTietCombo.Clear();
                    KiemTraVaCapNhatTrangThai();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nguyên liệu trong công thức để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn món ăn và nguyên liệu chưa
            if (dgvDanhSachCombo.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn combo.");
                return;
            }

            if (dgvDanhSachMonAn.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn món ăn.");
                return;
            }

            // Lấy thông tin từ DataGridView và các điều khiển
            string maCombo = dgvDanhSachCombo.CurrentRow.Cells["MaCombo"].Value.ToString();
            string maMonAn = dgvDanhSachMonAn.CurrentRow.Cells["MaMonAn"].Value.ToString();
            if (!KiemTraSoLuongNguyen())
            {
                MessageBox.Show("Số lượng không hợp lệ.");
                return;
            }
            int soLuong = int.Parse(txtSoLuong.Text);
            if (soLuong == 0)
            {
                MessageBox.Show("Không thể cập nhật thành 0, Hãy ấn nút xóa");
                return;
            }

            // Tạo đối tượng DTO cho công thức
            ChiTietComboDTO chiTietCombo = new ChiTietComboDTO
            {
                MaCombo = maCombo,
                MaMonAn = maMonAn,
                SoLuong = soLuong
            };

            // Gọi BUS để thêm định lượng cho công thức
            bool result = busQuanLyCombo.ThemMonAnChoChiTietCombo(chiTietCombo);

            if (result)
            {
                MessageBox.Show("Thêm món ăn thành công!");
                // Cập nhật lại danh sách công thức nếu cần
                LoadChiTietCombo(maCombo);
                txtSoLuong.Clear();
                KiemTraVaCapNhatTrangThai();
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
                // Lấy thông tin từ hàng được chọn
                DataGridViewRow row = dgvDanhSachMonAn.Rows[e.RowIndex];

                // Lấy tên nguyên liệu từ cột TenNguyenLieu
                txtTenMonAn.Text = row.Cells["TenMonAn"].Value.ToString();
                cboTrangThai.SelectedItem = row.Cells["TrangThai"].Value.ToString();

                btnCapNhat.Enabled = false;
                btnXoa.Enabled = false;
                btnChuyen.Enabled = true;
            }
        }

        private void btnFileURL_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbCombo.Image = Image.FromFile(ofd.FileName); // Gán hình ảnh
                    pbCombo.ImageLocation = ofd.FileName;         // Lưu đường dẫn ảnh
                }
            }
        }

        private void btnConBan_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn trong DataGridView không
            if (dgvDanhSachCombo.SelectedRows.Count > 0)
            {
                // Lấy mã combo từ dòng đã chọn
                string maCombo = dgvDanhSachCombo.CurrentRow.Cells["MaCombo"].Value.ToString();


                // Kiểm tra và cập nhật trạng thái combo
                bool isUpdated = busQuanLyCombo.CapNhatTrangThaiComboConBan(maCombo);

                if (isUpdated)
                {
                    // Thông báo cập nhật thành công
                    MessageBox.Show("Cập nhật trạng thái combo thành công.");
                    LoadDanhSachCombo(); // Tải lại danh sách combo
                }
                else
                {
                    // Thông báo nếu có món ăn đang ngừng bán trong combo
                    MessageBox.Show("Không thể cập nhật trạng thái thành 'Còn Bán'! Có món ăn đang 'Ngừng Bán'.");
                }
            }
            else
            {
                // Thông báo nếu người dùng chưa chọn combo
                MessageBox.Show("Vui lòng chọn một combo trong danh sách.");
            }
        }

        private void btnNgungBan_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn trong DataGridView không
            if (dgvDanhSachCombo.SelectedRows.Count > 0)
            {
                // Lấy mã combo từ dòng đã chọn
                string maCombo = dgvDanhSachCombo.CurrentRow.Cells["MaCombo"].Value.ToString();


                // Kiểm tra và cập nhật trạng thái combo
                bool isUpdated = busQuanLyCombo.CapNhatTrangThaiComboNgungBan(maCombo);

                if (isUpdated)
                {
                    // Thông báo cập nhật thành công
                    MessageBox.Show("Cập nhật trạng thái combo thành công.");
                    LoadDanhSachCombo(); // Tải lại danh sách combo
                }
            }
            else
            {
                // Thông báo nếu người dùng chưa chọn combo
                MessageBox.Show("Vui lòng chọn một combo trong danh sách.");
            }
        }

        private void btnThemCombo_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường không được để trống
            if (string.IsNullOrWhiteSpace(txtTenCombo.Text))
            {
                MessageBox.Show("Tên combo không được để trống!");
                txtTenCombo.Focus(); // Đặt tiêu điểm vào trường này
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGiaCombo.Text) || !float.TryParse(txtGiaCombo.Text, out float giaCombo) || giaCombo <= 0)
            {
                MessageBox.Show("Giá combo không được để trống và phải lớn hơn 0!");
                txtGiaCombo.Focus(); // Đặt tiêu điểm vào trường này
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMoTa.Text))
            {
                MessageBox.Show("Mô tả combo không được để trống!");
                txtMoTa.Focus(); // Đặt tiêu điểm vào trường này
                return;
            }

            if (pbCombo.Image == null)
            {
                MessageBox.Show("Cần chọn 1 hình ảnh");
                return;
            }

            // Tạo mã combo mới
            string maComboMoi = busQuanLyCombo.TaoMaComboMoi();
            if (maComboMoi == null)
            {
                MessageBox.Show("Không thể tạo mã combo mới!");
                return;
            }

            // Upload ảnh lên Imgur
            string imgurUrl = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(pbCombo.ImageLocation))
                {
                    imgurUrl = imgurUploader.UploadImageToImgur(pbCombo.ImageLocation);
                }
                else
                {
                    // Lưu ảnh tạm nếu ImageLocation không được thiết lập
                    string tempImagePath = Path.Combine(Path.GetTempPath(), "temp_image.png");
                    pbCombo.Image.Save(tempImagePath);
                    imgurUrl = imgurUploader.UploadImageToImgur(tempImagePath);
                }

                if (string.IsNullOrEmpty(imgurUrl))
                {
                    MessageBox.Show("Không thể tải ảnh lên Imgur.");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải ảnh lên Imgur: " + ex.Message);
                return;
            }

            // Tạo đối tượng ComboDTO
            ComboDTO combo = new ComboDTO(maComboMoi, txtTenCombo.Text, giaCombo, imgurUrl, txtMoTa.Text, "Ngừng Bán");

            // Gọi phương thức thêm combo
            bool isSuccess = busQuanLyCombo.ThemCombo(combo);

            if (isSuccess)
            {
                MessageBox.Show("Thêm combo thành công!");
                busQuanLyMonAn.LuuGiaVaoLichSu(combo.MaCombo, combo.GiaCombo);
                MessageBox.Show("Đã cập nhật lịch sử");
                LoadDanhSachCombo();
            }
            else
            {
                MessageBox.Show("Thêm combo thất bại!");
            }
        }

        private void btnSuaCombo_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachCombo.SelectedRows.Count > 0)
            {
                // Lấy thông tin từ dòng đã chọn
                string maCombo = dgvDanhSachCombo.CurrentRow.Cells["MaCombo"].Value.ToString();
                string tenCombo = txtTenCombo.Text.Trim();
                string giaComboText = txtGiaCombo.Text.Trim();
                string moTa = txtMoTa.Text.Trim();

                // Kiểm tra xem giá có phải là số và không null
                if (string.IsNullOrEmpty(tenCombo) || string.IsNullOrEmpty(giaComboText) || string.IsNullOrEmpty(moTa))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin tên combo, giá combo và mô tả.");
                    return; // Kết thúc phương thức nếu điều kiện không thỏa mãn
                }

                // Chuyển đổi giá từ chuỗi sang số thực
                if (!float.TryParse(giaComboText, out float giaCombo) || giaCombo <= 0)
                {
                    MessageBox.Show("Giá combo phải là số lớn hơn 0.");
                    return; // Kết thúc phương thức nếu giá không hợp lệ
                }

                // Lấy giá cũ từ DataGridView
                float giaCu = float.Parse(dgvDanhSachCombo.CurrentRow.Cells["GiaCombo"].Value.ToString());

                // Lấy đường dẫn hiện tại của ảnh từ cơ sở dữ liệu
                string currentImageUrl = dgvDanhSachCombo.CurrentRow.Cells["HinhAnh"].Value.ToString();

                string updatedImageUrl = currentImageUrl; // Mặc định giữ nguyên URL cũ
                try
                {
                    // Nếu có ảnh mới được chọn
                    if (pbCombo.Image != null && !string.IsNullOrEmpty(pbCombo.ImageLocation))
                    {
                        // Kiểm tra xem ảnh có thay đổi không
                        if (!pbCombo.ImageLocation.EndsWith(currentImageUrl, StringComparison.OrdinalIgnoreCase))
                        {
                            // Upload ảnh mới lên Imgur
                            updatedImageUrl = imgurUploader.UploadImageToImgur(pbCombo.ImageLocation);

                            // Kiểm tra xem ảnh đã upload thành công hay chưa
                            if (string.IsNullOrEmpty(updatedImageUrl))
                            {
                                MessageBox.Show("Không thể tải ảnh mới lên Imgur.");
                                return;
                            }
                        }
                    }

                    // Gọi phương thức cập nhật trong lớp BUS
                    if (busQuanLyCombo.UpdateCombo(maCombo, tenCombo, giaCombo, moTa, giaCu, updatedImageUrl))
                    {
                        MessageBox.Show("Cập nhật thông tin combo thành công.");
                        // Cập nhật lại danh sách combo
                        LoadDanhSachCombo();
                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật thông tin combo.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật combo: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một combo để sửa.");
            }
        }

    }
}
