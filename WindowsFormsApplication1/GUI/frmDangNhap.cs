using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.DAL;
using WindowsFormsApplication1.DTO;

namespace WindowsFormsApplication1.GUI
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        void lamMoi()
        {
            txtTendangnhap.Text = "";
            txtMatkhau.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string matkhau = DAL.EnCryptDAL.EncryptMD5(txtMatkhau.Text);
            string maNhanVien = DAL.NhanVienDAL.kiemDangNhap(txtTendangnhap.Text, matkhau);
            if (maNhanVien != "ERROR")
            {
                NhanVienDAL nhanVienDAL = new NhanVienDAL();
                NhanVienDTO nhanVien = nhanVienDAL.GetNhanVienByMaNV(maNhanVien);

                if (nhanVien != null)
                {
                    using (frmTrangChu frm = new frmTrangChu(nhanVien)) 
                    {
                        this.Hide();
                        //this.Dispose();
                        lamMoi();
                        frm.ShowDialog();
                        this.Show();
                        //this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTendangnhap.Focus();
            }
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*DialogResult result = MessageBox.Show("Bạn có muốn thoát ứng dụng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                
                Application.Exit();
            }*/
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát ứng dụng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            lamMoi();
        }
    }
}
