using Octokit.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.BUS;
using WindowsFormsApplication1.DAL;
using WindowsFormsApplication1.DTO;

namespace WindowsFormsApplication1
{
    public partial class frmBep : Form
    {
        private string connectionString = "Server=MSI;Database=QLCuaHangKFC;User Id=sa;Password=123;";
        BUS_Kho BUS_Kho = new BUS_Kho();
        public frmBep()
        {
            InitializeComponent();
            LoadDgvBep();
            InitializeComboBox();
            InitializedgvHD();
            InitializedgvCTHD();
        }
        private void LoadDgvBep()
        {
            List<NguyenLieuDTO> nguyenLieu = BUS_Kho.LayNguyenLieuBep();
            dgvBep.DataSource = nguyenLieu;
            dgvBep.Columns["MaNguyenLieu"].HeaderText = "Mã Nguyên Liệu";
            dgvBep.Columns["TenNguyenLieu"].HeaderText = "Tên Nguyên Liệu";
            dgvBep.Columns["TenDVT"].HeaderText = "Đơn Vị Tính";
            dgvBep.Columns["SoLuongTon"].HeaderText = "Số Lượng Tồn";
            dgvBep.Columns["TrangThai"].HeaderText = "Trạng Thái";
            dgvBep.Columns["TenLoaiNguyenLieu"].Visible = false;
            dgvBep.Columns["MaLoaiNguyenLieu"].Visible = false;
            dgvBep.Columns["MaDVT"].Visible = false;
        }
        
        private void InitializedgvHD()
        {
            // Clear existing columns
            dgvHoaDonThanHToan.AutoGenerateColumns = false; // Disable auto-generating columns
            dgvHoaDonThanHToan.Columns.Clear();

            // Add columns programmatically
            dgvHoaDonThanHToan.Columns.Add(new DataGridViewTextBoxColumn { Name = "MaHoaDon", HeaderText = "Mã Hóa Đơn", DataPropertyName = "MaHoaDon" });
            dgvHoaDonThanHToan.Columns.Add(new DataGridViewTextBoxColumn { Name = "NgayThanhToan", HeaderText = "Ngày Thanh Toán", DataPropertyName = "NgayThanhToan" });
            dgvHoaDonThanHToan.Columns.Add(new DataGridViewTextBoxColumn { Name = "TongTien", HeaderText = "Tổng Tiền", DataPropertyName = "TongTien" });
            dgvHoaDonThanHToan.Columns.Add(new DataGridViewTextBoxColumn { Name = "TrangThai", HeaderText = "Trạng Thái", DataPropertyName = "TrangThai" });

            // You can customize further column properties here if needed (like formatting)
        }
        //private void InitializedgvCTHD()
        //{
        //    // Xóa tất cả các cột hiện tại (nếu có)
        //    dgvChiTietHDTT.Columns.Clear();
        //    dgvChiTietHDTT.Columns.Add("MaHoaDon", "Mã Hóa Đơn");
        //    dgvChiTietHDTT.Columns.Add("MaMonAn", "Mã Món Ăn");
        //    dgvChiTietHDTT.Columns.Add("MaComBo", "Mã Combo");
        //    dgvChiTietHDTT.Columns.Add("SoLuong", "Số Lượng");
        //    dgvChiTietHDTT.Columns.Add("TrangThai", "Trạng Thái");
        //    dgvChiTietHDTT.Columns.Add("TenMonAn", "Tên Món Ăn");
        //    dgvChiTietHDTT.Columns.Add("TenComBo", "Tên Combo");
        //    dgvChiTietHDTT.Columns.Add("GiaMonAn", "Giá Món Ăn");
        //    dgvChiTietHDTT.Columns.Add("GiaCombo", "Giá Combo");

        //    // Bạn có thể tùy chỉnh thêm thuộc tính cho các cột ở đây nếu cần
        //}
        private void InitializedgvCTHD()
        {
            // Disable auto-generating columns
            dgvChiTietHDTT.AutoGenerateColumns = false;

            // Clear existing columns
            dgvChiTietHDTT.Columns.Clear();

            // Add columns with appropriate DataPropertyName
            dgvChiTietHDTT.Columns.Add(new DataGridViewTextBoxColumn { Name = "MaHoaDon", HeaderText = "Mã Hóa Đơn", DataPropertyName = "MaHoaDon" });
            dgvChiTietHDTT.Columns.Add(new DataGridViewTextBoxColumn { Name = "MaMonAn", HeaderText = "Mã Món Ăn", DataPropertyName = "MaMonAn" });
            dgvChiTietHDTT.Columns.Add(new DataGridViewTextBoxColumn { Name = "MaComBo", HeaderText = "Mã Combo", DataPropertyName = "MaCombo" });
            dgvChiTietHDTT.Columns.Add(new DataGridViewTextBoxColumn { Name = "SoLuong", HeaderText = "Số Lượng", DataPropertyName = "SoLuong" });
            dgvChiTietHDTT.Columns.Add(new DataGridViewTextBoxColumn { Name = "TrangThai", HeaderText = "Trạng Thái", DataPropertyName = "TrangThai" });
            dgvChiTietHDTT.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenMonAn", HeaderText = "Tên Món Ăn", DataPropertyName = "TenMonAn" });
            dgvChiTietHDTT.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenComBo", HeaderText = "Tên Combo", DataPropertyName = "TenCombo" });
            dgvChiTietHDTT.Columns.Add(new DataGridViewTextBoxColumn { Name = "GiaMonAn", HeaderText = "Giá Món Ăn", DataPropertyName = "GiaMonAn" });
            dgvChiTietHDTT.Columns.Add(new DataGridViewTextBoxColumn { Name = "GiaCombo", HeaderText = "Giá Combo", DataPropertyName = "GiaCombo" });

            // Customize column properties if necessary
        }


