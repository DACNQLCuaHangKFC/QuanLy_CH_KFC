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
    public partial class frmLoaiNguyenLieu : Form
    {
        public frmLoaiNguyenLieu()
        {
            InitializeComponent();
        }

        void loadDgrvLoainguyenlieu()
        {
            dgrvLoainguyenlieu.DataSource = BUS.LoaiNguyenLieuBUS.hienThiLoaiNguyenLieu();
            dgrvLoainguyenlieu.AllowUserToAddRows = false;
        }

        void xoaNoiDung()
        {
            txtMaLNL.Clear();
            txtTenLNL.Clear();
        }

        private void frmLoaiNguyenLieu_Load(object sender, EventArgs e)
        {
            loadDgrvLoainguyenlieu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaLNL.Text != string.Empty)
            {
                MessageBox.Show("Vui lòng nhấn nút Hủy bỏ để xóa thông tin đang được nhập trước khi thêm mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTenLNL.Text == string.Empty)
            {
                MessageBox.Show("Tên loại nguyên liệu không được để trống!! Vui lòng điền đầy đủ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BUS.LoaiNguyenLieuBUS lnl = new BUS.LoaiNguyenLieuBUS();
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm loại nguyên liệu này không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string newMaLnl = BUS.LoaiNguyenLieuBUS.taoMaLnlMoi();
                    txtMaLNL.Text = newMaLnl;
                    string maLnl = txtMaLNL.Text.Trim();
                    string tenLnl = txtTenLNL.Text.Trim();
                    bool kq = lnl.ThemLoaiNguyenLieu(maLnl, tenLnl);
                    if (kq)
                    {
                        MessageBox.Show("Thêm loại nguyên liệu thành công.");
                        loadDgrvLoainguyenlieu();
                        xoaNoiDung();
                    }
                    else
                    {
                        MessageBox.Show("Thêm loại nguyên liệu thất bại.");
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BUS.LoaiNguyenLieuBUS lnl = new BUS.LoaiNguyenLieuBUS();
            string maLnl = txtMaLNL.Text;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa loại nguyên liệu này không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                bool kq = lnl.XoaLoaiNguyenLieu(maLnl);
                if (kq)
                {
                    MessageBox.Show("Xóa loại nguyên liệu thành công.");
                    loadDgrvLoainguyenlieu();
                    xoaNoiDung();
                }
                else
                {
                    MessageBox.Show("Xóa loại nguyên liệu thất bại.");
                }
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (txtMaLNL.Text == string.Empty)
            {
                MessageBox.Show("Mã loại nguyên liệu không được để trống!! Vui lòng nhấn nút tạo mã DVT bên dưới để tạo mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTenLNL.Text == string.Empty)
            {
                MessageBox.Show("Tên loại nguyên liệu không được để trống!! Vui lòng điền đầy đủ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BUS.LoaiNguyenLieuBUS lnl = new BUS.LoaiNguyenLieuBUS();
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật loại nguyên liệu này không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string maLnl = txtMaLNL.Text.Trim();
                    string tenLnl = txtTenLNL.Text.Trim();
                    bool kq = lnl.CapNhatLoaiNguyenLieu(maLnl, tenLnl);
                    if (kq)
                    {
                        MessageBox.Show("Cập nhật loại nguyên liệu thành công.");
                        loadDgrvLoainguyenlieu();
                        xoaNoiDung();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật loại nguyên liệu thất bại.");
                    }
                }
            }
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            xoaNoiDung();
        }

        private void dgrvLoainguyenlieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgrvLoainguyenlieu.CurrentRow.Index;
            txtMaLNL.Text = dgrvLoainguyenlieu.Rows[index].Cells[0].Value.ToString();
            txtTenLNL.Text = dgrvLoainguyenlieu.Rows[index].Cells[1].Value.ToString();
        }
    }
}
