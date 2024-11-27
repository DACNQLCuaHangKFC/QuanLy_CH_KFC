using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApplication1.DAL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Runtime.InteropServices.ComTypes;
using WindowsFormsApplication1.DTO;
using WindowsFormsApplication1.BUS;

namespace WindowsFormsApplication1
{
    public partial class frmKho : Form
    {
        BUS_Kho BUS_Kho = new BUS_Kho();
        
        private Timer timerCurrentTime;
        public frmKho()
        {
            InitializeComponent();
            LoadDgvKho();
            LoadDgvBep();
            LoadComboBoxLNL();
            dgvKho.CellClick += dataGridView_CellClick;
            dgvBep.CellClick += dataGridView_CellClick;
            timerCurrentTime = new Timer();
            timerCurrentTime.Interval = 1000; // 1000 ms = 1 giây
            timerCurrentTime.Tick += timerCurrentTime_Tick; // Đăng ký sự kiện Tick
            timerCurrentTime.Start(); // Bắt đầu Timer
        }
        private void timerCurrentTime_Tick(object sender, EventArgs e)
        {
            UpdateCurrentTime(); // Cập nhật thời gian mỗi giây
        }
        private void UpdateCurrentTime()
        {
            lblTime.Text = "Thời gian hiện tại: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
        public void LoadDgvKho()
        {
            
            List<NguyenLieuDTO> nguyenLieu = BUS_Kho.LayDanhSachNguyenLieuKho();
            dgvKho.DataSource = nguyenLieu;
            dgvKho.Columns["MaNguyenLieu"].HeaderText = "Mã Nguyên Liệu";
            dgvKho.Columns["TenNguyenLieu"].HeaderText = "Tên Nguyên Liệu";
            dgvKho.Columns["TenDVT"].HeaderText = "Đơn Vị Tính";
            dgvKho.Columns["SoLuongTon"].HeaderText = "Số Lượng Tồn";
            dgvKho.Columns["TrangThai"].HeaderText = "Trạng Thái";
            dgvKho.Columns["TenLoaiNguyenLieu"].Visible = false;
            dgvKho.Columns["MaLoaiNguyenLieu"].Visible = false;
            dgvKho.Columns["MaDVT"].Visible = false;
        }   



        public void LoadDgvBep()
        {
            List<NguyenLieuDTO> nguyenLieu = BUS_Kho.LayDanhSachNguyenLieuBep();
            dgvBep.DataSource = nguyenLieu;
            dgvBep.Columns["MaNguyenLieu"].HeaderText = "Mã Nguyên Liệu";
            dgvBep.Columns["TenNguyenLieu"].HeaderText = "Tên Nguyên Liệu";
            dgvBep.Columns["TenDVT"].HeaderText = "Đơn Vị Tính";
            dgvBep.Columns["SoLuongTon"].HeaderText = "Số Lượng Tồn";
            dgvBep.Columns["TrangThai"].HeaderText = "Trạng Thái";
            dgvBep.Columns["MaLoaiNguyenLieu"].Visible = false;
            dgvKho.Columns["TenLoaiNguyenLieu"].Visible = false;
            dgvBep.Columns["MaDVT"].Visible = false;
            
        }


        private void dgvKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            frmNhapKho frm = new frmNhapKho();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            UpdateCurrentTime();
        }

        

