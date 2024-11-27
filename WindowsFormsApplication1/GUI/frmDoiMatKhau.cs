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
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            if (txtMaukhaucu.Text == "" || txtMatkhaumoi.Text == "" || txtXacnhanmatkhau.Text == "")
            {
                MessageBox.Show("Vui lòng kiểm tra lại mật khẩu. Mật khẩu không được trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMatkhaumoi.Text != txtXacnhanmatkhau.Text)
            {
                MessageBox.Show("Mật khẩu không khớp. Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!DAL.NhanVienDAL.kiemTraMatKhau(DAL.EnCryptDAL.EncryptMD5(txtMaukhaucu.Text), frmTrangChu.MaNhanVien))
            {
                MessageBox.Show("Mật khẩu cũ không đúng. Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (DAL.NhanVienDAL.doiMatKhau(DAL.EnCryptDAL.EncryptMD5(txtMatkhaumoi.Text), frmTrangChu.MaNhanVien))
            {
                MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaukhaucu.Text = "";
                txtMatkhaumoi.Text = "";
                txtXacnhanmatkhau.Text = "";
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng kiểm tra và thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            txtMaukhaucu.Clear();
            txtMatkhaumoi.Clear();
            txtXacnhanmatkhau.Clear();
        }
    }
}
