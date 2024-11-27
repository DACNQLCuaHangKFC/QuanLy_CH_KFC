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
    public partial class frmHeThong : Form
    {
        public frmHeThong()
        {
            InitializeComponent();
        }

        private void btnSaoluu_Click(object sender, EventArgs e)
        {
            frmSaoLuu frmSl = new frmSaoLuu();
            frmSl.ShowDialog();
        }

        private void btnPhuchoi_Click(object sender, EventArgs e)
        {
            frmPhucHoi frmPh = new frmPhucHoi();
            frmPh.ShowDialog();
        }

        private void btnPhanquyen_Click(object sender, EventArgs e)
        {
            frmPhanQuyen frmPq = new frmPhanQuyen();
            frmPq.ShowDialog();
        }
    }
}
