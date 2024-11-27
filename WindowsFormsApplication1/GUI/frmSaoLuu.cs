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

namespace WindowsFormsApplication1
{
    public partial class frmSaoLuu : Form
    {
        public frmSaoLuu()
        {
            InitializeComponent();
        }

        private void btnDuongdan_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Backup File File|*.bak";
            saveFileDialog1.Title = "Save Backup Database";
            saveFileDialog1.FileName = "WindowsFormsApplication1" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".bak";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = saveFileDialog1.FileName;
            }
            else
            {
                txtPath.Text = "";
            }
        }

        private void btnSaoluu_Click(object sender, EventArgs e)
        {
            if (DAL.SaoLuuPhucHoiDAL.saoLuu(txtPath.Text))
            {
                for (int i = 0; i <= 100; i++)
                {
                    progressBar1.Value = i;
                    this.toolStripStatusLabel1.Text = string.Format("Đang tiến hành sao lưu dữ liệu: {0} %", i);
                    this.Refresh();
                    if (i == 100)
                    {
                        this.toolStripStatusLabel1.Text = string.Format("Hoàn tất quá trình sao lưu.", i);
                        this.Refresh();
                    }
                    Thread.Sleep(50);
                }
                MessageBox.Show("Sao lưu dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPath.Text = "";
                progressBar1.Value = 0;
                progressBar1.Visible = false;
                this.toolStripStatusLabel1.Text = "";
                this.Refresh();
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra trong quá trình sao lưu dữ liệu. Vui lòng kiểm tra lại quyền thư mục lưu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
