
namespace WindowsFormsApplication1
{
    partial class frmDatMon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpSearchProduct = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cboLoaiMon = new System.Windows.Forms.ComboBox();
            this.dgvChonMon = new System.Windows.Forms.DataGridView();
            this.txtTimMonAn = new System.Windows.Forms.TextBox();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.grpInfoInvoice = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThemKhachHang = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHoTenTao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSDTTao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTimKhachHang = new System.Windows.Forms.TextBox();
            this.cboMaKhuyenMai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.grpPayment = new System.Windows.Forms.GroupBox();
            this.chkChuyenKhoan = new System.Windows.Forms.CheckBox();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkSuDung = new System.Windows.Forms.CheckBox();
            this.lblSoDiem = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalMoney = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.lblMoney = new System.Windows.Forms.Label();
            this.grpListProduct = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTimKiemMonDaGoi = new System.Windows.Forms.TextBox();
            this.dgvDanhSachMonChon = new System.Windows.Forms.DataGridView();
            this.btnXoaMon = new System.Windows.Forms.Button();
            this.grpSearchProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonMon)).BeginInit();
            this.grpInfoInvoice.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpPayment.SuspendLayout();
            this.grpListProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMonChon)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSearchProduct
            // 
            this.grpSearchProduct.Controls.Add(this.label9);
            this.grpSearchProduct.Controls.Add(this.label3);
            this.grpSearchProduct.Controls.Add(this.txtSoLuong);
            this.grpSearchProduct.Controls.Add(this.cboLoaiMon);
            this.grpSearchProduct.Controls.Add(this.dgvChonMon);
            this.grpSearchProduct.Controls.Add(this.txtTimMonAn);
            this.grpSearchProduct.Controls.Add(this.btnThemMon);
            this.grpSearchProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearchProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.grpSearchProduct.Location = new System.Drawing.Point(10, 10);
            this.grpSearchProduct.Name = "grpSearchProduct";
            this.grpSearchProduct.Size = new System.Drawing.Size(480, 436);
            this.grpSearchProduct.TabIndex = 23;
            this.grpSearchProduct.TabStop = false;
            this.grpSearchProduct.Text = "Chọn món";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(210, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "Tìm Kiếm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Số Lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(85, 400);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(129, 27);
            this.txtSoLuong.TabIndex = 13;
            // 
            // cboLoaiMon
            // 
            this.cboLoaiMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiMon.FormattingEnabled = true;
            this.cboLoaiMon.Location = new System.Drawing.Point(6, 27);
            this.cboLoaiMon.Name = "cboLoaiMon";
            this.cboLoaiMon.Size = new System.Drawing.Size(198, 28);
            this.cboLoaiMon.TabIndex = 12;
            this.cboLoaiMon.SelectedIndexChanged += new System.EventHandler(this.cboLoaiMon_SelectedIndexChanged);
            // 
            // dgvChonMon
            // 
            this.dgvChonMon.AllowUserToAddRows = false;
            this.dgvChonMon.AllowUserToDeleteRows = false;
            this.dgvChonMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChonMon.Location = new System.Drawing.Point(6, 60);
            this.dgvChonMon.Name = "dgvChonMon";
            this.dgvChonMon.ReadOnly = true;
            this.dgvChonMon.RowHeadersWidth = 51;
            this.dgvChonMon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChonMon.Size = new System.Drawing.Size(467, 334);
            this.dgvChonMon.TabIndex = 1;
            // 
            // txtTimMonAn
            // 
            this.txtTimMonAn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimMonAn.Location = new System.Drawing.Point(292, 26);
            this.txtTimMonAn.Name = "txtTimMonAn";
            this.txtTimMonAn.Size = new System.Drawing.Size(182, 27);
            this.txtTimMonAn.TabIndex = 0;
            this.txtTimMonAn.TextChanged += new System.EventHandler(this.txtTimMonAn_TextChanged);
            // 
            // btnThemMon
            // 
            this.btnThemMon.BackColor = System.Drawing.SystemColors.Control;
            this.btnThemMon.ForeColor = System.Drawing.Color.Black;
            this.btnThemMon.Location = new System.Drawing.Point(371, 395);
            this.btnThemMon.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(104, 36);
            this.btnThemMon.TabIndex = 11;
            this.btnThemMon.Text = "Thêm Món";
            this.btnThemMon.UseVisualStyleBackColor = false;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // grpInfoInvoice
            // 
            this.grpInfoInvoice.Controls.Add(this.groupBox1);
            this.grpInfoInvoice.Controls.Add(this.label5);
            this.grpInfoInvoice.Controls.Add(this.txtTimKhachHang);
            this.grpInfoInvoice.Controls.Add(this.cboMaKhuyenMai);
            this.grpInfoInvoice.Controls.Add(this.label1);
            this.grpInfoInvoice.Controls.Add(this.cboKhachHang);
            this.grpInfoInvoice.Controls.Add(this.lblUser);
            this.grpInfoInvoice.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfoInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.grpInfoInvoice.Location = new System.Drawing.Point(10, 453);
            this.grpInfoInvoice.Name = "grpInfoInvoice";
            this.grpInfoInvoice.Size = new System.Drawing.Size(480, 234);
            this.grpInfoInvoice.TabIndex = 25;
            this.grpInfoInvoice.TabStop = false;
            this.grpInfoInvoice.Text = "Thông tin hóa đơn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThemKhachHang);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtHoTenTao);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSDTTao);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.groupBox1.Location = new System.Drawing.Point(10, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 133);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm Khách Hàng";
            // 
            // btnThemKhachHang
            // 
            this.btnThemKhachHang.BackColor = System.Drawing.SystemColors.Control;
            this.btnThemKhachHang.ForeColor = System.Drawing.Color.Black;
            this.btnThemKhachHang.Location = new System.Drawing.Point(327, 56);
            this.btnThemKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemKhachHang.Name = "btnThemKhachHang";
            this.btnThemKhachHang.Size = new System.Drawing.Size(104, 36);
            this.btnThemKhachHang.TabIndex = 25;
            this.btnThemKhachHang.Text = "Thêm Khách Hàng";
            this.btnThemKhachHang.UseVisualStyleBackColor = false;
            this.btnThemKhachHang.Click += new System.EventHandler(this.btnThemKhachHang_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Họ Tên:";
            // 
            // txtHoTenTao
            // 
            this.txtHoTenTao.Location = new System.Drawing.Point(119, 81);
            this.txtHoTenTao.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoTenTao.Name = "txtHoTenTao";
            this.txtHoTenTao.Size = new System.Drawing.Size(136, 27);
            this.txtHoTenTao.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Số Điện Thoại:";
            // 
            // txtSDTTao
            // 
            this.txtSDTTao.Location = new System.Drawing.Point(119, 41);
            this.txtSDTTao.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDTTao.Name = "txtSDTTao";
            this.txtSDTTao.Size = new System.Drawing.Size(136, 27);
            this.txtSDTTao.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Tìm Kiếm:";
            // 
            // txtTimKhachHang
            // 
            this.txtTimKhachHang.Location = new System.Drawing.Point(78, 22);
            this.txtTimKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKhachHang.Name = "txtTimKhachHang";
            this.txtTimKhachHang.Size = new System.Drawing.Size(126, 27);
            this.txtTimKhachHang.TabIndex = 20;
            this.txtTimKhachHang.TextChanged += new System.EventHandler(this.txtTimKhachHang_TextChanged);
            // 
            // cboMaKhuyenMai
            // 
            this.cboMaKhuyenMai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaKhuyenMai.FormattingEnabled = true;
            this.cboMaKhuyenMai.Location = new System.Drawing.Point(324, 61);
            this.cboMaKhuyenMai.Margin = new System.Windows.Forms.Padding(2);
            this.cboMaKhuyenMai.Name = "cboMaKhuyenMai";
            this.cboMaKhuyenMai.Size = new System.Drawing.Size(149, 28);
            this.cboMaKhuyenMai.TabIndex = 17;
            this.cboMaKhuyenMai.SelectedIndexChanged += new System.EventHandler(this.cboMaKhuyenMai_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã Khuyến Mãi:";
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachHang.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboKhachHang.FormattingEnabled = true;
            this.cboKhachHang.Location = new System.Drawing.Point(324, 22);
            this.cboKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(149, 28);
            this.cboKhachHang.TabIndex = 15;
            this.cboKhachHang.SelectedIndexChanged += new System.EventHandler(this.cboKhachHang_SelectedIndexChanged);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(206, 25);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(94, 20);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Khách hàng:";
            // 
            // grpPayment
            // 
            this.grpPayment.Controls.Add(this.chkChuyenKhoan);
            this.grpPayment.Controls.Add(this.txtVAT);
            this.grpPayment.Controls.Add(this.label4);
            this.grpPayment.Controls.Add(this.chkSuDung);
            this.grpPayment.Controls.Add(this.lblSoDiem);
            this.grpPayment.Controls.Add(this.btnLuu);
            this.grpPayment.Controls.Add(this.label2);
            this.grpPayment.Controls.Add(this.lblTotalMoney);
            this.grpPayment.Controls.Add(this.lblTotal);
            this.grpPayment.Controls.Add(this.btnInHoaDon);
            this.grpPayment.Controls.Add(this.txtGiamGia);
            this.grpPayment.Controls.Add(this.lblDiscount);
            this.grpPayment.Controls.Add(this.txtThanhTien);
            this.grpPayment.Controls.Add(this.lblMoney);
            this.grpPayment.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.grpPayment.Location = new System.Drawing.Point(498, 453);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Size = new System.Drawing.Size(460, 234);
            this.grpPayment.TabIndex = 27;
            this.grpPayment.TabStop = false;
            this.grpPayment.Text = "Thanh toán";
            // 
            // chkChuyenKhoan
            // 
            this.chkChuyenKhoan.AutoSize = true;
            this.chkChuyenKhoan.Location = new System.Drawing.Point(11, 200);
            this.chkChuyenKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.chkChuyenKhoan.Name = "chkChuyenKhoan";
            this.chkChuyenKhoan.Size = new System.Drawing.Size(128, 24);
            this.chkChuyenKhoan.TabIndex = 25;
            this.chkChuyenKhoan.Text = "Chuyển Khoản";
            this.chkChuyenKhoan.UseVisualStyleBackColor = true;
            // 
            // txtVAT
            // 
            this.txtVAT.Enabled = false;
            this.txtVAT.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVAT.Location = new System.Drawing.Point(321, 96);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Size = new System.Drawing.Size(128, 27);
            this.txtVAT.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(237, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "VAT: 10%";
            // 
            // chkSuDung
            // 
            this.chkSuDung.AutoSize = true;
            this.chkSuDung.Location = new System.Drawing.Point(241, 30);
            this.chkSuDung.Margin = new System.Windows.Forms.Padding(2);
            this.chkSuDung.Name = "chkSuDung";
            this.chkSuDung.Size = new System.Drawing.Size(87, 24);
            this.chkSuDung.TabIndex = 21;
            this.chkSuDung.Text = "Sử Dụng";
            this.chkSuDung.UseVisualStyleBackColor = true;
            this.chkSuDung.CheckedChanged += new System.EventHandler(this.chkSuDung_CheckedChanged);
            // 
            // lblSoDiem
            // 
            this.lblSoDiem.AutoSize = true;
            this.lblSoDiem.Location = new System.Drawing.Point(137, 30);
            this.lblSoDiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoDiem.Name = "lblSoDiem";
            this.lblSoDiem.Size = new System.Drawing.Size(17, 20);
            this.lblSoDiem.TabIndex = 20;
            this.lblSoDiem.Text = "0";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.Control;
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Location = new System.Drawing.Point(243, 193);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(104, 36);
            this.btnLuu.TabIndex = 14;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Điểm Tích Lũy: ";
            // 
            // lblTotalMoney
            // 
            this.lblTotalMoney.AutoSize = true;
            this.lblTotalMoney.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.lblTotalMoney.Location = new System.Drawing.Point(159, 158);
            this.lblTotalMoney.Name = "lblTotalMoney";
            this.lblTotalMoney.Size = new System.Drawing.Size(25, 30);
            this.lblTotalMoney.TabIndex = 18;
            this.lblTotalMoney.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.lblTotal.Location = new System.Drawing.Point(6, 158);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(143, 30);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "TỔNG CỘNG:";
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.BackColor = System.Drawing.SystemColors.Control;
            this.btnInHoaDon.ForeColor = System.Drawing.Color.Black;
            this.btnInHoaDon.Location = new System.Drawing.Point(351, 193);
            this.btnInHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(104, 36);
            this.btnInHoaDon.TabIndex = 13;
            this.btnInHoaDon.Text = "In Hóa Đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = false;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Enabled = false;
            this.txtGiamGia.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiamGia.Location = new System.Drawing.Point(321, 64);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(128, 27);
            this.txtGiamGia.TabIndex = 12;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(237, 68);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(74, 20);
            this.lblDiscount.TabIndex = 11;
            this.lblDiscount.Text = "Giảm Giá:";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Location = new System.Drawing.Point(105, 65);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(126, 27);
            this.txtThanhTien.TabIndex = 10;
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.lblMoney.Location = new System.Drawing.Point(6, 66);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(89, 20);
            this.lblMoney.TabIndex = 1;
            this.lblMoney.Text = "Thành Tiền:";
            // 
            // grpListProduct
            // 
            this.grpListProduct.Controls.Add(this.label8);
            this.grpListProduct.Controls.Add(this.txtTimKiemMonDaGoi);
            this.grpListProduct.Controls.Add(this.dgvDanhSachMonChon);
            this.grpListProduct.Controls.Add(this.btnXoaMon);
            this.grpListProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpListProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.grpListProduct.Location = new System.Drawing.Point(498, 18);
            this.grpListProduct.Name = "grpListProduct";
            this.grpListProduct.Size = new System.Drawing.Size(460, 428);
            this.grpListProduct.TabIndex = 26;
            this.grpListProduct.TabStop = false;
            this.grpListProduct.Text = "Danh sách gọi món";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Tìm Kiếm:";
            // 
            // txtTimKiemMonDaGoi
            // 
            this.txtTimKiemMonDaGoi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemMonDaGoi.Location = new System.Drawing.Point(118, 18);
            this.txtTimKiemMonDaGoi.Name = "txtTimKiemMonDaGoi";
            this.txtTimKiemMonDaGoi.Size = new System.Drawing.Size(302, 27);
            this.txtTimKiemMonDaGoi.TabIndex = 13;
            this.txtTimKiemMonDaGoi.TextChanged += new System.EventHandler(this.txtTimKiemMonDaGoi_TextChanged);
            // 
            // dgvDanhSachMonChon
            // 
            this.dgvDanhSachMonChon.AllowUserToAddRows = false;
            this.dgvDanhSachMonChon.AllowUserToDeleteRows = false;
            this.dgvDanhSachMonChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachMonChon.Location = new System.Drawing.Point(6, 52);
            this.dgvDanhSachMonChon.Name = "dgvDanhSachMonChon";
            this.dgvDanhSachMonChon.ReadOnly = true;
            this.dgvDanhSachMonChon.RowHeadersWidth = 51;
            this.dgvDanhSachMonChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachMonChon.Size = new System.Drawing.Size(445, 334);
            this.dgvDanhSachMonChon.TabIndex = 2;
            // 
            // btnXoaMon
            // 
            this.btnXoaMon.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoaMon.ForeColor = System.Drawing.Color.Black;
            this.btnXoaMon.Location = new System.Drawing.Point(356, 387);
            this.btnXoaMon.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaMon.Name = "btnXoaMon";
            this.btnXoaMon.Size = new System.Drawing.Size(104, 36);
            this.btnXoaMon.TabIndex = 12;
            this.btnXoaMon.Text = "Xóa Món";
            this.btnXoaMon.UseVisualStyleBackColor = false;
            this.btnXoaMon.Click += new System.EventHandler(this.btnXoaMon_Click);
            // 
            // frmDatMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(967, 694);
            this.Controls.Add(this.grpPayment);
            this.Controls.Add(this.grpListProduct);
            this.Controls.Add(this.grpInfoInvoice);
            this.Controls.Add(this.grpSearchProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDatMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gọi Món";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDatMon_FormClosing);
            this.Load += new System.EventHandler(this.frmDatMon_Load);
            this.grpSearchProduct.ResumeLayout(false);
            this.grpSearchProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonMon)).EndInit();
            this.grpInfoInvoice.ResumeLayout(false);
            this.grpInfoInvoice.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpPayment.ResumeLayout(false);
            this.grpPayment.PerformLayout();
            this.grpListProduct.ResumeLayout(false);
            this.grpListProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMonChon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSearchProduct;
        private System.Windows.Forms.DataGridView dgvChonMon;
        private System.Windows.Forms.TextBox txtTimMonAn;
        private System.Windows.Forms.GroupBox grpInfoInvoice;
        private System.Windows.Forms.TextBox txtTimKhachHang;
        private System.Windows.Forms.ComboBox cboMaKhuyenMai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.GroupBox grpPayment;
        private System.Windows.Forms.CheckBox chkSuDung;
        private System.Windows.Forms.Label lblSoDiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalMoney;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.GroupBox grpListProduct;
        public System.Windows.Forms.DataGridView dgvDanhSachMonChon;
        private System.Windows.Forms.Button btnXoaMon;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.TextBox txtTimKiemMonDaGoi;
        private System.Windows.Forms.ComboBox cboLoaiMon;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.CheckBox chkChuyenKhoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThemKhachHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHoTenTao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSDTTao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

