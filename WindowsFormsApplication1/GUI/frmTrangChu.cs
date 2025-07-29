using QLCuaHangKFC;
using QLCuaHangKFC.GUI;
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
using WindowsFormsApplication1.GUI;

namespace WindowsFormsApplication1.GUI
{
    public partial class frmTrangChu : Form
    {
        private NhanVienDTO nhanvien;
        public static string MaNhanVien;
        private frmTrangChu trangChu;
        private Size originalFormSize;
        private Size originalPnlTrangchuSize;
        private Point originalPnlTrangchuLocation;
        public frmTrangChu(NhanVienDTO nhanvien)
        {
            InitializeComponent();
            this.nhanvien = nhanvien;
            lblTennhanvien.Text = "Xin chào: " + nhanvien.TenNhanVien;
            PhanQuyen();
            MaNhanVien = nhanvien.MaNhanVien;
            btnQuaylai.Visible = false;
        }

        private void loadBtnQuayLai()
        {
            if (pnlTrangchu.Controls.Count > 0)
            {
                btnQuaylai.Visible = true;
                btnQuaylai.BringToFront();
            }
            else
            {
                btnQuaylai.Visible = false;
            }
        }
        private bool IsDataValidToClose()
        {
            // Duyệt qua các form con hiện tại
            foreach (Control control in pnlTrangchu.Controls)
            {
                if (control is Form form && form is frmDatMon datMonForm)
                {
                    // Kiểm tra nếu form chứa `DataGridView` còn dữ liệu
                    if (datMonForm.dgvDanhSachMonChon.Rows.Count > 0)
                    {
                        var result = MessageBox.Show(
                            "Danh sách món chọn vẫn còn dữ liệu. Bạn có chắc chắn muốn tiếp tục?",
                            "Cảnh báo",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning
                        );

                        // Nếu người dùng chọn "No", không cho phép đóng/chuyển form
                        if (result == DialogResult.No)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        private void OpenFormInCorner1(Form childForm)
        {
            // Kiểm tra dữ liệu trước khi chuyển đổi
            if (!CanSwitchForm())
            {
                return; // Không làm gì nếu dữ liệu chưa được xử lý
            }

            // Tiếp tục logic mở form nếu kiểm tra thành công
            if (originalFormSize == Size.Empty)
            {
                originalFormSize = this.Size;
                originalPnlTrangchuSize = pnlTrangchu.Size;
                originalPnlTrangchuLocation = pnlTrangchu.Location;
            }

            pnlTrangchu.BackgroundImage = null;
            btnDangxuat.Visible = false;
            lblTennhanvien.Visible = false;

            // Đóng các form con hiện tại
            foreach (Control control in pnlTrangchu.Controls)
            {
                if (control is Form form)
                {
                    form.Close();
                }
            }

            pnlTrangchu.Controls.Clear();

            int menuStripHeight = menuStrip1.Height;
            int formWidth = childForm.Width;
            int formHeight = childForm.Height;

            pnlTrangchu.Location = new Point(btnQuaylai.Right, menuStripHeight);
            pnlTrangchu.Size = new Size(formWidth, formHeight);
            this.Size = new Size(formWidth + btnQuaylai.Right, formHeight + menuStripHeight);

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            pnlTrangchu.Controls.Add(childForm);
            childForm.Show();

            childForm.Location = new Point(
                (pnlTrangchu.Width - formWidth) / 2,
                (pnlTrangchu.Height - formHeight) / 2
            );

            pnlTrangchu.BringToFront();
            menuStrip1.BringToFront();
            loadBtnQuayLai();
        }


        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            originalFormSize = this.Size;
            originalPnlTrangchuSize = pnlTrangchu.Size;
            originalPnlTrangchuLocation = pnlTrangchu.Location;
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
                    sảnPhẩmToolStripMenuItem.Enabled = false;
                    break;
                case "LNV003":

                    bếpToolStripMenuItem.Enabled = false;
                    nhânSựToolStripMenuItem.Enabled = false;
                    thốngKêToolStripMenuItem.Enabled = false;
                    hệThốngToolStripMenuItem.Enabled = false;
                    danhMụcToolStripMenuItem.Enabled = false;
                    sảnPhẩmToolStripMenuItem.Enabled = false;
                    khoToolStripMenuItem.Enabled = false;
                    break;
                case "LNV004":

                    bếpToolStripMenuItem.Enabled = false;
                    nhânSựToolStripMenuItem.Enabled = false;
                    thốngKêToolStripMenuItem.Enabled = false;
                    hệThốngToolStripMenuItem.Enabled = false;
                    danhMụcToolStripMenuItem.Enabled = false;
                    khoToolStripMenuItem.Enabled = false;
                    sảnPhẩmToolStripMenuItem.Enabled = false;
                    break;
                case "LNV005":

                    bếpToolStripMenuItem.Enabled = false;
                    nhânSựToolStripMenuItem.Enabled = false;
                    thốngKêToolStripMenuItem.Enabled = false;
                    hệThốngToolStripMenuItem.Enabled = false;
                    danhMụcToolStripMenuItem.Enabled = false;
                    sảnPhẩmToolStripMenuItem.Enabled = false;
                    danhMụcToolStripMenuItem.Enabled = false;
                    gọiMónToolStripMenuItem.Enabled = false;
                    //khoToolStripMenuItem.Enabled = false;
                    break;
                default:
                    MessageBox.Show("Loại nhân viên không hợp lệ.");
                    break;
            }
        }
        private void btnSystem_Click(object sender, EventArgs e)
        {
            //CloseAllChildForms();
            //OpenFormInCorner(new frmHeThong());
        }

        private void btnDoimatkhau_Click(object sender, EventArgs e)
        {
            //CloseAllChildForms();
            OpenFormInCorner1(new frmDoiMatKhau());
        }

        private void btnNhansu_Click(object sender, EventArgs e)
        {
            OpenFormInCorner1(new frmQuanLyNhanVien());
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
            OpenFormInCorner1(new frmSaoLuu());
        }

        private void phụcHồiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInCorner1(new frmPhucHoi());
        }

        private void phânQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInCorner1(new frmPhanQuyen());
        }

