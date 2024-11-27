using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.DTO;

namespace WindowsFormsApplication1.GUI
{
    public partial class frmTrangChu : Form
    {
        private NhanVienDTO nhanvien;
        public static string MaNhanVien;
        public frmTrangChu(NhanVienDTO nhanvien)
        {
            InitializeComponent();
            this.nhanvien = nhanvien;
            lblTennhanvien.Text = "Xin chào: " + nhanvien.TenNhanVien;
            PhanQuyen();
            MaNhanVien = nhanvien.MaNhanVien;
        }

        void loadBtnQuayLai()
        {
            btnQuaylai.Visible = true;
            btnQuaylai.BringToFront();
        }

        private void OpenFormInCorner(Form form)
        {
            form.TopLevel = false; // Cho phép form con không phải là top-level
            form.FormBorderStyle = FormBorderStyle.None; // Ẩn viền của form
            pnlTrangchu.Controls.Add(form); // Thêm form vào Controls của MainForm
            form.Dock = DockStyle.Fill; // Đặt form chiếm toàn bộ không gian của panel
            form.Show(); // Hiển thị form
            form.BringToFront(); // Đưa form nhỏ lên trên cùng
        }

        private void OpenFormInCorner1(Form form)
        {
            pnlLeft.Hide();
            pnlTrangchu.BringToFront();
            // Lưu các form hiện tại trong pnlTrangchu vào danh sách
            var openForms = new List<Form>();
            foreach (Control ctrl in pnlTrangchu.Controls)
            {
                if (ctrl is Form existingForm)
                {
                    openForms.Add(existingForm);
                }
            }

            // Đóng tất cả các form hiện tại
            foreach (var existingForm in openForms)
            {
                existingForm.Close();
            }

            // Thiết lập form mới
            form.TopLevel = false; // Cho phép form con không phải là top-level
            form.FormBorderStyle = FormBorderStyle.None; // Ẩn viền của form
            form.StartPosition = FormStartPosition.Manual; // Định vị trí thủ công

            // Kiểm tra kích thước của form con và panel
            if (form.ClientSize.Width > pnlTrangchu.ClientSize.Width || form.ClientSize.Height > pnlTrangchu.ClientSize.Height)
            {
                form.Size = new Size(
                    Math.Min(form.ClientSize.Width, pnlTrangchu.ClientSize.Width),
                    Math.Min(form.ClientSize.Height, pnlTrangchu.ClientSize.Height)
                );
            }

            // Tính toán vị trí trung tâm của form trong pnlTrangChu
            int centerX = (pnlTrangchu.ClientSize.Width - form.ClientSize.Width) / 2 - 150;
            int centerY = (pnlTrangchu.ClientSize.Height - form.ClientSize.Height) / 2 - 50;
            form.Location = new Point(Math.Max(0, centerX), Math.Max(0, centerY));

            // Thêm form vào Panel và hiển thị
            pnlTrangchu.Controls.Add(form);
            form.Show();
            form.BringToFront(); // Đưa form lên trên cùng
        }

        private void CloseAllChildForms()
        {
            var formsToClose = new List<Form>(); // Danh sách để lưu trữ các form nhỏ cần đóng

            // Lưu trữ các form nhỏ vào danh sách
            foreach (Form form in Application.OpenForms)
            {
                // Kiểm tra nếu form không phải là form hiện tại (this) và không phải frmTrangChu
                if (form != this && form.Name != "frmTrangChu" && form.Name !="frmDangNhap")
                {
                    formsToClose.Add(form);
                }
            }

            // Đóng tất cả các form trong danh sách
            foreach (var form in formsToClose)
            {
                form.Close();
            }
        }



        private void frmTrangChu_Load(object sender, EventArgs e)
        {

        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                nhanvien.MaNhanVien = null;
                this.Dispose();
            }
        }

        private void PhanQuyen()
        {
            switch (nhanvien.MaLoaiNhanVien)
            {
                case "LNV001":
                    break;
                case "LNV002":
                   
                    gọiMónToolStripMenuItem.Enabled = false;
                    nhânSựToolStripMenuItem.Enabled = false;
                    thốngKêToolStripMenuItem.Enabled = false;
                    hệThốngToolStripMenuItem.Enabled = false;
                    danhMụcToolStripMenuItem.Enabled = false;
                    khoToolStripMenuItem.Enabled = false;
                    break;
                case "LNV003":
                   
                    bếpToolStripMenuItem.Enabled = false;
                    nhânSựToolStripMenuItem.Enabled = false;
                    thốngKêToolStripMenuItem.Enabled = false;
                    hệThốngToolStripMenuItem.Enabled = false;
                    danhMụcToolStripMenuItem.Enabled = false;
                    gọiMónToolStripMenuItem.Enabled = false;
                    break;
                case "LNV004":
                   
                    bếpToolStripMenuItem.Enabled = false;
                    nhânSựToolStripMenuItem.Enabled = false;
                    thốngKêToolStripMenuItem.Enabled = false;
                    hệThốngToolStripMenuItem.Enabled = false;
                    danhMụcToolStripMenuItem.Enabled = false;
                    khoToolStripMenuItem.Enabled = false;
                    break;
                case "LNV005":
                    
                    bếpToolStripMenuItem.Enabled = false;
                    nhânSựToolStripMenuItem.Enabled = false;
                    thốngKêToolStripMenuItem.Enabled = false;
                    hệThốngToolStripMenuItem.Enabled = false;
                    danhMụcToolStripMenuItem.Enabled = false;
                    khoToolStripMenuItem.Enabled = false;
                    break;
                default:
                    MessageBox.Show("Loại nhân viên không hợp lệ.");
                    break;
            }
        }

