using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.BUS;

namespace WindowsFormsApplication1.GUI
{
    public partial class frmQuanLyNhanVien : Form
    {
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }

        void loadDgvNhanVien()
        {
            dgvNhanvien.DataSource = BUS.NhanVienBUS.hienThiNhanVien();
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            loadDgvNhanVien();
        }

        private void xoaNoiDung()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtHinhthuc.Clear();
            txtLuong.Clear();
        }

        private void dgvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index=dgvNhanvien.CurrentCell.RowIndex;
            txtMaNV.Text = dgvNhanvien.Rows[index].Cells[0].Value.ToString();
            txtTenNV.Text = dgvNhanvien.Rows[index].Cells[1].Value.ToString();
            txtSDT.Text = dgvNhanvien.Rows[index].Cells[2].Value.ToString();
            txtDiaChi.Text = dgvNhanvien.Rows[index].Cells[3].Value.ToString();
            txtHinhthuc.Text = dgvNhanvien.Rows[index].Cells[4].Value.ToString();
            txtLuong.Text = dgvNhanvien.Rows[index].Cells[6].Value.ToString();
            //txtMatkhau.Text = dgvNhanvien.Rows[index].Cells[7].Value.ToString();

        }

        private void btnTaomanv_Click(object sender, EventArgs e)
        {
           
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập số và phím Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            // Giới hạn 10 ký tự
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {  
            if (txtMaNV.Text != string.Empty)
            {
                MessageBox.Show("Vui lòng nhấn nút Hủy bỏ để xóa thông tin đang được nhập trước khi thêm mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtDiaChi.Text == string.Empty||txtHinhthuc.Text == string.Empty||txtLuong.Text == string.Empty||txtTenNV.Text == string.Empty||txtSDT.Text==string.Empty)
            {
                MessageBox.Show("Không được để trống các thông tin!! Vui lòng điền đầy đủ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //DAL.NhanVienDAL nv = new DAL.NhanVienDAL();
                BUS.NhanVienBUS nv = new BUS.NhanVienBUS();
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm nhân viên này không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string newManv = DAL.NhanVienDAL.taoMaNvMoi();
                    txtMaNV.Text = newManv;
                    string maLoaiNv = "";
                    string maNv = txtMaNV.Text.Trim();
                    string tenNv = txtTenNV.Text.Trim();
                    string hinhThuc = txtHinhthuc.Text.Trim();
                    string diaChi = txtDiaChi.Text.Trim();
                    float luong = float.Parse(txtLuong.Text.Trim());
                    string sdt = txtSDT.Text.Trim();
                    bool kq = nv.ThemNhanVien(maNv, tenNv, sdt, diaChi, hinhThuc, maLoaiNv, luong);
                    if (kq)
                    {
                        MessageBox.Show("Thêm nhân viên thành công.");
                        loadDgvNhanVien();
                        xoaNoiDung();
                    }
                    else
                    {
                        MessageBox.Show("Thêm nhân viên thất bại.");
                    }
                }
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
           if (txtDiaChi.Text == string.Empty || txtHinhthuc.Text == string.Empty || txtLuong.Text == string.Empty || txtTenNV.Text == string.Empty||txtSDT.Text==string.Empty)
            {
                MessageBox.Show("Không được để trống các thông tin!! Vui lòng điền đầy đủ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BUS.NhanVienBUS nv = new BUS.NhanVienBUS();
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật nhân viên này không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string maLoaiNv = "";
                    string maNv = txtMaNV.Text.Trim();
                    string tenNv = txtTenNV.Text.Trim();
                    string hinhThuc = txtHinhthuc.Text.Trim();
                    string diaChi = txtDiaChi.Text.Trim();
                    float luong = float.Parse(txtLuong.Text.Trim());
                    string sdt = txtSDT.Text.Trim();
                    bool kq = nv.CapNhatNhanVien(maNv, tenNv, sdt, diaChi, hinhThuc, maLoaiNv, luong);
                    if (kq)
                    {
                        MessageBox.Show("Cập nhật nhân viên thành công.");
                        loadDgvNhanVien();
                        xoaNoiDung();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật nhân viên thất bại.");
                    }
                }
            }
        }


        private void txtLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tenNV = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(tenNV))
            {
                loadDgvNhanVien();
            }
            else
            {
                BUS.NhanVienBUS nv = new BUS.NhanVienBUS();
                DataTable result = nv.TimKiemNhanVien(tenNV);
                if (result != null)
                {
                    dgvNhanvien.DataSource = result;
                }
            }
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            xoaNoiDung();
        }

        private void dgvNhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnResetMatKhau_Click(object sender, EventArgs e)
        {
            if (dgvNhanvien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên để reset mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maNhanVien = txtMaNV.Text;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn reset mật khẩu nhân viên này về '123' không?","Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    NhanVienBUS nhanVienBUS = new NhanVienBUS();
                    bool kq = nhanVienBUS.ResetMatKhau(maNhanVien);

                    if (kq)
                    {
                        MessageBox.Show("Reset mật khẩu về mặc định thành công. Mật khẩu mới là '123'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
