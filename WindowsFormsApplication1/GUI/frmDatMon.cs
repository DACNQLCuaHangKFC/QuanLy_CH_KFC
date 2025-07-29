using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApplication1.BUS;
using WindowsFormsApplication1.DTO;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApplication1.GUI;

namespace WindowsFormsApplication1
{
    public partial class frmDatMon : Form
    {
        GoiMonBUS busGoiMon = new GoiMonBUS();
        HoaDonBUS busHoaDon = new HoaDonBUS();
        KhachHangBUS busKhachHang = new KhachHangBUS();
        private List<KhachHangDTO> danhSachKhachHangGoc;
        private string maNV;
        public frmDatMon(string maNV)
        {
            InitializeComponent();
            btnInHoaDon.Enabled = false;
            this.maNV = maNV;
        }

        private void frmDatMon_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
            SetToDefault();
            AutoResizeDataGridView(dgvChonMon);
            AutoResizeDataGridView(dgvDanhSachMonChon);
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
        private void SetToDefault()
        {
            lblTotalMoney.Text = "0";
            txtThanhTien.Clear();
            cboKhachHang.SelectedIndex = 0;
            chkSuDung.Checked = false;
            chkChuyenKhoan.Checked = false;
        }
        private void LoadcboLoaiMon()
        {
            // Xóa các mục cũ (nếu có)
            cboLoaiMon.Items.Clear();

            // Thêm các mục mới
            cboLoaiMon.Items.Add("Tất Cả");
            cboLoaiMon.Items.Add("Món Ăn");
            cboLoaiMon.Items.Add("Combo");

            // Đặt giá trị mặc định (nếu cần)
            cboLoaiMon.SelectedIndex = 0; // Chọn "Món Ăn" làm giá trị mặc định
        }

        private void LoadDuLieu()
        {
            LoadcboLoaiMon();
            LoadMaKhuyenMaiConHan();
            LoadDanhSachMonAnConBan();
            LoadCotdgvDanhSachMonChon();
            LoadCboKhachHang();

        }
        private void LoadMaKhuyenMaiConHan()
        {
            var danhSachKhuyenMai = busGoiMon.GetAllKhuyenMaiConHan();
            cboMaKhuyenMai.DataSource = danhSachKhuyenMai;
            cboMaKhuyenMai.DisplayMember = "TenKhuyenMai";  // Hiển thị tên khuyến mãi
            cboMaKhuyenMai.ValueMember = "MaKhuyenMai";     // Giá trị là mã khuyến mãi
        }
        private void LoadCboKhachHang()
        {
            // Tạo một danh sách mới để chứa tất cả các khách hàng, bao gồm 'Khách Vãng Lai'
            List<KhachHangDTO> danhSachKhachHang = new List<KhachHangDTO>();
            danhSachKhachHangGoc = busGoiMon.LayTatCaKhachHang();

            // Kiểm tra nếu danhSachKhachHangGoc là null hoặc rỗng
            if (danhSachKhachHangGoc != null && danhSachKhachHangGoc.Any())
            {
                // Lấy tất cả khách hàng từ database và thêm vào danh sách
                danhSachKhachHang.AddRange(danhSachKhachHangGoc.Select(kh => new KhachHangDTO
                {
                    SoDienThoai = kh.SoDienThoai,
                    TenKhachHang = kh.TenKhachHang,
                }));
            }
            else
            {
                // Nếu danhSachKhachHangGoc là null hoặc rỗng, có thể thông báo lỗi hoặc xử lý trường hợp này
                MessageBox.Show("Danh sách khách hàng không có dữ liệu.");
            }

            // Gán lại DataSource cho ComboBox
            cboKhachHang.DataSource = danhSachKhachHang;
            cboKhachHang.DisplayMember = "TenKhachHang";  // Hiển thị tên khách hàng trong ComboBox
            cboKhachHang.ValueMember = "SoDienThoai";    // Dùng số điện thoại làm giá trị của ComboBox

            // Chọn dòng đầu tiên mặc định
            if (danhSachKhachHang.Any())
            {
                cboKhachHang.SelectedIndex = 0; // Nếu có dữ liệu, chọn dòng đầu tiên
            }
        }

