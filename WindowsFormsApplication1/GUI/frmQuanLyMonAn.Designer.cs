namespace WindowsFormsApplication1.GUI
{
    partial class frmQuanLyMonAn
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTimKiemCongThuc = new System.Windows.Forms.TextBox();
            this.dgvCongThuc = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboTimKiemTrangThai = new System.Windows.Forms.ComboBox();
            this.txtTimKiemMonAn = new System.Windows.Forms.TextBox();
            this.dgvDanhSachMonAn = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.cboDonViTinh = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDinhLuong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenNguyenLieu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnChuyen = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtTimKiemNguyenLieu = new System.Windows.Forms.TextBox();
            this.dgvNguyenLieu = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grpThongTinMonAn = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnConBan = new System.Windows.Forms.Button();
            this.btnNgungBan = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTaiAnh = new System.Windows.Forms.Button();
            this.pbMonAn = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboLoaiMonAn = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGiaMonAn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemMonAn = new System.Windows.Forms.Button();
            this.txtTenMonAn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongThuc)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMonAn)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieu)).BeginInit();
            this.grpThongTinMonAn.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTimKiemCongThuc);
            this.groupBox2.Controls.Add(this.dgvCongThuc);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.groupBox2.Location = new System.Drawing.Point(1089, 401);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(437, 350);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Công Thức";
            // 
            // txtTimKiemCongThuc
            // 
            this.txtTimKiemCongThuc.Location = new System.Drawing.Point(143, 30);
            this.txtTimKiemCongThuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiemCongThuc.Name = "txtTimKiemCongThuc";
            this.txtTimKiemCongThuc.Size = new System.Drawing.Size(191, 32);
            this.txtTimKiemCongThuc.TabIndex = 29;
            this.txtTimKiemCongThuc.TextChanged += new System.EventHandler(this.txtTimKiemCongThuc_TextChanged);
            // 
            // dgvCongThuc
            // 
            this.dgvCongThuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCongThuc.Location = new System.Drawing.Point(12, 66);
            this.dgvCongThuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCongThuc.Name = "dgvCongThuc";
            this.dgvCongThuc.ReadOnly = true;
            this.dgvCongThuc.RowHeadersWidth = 51;
            this.dgvCongThuc.RowTemplate.Height = 24;
            this.dgvCongThuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCongThuc.Size = new System.Drawing.Size(419, 276);
            this.dgvCongThuc.TabIndex = 27;
            this.dgvCongThuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCongThuc_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cboTimKiemTrangThai);
            this.groupBox1.Controls.Add(this.txtTimKiemMonAn);
            this.groupBox1.Controls.Add(this.dgvDanhSachMonAn);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.groupBox1.Location = new System.Drawing.Point(754, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(772, 382);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Món Ăn";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(404, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 25);
            this.label11.TabIndex = 35;
            this.label11.Text = "Theo Tên";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 25);
            this.label10.TabIndex = 34;
            this.label10.Text = "Trạng Thái";
            // 
            // cboTimKiemTrangThai
            // 
            this.cboTimKiemTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimKiemTrangThai.FormattingEnabled = true;
            this.cboTimKiemTrangThai.Location = new System.Drawing.Point(127, 28);
            this.cboTimKiemTrangThai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTimKiemTrangThai.Name = "cboTimKiemTrangThai";
            this.cboTimKiemTrangThai.Size = new System.Drawing.Size(253, 33);
            this.cboTimKiemTrangThai.TabIndex = 33;
            // 
            // txtTimKiemMonAn
            // 
            this.txtTimKiemMonAn.Location = new System.Drawing.Point(499, 30);
            this.txtTimKiemMonAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiemMonAn.Name = "txtTimKiemMonAn";
            this.txtTimKiemMonAn.Size = new System.Drawing.Size(267, 32);
            this.txtTimKiemMonAn.TabIndex = 29;
            this.txtTimKiemMonAn.TextChanged += new System.EventHandler(this.txtTimKiemMonAn_TextChanged);
            // 
            // dgvDanhSachMonAn
            // 
            this.dgvDanhSachMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachMonAn.Location = new System.Drawing.Point(12, 66);
            this.dgvDanhSachMonAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDanhSachMonAn.Name = "dgvDanhSachMonAn";
            this.dgvDanhSachMonAn.ReadOnly = true;
            this.dgvDanhSachMonAn.RowHeadersWidth = 51;
            this.dgvDanhSachMonAn.RowTemplate.Height = 24;
            this.dgvDanhSachMonAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachMonAn.Size = new System.Drawing.Size(753, 308);
            this.dgvDanhSachMonAn.TabIndex = 27;
            this.dgvDanhSachMonAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachMonAn_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnXoa);
            this.groupBox4.Controls.Add(this.btnCapNhat);
            this.groupBox4.Controls.Add(this.cboDonViTinh);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtDinhLuong);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtTenNguyenLieu);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.groupBox4.Location = new System.Drawing.Point(9, 401);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(441, 353);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông Tin Nguyên Liệu";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(317, 162);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(117, 36);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(167, 164);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(103, 36);
            this.btnCapNhat.TabIndex = 10;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // cboDonViTinh
            // 
            this.cboDonViTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDonViTinh.Enabled = false;
            this.cboDonViTinh.FormattingEnabled = true;
            this.cboDonViTinh.Location = new System.Drawing.Point(165, 113);
            this.cboDonViTinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboDonViTinh.Name = "cboDonViTinh";
            this.cboDonViTinh.Size = new System.Drawing.Size(267, 33);
            this.cboDonViTinh.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Đơn Vị Tính";
            // 
            // txtDinhLuong
            // 
            this.txtDinhLuong.Location = new System.Drawing.Point(165, 71);
            this.txtDinhLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDinhLuong.Name = "txtDinhLuong";
            this.txtDinhLuong.Size = new System.Drawing.Size(267, 32);
            this.txtDinhLuong.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Định Lượng";
            // 
            // txtTenNguyenLieu
            // 
            this.txtTenNguyenLieu.Enabled = false;
            this.txtTenNguyenLieu.Location = new System.Drawing.Point(167, 33);
            this.txtTenNguyenLieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNguyenLieu.Name = "txtTenNguyenLieu";
            this.txtTenNguyenLieu.Size = new System.Drawing.Size(267, 32);
            this.txtTenNguyenLieu.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tên Nguyên Liệu";
            // 
            // btnChuyen
            // 
            this.btnChuyen.Location = new System.Drawing.Point(1007, 586);
            this.btnChuyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.Size = new System.Drawing.Size(75, 42);
            this.btnChuyen.TabIndex = 35;
            this.btnChuyen.Text = "Thêm\r\n>>";
            this.btnChuyen.UseVisualStyleBackColor = true;
            this.btnChuyen.Click += new System.EventHandler(this.btnChuyen_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtTimKiemNguyenLieu);
            this.groupBox5.Controls.Add(this.dgvNguyenLieu);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.groupBox5.Location = new System.Drawing.Point(457, 401);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(543, 350);
            this.groupBox5.TabIndex = 36;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Nguyên Liệu";
            // 
            // txtTimKiemNguyenLieu
            // 
            this.txtTimKiemNguyenLieu.Location = new System.Drawing.Point(163, 30);
            this.txtTimKiemNguyenLieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiemNguyenLieu.Name = "txtTimKiemNguyenLieu";
            this.txtTimKiemNguyenLieu.Size = new System.Drawing.Size(267, 32);
            this.txtTimKiemNguyenLieu.TabIndex = 28;
            this.txtTimKiemNguyenLieu.TextChanged += new System.EventHandler(this.txtTimKiemNguyenLieu_TextChanged);
            // 
            // dgvNguyenLieu
            // 
            this.dgvNguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguyenLieu.Location = new System.Drawing.Point(7, 66);
            this.dgvNguyenLieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNguyenLieu.Name = "dgvNguyenLieu";
            this.dgvNguyenLieu.ReadOnly = true;
            this.dgvNguyenLieu.RowHeadersWidth = 51;
            this.dgvNguyenLieu.RowTemplate.Height = 24;
            this.dgvNguyenLieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNguyenLieu.Size = new System.Drawing.Size(529, 276);
            this.dgvNguyenLieu.TabIndex = 27;
            this.dgvNguyenLieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNguyenLieu_CellClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // grpThongTinMonAn
            // 
            this.grpThongTinMonAn.Controls.Add(this.groupBox3);
            this.grpThongTinMonAn.Controls.Add(this.label9);
            this.grpThongTinMonAn.Controls.Add(this.txtMoTa);
            this.grpThongTinMonAn.Controls.Add(this.label5);
            this.grpThongTinMonAn.Controls.Add(this.btnSua);
            this.grpThongTinMonAn.Controls.Add(this.btnTaiAnh);
            this.grpThongTinMonAn.Controls.Add(this.pbMonAn);
            this.grpThongTinMonAn.Controls.Add(this.label4);
            this.grpThongTinMonAn.Controls.Add(this.cboLoaiMonAn);
            this.grpThongTinMonAn.Controls.Add(this.label3);
            this.grpThongTinMonAn.Controls.Add(this.txtGiaMonAn);
            this.grpThongTinMonAn.Controls.Add(this.label2);
            this.grpThongTinMonAn.Controls.Add(this.btnThemMonAn);
            this.grpThongTinMonAn.Controls.Add(this.txtTenMonAn);
            this.grpThongTinMonAn.Controls.Add(this.label1);
            this.grpThongTinMonAn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTinMonAn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.grpThongTinMonAn.Location = new System.Drawing.Point(7, 13);
            this.grpThongTinMonAn.Margin = new System.Windows.Forms.Padding(4);
            this.grpThongTinMonAn.Name = "grpThongTinMonAn";
            this.grpThongTinMonAn.Padding = new System.Windows.Forms.Padding(4);
            this.grpThongTinMonAn.Size = new System.Drawing.Size(739, 382);
            this.grpThongTinMonAn.TabIndex = 32;
            this.grpThongTinMonAn.TabStop = false;
            this.grpThongTinMonAn.Text = "Thông Tin Món Ăn";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnConBan);
            this.groupBox3.Controls.Add(this.btnNgungBan);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.groupBox3.Location = new System.Drawing.Point(8, 300);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(405, 74);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cập Nhật Trạng Thái";
            // 
            // btnConBan
            // 
            this.btnConBan.Location = new System.Drawing.Point(161, 31);
            this.btnConBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConBan.Name = "btnConBan";
            this.btnConBan.Size = new System.Drawing.Size(123, 33);
            this.btnConBan.TabIndex = 15;
            this.btnConBan.Text = "Còn Bán";
            this.btnConBan.UseVisualStyleBackColor = true;
            this.btnConBan.Click += new System.EventHandler(this.btnConBan_Click);
            // 
            // btnNgungBan
            // 
            this.btnNgungBan.Location = new System.Drawing.Point(7, 31);
            this.btnNgungBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNgungBan.Name = "btnNgungBan";
            this.btnNgungBan.Size = new System.Drawing.Size(123, 33);
            this.btnNgungBan.TabIndex = 10;
            this.btnNgungBan.Text = "Ngừng Bán";
            this.btnNgungBan.UseVisualStyleBackColor = true;
            this.btnNgungBan.Click += new System.EventHandler(this.btnNgungBan_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(421, 75);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "vnđ";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(147, 160);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(267, 130);
            this.txtMoTa.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mô Tả";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(609, 330);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(123, 33);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTaiAnh
            // 
            this.btnTaiAnh.Location = new System.Drawing.Point(587, 251);
            this.btnTaiAnh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaiAnh.Name = "btnTaiAnh";
            this.btnTaiAnh.Size = new System.Drawing.Size(93, 36);
            this.btnTaiAnh.TabIndex = 9;
            this.btnTaiAnh.Text = "Tải Ảnh";
            this.btnTaiAnh.UseVisualStyleBackColor = true;
            this.btnTaiAnh.Click += new System.EventHandler(this.btnTaiAnh_Click);
            // 
            // pbMonAn
            // 
            this.pbMonAn.Location = new System.Drawing.Point(525, 47);
            this.pbMonAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMonAn.Name = "pbMonAn";
            this.pbMonAn.Size = new System.Drawing.Size(200, 199);
            this.pbMonAn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMonAn.TabIndex = 8;
            this.pbMonAn.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(581, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hình Ảnh";
            // 
            // cboLoaiMonAn
            // 
            this.cboLoaiMonAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiMonAn.FormattingEnabled = true;
            this.cboLoaiMonAn.Location = new System.Drawing.Point(147, 113);
            this.cboLoaiMonAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboLoaiMonAn.Name = "cboLoaiMonAn";
            this.cboLoaiMonAn.Size = new System.Drawing.Size(267, 33);
            this.cboLoaiMonAn.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loại Món Ăn";
            // 
            // txtGiaMonAn
            // 
            this.txtGiaMonAn.Location = new System.Drawing.Point(147, 71);
            this.txtGiaMonAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaMonAn.Name = "txtGiaMonAn";
            this.txtGiaMonAn.Size = new System.Drawing.Size(267, 32);
            this.txtGiaMonAn.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Giá Món Ăn";
            // 
            // btnThemMonAn
            // 
            this.btnThemMonAn.Location = new System.Drawing.Point(457, 330);
            this.btnThemMonAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemMonAn.Name = "btnThemMonAn";
            this.btnThemMonAn.Size = new System.Drawing.Size(123, 33);
            this.btnThemMonAn.TabIndex = 2;
            this.btnThemMonAn.Text = "Thêm";
            this.btnThemMonAn.UseVisualStyleBackColor = true;
            this.btnThemMonAn.Click += new System.EventHandler(this.btnThemMonAn_Click);
            // 
            // txtTenMonAn
            // 
            this.txtTenMonAn.Location = new System.Drawing.Point(147, 33);
            this.txtTenMonAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenMonAn.Name = "txtTenMonAn";
            this.txtTenMonAn.Size = new System.Drawing.Size(267, 32);
            this.txtTenMonAn.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Món Ăn";
            // 
            // frmQuanLyMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 774);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnChuyen);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.grpThongTinMonAn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyMonAn";
            this.Text = "frmQuanLyMonAn";
            this.Load += new System.EventHandler(this.frmQuanLyMonAn_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongThuc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMonAn)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieu)).EndInit();
            this.grpThongTinMonAn.ResumeLayout(false);
            this.grpThongTinMonAn.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMonAn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTimKiemCongThuc;
        private System.Windows.Forms.DataGridView dgvCongThuc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboTimKiemTrangThai;
        private System.Windows.Forms.TextBox txtTimKiemMonAn;
        private System.Windows.Forms.DataGridView dgvDanhSachMonAn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.ComboBox cboDonViTinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDinhLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenNguyenLieu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnChuyen;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtTimKiemNguyenLieu;
        private System.Windows.Forms.DataGridView dgvNguyenLieu;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox grpThongTinMonAn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnConBan;
        private System.Windows.Forms.Button btnNgungBan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTaiAnh;
        private System.Windows.Forms.PictureBox pbMonAn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboLoaiMonAn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGiaMonAn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThemMonAn;
        private System.Windows.Forms.TextBox txtTenMonAn;
        private System.Windows.Forms.Label label1;
    }
}