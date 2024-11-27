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
    public partial class frmDonViTinh : Form
    {
        public frmDonViTinh()
        {
            InitializeComponent();
        }

        void loadDgrvDonvitinh()
        {
            dgrvDonvitinh.DataSource = BUS.DonViTinhBUS.hienThiDonViTinh();
            dgrvDonvitinh.AllowUserToAddRows = false;
        }

        void xoaNoiDung()
        {
            txtMaDVT.Clear();
            txtTenDVT.Clear();
        }

        private void frmDonViTinh_Load(object sender, EventArgs e)
        {
            loadDgrvDonvitinh();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMaDVT.Text!=string.Empty)
            {
                MessageBox.Show("Vui lòng nhấn nút Hủy bỏ để xóa thông tin đang được nhập trước khi thêm mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtTenDVT.Text==string.Empty)
            {
                MessageBox.Show("Tên đơn vị tính không được để trống!! Vui lòng điền đầy đủ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BUS.DonViTinhBUS dvt = new BUS.DonViTinhBUS();
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm đơn vị tính này không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string newMaDvt = BUS.DonViTinhBUS.taoMDvtMoi();
                    txtMaDVT.Text = newMaDvt;
                    string maDvt = txtMaDVT.Text.Trim();
                    string tenDvt = txtTenDVT.Text.Trim();
                    bool kq = dvt.ThemDonViTinh(maDvt, tenDvt);
                    if (kq)
                    {
                        MessageBox.Show("Thêm đơn vị tính thành công.");
                        loadDgrvDonvitinh();
                        xoaNoiDung();
                    }
                    else
                    {
                        MessageBox.Show("Thêm đơn vị tính thất bại.");
                    }
                }
            }
        }

        private void dgrvDonvitinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgrvDonvitinh.CurrentRow.Index;
            txtMaDVT.Text = dgrvDonvitinh.Rows[index].Cells[0].Value.ToString();
            txtTenDVT.Text = dgrvDonvitinh.Rows[index].Cells[1].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BUS.DonViTinhBUS dvt = new BUS.DonViTinhBUS();
            string maDvt = txtMaDVT.Text;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa đơn vị tính này không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                bool kq = dvt.XoaDonViTinh(maDvt);
                if (kq)
                {
                    MessageBox.Show("Xóa đơn vị tính thành công.");
                    loadDgrvDonvitinh();
                    xoaNoiDung();
                }
                else
                {
                    MessageBox.Show("Xóa đơn vị tính thất bại.");
                }
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (txtMaDVT.Text == string.Empty)
            {
                MessageBox.Show("Mã đơn vị tính không được để trống!! Vui lòng nhấn nút tạo mã DVT bên dưới để tạo mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTenDVT.Text == string.Empty)
            {
                MessageBox.Show("Tên đơn vị tính không được để trống!! Vui lòng điền đầy đủ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BUS.DonViTinhBUS dvt = new BUS.DonViTinhBUS();
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật đơn vị tính này không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string maDvt = txtMaDVT.Text.Trim();
                    string tenDvt = txtTenDVT.Text.Trim();
                    bool kq = dvt.CapNhatDonViTinh(maDvt, tenDvt);
                    if (kq)
                    {
                        MessageBox.Show("Cập nhật đơn vị tính thành công.");
                        loadDgrvDonvitinh();
                        xoaNoiDung();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật đơn vị tính thất bại.");
                    }
                }
            }
        }

        private void btnTaomadvt_Click(object sender, EventArgs e)
        {
            string maDvt = BUS.DonViTinhBUS.taoMDvtMoi();
            txtMaDVT.Text = maDvt;
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            xoaNoiDung();
        }
    }
}