        private void LoadCotdgvDanhSachMonChon()
        {
            // Thiết lập cột cho dgvDanhSachMonChon
            dgvDanhSachMonChon.Columns.Add("MaMonAn", "Mã Món Ăn");
            dgvDanhSachMonChon.Columns.Add("TenMonAn", "Tên Món Ăn");
            dgvDanhSachMonChon.Columns.Add("GiaMonAn", "Giá Món Ăn\n(VNĐ)");
            dgvDanhSachMonChon.Columns.Add("SoLuong", "Số Lượng");
            dgvDanhSachMonChon.Columns["MaMonAn"].Visible = false;

            dgvChonMon.Columns["GiaMonAn"].DefaultCellStyle.Format = "N0";
        }
        private void LoadDanhSachMonAnConBan()
        {
            // Lấy dữ liệu từ DataTable (chứa cả món ăn và combo)
            DataTable dtMonAnCombo = busGoiMon.LayDanhSachMonAnConBan(); // Lấy dữ liệu từ database

            // Kiểm tra nếu DataTable là null hoặc không có dữ liệu
            if (dtMonAnCombo == null || dtMonAnCombo.Rows.Count == 0)
            {
                MessageBox.Show("Không có món ăn hoặc combo nào.");
                return;
            }

            // Kiểm tra lựa chọn từ cboLoaiMon
            string selectedType = cboLoaiMon.SelectedItem.ToString();

            // Lọc dữ liệu tùy theo lựa chọn
            DataView dvFiltered = new DataView(dtMonAnCombo);

            if (selectedType == "Tất Cả")
            {
                // Nếu chọn "Tất cả", hiển thị cả món ăn và combo
                dgvChonMon.DataSource = dvFiltered;
            }
            else if (selectedType == "Món Ăn")
            {
                // Nếu chọn "Món Ăn", chỉ hiển thị những món có mã món bắt đầu bằng "MA"
                dvFiltered.RowFilter = "MaMonAn LIKE 'MA%'"; // Lọc mã món ăn bắt đầu bằng "MA"
                dgvChonMon.DataSource = dvFiltered;
            }
            else if (selectedType == "Combo")
            {
                // Nếu chọn "Combo", chỉ hiển thị những combo có mã món bắt đầu bằng "CB"
                dvFiltered.RowFilter = "MaMonAn LIKE 'CB%'"; // Lọc mã combo bắt đầu bằng "CB"
                dgvChonMon.DataSource = dvFiltered;
            }

            // Cập nhật các header column cho dgvChonMon
            dgvChonMon.Columns["SoLuongCoTheBan"].HeaderText = "Số lượng có thể bán";
            dgvChonMon.Columns["MaMonAn"].HeaderText = "Mã Món Ăn";
            dgvChonMon.Columns["TenMonAn"].HeaderText = "Tên Món Ăn";
            dgvChonMon.Columns["GiaMonAn"].HeaderText = "Giá Món Ăn\n(VNĐ)";

            // Ẩn các cột không cần thiết (nếu có)
            dgvChonMon.Columns["HinhAnh"].Visible = false;
            dgvChonMon.Columns["MoTa"].Visible = false;
            dgvChonMon.Columns["MaMonAn"].Visible = false;
            // Cập nhật định dạng giá tiền cho cột "GiaMonAn"
            dgvChonMon.Columns["GiaMonAn"].DefaultCellStyle.Format = "N0";
        }