        private void AnForm(List<string> formAn)
        {
            foreach(var form in formAn)
            {
                return;
            }
        }

        private void btnSystem_Click(object sender, EventArgs e)
        {
            //CloseAllChildForms();
            OpenFormInCorner(new frmHeThong());
        }

        private void btnDoimatkhau_Click(object sender, EventArgs e)
        {
            //CloseAllChildForms();
            OpenFormInCorner(new frmDoiMatKhau());
        }

        private void btnNhansu_Click(object sender, EventArgs e)
        {
            OpenFormInCorner(new frmQuanLyNhanVien());
        }

        private void frmTrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (result == DialogResult.Yes)
            //{
            //    nhanvien.MaLoaiNhanVien = null;
            //    this.Close();
            //}
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (result == DialogResult.Yes)
            //{
            //    nhanvien.MaLoaiNhanVien = null;
            //    this.Close();
            //}
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OpenFormInCorner(new frmHeThong());
        }

        private void saoLưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmSaoLuu frmSl = new frmSaoLuu();
            //frmSl.ShowDialog();
            //CloseAllChildForms();
            OpenFormInCorner1(new frmSaoLuu());
            loadBtnQuayLai();
        }

        private void phụcHồiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CloseAllChildForms();
            OpenFormInCorner1(new frmPhucHoi());
            loadBtnQuayLai();
        }

        private void phânQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CloseAllChildForms();
            OpenFormInCorner1(new frmPhanQuyen());
            loadBtnQuayLai();
        }

        private void quảnLýNhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInCorner1(new frmQuanLyNhanVien());
            loadBtnQuayLai();
        }

        private void đơnVịTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInCorner1(new frmDonViTinh());
            loadBtnQuayLai();
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in pnlTrangchu.Controls)
            {
                if (ctrl is Form)
                {
                    ((Form)ctrl).Close();
                }
            }
            btnQuaylai.Visible = false; 
            pnlLeft.Show();
            pnlTrangchu.SendToBack();
        }

        private void loạiNguyênLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void loạiMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInCorner1(new frmLoaiMonAn());
            loadBtnQuayLai();
        }

        private void quảnLýLịchLàmViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInCorner1(new frmLichLamViec());
            loadBtnQuayLai();
        }

        private void khuyếnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInCorner1(new frmKhuyenMai());
            loadBtnQuayLai();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInCorner1(new frmDoiMatKhau());
            loadBtnQuayLai();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInCorner1(new frmThongKeDoanhThu());
            loadBtnQuayLai();
        }

        private void gọiMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInCorner1(new frmDatMon());
            loadBtnQuayLai();
        }

        private void quảnLýMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInCorner1(new frmQuanLyMonAn());
            loadBtnQuayLai();
        }

        private void tàiKhoảnNgânHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInCorner1(new frmTaiKhoanNganHang());
            loadBtnQuayLai();
        }

        private void quảnLýComboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInCorner1(new frmQuanLyCombo());
            loadBtnQuayLai();
        }

        private void bếpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInCorner1(new frmBep());
            loadBtnQuayLai();
        }

        private void đặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInCorner1(new frmDatHang());
            loadBtnQuayLai();
        }

        private void nhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInCorner1(new frmNhapKho());
            loadBtnQuayLai();
        }

        private void xuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInCorner1(new frmKho());
            loadBtnQuayLai();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInCorner1(new frmTaoNhaCungCap());
            loadBtnQuayLai();
        }

        private void thêmNguyênLiệuMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void loạiNguyênLiệuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFormInCorner1(new frmLoaiNguyenLieu());
            loadBtnQuayLai();
        }

        private void thêmNguyênLiệuMớiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFormInCorner1(new frmTaoNguyenLieu());
            loadBtnQuayLai();
        }

        private void lịchSửXuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInCorner1(new frmLichSuXuatKho());
            loadBtnQuayLai();
        }
    }
}