        private void cmbTenLNL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTenLNL.SelectedValue != null)
            {
                string maLoaiNguyenLieu = cmbTenLNL.SelectedValue.ToString();

                if (maLoaiNguyenLieu == "0") // Kiểm tra nếu "Tất cả" được chọn
                {
                    LoadDgvKho(); // Tải toàn bộ dữ liệu
                }
                else
                {
                    // Lấy dữ liệu từ BUS và cập nhật DataGridView theo loại nguyên liệu được chọn
                    DataTable dt = BUS_Kho.TimNguyenLieuTheoLoai(maLoaiNguyenLieu);
                    dgvKho.DataSource = dt; // Cập nhật DataGridView với dữ liệu mới
                }
            }
        }


        private void LoadComboBoxLNL()
        {
            // Khởi tạo đối tượng BUS_LoaiNguyenLieu từ tầng Business Logic
            BUS_LoaiNguyenLieu busLoaiNguyenLieu = new BUS_LoaiNguyenLieu();

            // Lấy tất cả loại nguyên liệu từ BLL (Business Logic Layer)
            List<LoaiNguyenLieuDTO> dtLoaiNguyenLieu = busLoaiNguyenLieu.GetAllLoaiNguyenLieu();

            // Thêm lựa chọn "Tất cả" vào List<LoaiNguyenLieuDTO>
            LoaiNguyenLieuDTO allLoaiNguyenLieu = new LoaiNguyenLieuDTO
            {
                MaLoaiNguyenLieu = "0", // Giá trị đặc biệt để đại diện cho "Tất cả"
                TenLoaiNguyenLieu = "Tất cả"
            };
            dtLoaiNguyenLieu.Insert(0, allLoaiNguyenLieu); // Thêm vào đầu danh sách

            // Gán List<LoaiNguyenLieuDTO> cho ComboBox
            cmbTenLNL.DataSource = dtLoaiNguyenLieu;
            cmbTenLNL.DisplayMember = "TenLoaiNguyenLieu"; // Hiển thị tên loại nguyên liệu
            cmbTenLNL.ValueMember = "MaLoaiNguyenLieu"; // Sử dụng mã loại nguyên liệu khi lọc
            cmbTenLNL.SelectedIndex = 0; // Mặc định chọn "Tất cả"
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
                }
                else if (dgv == dgvBep)
                {
                    txtManl.Text = selectedRow.Cells["MaNguyenLieu"].Value.ToString();
                    txtTennl.Text = selectedRow.Cells["TenNguyenLieu"].Value.ToString();
                    txtDvt.Text = selectedRow.Cells["TenDVT"].Value.ToString();
                    // Thêm các cột khác nếu có
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtTimKiem.Text.Trim(); // Loại bỏ khoảng trắng đầu và cuối
            if (!string.IsNullOrEmpty(searchText))
            {
                SearchByTenNguyenLieu(searchText);
            }
            else
            {
                dgvKho.DataSource = BUS_Kho.TimKiemNguyenLieuKho(""); // Hoặc một phương thức hiển thị toàn bộ
            }
        }

        private void SearchByTenNguyenLieu(string searchText)
        {
            List<NguyenLieuDTO> nguyenLieu = BUS_Kho.TimKiemNguyenLieuKho(searchText);
            dgvKho.DataSource = nguyenLieu;
            dgvKho.Columns["MaNguyenLieu"].HeaderText = "Mã Nguyên Liệu";
            dgvKho.Columns["TenNguyenLieu"].HeaderText = "Tên Nguyên Liệu";
            dgvKho.Columns["TenDVT"].HeaderText = "Đơn Vị Tính";
            dgvKho.Columns["SoLuongTon"].HeaderText = "Số Lượng Tồn";
            dgvKho.Columns["TrangThai"].HeaderText = "Trạng Thái";
            }




        private void btnNhapBep_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoLuong.Text) ||
        !int.TryParse(txtSoLuong.Text, out int soLuongNhap) ||
        soLuongNhap <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác nhận hành động từ người dùng
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn nhập nguyên liệu này vào bếp không?",
                                  "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Nếu người dùng chọn "No", dừng lại
            if (result == DialogResult.No)
            {
                return;
            }

            // Lấy mã nguyên liệu từ DataGridView
            if (dgvKho.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một nguyên liệu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maNguyenLieu = dgvKho.SelectedRows[0].Cells["MaNguyenLieu"].Value.ToString();

            if (BUS_Kho.NhapNguyenLieuVaoBep(maNguyenLieu, soLuongNhap, out string message))
            {
                MessageBox.Show(message);
                LoadDgvKho();
                LoadDgvBep();
            }
            else
            {
                MessageBox.Show(message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            frmTaoNguyenLieu tnl = new frmTaoNguyenLieu();
            this.Hide();
            tnl.ShowDialog();
            this.Show();
        }

        private void btnLichSuXuat_Click(object sender, EventArgs e)
        {
            frmLichSuXuatKho lsx = new frmLichSuXuatKho();
            this.Hide();
            lsx.ShowDialog();
            this.Show();
        }

        private void btnBep_Click(object sender, EventArgs e)
        {
            frmBep frmBep = new frmBep();
            this.Hide();
            frmBep.ShowDialog();
            this.Show();
        }

        private void dgvBep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmKho_Load_1(object sender, EventArgs e)
        {

        }
    }
}