        private void txtTimMonAn_TextChanged(object sender, EventArgs e)
        {
            string tenMonAn = txtTimMonAn.Text.Trim();
            DataTable dtMonAn = busGoiMon.TimKiemMonAn(tenMonAn);

            dgvChonMon.DataSource = dtMonAn;

            // Đặt lại các thuộc tính hiển thị cho DataGridView nếu cần
            dgvChonMon.Columns["MaMonAn"].HeaderText = "Mã Món Ăn";
            dgvChonMon.Columns["TenMonAn"].HeaderText = "Tên Món Ăn";
            dgvChonMon.Columns["GiaMonAn"].HeaderText = "Giá Món Ăn\n(VNĐ)";
            dgvChonMon.Columns["HinhAnh"].HeaderText = "Hình Ảnh";
            dgvChonMon.Columns["MoTa"].HeaderText = "Mô Tả";
            dgvChonMon.Columns["SoLuongCoTheBan"].HeaderText = "Số lượng có thể bán";

            dgvChonMon.Columns["GiaMonAn"].DefaultCellStyle.Format = "N0";
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (dgvChonMon.SelectedRows.Count > 0)
            {
                // Lấy thông tin món ăn từ dòng đã chọn
                string maMonAn = dgvChonMon.SelectedRows[0].Cells["MaMonAn"].Value.ToString();
                string tenMonAn = dgvChonMon.SelectedRows[0].Cells["TenMonAn"].Value.ToString();
                float giaMonAn = Convert.ToSingle(dgvChonMon.SelectedRows[0].Cells["GiaMonAn"].Value);
                int soLuongCoTheBan = Convert.ToInt32(dgvChonMon.SelectedRows[0].Cells["SoLuongCoTheBan"].Value);

                // Lấy số lượng từ txtSoLuong
                if (int.TryParse(txtSoLuong.Text, out int soLuong) && soLuong > 0)
                {
                    // Kiểm tra số lượng có lớn hơn số lượng có thể bán không
                    if (soLuong > soLuongCoTheBan)
                    {
                        MessageBox.Show("Số lượng không thể lớn hơn số lượng có thể bán.");
                        return;
                    }

                    // Kiểm tra xem món ăn đã tồn tại trong dgvDanhSachMonChon hay chưa
                    bool monAnDaTonTai = false;
                    foreach (DataGridViewRow row in dgvDanhSachMonChon.Rows)
                    {
                        // Kiểm tra xem ô có giá trị null hay không
                        if (row.Cells["MaMonAn"].Value != null && row.Cells["MaMonAn"].Value.ToString() == maMonAn)
                        {
                            // Nếu đã tồn tại, cộng thêm số lượng
                            int soLuongHienTai = Convert.ToInt32(row.Cells["SoLuong"].Value);
                            if (soLuongHienTai + soLuong > soLuongCoTheBan)
                            {
                                MessageBox.Show("Số lượng không thể lớn hơn số lượng có thể bán.");
                                return;
                            }
                            row.Cells["SoLuong"].Value = soLuongHienTai + soLuong;
                            monAnDaTonTai = true;
                            break;
                        }
                    }

                    // Nếu món ăn chưa tồn tại, thêm mới
                    if (!monAnDaTonTai)
                    {
                        int index = dgvDanhSachMonChon.Rows.Add();
                        dgvDanhSachMonChon.Rows[index].Cells["MaMonAn"].Value = maMonAn;
                        dgvDanhSachMonChon.Rows[index].Cells["TenMonAn"].Value = tenMonAn;
                        dgvDanhSachMonChon.Rows[index].Cells["GiaMonAn"].Value = giaMonAn;
                        dgvDanhSachMonChon.Rows[index].Cells["SoLuong"].Value = soLuong; // Thêm số lượng
                        dgvDanhSachMonChon.Columns["GiaMonAn"].DefaultCellStyle.Format = "N0";
                    }
                    // Cập nhật tổng tiền
                    UpdateTotalMoney();
                    txtSoLuong.Clear();
                    //trừ đi nguyên liệu
                    try
                    {
                        // Gọi phương thức trong BUS để trừ nguyên liệu
                        busGoiMon.TruNguyenLieu(maMonAn, soLuong);
                        LoadDanhSachMonAnConBan();
                        txtSoLuong.Focus();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số lượng hợp lệ.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn món ăn để thêm.");
            }
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn hay không
            if (dgvDanhSachMonChon.SelectedRows.Count > 0)
            {
                // Lấy dòng đã chọn
                DataGridViewRow selectedRow = dgvDanhSachMonChon.SelectedRows[0];
                string maMonAn = dgvDanhSachMonChon.SelectedRows[0].Cells["MaMonAn"].Value.ToString();
                int soLuong = int.Parse(dgvDanhSachMonChon.SelectedRows[0].Cells["SoLuong"].Value.ToString());
                // Xóa dòng đã chọn
                dgvDanhSachMonChon.Rows.Remove(selectedRow);

                // Hiển thị thông báo thành công
                MessageBox.Show("Đã xóa món ăn khỏi danh sách.");
                UpdateTotalMoney();

                //thêm lại nguyên liệu
                try
                {
                    // Gọi phương thức trong BUS để thêm nguyên liệu
                    busGoiMon.ThemNguyenLieuKhiBoChon(maMonAn, soLuong);
                    //MessageBox.Show("Đã thêm lại nguyên liệu thành công.");
                    LoadDanhSachMonAnConBan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
                }
            }
            else
            {
                // Nếu không có dòng nào được chọn, hiển thị thông báo
                MessageBox.Show("Vui lòng chọn món ăn để xóa.");
            }
        }
        // Phương thức để cập nhật tổng tiền
        private void UpdateTotalMoney()
        {
            decimal totalMoney = 0;

            // Tính tổng tiền từ danh sách món ăn đã chọn
            foreach (DataGridViewRow row in dgvDanhSachMonChon.Rows)
            {
                if (row.Cells["GiaMonAn"].Value != null && row.Cells["SoLuong"].Value != null)
                {
                    decimal price = Convert.ToDecimal(row.Cells["GiaMonAn"].Value);
                    int quantity = Convert.ToInt32(row.Cells["SoLuong"].Value);
                    totalMoney += price * quantity;
                }
            }

            // Hiển thị tổng tiền chưa có khuyến mãi
            txtThanhTien.Text = totalMoney.ToString("N0");

            // Tính VAT (10%)
            decimal vat = totalMoney * 10 / 100;
            txtVAT.Text = vat.ToString("N0");

            // Xử lý điểm thân thiết nếu có
            decimal diemthanthiet = 0;
            if (chkSuDung.Checked == true)
            {
                diemthanthiet = decimal.Parse(lblSoDiem.Text.ToString());
            }
            else
            {
                diemthanthiet = 0;
            }

            decimal discountPercent = 0;

            // Loại bỏ dấu phần trăm và chuyển đổi thành decimal
            string discountText = txtGiamGia.Text.Replace("%", "").Trim();
            if (decimal.TryParse(discountText, out discountPercent))
            {
                // Kiểm tra xem phần trăm có hợp lệ không
                if (discountPercent > 0 && discountPercent <= 100)
                {
                    decimal discountAmount = totalMoney * (discountPercent / 100); // Tính số tiền giảm
                    totalMoney -= discountAmount; // Giảm số tiền tổng
                }
            }

            // Tính tổng tiền sau khi áp dụng khuyến mãi, VAT, và điểm thân thiết
            lblTotalMoney.Text = (totalMoney + vat - diemthanthiet).ToString("N0"); // Cập nhật lblTotalMoney
        }



        private void cboKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu SelectedValue không phải null và SelectedIndex hợp lệ
            if (cboKhachHang.SelectedIndex != -1 && cboKhachHang.SelectedValue != null)
            {
                string soDienThoai = cboKhachHang.SelectedValue.ToString();

                // Lấy thông tin khách hàng dựa trên số điện thoại
                KhachHangDTO khachHang = busGoiMon.LayThongTinKhachHang(soDienThoai);

                // Gán thông tin vào các control tương ứng
                lblSoDiem.Text = khachHang?.DiemTichLuy.ToString() ?? "0";
            }
            else
            {
                // Nếu không có khách hàng nào được chọn, hiển thị "0"
                lblSoDiem.Text = "0";
            }
        }

        private void txtTimKiemMonDaGoi_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiemMonDaGoi.Text.Trim();
            TimKiemSanPhamDaChon(tuKhoa);
        }
        private void TimKiemSanPhamDaChon(string tuKhoa)
        {
            if (dgvDanhSachMonChon.Rows.Count > 0)
            {
                // Duyệt qua tất cả các dòng trong DataGridView trừ dòng cuối cùng (dòng đang chỉnh sửa)
                foreach (DataGridViewRow row in dgvDanhSachMonChon.Rows)
                {
                    if (row.IsNewRow) continue; // Bỏ qua dòng chưa hoàn thành

                    bool isMatch = false;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().ToLower().Contains(tuKhoa.ToLower()))
                        {
                            isMatch = true;
                            break;
                        }
                    }

                    row.Visible = isMatch;
                }
            }
        }

        private void chkSuDung_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalMoney();
        }

        private void txtTimKhachHang_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKhachHang.Text.Trim().ToLower();
            List<KhachHangDTO> danhSachHienThi = new List<KhachHangDTO>();


            if (string.IsNullOrEmpty(tuKhoa))
            {
                danhSachHienThi = new List<KhachHangDTO>(danhSachKhachHangGoc);

            }
            else
            {
                // Lọc danh sách dựa trên từ khóa tìm kiếm
                danhSachHienThi = danhSachKhachHangGoc
                    .Where(kh => kh.SoDienThoai.Contains(tuKhoa))
                    .ToList();
            }

            // Cập nhật lại DataSource cho ComboBox
            cboKhachHang.DataSource = danhSachHienThi;
            cboKhachHang.DisplayMember = "TenKhachHang";
            cboKhachHang.ValueMember = "SoDienThoai";
        }

        private void cboMaKhuyenMai_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu ComboBox có mục được chọn
            if (cboMaKhuyenMai.SelectedIndex != -1)
            {
                // Lấy mã khuyến mãi đã chọn từ ComboBox
                string maKhuyenMai = cboMaKhuyenMai.SelectedValue.ToString();

                // Gọi hàm để lấy phần trăm khuyến mãi từ cơ sở dữ liệu
                float phanTramKhuyenMai = busGoiMon.LayPhanTramKhuyenMai(maKhuyenMai);

                // Hiển thị phần trăm giảm giá vào txtGiamGia
                txtGiamGia.Text = phanTramKhuyenMai.ToString("F2") + "%";
                UpdateTotalMoney();
            }
            else
            {
                // Nếu không có mục nào được chọn, set txtGiamGia là rỗng
                txtGiamGia.Text = string.Empty;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Tạo mã hóa đơn mới
            string maHoaDonMoi = busGoiMon.TaoMaHoaDonMoi();
            DateTime ngayLap = DateTime.Now;
            decimal thanhTien = Convert.ToDecimal(lblTotalMoney.Text.Trim());
            string phuongThucThanhToan = null;

            if (chkChuyenKhoan.Checked == true)
            {
                phuongThucThanhToan = "Chuyển Khoản";
            }
            else
            {
                phuongThucThanhToan = "Tiền Mặt";
            }

            //string maNV = "NV001";
            string sdt;
            if (cboKhachHang.SelectedItem != null)
            {
                // Ép kiểu đối tượng được chọn thành KhachHangDTO
                var selectedCustomer = (KhachHangDTO)cboKhachHang.SelectedItem;
                sdt = selectedCustomer.SoDienThoai; // Mã khách hàng
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng.");
                return;
            }
            string maKhuyenMai = null;
            if (cboMaKhuyenMai.SelectedItem != null)
            {
                // Ép kiểu đối tượng được chọn thành KhachHangDTO
                var selectedKhuyenMai = (KhuyenMaiDTO)cboMaKhuyenMai.SelectedItem;
                maKhuyenMai = selectedKhuyenMai.MaKhuyenMai; // Mã khách hàng
            }
            else
            {

            }
            // Lưu hóa đơn
            bool hoaDonLuuThanhCong = busGoiMon.LuuHoaDon(maHoaDonMoi, maNV, sdt, "BA000", maKhuyenMai, ngayLap, thanhTien, phuongThucThanhToan); ;

            if (hoaDonLuuThanhCong)
            {
                // Kiểm tra xem có sản phẩm nào trong dgvDanhSachLinhKienDaChon không
                if (dgvDanhSachMonChon.Rows.Count == 0)
                {
                    MessageBox.Show("Chưa có món nào được đặt.");
                    return;  // Nếu không có sản phẩm, dừng thực hiện
                }

                // Duyệt qua dgvDanhSachLinhKienDaChon và lưu chi tiết hóa đơn
                foreach (DataGridViewRow row in dgvDanhSachMonChon.Rows)
                {
                    // Lấy thông tin từ từng dòng trong DataGridView
                    string MaMonAn = row.Cells["MaMonAn"].Value.ToString();
                    int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);

                    // Kiểm tra xem mã món ăn bắt đầu là "MA" hay "CB"
                    if (MaMonAn.StartsWith("MA"))
                    {
                        // Lưu chi tiết hóa đơn kiểu khác cho món ăn
                        bool chiTietLuuThanhCong = busGoiMon.LuuChiTietHoaDon(maHoaDonMoi, MaMonAn, "CB000", soLuong, "Chờ thực hiện");
                        if (!chiTietLuuThanhCong)
                        {
                            MessageBox.Show("Lưu chi tiết hóa đơn món ăn thất bại!");
                            return;
                        }
                    }
                    else if (MaMonAn.StartsWith("CB"))
                    {
                        // Lưu chi tiết hóa đơn kiểu khác cho combo
                        bool chiTietLuuThanhCong = busGoiMon.LuuChiTietHoaDon(maHoaDonMoi, "MA000", MaMonAn, soLuong, "Chờ thực hiện");
                        if (!chiTietLuuThanhCong)
                        {
                            MessageBox.Show("Lưu chi tiết hóa đơn combo thất bại!");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã món ăn không hợp lệ!");
                    }
                }
                MessageBox.Show("Hóa đơn và chi tiết hóa đơn đã được lưu thành công!");
                LoadDanhSachMonAnConBan();
                // Xóa tất cả dữ liệu trong DataGridView
                dgvDanhSachMonChon.Rows.Clear();
                if (chkSuDung.Checked == true && sdt != "0000000000")
                {
                    busGoiMon.CaiLaiDiemTichLuyChoKhachHang(sdt);
                }
                // Loại bỏ dấu phẩy khỏi chuỗi và parse sang số
                int soDiem = int.Parse(lblTotalMoney.Text.Replace(",", "")) / 1000;

                if (sdt != "0000000000")
                {
                    // Cộng điểm tích lũy cho khách hàng
                    busGoiMon.CongDiemTichLuyChoKhachHang(sdt, soDiem);
                }

                //SetToDefault();
                btnLuu.Enabled = false;
                btnInHoaDon.Enabled = true;
                btnThemMon.Enabled = false;
            }
            else
            {
                MessageBox.Show("Lưu hóa đơn thất bại!");
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            string maHoaDonMoiNhat = busGoiMon.GetLatestInvoice();
            DataSet dulieu = LoadInvoiceReport(maHoaDonMoiNhat);
            frmHoaDon frm = new frmHoaDon(dulieu);
            frm.ShowDialog();
            btnInHoaDon.Enabled = false;
            btnLuu.Enabled = true;
            btnThemMon.Enabled = true;
            ClearInputFields();
        }
        private DataSet LoadInvoiceReport(string maHoaDon)
        {
            // Hiển thị tổng tiền chưa có khuyến mãi
            decimal totalMoney = decimal.Parse(txtThanhTien.Text.Replace(",", "").Trim());
            decimal discountPercent = 0;
            decimal discountAmount = 0;
            // Loại bỏ dấu phần trăm và chuyển đổi thành decimal
            string discountText = txtGiamGia.Text.Replace("%", "").Trim();
            if (decimal.TryParse(discountText, out discountPercent))
            {
                // Kiểm tra xem phần trăm có hợp lệ không
                if (discountPercent > 0 && discountPercent <= 100)
                {
                    discountAmount = totalMoney * (discountPercent / 100); // Tính số tiền giảm
                }
            }
            int soDiem = int.Parse(lblTotalMoney.Text.Replace(",", "")) / 1000;


            CombinedInvoiceDTO dulieu = new CombinedInvoiceDTO();

            dulieu = busHoaDon.GetInvoiceDetails(maHoaDon);

            // Tạo DataTable cho chi tiết hóa đơn
            // Tạo DataTable cho thông tin hóa đơn
            DataTable invoiceDetails = new DataTable();
            DataTable invoiceInfo = new DataTable();

            if (dulieu != null && dulieu.InvoiceDetails != null && dulieu.Items.Count > 0)
            {

                invoiceDetails.Columns.Add("ProductName", typeof(string));
                invoiceDetails.Columns.Add("Quantity", typeof(int));
                invoiceDetails.Columns.Add("Price", typeof(decimal));
                invoiceDetails.Columns.Add("SubTotal", typeof(decimal));


                invoiceInfo.Columns.Add("EmployeeName", typeof(string));
                invoiceInfo.Columns.Add("PaymentMethod", typeof(string));
                invoiceInfo.Columns.Add("InvoiceID", typeof(string));
                invoiceInfo.Columns.Add("Total", typeof(decimal));
                invoiceInfo.Columns.Add("Tax", typeof(decimal));
                invoiceInfo.Columns.Add("Discount", typeof(decimal));
                invoiceInfo.Columns.Add("UsedPoints", typeof(int));
                invoiceInfo.Columns.Add("FinalAmount", typeof(decimal));
                invoiceInfo.Columns.Add("ReceivedPoints", typeof(int));
                invoiceInfo.Columns.Add("Date", typeof(string));
                invoiceInfo.Columns.Add("QRCode", typeof(byte[]));
                foreach (var item in dulieu.Items)
                {
                    invoiceDetails.Rows.Add(item.ItemName, item.Quantity, item.UnitPrice, item.TotalPrice);
                }
                if (chkSuDung.Checked == true)
                {
                    if (chkChuyenKhoan.Checked == false)
                    {
                        invoiceInfo.Rows.Add(
                                   dulieu.InvoiceDetails.EmployeeName,
                                   dulieu.InvoiceDetails.PaymentMethod,
                                   dulieu.InvoiceDetails.InvoiceID,
                                   txtThanhTien.Text.Replace(",", "").Trim(),
                                   txtVAT.Text.Replace(",", "").Trim(),
                                   discountAmount.ToString("N0"),
                                   lblSoDiem.Text.ToString(),
                                   dulieu.InvoiceDetails.Total,
                                   soDiem,
                                   DateTime.Now.ToString()
                               );
                    }
                    else
                    {
                        invoiceInfo.Rows.Add(
                                   dulieu.InvoiceDetails.EmployeeName,
                                   dulieu.InvoiceDetails.PaymentMethod,
                                   dulieu.InvoiceDetails.InvoiceID,
                                   txtThanhTien.Text.Replace(",", "").Trim(),
                                   txtVAT.Text.Replace(",", "").Trim(),
                                   discountAmount.ToString("N0"),
                                   lblSoDiem.Text.ToString(),
                                   dulieu.InvoiceDetails.Total,
                                   soDiem,
                                   DateTime.Now.ToString()
                               );
                    }
                }
                else
                {
                    if (chkChuyenKhoan.Checked == false)
                    {
                        invoiceInfo.Rows.Add(
                                   dulieu.InvoiceDetails.EmployeeName,
                                   dulieu.InvoiceDetails.PaymentMethod,
                                   dulieu.InvoiceDetails.InvoiceID,
                                   txtThanhTien.Text.Replace(",", "").Trim(),
                                   txtVAT.Text.Replace(",", "").Trim(),
                                   discountAmount.ToString("N0"),
                                   "0",
                                   dulieu.InvoiceDetails.Total,
                                   soDiem,
                                   DateTime.Now.ToString()
                               );
                    }
                    else
                    {
                        invoiceInfo.Rows.Add(
                                  dulieu.InvoiceDetails.EmployeeName,
                                  dulieu.InvoiceDetails.PaymentMethod,
                                  dulieu.InvoiceDetails.InvoiceID,
                                  txtThanhTien.Text.Replace(",", "").Trim(),
                                  txtVAT.Text.Replace(",", "").Trim(),
                                  discountAmount.ToString("N0"),
                                  "0",
                                  dulieu.InvoiceDetails.Total,
                                  soDiem,
                                  DateTime.Now.ToString()
                              );
                    }
                }
                // Tạo DataSet và thêm các DataTable vào
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
            // Thêm dữ liệu vào DataTable
            //invoiceDetails.Rows.Add("Fried Chicken", 2, 150.00, 300.00);
            //invoiceDetails.Rows.Add("Burger", 1, 50.00, 50.00);

            // Thêm dữ liệu vào DataTable thông tin hóa đơn
            //invoiceInfo.Rows.Add("John Doe", "Cash", "HD001", 350.00, 35.00, 0.00, 10, 375.00, 400.00, 25.00, 5, DateTime.Now.ToString());


        }

        private void cboLoaiMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDanhSachMonAnConBan();
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            if (!IsInputValid())
                return;

            try
            {
                // Lấy số điện thoại từ input
                string soDienThoai = txtSDTTao.Text;

                // Kiểm tra xem số điện thoại đã tồn tại chưa
                if (busKhachHang.IsSoDienThoaiTonTai(soDienThoai))
                {
                    MessageBox.Show("Số điện thoại này đã tồn tại trong hệ thống. Vui lòng kiểm tra lại!");
                    return;
                }

                // Hỏi xác nhận người dùng
                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn thêm khách hàng với số điện thoại {soDienThoai} không?",
                    "Xác nhận thêm khách hàng",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                // Nếu người dùng chọn "No", thoát khỏi hàm
                if (result == DialogResult.No)
                    return;

                // Nếu người dùng chọn "Yes", tiến hành thêm khách hàng
                if (busKhachHang.AddKhachHangWithDefaultDiemTichLuy(txtSDTTao.Text, txtHoTenTao.Text))
                {
                    MessageBox.Show("Thêm khách hàng thành công!");
                    LoadCboKhachHang(); // Refresh danh sách khách hàng
                    ClearInputFields(); // Xóa dữ liệu input
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

        private void ClearInputFields()
        {
            txtSDTTao.Text = "";
            txtHoTenTao.Text = "";
            txtTimKhachHang.Text = "";
            txtSoLuong.Text = "";
            cboKhachHang.SelectedIndex = 0;
            cboMaKhuyenMai.SelectedIndex = 0;
            chkChuyenKhoan.Checked = false;
            chkSuDung.Checked = false;
        }
        private bool IsInputValid()
        {
            if (string.IsNullOrWhiteSpace(txtSDTTao.Text) || !IsValidPhoneNumber(txtSDTTao.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ! Vui lòng nhập số có từ 10-15 chữ số.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtHoTenTao.Text))
            {
                MessageBox.Show("Tên khách hàng không được để trống!");
                return false;
            }
            return true;
        }
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Loại bỏ khoảng trắng và định dạng khác
            phoneNumber = phoneNumber.Trim();

            // Biểu thức chính quy kiểm tra số điện thoại hợp lệ ở Việt Nam
            string pattern = @"^(0|\+84)(3[2-9]|5[6|8|9]|7[0|6-9]|8[1-5|8|9]|9[0-9])\d{7}$";
            return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, pattern);
        }

        private void frmDatMon_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
