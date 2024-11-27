using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.GUI
{
    public partial class frmKiemTraDB : Form
    {
        public frmKiemTraDB()
        {
            InitializeComponent();
        }

        private void moFrmDangNhap()
        {
            Thread.Sleep(0);
            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate ()
                {
                    new frmDangNhap().Show();
                    this.Visible = false;
                });
            }
            else
            {
                new frmDangNhap().Show();
                this.Visible = false;
            }
        }

        private void moFrmKetNoi()
        {
            Thread.Sleep(0);
            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate ()
                {
                    new frmKetNoi().Show();
                    this.Visible = false;
                });
            }
            else
            {
                new frmKetNoi().Show();
                this.Visible = false;
            }
        }

        private void kiemTraKetNoi()
        {
            if(!DAL.KiemTraKetNoiDAL.kiemTraKetNoi())
            {
                lblTrangthai.Text= "...Không thể kết nối đến CSDL. Đang cấu hình lại";
                Thread th = new Thread(new ThreadStart(moFrmKetNoi));
                th.IsBackground = true;
                th.Start();
            }
            else
            {
                lblTrangthai.Text = "...Kết nối thành công. Đang mở ứng dụng";
                Thread th = new Thread(new ThreadStart(moFrmDangNhap));
                th.IsBackground = true;
                th.Start();
            }
        }

        private void loadTrangThai()
        {
            Thread.Sleep(0);
            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate ()
                {
                    lblTrangthai.Text = "...Đang kiểm tra kết nối đến CSDL";
                });
            }
            else
            {
                lblTrangthai.Text = "...Đang kiểm tra kết nối đến CSDL";
            }
            Thread.Sleep(0);
            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate ()
                {
                    kiemTraKetNoi();
                });
            }
            else
            {
                kiemTraKetNoi();
            }
        }

        private void frmKiemTraDB_Load(object sender, EventArgs e)
        {
            lblTrangthai.Text = "...Đang mở ứng dụng";
            Thread th = new Thread(new ThreadStart(loadTrangThai));
            th.IsBackground = true;
            th.Start();
        }
    }
}
