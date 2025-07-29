using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.GUI
{
    public partial class frmKhuyenMai : Form
    {
        public frmKhuyenMai()
        {
            InitializeComponent();
            AutoResizeDataGridView(dgrvKhuyenmai);
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
        void loadDgrvKhuyenMai()
        {
            dgrvKhuyenmai.DataSource = BUS.KhuyenMaiBUS.hienThiKhuyenMai();
            dgrvKhuyenmai.AllowUserToAddRows = false;
        }

        void xoaNoiDung()
        {
            txtMaKM.Clear();
            txtTenKM.Clear();
            txtPhantram.Clear();
            dtpNgayBD.Value = DateTime.Now;
            dtpNgayKT.Value = DateTime.Now;
        }

        private void btnTaomakm_Click(object sender, EventArgs e)
        {
            string maKm = BUS.KhuyenMaiBUS.taoMakmMoi();
            txtMaKM.Text = maKm;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKM.Text != string.Empty)
            {
                MessageBox.Show("Vui lòng nhấn nút Hủy bỏ để xóa thông tin đang được nhập trước khi thêm mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTenKM.Text == string.Empty)
            {
                MessageBox.Show("Tên khuyến mãi không được để trống!! Vui lòng điền đầy đủ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(dtpNgayKT.Value < dtpNgayBD.Value)
            {
                MessageBox.Show("Ngày kết thúc không được trước ngày bắt đầu. Tự động đặt lại ngày kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgayKT.Value = dtpNgayBD.Value;
            }
            else
            {
                BUS.KhuyenMaiBUS km = new BUS.KhuyenMaiBUS();
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm khuyến mãi này không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string maKm = BUS.KhuyenMaiBUS.taoMakmMoi();
                    string tenKm = txtTenKM.Text.Trim();
                    float ptkm = float.Parse(txtPhantram.Text.Trim());
                    DateTime ngayBd = dtpNgayBD.Value;
                    DateTime ngayKt = dtpNgayKT.Value;
                    bool kq = km.ThemKhuyenMai(maKm,tenKm,ptkm,ngayBd,ngayKt);
                    if (kq)
                    {
                        MessageBox.Show("Thêm khuyến mãi thành công.");
                        loadDgrvKhuyenMai();
                        xoaNoiDung();
                    }
                    else
                    {
                        MessageBox.Show("Thêm khuyến mãi thất bại.");
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BUS.KhuyenMaiBUS km = new BUS.KhuyenMaiBUS();
            string maKm = txtMaKM.Text;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khuyến mãi này không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                bool kq = km.XoaKhuyenMai(maKm);
                if (kq)
                {
                    MessageBox.Show("Xóa khuyến mãi thành công.");
                    loadDgrvKhuyenMai();
                    xoaNoiDung();
                }
                else
                {
                    MessageBox.Show("Xóa khuyến mãi thất bại.");
                }
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (txtMaKM.Text == string.Empty)
            {
                MessageBox.Show("Mã khuyến mãi không được để trống!! Vui lòng nhấn nút tạo mã DVT bên dưới để tạo mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTenKM.Text == string.Empty)
            {
                MessageBox.Show("Tên khuyến mãi không được để trống!! Vui lòng điền đầy đủ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dtpNgayKT.Value < dtpNgayBD.Value)
            {
                MessageBox.Show("Ngày kết thúc không được trước ngày bắt đầu. Tự động đặt lại ngày kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgayKT.Value = dtpNgayBD.Value;
            }
            else
            {
                BUS.KhuyenMaiBUS km = new BUS.KhuyenMaiBUS();
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật khuyến mãi này không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string maKm = txtMaKM.Text.Trim();
                    string tenKm = txtTenKM.Text.Trim();
                    float ptkm = float.Parse(txtPhantram.Text.Trim());
                    DateTime ngayBd = dtpNgayBD.Value;
                    DateTime ngayKt = dtpNgayKT.Value;
                    bool kq = km.CapNhatKhuyenMai(maKm, tenKm, ptkm, ngayBd, ngayKt);
                    if (kq)
                    {
                        MessageBox.Show("Cập nhật khuyến mãi thành công.");
                        loadDgrvKhuyenMai();
                        xoaNoiDung();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật khuyến mãi thất bại.");
                    }
                }
            }
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            xoaNoiDung();
        }

        private void frmKhuyenMai_Load(object sender, EventArgs e)
        {
            loadDgrvKhuyenMai();
        }

        private void dgrvKhuyenmai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgrvKhuyenmai.CurrentRow.Index;
            txtMaKM.Text = dgrvKhuyenmai.Rows[index].Cells[0].Value.ToString();
            txtTenKM.Text = dgrvKhuyenmai.Rows[index].Cells[1].Value.ToString();
            txtPhantram.Text = dgrvKhuyenmai.Rows[index].Cells[2].Value.ToString();
            if (DateTime.TryParse(dgrvKhuyenmai.Rows[index].Cells[3].Value.ToString(), out DateTime dateValue))
            {
                dtpNgayBD.Value = dateValue;
            }
            else
            {
                dtpNgayBD.Value = DateTime.Now;
            }
            if (DateTime.TryParse(dgrvKhuyenmai.Rows[index].Cells[4].Value.ToString(),out dateValue))
            {
                dtpNgayKT.Value = dateValue;
            }
            else
            {
                dtpNgayKT.Value = DateTime.Now;
            }
        }


    }
}
