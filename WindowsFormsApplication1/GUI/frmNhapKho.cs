using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.BUS;
using WindowsFormsApplication1.DAL;
using WindowsFormsApplication1.DTO;

namespace WindowsFormsApplication1
{
    public partial class frmNhapKho : Form
    {
        BUS_Kho BUS_Kho = new BUS_Kho();
        public frmNhapKho()
        {
            InitializeComponent();
            
            //LoadDgvNhap();
            LoadDgvPhieuPhap();
            LoadTrangThaiComboBox();
            LoadTrangThaiKhoComboBox();
            //InitializedgvCTPN();
            dgvKho.CellClick += dataGridView_CellClick;
            dgvPhieuNhap.CellClick += dgvPhieuNhap_CellClick;
            dgvDanhSachNhap.CellClick += dataGridView_CellClick;
        }
        private void frmNhapKho_Load(object sender, EventArgs e)
        {
            LoadDgvKho("Cần Nhập");
            cmbTrangThai.SelectedIndex = 0;
        }
        private void LoadDgvKho(string trangThai)
        {
            List<NguyenLieuDTO> nguyenLieu = BUS_Kho.HienThiNguyenLieuKhoTheoTrangThai(trangThai);
            dgvKho.DataSource = nguyenLieu;
            dgvKho.Columns["MaNguyenLieu"].HeaderText = "Mã Nguyên Liệu";
            dgvKho.Columns["TenNguyenLieu"].HeaderText = "Tên Nguyên Liệu";
            dgvKho.Columns["TenDVT"].HeaderText = "Đơn Vị Tính";
            dgvKho.Columns["SoLuongTon"].HeaderText = "Số Lượng Tồn";
            dgvKho.Columns["TrangThai"].HeaderText = "Trạng Thái";
            dgvKho.Columns["TenLoaiNguyenLieu"].Visible = false;
            dgvKho.Columns["MaDVT"].Visible = false;
            dgvKho.Columns["MaLoaiNguyenLieu"].Visible = false;

        }
        //private void LoadDgvNhap()
        //{
        //    List<ChiTietPhieuNhapDTO> chiTietPhieuNhaps = BUS_Kho.HienThiDanhSachChiTietPhieuNhap();

        //    // Gán nguồn dữ liệu cho DataGridView
        //    dgvDanhSachNhap.DataSource = chiTietPhieuNhaps;

        //    // Thiết lập tiêu đề cho các cột (nếu cần)
        //    dgvDanhSachNhap.Columns["MaPhieuNhapHang"].HeaderText = "Mã Phiếu Nhập";
        //    dgvDanhSachNhap.Columns["MaNguyenLieu"].HeaderText = "Mã Nguyên Liệu";
        //    dgvDanhSachNhap.Columns["TenNguyenLieu"].HeaderText = "Tên Nguyên Liệu";
        //    dgvDanhSachNhap.Columns["SoLuong"].HeaderText = "Số Lượng";
        //    dgvDanhSachNhap.Columns["TenDVT"].HeaderText = "Tên DVT";
        //    dgvDanhSachNhap.Columns["TongGia"].HeaderText = "Tổng Giá";
        //    dgvDanhSachNhap.Columns["TrangThai"].HeaderText = "Trạng Thái";

        //    // Ẩn cột nếu cần
        //    // dgvNhap.Columns["TenCotKhongCanHienThi"].Visible = false;
        //}
        //private void InitializedgvCTPN()
        //{
        //    // Xóa tất cả các cột hiện tại (nếu có)
        //    dgvDanhSachNhap.Columns.Clear();

        //    // Thêm cột cho DataGridView
        //    dgvDanhSachNhap.Columns.Add("MaPhieuNhapHang", "Mã Phiếu Nhập");
        //    dgvDanhSachNhap.Columns.Add("MaNguyenLieu", "Mã Nguyên Liệu");
        //    dgvDanhSachNhap.Columns.Add("TenNguyenLieu", "Tên Nguyên Liệu");
        //    dgvDanhSachNhap.Columns.Add("SoLuong", "Số Lượng");
        //    dgvDanhSachNhap.Columns.Add("TenDVT", "Tên DVT");
        //    dgvDanhSachNhap.Columns.Add("TongGia", "Tổng Giá");
        //    dgvDanhSachNhap.Columns.Add("TrangThai", "Trạng Thái");

