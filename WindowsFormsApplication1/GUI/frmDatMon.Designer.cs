
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cboLoaiMon = new System.Windows.Forms.ComboBox();
            this.dgvChonMon = new System.Windows.Forms.DataGridView();
            this.txtTimMonAn = new System.Windows.Forms.TextBox();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.grpInfoInvoice = new System.Windows.Forms.GroupBox();
            this.txtTimKhachHang = new System.Windows.Forms.TextBox();
            this.btnThemKhachHang = new System.Windows.Forms.Button();
            this.cboMaKhuyenMai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.grpPayment = new System.Windows.Forms.GroupBox();
            this.chkChuyenKhoan = new System.Windows.Forms.CheckBox();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkSuDung = new System.Windows.Forms.CheckBox();
            this.lblSoDiem = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalMoney = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTienThoi = new System.Windows.Forms.TextBox();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.lblReturnPayment = new System.Windows.Forms.Label();
            this.txtKhachDua = new System.Windows.Forms.TextBox();
            this.lblReceive = new System.Windows.Forms.Label();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.lblMoney = new System.Windows.Forms.Label();
            this.grpListProduct = new System.Windows.Forms.GroupBox();
            this.txtTimKiemMonDaGoi = new System.Windows.Forms.TextBox();
            this.dgvDanhSachMonChon = new System.Windows.Forms.DataGridView();
            this.btnXoaMon = new System.Windows.Forms.Button();
            this.grpSearchProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonMon)).BeginInit();
            this.grpInfoInvoice.SuspendLayout();
            this.grpPayment.SuspendLayout();
            this.grpListProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMonChon)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSearchProduct
            // 
            this.grpSearchProduct.Controls.Add(this.label3);
            this.grpSearchProduct.Controls.Add(this.txtSoLuong);
            this.grpSearchProduct.Controls.Add(this.cboLoaiMon);
            this.grpSearchProduct.Controls.Add(this.dgvChonMon);
            this.grpSearchProduct.Controls.Add(this.txtTimMonAn);
            this.grpSearchProduct.Controls.Add(this.btnThemMon);
            this.grpSearchProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearchProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.grpSearchProduct.Location = new System.Drawing.Point(12, 12);
            this.grpSearchProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSearchProduct.Name = "grpSearchProduct";
            this.grpSearchProduct.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSearchProduct.Size = new System.Drawing.Size(600, 545);
            this.grpSearchProduct.TabIndex = 23;
            this.grpSearchProduct.TabStop = false;
            this.grpSearchProduct.Text = "Chọn món";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 504);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Số Lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(106, 500);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(160, 32);
            this.txtSoLuong.TabIndex = 13;
            // 
            // cboLoaiMon
            // 
            this.cboLoaiMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiMon.FormattingEnabled = true;
            this.cboLoaiMon.Location = new System.Drawing.Point(8, 34);
            this.cboLoaiMon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboLoaiMon.Name = "cboLoaiMon";
            this.cboLoaiMon.Size = new System.Drawing.Size(246, 33);
            this.cboLoaiMon.TabIndex = 12;
            this.cboLoaiMon.SelectedIndexChanged += new System.EventHandler(this.cboLoaiMon_SelectedIndexChanged);
            // 
            // dgvChonMon
            // 
            this.dgvChonMon.AllowUserToAddRows = false;
            this.dgvChonMon.AllowUserToDeleteRows = false;
            this.dgvChonMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChonMon.Location = new System.Drawing.Point(8, 75);
            this.dgvChonMon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvChonMon.Name = "dgvChonMon";
            this.dgvChonMon.ReadOnly = true;
            this.dgvChonMon.RowHeadersWidth = 51;
            this.dgvChonMon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChonMon.Size = new System.Drawing.Size(584, 418);
            this.dgvChonMon.TabIndex = 1;
            // 
            // txtTimMonAn
            // 
            this.txtTimMonAn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimMonAn.Location = new System.Drawing.Point(345, 32);
            this.txtTimMonAn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimMonAn.Name = "txtTimMonAn";
            this.txtTimMonAn.Size = new System.Drawing.Size(246, 32);
            this.txtTimMonAn.TabIndex = 0;
            this.txtTimMonAn.TextChanged += new System.EventHandler(this.txtTimMonAn_TextChanged);
            // 
            // btnThemMon
            // 
            this.btnThemMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.btnThemMon.ForeColor = System.Drawing.Color.White;
            this.btnThemMon.Location = new System.Drawing.Point(464, 494);
            this.btnThemMon.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(130, 45);
            this.btnThemMon.TabIndex = 11;
            this.btnThemMon.Text = "Thêm Món";
            this.btnThemMon.UseVisualStyleBackColor = false;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // grpInfoInvoice
            // 
            this.grpInfoInvoice.Controls.Add(this.txtTimKhachHang);
            this.grpInfoInvoice.Controls.Add(this.btnThemKhachHang);
            this.grpInfoInvoice.Controls.Add(this.cboMaKhuyenMai);
            this.grpInfoInvoice.Controls.Add(this.label1);
            this.grpInfoInvoice.Controls.Add(this.cboKhachHang);
            this.grpInfoInvoice.Controls.Add(this.lblUser);
            this.grpInfoInvoice.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfoInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.grpInfoInvoice.Location = new System.Drawing.Point(12, 565);
            this.grpInfoInvoice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpInfoInvoice.Name = "grpInfoInvoice";
            this.grpInfoInvoice.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpInfoInvoice.Size = new System.Drawing.Size(600, 292);
            this.grpInfoInvoice.TabIndex = 25;
            this.grpInfoInvoice.TabStop = false;
            this.grpInfoInvoice.Text = "Thông tin hóa đơn";
            // 
            // txtTimKhachHang
            // 
            this.txtTimKhachHang.Location = new System.Drawing.Point(158, 28);
            this.txtTimKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKhachHang.Name = "txtTimKhachHang";
            this.txtTimKhachHang.Size = new System.Drawing.Size(169, 32);
            this.txtTimKhachHang.TabIndex = 20;
            this.txtTimKhachHang.TextChanged += new System.EventHandler(this.txtTimKhachHang_TextChanged);
            // 
            // btnThemKhachHang
            // 
            this.btnThemKhachHang.Location = new System.Drawing.Point(399, 28);
            this.btnThemKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemKhachHang.Name = "btnThemKhachHang";
            this.btnThemKhachHang.Size = new System.Drawing.Size(194, 32);
            this.btnThemKhachHang.TabIndex = 19;
            this.btnThemKhachHang.Text = "Thêm Khách Hàng";
            this.btnThemKhachHang.UseVisualStyleBackColor = true;
            this.btnThemKhachHang.Click += new System.EventHandler(this.btnThemKhachHang_Click);
            // 
            // cboMaKhuyenMai
            // 
            this.cboMaKhuyenMai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaKhuyenMai.FormattingEnabled = true;
            this.cboMaKhuyenMai.Location = new System.Drawing.Point(158, 126);
            this.cboMaKhuyenMai.Margin = new System.Windows.Forms.Padding(2);
            this.cboMaKhuyenMai.Name = "cboMaKhuyenMai";
            this.cboMaKhuyenMai.Size = new System.Drawing.Size(169, 33);
            this.cboMaKhuyenMai.TabIndex = 17;
            this.cboMaKhuyenMai.SelectedIndexChanged += new System.EventHandler(this.cboMaKhuyenMai_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã Khuyến Mãi";
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachHang.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboKhachHang.FormattingEnabled = true;
            this.cboKhachHang.Location = new System.Drawing.Point(158, 76);
            this.cboKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(169, 28);
            this.cboKhachHang.TabIndex = 15;
            this.cboKhachHang.SelectedIndexChanged += new System.EventHandler(this.cboKhachHang_SelectedIndexChanged);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(2, 75);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(118, 25);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Khách hàng:";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(304, 241);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(130, 45);
            this.btnLuu.TabIndex = 14;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
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
            this.grpPayment.Controls.Add(this.txtTienThoi);
            this.grpPayment.Controls.Add(this.btnInHoaDon);
            this.grpPayment.Controls.Add(this.lblReturnPayment);
            this.grpPayment.Controls.Add(this.txtKhachDua);
            this.grpPayment.Controls.Add(this.lblReceive);
            this.grpPayment.Controls.Add(this.txtGiamGia);
            this.grpPayment.Controls.Add(this.lblDiscount);
            this.grpPayment.Controls.Add(this.txtThanhTien);
            this.grpPayment.Controls.Add(this.lblMoney);
            this.grpPayment.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.grpPayment.Location = new System.Drawing.Point(621, 565);
            this.grpPayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPayment.Size = new System.Drawing.Size(575, 292);
            this.grpPayment.TabIndex = 27;
            this.grpPayment.TabStop = false;
            this.grpPayment.Text = "Thanh toán";
            // 
            // chkChuyenKhoan
            // 
            this.chkChuyenKhoan.AutoSize = true;
            this.chkChuyenKhoan.Location = new System.Drawing.Point(14, 250);
            this.chkChuyenKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.chkChuyenKhoan.Name = "chkChuyenKhoan";
            this.chkChuyenKhoan.Size = new System.Drawing.Size(159, 29);
            this.chkChuyenKhoan.TabIndex = 25;
            this.chkChuyenKhoan.Text = "Chuyển Khoản";
            this.chkChuyenKhoan.UseVisualStyleBackColor = true;
            // 
            // txtVAT
            // 
            this.txtVAT.Enabled = false;
            this.txtVAT.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVAT.Location = new System.Drawing.Point(401, 120);
            this.txtVAT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Size = new System.Drawing.Size(159, 32);
            this.txtVAT.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(296, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "VAT: 10%";
            // 
            // chkSuDung
            // 
            this.chkSuDung.AutoSize = true;
            this.chkSuDung.Location = new System.Drawing.Point(301, 38);
            this.chkSuDung.Margin = new System.Windows.Forms.Padding(2);
            this.chkSuDung.Name = "chkSuDung";
            this.chkSuDung.Size = new System.Drawing.Size(108, 29);
            this.chkSuDung.TabIndex = 21;
            this.chkSuDung.Text = "Sử Dụng";
            this.chkSuDung.UseVisualStyleBackColor = true;
            this.chkSuDung.CheckedChanged += new System.EventHandler(this.chkSuDung_CheckedChanged);
            // 
            // lblSoDiem
            // 
            this.lblSoDiem.AutoSize = true;
            this.lblSoDiem.Location = new System.Drawing.Point(171, 38);
            this.lblSoDiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoDiem.Name = "lblSoDiem";
            this.lblSoDiem.Size = new System.Drawing.Size(23, 25);
            this.lblSoDiem.TabIndex = 20;
            this.lblSoDiem.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Điểm Tích Lũy: ";
            // 
            // lblTotalMoney
            // 
            this.lblTotalMoney.AutoSize = true;
            this.lblTotalMoney.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.lblTotalMoney.Location = new System.Drawing.Point(199, 198);
            this.lblTotalMoney.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalMoney.Name = "lblTotalMoney";
            this.lblTotalMoney.Size = new System.Drawing.Size(32, 37);
            this.lblTotalMoney.TabIndex = 18;
            this.lblTotalMoney.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.lblTotal.Location = new System.Drawing.Point(8, 198);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(183, 37);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "TỔNG CỘNG:";
            // 
            // txtTienThoi
            // 
            this.txtTienThoi.Enabled = false;
            this.txtTienThoi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienThoi.Location = new System.Drawing.Point(131, 160);
            this.txtTienThoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTienThoi.Name = "txtTienThoi";
            this.txtTienThoi.Size = new System.Drawing.Size(156, 32);
            this.txtTienThoi.TabIndex = 16;
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.btnInHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnInHoaDon.Location = new System.Drawing.Point(439, 241);
            this.btnInHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(130, 45);
            this.btnInHoaDon.TabIndex = 13;
            this.btnInHoaDon.Text = "In Hóa Đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = false;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // lblReturnPayment
            // 
            this.lblReturnPayment.AutoSize = true;
            this.lblReturnPayment.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnPayment.Location = new System.Drawing.Point(9, 162);
            this.lblReturnPayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReturnPayment.Name = "lblReturnPayment";
            this.lblReturnPayment.Size = new System.Drawing.Size(95, 25);
            this.lblReturnPayment.TabIndex = 15;
            this.lblReturnPayment.Text = "Tiền Thối:";
            // 
            // txtKhachDua
            // 
            this.txtKhachDua.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhachDua.Location = new System.Drawing.Point(131, 120);
            this.txtKhachDua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKhachDua.Name = "txtKhachDua";
            this.txtKhachDua.Size = new System.Drawing.Size(156, 32);
            this.txtKhachDua.TabIndex = 14;
            this.txtKhachDua.TextChanged += new System.EventHandler(this.txtKhachDua_TextChanged);
            // 
            // lblReceive
            // 
            this.lblReceive.AutoSize = true;
            this.lblReceive.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceive.Location = new System.Drawing.Point(9, 124);
            this.lblReceive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceive.Name = "lblReceive";
            this.lblReceive.Size = new System.Drawing.Size(111, 25);
            this.lblReceive.TabIndex = 13;
            this.lblReceive.Text = "Khách Đưa:";
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Enabled = false;
            this.txtGiamGia.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiamGia.Location = new System.Drawing.Point(401, 80);
            this.txtGiamGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(159, 32);
            this.txtGiamGia.TabIndex = 12;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(296, 85);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(95, 25);
            this.lblDiscount.TabIndex = 11;
            this.lblDiscount.Text = "Giảm Giá:";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Location = new System.Drawing.Point(131, 81);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(156, 32);
            this.txtThanhTien.TabIndex = 10;
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.lblMoney.Location = new System.Drawing.Point(8, 82);
            this.lblMoney.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(111, 25);
            this.lblMoney.TabIndex = 1;
            this.lblMoney.Text = "Thành Tiền:";
            // 
            // grpListProduct
            // 
            this.grpListProduct.Controls.Add(this.txtTimKiemMonDaGoi);
            this.grpListProduct.Controls.Add(this.dgvDanhSachMonChon);
            this.grpListProduct.Controls.Add(this.btnXoaMon);
            this.grpListProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpListProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.grpListProduct.Location = new System.Drawing.Point(621, 22);
            this.grpListProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpListProduct.Name = "grpListProduct";
            this.grpListProduct.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpListProduct.Size = new System.Drawing.Size(575, 535);
            this.grpListProduct.TabIndex = 26;
            this.grpListProduct.TabStop = false;
            this.grpListProduct.Text = "Danh sách gọi món";
            // 
            // txtTimKiemMonDaGoi
            // 
            this.txtTimKiemMonDaGoi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemMonDaGoi.Location = new System.Drawing.Point(108, 24);
            this.txtTimKiemMonDaGoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimKiemMonDaGoi.Name = "txtTimKiemMonDaGoi";
            this.txtTimKiemMonDaGoi.Size = new System.Drawing.Size(376, 32);
            this.txtTimKiemMonDaGoi.TabIndex = 13;
            this.txtTimKiemMonDaGoi.TextChanged += new System.EventHandler(this.txtTimKiemMonDaGoi_TextChanged);
            // 
            // dgvDanhSachMonChon
            // 
            this.dgvDanhSachMonChon.AllowUserToAddRows = false;
            this.dgvDanhSachMonChon.AllowUserToDeleteRows = false;
            this.dgvDanhSachMonChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachMonChon.Location = new System.Drawing.Point(8, 65);
            this.dgvDanhSachMonChon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDanhSachMonChon.Name = "dgvDanhSachMonChon";
            this.dgvDanhSachMonChon.ReadOnly = true;
            this.dgvDanhSachMonChon.RowHeadersWidth = 51;
            this.dgvDanhSachMonChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachMonChon.Size = new System.Drawing.Size(556, 418);
            this.dgvDanhSachMonChon.TabIndex = 2;
            // 
            // btnXoaMon
            // 
            this.btnXoaMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.btnXoaMon.ForeColor = System.Drawing.Color.White;
            this.btnXoaMon.Location = new System.Drawing.Point(445, 484);
            this.btnXoaMon.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaMon.Name = "btnXoaMon";
            this.btnXoaMon.Size = new System.Drawing.Size(130, 45);
            this.btnXoaMon.TabIndex = 12;
            this.btnXoaMon.Text = "Xóa Món";
            this.btnXoaMon.UseVisualStyleBackColor = false;
            this.btnXoaMon.Click += new System.EventHandler(this.btnXoaMon_Click);
            // 
            // frmDatMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1209, 872);
            this.Controls.Add(this.grpPayment);
            this.Controls.Add(this.grpListProduct);
            this.Controls.Add(this.grpInfoInvoice);
            this.Controls.Add(this.grpSearchProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDatMon";
            this.Text = "Gọi Món";
            this.Load += new System.EventHandler(this.frmDatMon_Load);
            this.grpSearchProduct.ResumeLayout(false);
            this.grpSearchProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonMon)).EndInit();
            this.grpInfoInvoice.ResumeLayout(false);
            this.grpInfoInvoice.PerformLayout();
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
        private System.Windows.Forms.Button btnThemKhachHang;
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
        private System.Windows.Forms.TextBox txtTienThoi;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Label lblReturnPayment;
        private System.Windows.Forms.TextBox txtKhachDua;
        private System.Windows.Forms.Label lblReceive;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.GroupBox grpListProduct;
        private System.Windows.Forms.DataGridView dgvDanhSachMonChon;
        private System.Windows.Forms.Button btnXoaMon;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.TextBox txtTimKiemMonDaGoi;
        private System.Windows.Forms.ComboBox cboLoaiMon;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkChuyenKhoan;
    }
}