        private void frmBep_Load(object sender, EventArgs e)
        {
            dtpNgayThanhToan.ValueChanged += dtpNgayThanhToan_ValueChanged;

            // Kiểm tra ngay khi form load
            dtpNgayThanhToan_ValueChanged(sender, e);
        }
        private void dtpNgayThanhToan_ValueChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu ngày trong DateTimePicker là ngày hiện tại
            if (dtpNgayThanhToan.Value.Date != DateTime.Now.Date)
            {
                // Nếu không phải ngày hiện tại thì vô hiệu hóa nút Xác Nhận
                btnXacNhan.Enabled = false;
            }
            else
            {
                // Nếu là ngày hiện tại thì kích hoạt nút Xác Nhận
                btnXacNhan.Enabled = true;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            //if (dgvBep.SelectedRows.Count > 0)
            //{
            //    // Lấy dòng đã chọn
            //    DataGridViewRow selectedRow = dgvBep.SelectedRows[0];

            //    // Lấy mã nguyên liệu từ dòng đã chọn
            //    string maNguyenLieu = selectedRow.Cells["MaNguyenLieu"].Value.ToString();

            //    // Cập nhật trạng thái
            //    UpdateTrangThaiNguyenLieu(maNguyenLieu, "Cần Nhập");

            //    // Tải lại DataGridView để phản ánh thay đổi
            //    LoadDgvBep();
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng chọn một sản phẩm để cập nhật trạng thái.");
            //}
            if (dgvBep.SelectedRows.Count > 0)
            {
                // Lấy dòng đã chọn
                DataGridViewRow selectedRow = dgvBep.SelectedRows[0];

                // Lấy mã nguyên liệu và trạng thái từ dòng đã chọn
                string maNguyenLieu = selectedRow.Cells["MaNguyenLieu"].Value.ToString();
                string trangThaiHienTai = selectedRow.Cells["TrangThai"].Value.ToString();

                // Kiểm tra trạng thái hiện tại
                if (trangThaiHienTai == "Cần Nhập")
                {
                    MessageBox.Show("Sản phẩm đã ở trạng thái 'Cần Nhập'.");
                }
                else
                {
                    // Cập nhật trạng thái thông qua lớp Business Logic
                    bool isUpdated = BUS_Kho.CapNhatTrangThaiTonKhoBep(maNguyenLieu, "Cần Nhập");

                    if (isUpdated)
                    {
                        MessageBox.Show("Cập nhật trạng thái thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại. Không tìm thấy sản phẩm.");
                    }

                    // Tải lại DataGridView để phản ánh thay đổi
                    LoadDgvBep();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để cập nhật trạng thái.");
            }
        }
        //private void UpdateTrangThaiNguyenLieu(string maNguyenLieu, string trangThai)
        //{
        //    // Kết nối tới cơ sở dữ liệu
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();

        //        // Tạo câu lệnh cập nhật
        //        string query = "UPDATE TonKho SET TrangThai = N'Cần Nhập' WHERE MaNguyenLieu = @MaNguyenLieu AND MaDiaDiem = (SELECT MaDiaDiem FROM DiaDiem WHERE TenDiaDiem = N'Bếp')";

        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            command.Parameters.AddWithValue("@TrangThai", trangThai);
        //            command.Parameters.AddWithValue("@MaNguyenLieu", maNguyenLieu);

        //            // Thực thi câu lệnh
        //            int rowsAffected = command.ExecuteNonQuery();

        //            if (rowsAffected > 0)
        //            {
        //                MessageBox.Show("Cập nhật trạng thái thành công.");
        //            }
        //            else
        //            {
        //                MessageBox.Show("Cập nhật thất bại. Không tìm thấy sản phẩm.");
        //            }
        //        }
        //    }
        //}
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            SearchByTenNguyenLieu(txtTimKiem.Text);
        }
        private void SearchByTenNguyenLieu(string searchText)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Câu lệnh SQL để tìm kiếm theo tên nguyên liệu
                string query = "SELECT \r\n    NguyenLieu.MaNguyenLieu, \r\n    NguyenLieu.TenNguyenLieu, \r\n    DanhMucDVT.TenDVT, \r\n    TonKho.SoLuongTon, \r\n    TonKho.TrangThai\r\nFROM \r\n    NguyenLieu\r\nJOIN \r\n    DanhMucDVT ON NguyenLieu.MaDVT = DanhMucDVT.MaDVT\r\nJOIN \r\n    TonKho ON NguyenLieu.MaNguyenLieu = TonKho.MaNguyenLieu\r\nJOIN \r\n    DiaDiem ON TonKho.MaDiaDiem = DiaDiem.MaDiaDiem\r\nWHERE \r\n    DiaDiem.TenDiaDiem = N'Bếp' \r\n    AND NguyenLieu.TenNguyenLieu LIKE @SearchText;\r\n";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm tham số tìm kiếm vào câu lệnh SQL
                    command.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Cập nhật DataGridView với dữ liệu tìm được
                    if (dataTable.Rows.Count > 0)
                    {
                        dgvBep.DataSource = dataTable;
                    }
                    else
                    {
                        dgvBep.DataSource = null; // Xóa dữ liệu cũ
                    }
                }
            }
        }

        private void LoadFilteredData()
        {
            DateTime selectedDate = dtpNgayThanhToan.Value;
            string status = cmbTrangThai.SelectedItem.ToString(); // "Tất cả", "Chờ thực hiện", "Đã thực hiện"

            DataTable dt = BUS_Kho.GetHoaDonFiltered(selectedDate, status);
            dgvHoaDonThanHToan.DataSource = dt;
            //foreach (DataRow row in dt.Rows)
            //{
            //    int rowIndex = dgvHoaDonThanHToan.Rows.Add();  // Add a new row to the DataGridView
            //    dgvHoaDonThanHToan.Rows[rowIndex].Cells["MaHoaDon"].Value = row["MaHoaDon"];
            //    dgvHoaDonThanHToan.Rows[rowIndex].Cells["NgayThanhToan"].Value = row["NgayThanhToan"];
            //    dgvHoaDonThanHToan.Rows[rowIndex].Cells["TongTien"].Value = row["TongTien"];
            //    dgvHoaDonThanHToan.Rows[rowIndex].Cells["TrangThai"].Value = row["TrangThai"];
            //}

        }
        
        private void InitializeComboBox()
        {
            cmbTrangThai.Items.Add("Tất cả");
            cmbTrangThai.Items.Add("Chờ thực hiện");
            cmbTrangThai.Items.Add("Đã thực hiện");
            cmbTrangThai.SelectedIndex = 0; // Mặc định chọn "Tất cả"
        }

        private void cmbTrangThai_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadFilteredData();
        }

        private void dtpNgayThanhToan_ValueChanged_1(object sender, EventArgs e)
        {
            LoadFilteredData();
        }

        private void dgvHoaDonThanHToan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvHoaDonThanHToan_SelectionChanged(object sender, EventArgs e)
        {
            
        }
        private void LoadChiTietHoaDon(string maHoaDon)
        {
            DataTable dtChiTietHD = BUS_Kho.LayChiTietHoaDon(maHoaDon);
            dgvChiTietHDTT.DataSource = dtChiTietHD;
        }

        private void dgvHoaDonThnHToan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvHoaDonThanHToan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHoaDonThanHToan.CurrentRow != null)
            {
                string maHoaDon = dgvHoaDonThanHToan.CurrentRow.Cells["MaHoaDon"].Value.ToString();
                LoadChiTietHoaDon(maHoaDon);
            }
            //dgvChiTietHDTT.DataSource = "";
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (dtpNgayThanhToan.Value.Date != DateTime.Now.Date)
            {
                // Vô hiệu hóa button và hiển thị thông báo
                MessageBox.Show("Bạn chỉ có thể xác nhận hóa đơn trong ngày hiện tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnXacNhan.Enabled = false; // Vô hiệu hóa nút Xác Nhận
                return; // Thoát khỏi hàm để không thực hiện các thao tác tiếp theo
            }

            if (dgvChiTietHDTT.SelectedRows.Count > 0)
            {
                // Lấy mã hóa đơn từ hàng đầu tiên được chọn
                string maHoaDon = dgvChiTietHDTT.SelectedRows[0].Cells["MaHoaDon"].Value.ToString();

                // Lấy mã món ăn hoặc mã combo
                string maMonAn = dgvChiTietHDTT.SelectedRows[0].Cells["MaMonAn"].Value.ToString(); // Hoặc MaCombo nếu có

                string maComBo = dgvChiTietHDTT.SelectedRows[0].Cells["MaComBo"].Value.ToString();

                // Cập nhật trạng thái
                bool result = BUS_Kho.CapNhatTrangThaiChiTietHoaDon(maHoaDon, maMonAn,maComBo, "Đã thực hiện");

                if (result)
                {
                    MessageBox.Show("Cập nhật trạng thái thành công!");

                    // Reload lại dữ liệu sau khi cập nhật thành công
                    dgvChiTietHDTT.DataSource = BUS_Kho.LayChiTietHoaDon(maHoaDon);
                }
                else
                {
                    MessageBox.Show("Cập nhật trạng thái thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một chi tiết hóa đơn để xác nhận.");
            }
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
