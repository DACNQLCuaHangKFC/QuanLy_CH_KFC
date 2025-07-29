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
using WindowsFormsApplication1.DAL;

namespace WindowsFormsApplication1.GUI
{
    public partial class frmLichLamViec : Form
    {
        public frmLichLamViec()
        {
            InitializeComponent();
            AutoResizeDataGridView(dgvLichLam);
        }

        public void AutoResizeDataGridView(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.MinimumWidth = 50;
            }
        }
        void loadLichLam()
        {
            DateTime ngayLamViec = dtpNgayLamViec.Value;
            LichLamViecBUS lichLamViecBUS = new LichLamViecBUS();

            DataTable dt = lichLamViecBUS.GetLichLamViecByNgay(ngayLamViec);

            dgvLichLam.DataSource = dt;
        }
        void loadCaLam()
        {
            CaLamBUS caLamBUS = new CaLamBUS();
            DataTable dt = caLamBUS.LayDanhSachCaLam();
            cboMaCaLam.DataSource = dt;
            cboMaCaLam.DisplayMember = "MaCaLam";
            cboMaCaLam.ValueMember = "MaCaLam";
        }

        void loadNhanVien()
        {
            DataTable dt = DAL.NhanVienDAL.hienThiNhanVien();
            cboMaNhanVien.DataSource = dt;
            cboMaNhanVien.DisplayMember = "MaNhanVien";
            cboMaNhanVien.ValueMember = "MaNhanVien";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboMaCaLam.SelectedValue==null)
            {
                MessageBox.Show("Vui lòng chọn 1 ca làm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cboMaNhanVien.SelectedValue==null)
            {
                MessageBox.Show("Vui lòng chọn 1 nhân viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dtpNgayLamViec.Value < DateTime.Now)
            {
                MessageBox.Show("Ngày làm việc phải lớn hơn ngày hiện tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgayLamViec.Value = DateTime.Now;
            }
            else
            {
                string maCa = cboMaCaLam.SelectedValue.ToString();
                string maNhanVien = cboMaNhanVien.SelectedValue.ToString();
                DateTime ngayLam = dtpNgayLamViec.Value;
                BUS.LichLamViecBUS llv = new BUS.LichLamViecBUS();
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm lịch làm việc vào ngày "+dtpNgayLamViec.Value.ToShortTimeString()+" cho nhân viên "+cboMaNhanVien.SelectedValue.ToString()+" không ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (llv.KiemTraLichLam(maNhanVien, ngayLam))
                {
                    MessageBox.Show("Nhân viên đã được xếp lịch làm việc trong ngày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (result == DialogResult.Yes)
                {
                    bool kq = llv.ThemLichLamViec(maCa,maNhanVien,ngayLam);
                    if (kq)
                    {
                        MessageBox.Show("Thêm lịch làm việc thành công.");
                        loadLichLam();
                    }
                    else
                    {
                        MessageBox.Show("Thêm lịch làm việc thất bại.");
                    }
                }
            }
        }

        private void dtpNgayLamViec_ValueChanged(object sender, EventArgs e)
        {
            DateTime ngayLamViec = dtpNgayLamViec.Value;
            LichLamViecBUS lichLamViecBUS = new LichLamViecBUS();

            DataTable dt = lichLamViecBUS.GetLichLamViecByNgay(ngayLamViec);

            dgvLichLam.DataSource = dt;
        }

        private void frmLichLamViec_Load(object sender, EventArgs e)
        {
            loadCaLam();
            loadNhanVien();
        }

        private void cboMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            NhanVienBUS nhanVienBUS = new NhanVienBUS();
            if (cboMaNhanVien.SelectedValue != null)
            {
                string maNhanVien = cboMaNhanVien.SelectedValue.ToString();
                string tenNhanVien = nhanVienBUS.LayTenNhanVien(maNhanVien);
                txtTenNhanVien.Text = tenNhanVien;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtpNgayLamViec.Value < DateTime.Now)
            {
                MessageBox.Show("Không thể xóa lịch làm của ngày đã diễn ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BUS.LichLamViecBUS llv = new BUS.LichLamViecBUS();
                string maCa = cboMaCaLam.SelectedValue.ToString();
                string maNhanVien = cboMaNhanVien.SelectedValue.ToString();
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa lịch làm này không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    bool kq = llv.XoaLichLamViec(maCa, maNhanVien);
                    if (kq)
                    {
                        MessageBox.Show("Xóa lịch làm việc thành công.");
                        loadLichLam();
                    }
                    else
                    {
                        MessageBox.Show("Xóa lịch làm việc thất bại.");
                    }
                }
            }
        }

        private void dgvLichLam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLichLam.CurrentRow == null || dgvLichLam.CurrentRow.Index < 0)
            {
                MessageBox.Show("Không có dòng nào được chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int index = dgvLichLam.CurrentRow.Index;
                cboMaCaLam.SelectedValue = dgvLichLam.Rows[index].Cells[0].Value.ToString();
                cboMaNhanVien.SelectedValue = dgvLichLam.Rows[index].Cells[1].Value.ToString();
            }
        }
    }
}
