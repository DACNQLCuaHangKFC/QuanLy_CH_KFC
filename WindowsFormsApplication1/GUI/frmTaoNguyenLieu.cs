using WindowsFormsApplication1.BUS;
using WindowsFormsApplication1.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.DTO;

namespace WindowsFormsApplication1
{
    public partial class frmTaoNguyenLieu : Form
    {
        BUS_Kho BUS_Kho = new BUS_Kho();
        
        public frmTaoNguyenLieu()
        {
            InitializeComponent();
            LoadComboboxDVT();
            LoadComboboxLNL();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void LoadComboboxDVT()
        {
            //DonViTinhBUS dvt = new DonViTinhBUS();
            DataTable dtLoaiDVT = BUS.DonViTinhBUS.hienThiDonViTinh(); // Giả sử bạn đã có phương thức để lấy tất cả loại nguyên liệu
            cboDvt.DataSource = dtLoaiDVT;
            cboDvt.DisplayMember = "TenDVT"; // Tên hiển thị trong ComboBox
            cboDvt.ValueMember = "MaDVT";
        }
        private void LoadComboboxLNL()
        {
            BUS_LoaiNguyenLieu busLoaiNguyenLieu = new BUS_LoaiNguyenLieu();
            List<LoaiNguyenLieuDTO> dtLoaiNguyenLieu = busLoaiNguyenLieu.GetAllLoaiNguyenLieu(); // Giả sử bạn đã có phương thức để lấy tất cả loại nguyên liệu
            cboMaLNL.DataSource = dtLoaiNguyenLieu;
            cboMaLNL.DisplayMember = "TenLoaiNguyenLieu"; // Tên hiển thị trong ComboBox
            cboMaLNL.ValueMember = "MaLoaiNguyenLieu";
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            frmKho formKho = new frmKho();
            this.Hide();
            formKho.ShowDialog();
            this.Show();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn tạo nguyên liệu này không?",
            //                              "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //// Nếu người dùng chọn "No", dừng lại và không làm gì
            //if (result == DialogResult.No)
            //{
            //    return;
            //}
            //if (string.IsNullOrEmpty(txtTennl.Text) || cboDvt.SelectedValue == null || cboMaLNL.SelectedValue == null)
            //{
            //    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //string tenNguyenLieu = txtTennl.Text;
            //string maDVT = cboDvt.SelectedValue.ToString();
            //string maLoaiNguyenLieu = cboMaLNL.SelectedValue.ToString();
            //string maNguyenLieu = GenerateNewMaNguyenLieu();

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            //    SqlTransaction transaction = connection.BeginTransaction();

            //    try
            //    {
            //        // Thêm vào bảng NguyenLieu
            //        string queryInsertNguyenLieu = "INSERT INTO NguyenLieu (MaNguyenLieu, MaLoaiNguyenLieu, TenNguyenLieu, MaDVT) " +
            //                                       "VALUES (@MaNguyenLieu, @MaLoaiNguyenLieu, @TenNguyenLieu, @MaDVT)";

            //        using (SqlCommand cmdNguyenLieu = new SqlCommand(queryInsertNguyenLieu, connection, transaction))
            //        {
            //            cmdNguyenLieu.Parameters.AddWithValue("@MaNguyenLieu", maNguyenLieu);
            //            cmdNguyenLieu.Parameters.AddWithValue("@MaLoaiNguyenLieu", maLoaiNguyenLieu);
            //            cmdNguyenLieu.Parameters.AddWithValue("@TenNguyenLieu", tenNguyenLieu);
            //            cmdNguyenLieu.Parameters.AddWithValue("@MaDVT", maDVT);
            //            cmdNguyenLieu.ExecuteNonQuery();
            //        }

            //        // Cập nhật vào bảng TonKho với địa điểm Kho
            //        string queryInsertKho = "INSERT INTO TonKho (MaNguyenLieu, MaDiaDiem, SoLuongTon, TrangThai) " +
            //                                "VALUES (@MaNguyenLieu, 'DD001', 0, N'Cần Nhập')";
            //        using (SqlCommand cmdTonKho = new SqlCommand(queryInsertKho, connection, transaction))
            //        {
            //            cmdTonKho.Parameters.AddWithValue("@MaNguyenLieu", maNguyenLieu);
            //            cmdTonKho.ExecuteNonQuery();
            //        }

            //        // Cập nhật vào bảng TonKho với địa điểm Bếp
            //        string queryInsertBep = "INSERT INTO TonKho (MaNguyenLieu, MaDiaDiem, SoLuongTon, TrangThai) " +
            //                                "VALUES (@MaNguyenLieu, 'DD002', 0, N'Cần Nhập')";
            //        using (SqlCommand cmdTonBep = new SqlCommand(queryInsertBep, connection, transaction))
            //        {
            //            cmdTonBep.Parameters.AddWithValue("@MaNguyenLieu", maNguyenLieu);
            //            cmdTonBep.ExecuteNonQuery();
            //        }

            //        transaction.Commit();
            //        MessageBox.Show("Tạo nguyên liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    catch (Exception ex)
            //    {
            //        transaction.Rollback();
            //        MessageBox.Show("Lỗi: " + ex.Message);
            //    }
            //}
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn tạo nguyên liệu này không?",
                                  "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }

            string tenNguyenLieu = txtTennl.Text;
            string maLoaiNguyenLieu = cboMaLNL.SelectedValue?.ToString();
            string maDVT = cboDvt.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(tenNguyenLieu) || string.IsNullOrEmpty(maLoaiNguyenLieu) || string.IsNullOrEmpty(maDVT))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool success = BUS_Kho.TaoNguyenLieu(tenNguyenLieu, maLoaiNguyenLieu, maDVT);

            if (success)
            {   
                MessageBox.Show("Tạo nguyên liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
            }
            else
                MessageBox.Show("Tạo nguyên liệu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        private void ResetForm()
        {
            // Đặt lại giá trị cho các textbox
            txtTennl.Clear();

            // Nếu có combobox cho mã loại và mã đơn vị, đặt lại về giá trị mặc định
            if (cboMaLNL.Items.Count > 0)
            {
                cboMaLNL.SelectedIndex = 0; // Hoặc null nếu bạn muốn
            }

            if (cboDvt.Items.Count > 0)
            {
                cboDvt.SelectedIndex = 0; // Hoặc null nếu bạn muốn
            }

            // Nếu có bất kỳ textbox nào khác, bạn cũng có thể đặt lại chúng ở đây
        }

        private void frmTaoNguyenLieu_Load(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void cboDvt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