        //    // Bạn có thể tùy chỉnh thêm thuộc tính cho các cột ở đây nếu cần
        //}
        private void LoadDgvDanhSachNhap(string maPhieuNhapHang)
        {
            // Gọi phương thức từ BUS hoặc DAL để lấy danh sách chi tiết phiếu nhập
            List<ChiTietPhieuNhapDTO> chiTietPhieuNhaps = BUS_Kho.HienThiDanhSachChiTietPhieuNhap(maPhieuNhapHang);

            // Gán nguồn dữ liệu cho DataGridView
            dgvDanhSachNhap.DataSource = chiTietPhieuNhaps;

            // Thiết lập tiêu đề cho các cột
            dgvDanhSachNhap.Columns["MaPhieuNhapHang"].HeaderText = "Mã Phiếu Nhập";
            dgvDanhSachNhap.Columns["MaNguyenLieu"].HeaderText = "Mã Nguyên Liệu";
            dgvDanhSachNhap.Columns["TenNguyenLieu"].HeaderText = "Tên Nguyên Liệu";
            dgvDanhSachNhap.Columns["SoLuong"].HeaderText = "Số Lượng";
            dgvDanhSachNhap.Columns["TenDVT"].HeaderText = "Tên DVT";
            dgvDanhSachNhap.Columns["TongGia"].HeaderText = "Tổng Giá";
            dgvDanhSachNhap.Columns["TrangThai"].HeaderText = "Trạng Thái";
        }

