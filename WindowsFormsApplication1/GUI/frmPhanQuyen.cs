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
    public partial class frmPhanQuyen : Form
    {
        public frmPhanQuyen()
        {
            InitializeComponent();
        }

        void loadCboBoPhan()
        {
            DataTable dt = DAL.NhanVienDAL.layLoaiNhanVien();
            cboBophan.ValueMember = "MaLoaiNhanVien";
            cboBophan.DisplayMember = "TenLoaiNhanVien";
            cboBophan.DataSource = dt;
        }

        void loadDgvNhanVien()
        {
            dgvNhanvien.DataSource = DAL.NhanVienDAL.hienThiNhanVienPhanQuyen();
            dgvNhanvien.AllowUserToResizeColumns = false;
        }

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            loadCboBoPhan();
            cboBophan.SelectedValue = -1;
            loadDgvNhanVien();
        }

        private void dgvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvNhanvien.CurrentCell.RowIndex;
            
            if(dgvNhanvien.Rows[index].Cells[2].Value.ToString()==string.Empty)
            {
                cboBophan.SelectedValue = -1;
                txtManv.Text = dgvNhanvien.Rows[index].Cells[0].Value.ToString();
            }
            else 
            {
                txtManv.Text = dgvNhanvien.Rows[index].Cells[0].Value.ToString();
                cboBophan.SelectedValue = dgvNhanvien.Rows[index].Cells[2].Value.ToString();
            }
        }

        private void dgvNhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvNhanvien.CurrentCell.RowIndex;
            if (dgvNhanvien.Rows[index].Cells[2].Value.ToString() == string.Empty)
            {
                cboBophan.SelectedValue = -1;
                txtManv.Text = dgvNhanvien.Rows[index].Cells[0].Value.ToString();
            }
            else
            {
                cboBophan.SelectedValue = dgvNhanvien.Rows[index].Cells[2].Value.ToString();
                txtManv.Text = dgvNhanvien.Rows[index].Cells[0].Value.ToString();
            }
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            string maLoaiNV = cboBophan.SelectedValue.ToString();
            string maNv = txtManv.Text;
            if(txtManv.Text==string.Empty)
            {
                MessageBox.Show("Vui lòng chọm nhân viên","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                DAL.NhanVienDAL nv = new DAL.NhanVienDAL();
                bool kq=nv.CapNhatMaLoaiNhanVien(maNv, maLoaiNV);
                if(kq)
                {
                    MessageBox.Show("Cập nhật loại nhân viên thành công!");
                    loadDgvNhanVien();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
