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
    public partial class frmLoaiMonAn : Form
    {
        public frmLoaiMonAn()
        {
            InitializeComponent();
        }

        void loadDgrvLoaimonan()
        {
            dgrvLoaimonan.DataSource = BUS.LoaiMonAnBUS.hienThiLoaiMonAn();
            dgrvLoaimonan.AllowUserToAddRows = false;
        }

        void xoaNoiDung()
        {
            txtMaLMA.Clear();
            txtTenLMA.Clear();
        }

        private void frmLoaiMonAn_Load(object sender, EventArgs e)
        {
            loadDgrvLoaimonan();
        }

        private void dgrvLoaimonan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgrvLoaimonan.CurrentRow.Index;
            txtMaLMA.Text = dgrvLoaimonan.Rows[index].Cells[0].Value.ToString();
            txtTenLMA.Text = dgrvLoaimonan.Rows[index].Cells[1].Value.ToString();
        }

        private void btnTaomalma_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaLMA.Text != string.Empty)
            {
                MessageBox.Show("Vui lòng nhấn nút Hủy bỏ để xóa thông tin đang được nhập trước khi thêm mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTenLMA.Text == string.Empty)
            {
                MessageBox.Show("Tên loại món ăn không được để trống!! Vui lòng điền đầy đủ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BUS.LoaiMonAnBUS lma = new BUS.LoaiMonAnBUS();
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm loại món ăn này không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string newMaLma = BUS.LoaiMonAnBUS.taoMaLmaMoi();
                    txtMaLMA.Text = newMaLma;
                    string maLma = txtMaLMA.Text.Trim();
                    string tenLma = txtTenLMA.Text.Trim();
                    bool kq = lma.ThemLoaiMonAn(maLma, tenLma);
                    if (kq)
                    {
                        MessageBox.Show("Thêm loại món ăn thành công.");
                        loadDgrvLoaimonan();
                        xoaNoiDung();
                    }
                    else
                    {
                        MessageBox.Show("Thêm loại món ăn thất bại.");
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BUS.LoaiMonAnBUS lma = new BUS.LoaiMonAnBUS();
            string maLma = txtMaLMA.Text;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa loại món ăn này không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                bool kq = lma.XoaLoaiMonAn(maLma);
                if (kq)
                {
                    MessageBox.Show("Xóa loại món ăn thành công.");
                    loadDgrvLoaimonan();
                    xoaNoiDung();
                }
                else
                {
                    MessageBox.Show("Xóa loại món ăn thất bại.");
                }
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (txtMaLMA.Text == string.Empty)
            {
                MessageBox.Show("Mã loại món ăn không được để trống!! Vui lòng nhấn nút tạo mã DVT bên dưới để tạo mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTenLMA.Text == string.Empty)
            {
                MessageBox.Show("Tên loại món ăn không được để trống!! Vui lòng điền đầy đủ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BUS.LoaiMonAnBUS lma = new BUS.LoaiMonAnBUS();
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật loại món ăn này không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string maLma = txtMaLMA.Text.Trim();
                    string tenLma = txtTenLMA.Text.Trim();
                    bool kq = lma.CapNhatLoaiMonAn(maLma, tenLma);
                    if (kq)
                    {
                        MessageBox.Show("Cập nhật loại món ăn thành công.");
                        loadDgrvLoaimonan();
                        xoaNoiDung();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật loại món ăn thất bại.");
                    }
                }
            }
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            xoaNoiDung();
        }
 
    }
}