        private void LoadDgvPhieuPhap()
        {
            string tenNCC = txtTimKiem.Text.Trim();

            // Lấy trạng thái từ ComboBox
            string trangThai = cmbTrangThai.SelectedItem?.ToString() ?? "Chờ nhập"; // Đặt mặc định nếu null


            // Gọi phương thức từ lớp BUS để lấy danh sách phiếu nhập
            List<PhieuNhapDTO> danhSachPhieuNhap = BUS_Kho.LayDanhSachPhieuNhap(tenNCC, trangThai);

            // Kiểm tra nếu có kết quả
            if (danhSachPhieuNhap != null && danhSachPhieuNhap.Count > 0)
            {
                // Gán dữ liệu vào DataGridView
                dgvPhieuNhap.DataSource = danhSachPhieuNhap;
            }
            else
            {
                // Nếu không có dữ liệu, hiển thị thông báo
                MessageBox.Show("Không có phiếu nhập nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvPhieuNhap.DataSource = null;
            }
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng đã nhấp vào một dòng (không nhấp vào tiêu đề)
            if (e.RowIndex >= 0)
            {
                // Kiểm tra DataGridView nào đã gọi sự kiện
                DataGridView dgv = sender as DataGridView;

                // Lấy dòng đã chọn
                DataGridViewRow selectedRow = dgv.Rows[e.RowIndex];

                // Kiểm tra DataGridView nào đã gọi sự kiện để gán dữ liệu vào TextBox
                if (dgv == dgvKho)
                {
                    // Gán dữ liệu từ DataGridViewKho
                    txtManl.Text = selectedRow.Cells["MaNguyenLieu"].Value.ToString();
                    txtTennl.Text = selectedRow.Cells["TenNguyenLieu"].Value.ToString();
                    txtDvt.Text = selectedRow.Cells["TenDVT"].Value.ToString();
                    txtSoLuong.Text = selectedRow.Cells["SoLuongTon"].Value.ToString();
                }
                else if (dgv == dgvDanhSachNhap)
                {
                    txtManl.Text = selectedRow.Cells["MaNguyenLieu"].Value.ToString();
                    txtTennl.Text = selectedRow.Cells["TenNguyenLieu"].Value.ToString();
                    txtDvt.Text = selectedRow.Cells["TenDVT"].Value.ToString();
                    txtSoLuong.Text = selectedRow.Cells["SoLuong"].Value.ToString();
                    // Thêm các cột khác nếu có
                }
            }
        }
        


        private void btnTroVe_Click(object sender, EventArgs e)
        {
            frmKho formKho = new frmKho();
            this.Hide();
            formKho.ShowDialog();
            this.Show();
        }

        private void dgvKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            string trangThaiKho = cmbTrangThaiKho.SelectedItem.ToString();
            if (dgvDanhSachNhap.SelectedRows.Count > 0)
            {
                // Lấy dòng đã chọn
                DataGridViewRow selectedRow = dgvDanhSachNhap.SelectedRows[0];

                // Lấy các giá trị từ dòng đã chọn
                string maPhieuNhapHang = selectedRow.Cells["MaPhieuNhapHang"].Value.ToString();
                string maNguyenLieu = selectedRow.Cells["MaNguyenLieu"].Value.ToString();
                int soLuong = Convert.ToInt32(selectedRow.Cells["SoLuong"].Value);
                string trangThai = selectedRow.Cells["TrangThai"].Value.ToString();

                // Kiểm tra trạng thái phải là 'Chờ vào kho'
                if (trangThai == "Chờ vào kho")
                {
                    // Gọi phương thức từ BLL để nhập vào kho
                    bool isUpdated = BUS_Kho.NhapHangVaoKho(maPhieuNhapHang, maNguyenLieu, soLuong);

                    if (isUpdated)
                    {
                        MessageBox.Show("Nhập hàng thành công!");
                        LoadDgvDanhSachNhap(maPhieuNhapHang); // Reload để hiển thị thay đổi
                        LoadDgvKho(trangThaiKho);          // Reload danh sách kho
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại.");
                    }
                }
                else
                {
                    MessageBox.Show("Nguyên liệu phải ở trạng thái 'Chờ vào kho' để thực hiện nhập kho.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nguyên liệu.");
            }
        }

        private void btnNhanHang_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachNhap.SelectedRows.Count > 0)
            {
                // Lấy dòng đã chọn
                DataGridViewRow selectedRow = dgvDanhSachNhap.SelectedRows[0];

                // Lấy mã nguyên liệu và trạng thái từ dòng đã chọn
                string maPhieuNhapHang = selectedRow.Cells["MaPhieuNhapHang"].Value.ToString();
                string maNguyenLieu = selectedRow.Cells["MaNguyenLieu"].Value.ToString();
                string trangThaiHienTai = selectedRow.Cells["TrangThai"].Value.ToString();

                // Kiểm tra trạng thái hiện tại
                if (trangThaiHienTai == "Chờ vào kho")
                {
                    MessageBox.Show("Sản phẩm đã ở trạng thái 'Chờ vào kho'.");
                }
                else
                {
                    // Cập nhật trạng thái thông qua lớp Business Logic
                    bool isUpdated = BUS_Kho.UpdateTrangThai(maPhieuNhapHang, maNguyenLieu, "Chờ vào kho");

                    if (isUpdated)
                    {
                        MessageBox.Show("Cập nhật trạng thái thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại. Không tìm thấy sản phẩm.");
                    }

                    // Tải lại DataGridView để phản ánh thay đổi
                    LoadDgvDanhSachNhap( maPhieuNhapHang);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để cập nhật trạng thái.");
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tenNCC = txtTimKiem.Text.Trim(); // Lấy tên nhà cung cấp từ TextBox
            string trangThai = cmbTrangThai.SelectedItem?.ToString(); // Lấy trạng thái từ ComboBox

            if (trangThai == "Tất cả")
            {
                trangThai = ""; // Nếu chọn 'Tất cả', không lọc theo trạng thái
            }

            // Gọi BUS để lấy danh sách phiếu nhập theo điều kiện
            List<PhieuNhapDTO> danhSachPhieuNhap = BUS_Kho.LayDanhSachPhieuNhap(tenNCC, trangThai);

            // Hiển thị kết quả lên DataGridView
            dgvPhieuNhap.DataSource = danhSachPhieuNhap;
        }
        private void LoadTrangThaiComboBox()
        {
            List<string> trangThaiList = new List<string> { "Tất cả", "Chờ nhập", "Đã xong" };
            cmbTrangThai.DataSource = trangThaiList;
        }
        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu người dùng đã click vào một dòng hợp lệ
            {
                // Lấy mã phiếu nhập từ dòng được chọn
                string maPhieuNhapHang = dgvPhieuNhap.Rows[e.RowIndex].Cells["MaPhieuNhapHang"].Value.ToString();

                // Gọi phương thức để hiển thị chi tiết phiếu nhập tương ứng với mã phiếu nhập
                LoadDgvDanhSachNhap(maPhieuNhapHang);
            }
        }

        private void cmbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenNCC = txtTimKiem.Text.Trim(); // Lấy tên nhà cung cấp từ TextBox
            string trangThai = cmbTrangThai.SelectedItem?.ToString(); // Lấy trạng thái từ ComboBox

            if (trangThai == "Tất cả")
            {
                trangThai = "Tất cả"; // Nếu chọn 'Tất cả', không lọc theo trạng thái
            }

            // Gọi BUS để lấy danh sách phiếu nhập theo điều kiện
            List<PhieuNhapDTO> danhSachPhieuNhap = BUS_Kho.LayDanhSachPhieuNhap(tenNCC, trangThai);

            // Hiển thị kết quả lên DataGridView
            dgvPhieuNhap.DataSource = danhSachPhieuNhap;
        }
        private void LoadTrangThaiKhoComboBox()
        {
            List<string> trangThaiList = new List<string> {"Cần Nhập", "Tất cả", "Còn Hàng"};
            cmbTrangThaiKho.DataSource = trangThaiList;
        }

        private void cmbTrangThaiKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cmbTrangThaiKho.SelectedItem.ToString();

            // Gọi LoadDgvKho để hiển thị dữ liệu theo trạng thái đã chọn
            LoadDgvKho(trangThai);
        }
    }
}