        private void quảnLýNhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInCorner1(new frmQuanLyNhanVien());
        }

        private void đơnVịTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInCorner1(new frmDonViTinh());
        }

        private void loạiNguyênLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loạiMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInCorner1(new frmLoaiMonAn());
        }

        private void quảnLýLịchLàmViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInCorner1(new frmLichLamViec());
        }

        private void khuyếnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInCorner1(new frmKhuyenMai());
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tenNhanVien = lblTennhanvien.Text;
            OpenFormInCorner1(new frmThongKeDoanhThu(tenNhanVien));
        }


        private void quảnLýMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInCorner1(new frmQuanLyMonAn());
        }

        private void tàiKhoảnNgânHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInCorner1(new frmTaiKhoanNganHang());
        }

        private void quảnLýComboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInCorner1(new frmQuanLyCombo());
        }

        private void bếpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInCorner1(new frmBep());
        }

        private void đặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string maNV = MaNhanVien;
            OpenFormInCorner1(new frmDatHang(maNV));
        }

        private void nhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInCorner1(new frmNhapKho());
        }

        private void xuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInCorner1(new frmKho());
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInCorner1(new frmTaoNhaCungCap());
        }

        private void thêmNguyênLiệuMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loạiNguyênLiệuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFormInCorner1(new frmLoaiNguyenLieu());
        }

        private void thêmNguyênLiệuMớiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFormInCorner1(new frmTaoNguyenLieu());
        }

        private void lịchSửXuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInCorner1(new frmLichSuXuatKho());
        }

        private void tồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tenNhanVien = lblTennhanvien.Text;
            OpenFormInCorner1(new frmThongKeTonKho(tenNhanVien));
        }

        private void bànĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInCorner1(new frmBanAn());
        }

        private void gọiMónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
                string maNV = MaNhanVien;
                OpenFormInCorner1(new frmDatMon(maNV));
        }



        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private bool CanSwitchForm()
        {
            // Duyệt qua các control hiện tại trong pnlTrangchu
            foreach (Control control in pnlTrangchu.Controls)
            {
                if (control is Form form && form is frmDatMon datMonForm)
                {
                    // Kiểm tra DataGridView còn dữ liệu không
                    if (datMonForm.dgvDanhSachMonChon.Rows.Count > 0)
                    {
                        // Hiển thị thông báo và không cho phép chuyển form
                        MessageBox.Show(
                            "Danh sách món chọn vẫn còn dữ liệu. Vui lòng hoàn tất trước khi chuyển đổi form!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        return false;
                    }
                }
            }

            // Cho phép chuyển form nếu không có dữ liệu còn lại
            return true;
        }



        private void btnQuaylai_Click_1(object sender, EventArgs e)
        {
            if (CanSwitchForm())
            {
                foreach (Control control in pnlTrangchu.Controls)
                {
                    if (control is Form form)
                    {
                        form.Close();
                    }
                }
                pnlTrangchu.Controls.Clear();
                btnQuaylai.Visible = false;
                this.Size = originalFormSize;
                pnlTrangchu.Location = originalPnlTrangchuLocation;
                pnlTrangchu.Size = originalPnlTrangchuSize;
                btnDangxuat.Visible = true;
                lblTennhanvien.Visible = true;
                pnlTrangchu.BackgroundImage = Properties.Resources.bg_kfc;
            }
        }

        private void pnlTrangchu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void danhSáchHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInCorner1(new frmDanhSachHoaDon());
        }

        private void kháchHàngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFormInCorner1(new frmKhachHang());
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFormInCorner1(new frmDoiMatKhau());
        }
    }
}
