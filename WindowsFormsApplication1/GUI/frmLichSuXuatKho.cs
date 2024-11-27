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
using WindowsFormsApplication1.BUS;
using WindowsFormsApplication1.DAL;
using WindowsFormsApplication1.DTO;

namespace WindowsFormsApplication1
{
    public partial class frmLichSuXuatKho : Form
    {
        BUS_LichSuXuatKho lsx = new BUS_LichSuXuatKho();
        public frmLichSuXuatKho()
        {
            InitializeComponent();
            LoadDgvLichSuXuat();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DateTime ngayBatDau = dtpNgayBatDau.Value;
            DateTime ngayKetThuc = dtpNgayKetThuc.Value;

            // Kiểm tra ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc
            if (ngayBatDau > ngayKetThuc)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc.");
                return;
            }

            // Tìm kiếm theo khoảng thời gian
            DataTable result = lsx.TimKiemLichSuXuatTheoNgay(ngayBatDau, ngayKetThuc);

            // Hiển thị kết quả tìm kiếm trong DataGridView
            dgvLichSuXuat.DataSource = result;
        }
        private BUS_Kho busLichSuXuatKho = new BUS_Kho();
        private void LoadDgvLichSuXuat()
        {
            //string query = "SELECT MaXuatKho, MaNguyenLieu, MaDiaDiemXuat, MaDiaDiemNhap, SoLuong, NgayThucHien " +
            //               "FROM LichSuXuatNguyenLieu";

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    using (SqlCommand command = new SqlCommand(query, connection))
            //    {
            //        SqlDataAdapter adapter = new SqlDataAdapter(command);
            //        DataTable dataTable = new DataTable();
            //        adapter.Fill(dataTable);

            //        dgvLichSuXuat.DataSource = dataTable;
            //    }
            //}
            List<LichSuXuatKhoDTO> lstLichSuXuatKho = busLichSuXuatKho.LichSuXuatKho();
            dgvLichSuXuat.DataSource = lstLichSuXuatKho;
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            frmKho frmKho = new frmKho();
            this.Hide();
            frmKho.ShowDialog();
            this.Show();
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            dtpNgayBatDau.Value = DateTime.Now;
            dtpNgayKetThuc.Value = DateTime.Now;

            // Tải lại dữ liệu mặc định của DataGridView
            LoadDgvLichSuXuat();  // Giả sử bạn có hàm này để tải lại dữ liệu ban đầu

            // Thông báo cho người dùng nếu cần
            MessageBox.Show("Dữ liệu đã hiển thị tất cả.");
        }
    }
}
