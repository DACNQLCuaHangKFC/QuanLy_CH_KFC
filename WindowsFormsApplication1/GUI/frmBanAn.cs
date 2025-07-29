using WindowsFormsApplication1.BUS;
using WindowsFormsApplication1.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.BUS;

namespace QLCuaHangKFC.GUI
{
    public partial class frmBanAn : Form
    {
        BanAnBUS banAnBus = new BanAnBUS();
        public frmBanAn()
        {
            InitializeComponent();
        }
        public void LoadTrangThai()
        {
            try
            {
                // Xóa tất cả các mục hiện tại trong ComboBox
                cboTrangThai.Items.Clear();

                // Thêm các trạng thái vào ComboBox
                cboTrangThai.Items.Add("Trống");
                cboTrangThai.Items.Add("Có khách");
                cboTrangThai.Items.Add("Ngưng hoạt động");
                // Chọn mặc định trạng thái đầu tiên nếu có
                if (cboTrangThai.Items.Count > 0)
                {
                    cboTrangThai.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load trạng thái: " + ex.Message);
            }
        }

        private void LoadDanhSachBanAn()
        {
            DataTable danhSachBanAn = banAnBus.LayTatCaBanAn();

            if (danhSachBanAn != null)
            {
                dgvDanhSachBan.DataSource = danhSachBanAn;
                dgvDanhSachBan.Columns["MaBan"].HeaderText = "Mã Bàn";
                dgvDanhSachBan.Columns["SoChoNgoi"].HeaderText = "Số Chỗ Ngồi";
                dgvDanhSachBan.Columns["TrangThai"].HeaderText = "Trạng Thái";
            }
            else
            {
                MessageBox.Show("Không thể tải danh sách bàn ăn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin từ giao diện
                string maBan = banAnBus.TaoMaBanAnMoi(); // Tự động tạo mã bàn mới
                int soChoNgoi = int.Parse(txtSoChoNgoi.Text);

                // Kiểm tra dữ liệu đầu vào
                if (soChoNgoi <= 0)
                {
                    MessageBox.Show("Thông tin bàn ăn không hợp lệ. Vui lòng kiểm tra lại.");
                    return;
                }

                // Tạo đối tượng BanAnDTO
                BanAnDTO banAnDTO = new BanAnDTO
                {
                    MaBan = maBan,
                    SoChoNgoi = soChoNgoi,
                    TrangThai = "Trống"
                };

                // Gọi phương thức BUS để thêm mới
                if (banAnBus.ThemBanAn(banAnDTO))
                {
                    MessageBox.Show("Thêm bàn ăn thành công!");
                    LoadDanhSachBanAn(); // Cập nhật lại danh sách bàn ăn
                }
                else
                {
                    MessageBox.Show("Thêm bàn ăn thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm bàn ăn: " + ex.Message);
            }
        }

        private void frmBanAn_Load(object sender, EventArgs e)
        {
            LoadDanhSachBanAn();
            LoadTrangThai();
            AutoResizeDataGridView(dgvDanhSachBan);
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

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin bàn ăn từ dòng được chọn trên DataGridView
                if (dgvDanhSachBan.SelectedRows.Count > 0)
                {
                    string maBan = dgvDanhSachBan.SelectedRows[0].Cells["MaBan"].Value.ToString();
                    int soChoNgoi = int.Parse(txtSoChoNgoi.Text);
                    string trangThai = cboTrangThai.SelectedItem?.ToString();

                    // Kiểm tra dữ liệu đầu vào
                    if (soChoNgoi <= 0 || string.IsNullOrEmpty(trangThai))
                    {
                        MessageBox.Show("Thông tin bàn ăn không hợp lệ. Vui lòng kiểm tra lại.");
                        return;
                    }

                    // Tạo đối tượng DTO
                    BanAnDTO banAnDTO = new BanAnDTO
                    {
                        MaBan = maBan,
                        SoChoNgoi = soChoNgoi,
                        TrangThai = trangThai
                    };

                    // Gọi BUS để thực hiện cập nhật
                    if (banAnBus.CapNhatBanAn(banAnDTO))
                    {
                        MessageBox.Show("Cập nhật bàn ăn thành công!");
                        LoadDanhSachBanAn(); // Tải lại danh sách bàn ăn
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật bàn ăn thất bại!");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một bàn ăn cần cập nhật.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật bàn ăn: " + ex.Message);
            }
        }

        private void dgvDanhSachBan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDanhSachBan.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvDanhSachBan.SelectedRows[0];

                string maBan = selectedRow.Cells["MaBan"].Value.ToString();
                int soChoNgoi = Convert.ToInt32(selectedRow.Cells["SoChoNgoi"].Value);
                string trangThai = selectedRow.Cells["TrangThai"].Value.ToString();

                // Gán giá trị cho các điều khiển
                txtSoChoNgoi.Text = soChoNgoi.ToString();
                cboTrangThai.SelectedItem = trangThai;
            }
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
