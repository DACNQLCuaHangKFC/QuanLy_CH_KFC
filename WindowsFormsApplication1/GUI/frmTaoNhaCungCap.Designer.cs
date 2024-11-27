namespace WindowsFormsApplication1.GUI
{
    partial class frmTaoNhaCungCap
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbLoaiNL = new System.Windows.Forms.ComboBox();
            this.cmbTenLoai = new System.Windows.Forms.ComboBox();
            this.txtTenNguyenLieu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNguyenLieu = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvNhaCungCap = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_NganHang = new System.Windows.Forms.ComboBox();
            this.cmbTTCU = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCungUng = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuyTao = new System.Windows.Forms.Button();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.dgvCungUng = new System.Windows.Forms.DataGridView();
            this.txtSTK = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lab = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MaNCC = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCungCap)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCungUng)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbLoaiNL);
            this.panel2.Controls.Add(this.cmbTenLoai);
            this.panel2.Controls.Add(this.txtTenNguyenLieu);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dgvNguyenLieu);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dgvNhaCungCap);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(2, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 434);
            this.panel2.TabIndex = 94;
            // 
            // cmbLoaiNL
            // 
            this.cmbLoaiNL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiNL.FormattingEnabled = true;
            this.cmbLoaiNL.Location = new System.Drawing.Point(322, 221);
            this.cmbLoaiNL.Name = "cmbLoaiNL";
            this.cmbLoaiNL.Size = new System.Drawing.Size(229, 23);
            this.cmbLoaiNL.TabIndex = 95;
            this.cmbLoaiNL.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiNL_SelectedIndexChanged);
            // 
            // cmbTenLoai
            // 
            this.cmbTenLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenLoai.FormattingEnabled = true;
            this.cmbTenLoai.Location = new System.Drawing.Point(322, 17);
            this.cmbTenLoai.Name = "cmbTenLoai";
            this.cmbTenLoai.Size = new System.Drawing.Size(229, 23);
            this.cmbTenLoai.TabIndex = 94;
            this.cmbTenLoai.SelectedIndexChanged += new System.EventHandler(this.cmbTenLoai_SelectedIndexChanged_1);
            // 
            // txtTenNguyenLieu
            // 
            this.txtTenNguyenLieu.Location = new System.Drawing.Point(110, 221);
            this.txtTenNguyenLieu.Name = "txtTenNguyenLieu";
            this.txtTenNguyenLieu.Size = new System.Drawing.Size(195, 22);
            this.txtTenNguyenLieu.TabIndex = 93;
            this.txtTenNguyenLieu.TextChanged += new System.EventHandler(this.txtTenNguyenLieu_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 92;
            this.label1.Text = "Nguyên Liệu:";
            // 
            // dgvNguyenLieu
            // 
            this.dgvNguyenLieu.AllowUserToAddRows = false;
            this.dgvNguyenLieu.AllowUserToDeleteRows = false;
            this.dgvNguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguyenLieu.Location = new System.Drawing.Point(3, 255);
            this.dgvNguyenLieu.Name = "dgvNguyenLieu";
            this.dgvNguyenLieu.ReadOnly = true;
            this.dgvNguyenLieu.RowHeadersWidth = 51;
            this.dgvNguyenLieu.RowTemplate.Height = 24;
            this.dgvNguyenLieu.Size = new System.Drawing.Size(549, 176);
            this.dgvNguyenLieu.TabIndex = 91;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nhà Cung Cấp:";
            // 
            // dgvNhaCungCap
            // 
            this.dgvNhaCungCap.AllowUserToAddRows = false;
            this.dgvNhaCungCap.AllowUserToDeleteRows = false;
            this.dgvNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhaCungCap.Location = new System.Drawing.Point(1, 49);
            this.dgvNhaCungCap.Name = "dgvNhaCungCap";
            this.dgvNhaCungCap.ReadOnly = true;
            this.dgvNhaCungCap.RowHeadersWidth = 51;
            this.dgvNhaCungCap.RowTemplate.Height = 24;
            this.dgvNhaCungCap.Size = new System.Drawing.Size(551, 160);
            this.dgvNhaCungCap.TabIndex = 90;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cb_NganHang);
            this.panel1.Controls.Add(this.cmbTTCU);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.Controls.Add(this.txtDonGia);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnCungUng);
            this.panel1.Controls.Add(this.btnXacNhan);
            this.panel1.Controls.Add(this.btnHuyTao);
            this.panel1.Controls.Add(this.btnTaoMoi);
            this.panel1.Controls.Add(this.dgvCungUng);
            this.panel1.Controls.Add(this.txtSTK);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.txtTenNCC);
            this.panel1.Controls.Add(this.txtMaNCC);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lab);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.MaNCC);
            this.panel1.Location = new System.Drawing.Point(563, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 434);
            this.panel1.TabIndex = 95;
            // 
            // cb_NganHang
            // 
            this.cb_NganHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_NganHang.FormattingEnabled = true;
            this.cb_NganHang.Location = new System.Drawing.Point(136, 107);
            this.cb_NganHang.Name = "cb_NganHang";
            this.cb_NganHang.Size = new System.Drawing.Size(148, 23);
            this.cb_NganHang.TabIndex = 105;
            this.cb_NganHang.SelectedIndexChanged += new System.EventHandler(this.cb_NganHang_SelectedIndexChanged);
            // 
            // cmbTTCU
            // 
            this.cmbTTCU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTTCU.FormattingEnabled = true;
            this.cmbTTCU.Location = new System.Drawing.Point(362, 389);
            this.cmbTTCU.Name = "cmbTTCU";
            this.cmbTTCU.Size = new System.Drawing.Size(121, 23);
            this.cmbTTCU.TabIndex = 104;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 103;
            this.label5.Text = "Trạng Thái:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(378, 187);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(72, 22);
            this.btnThem.TabIndex = 102;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(468, 149);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(72, 22);
            this.btnXoa.TabIndex = 101;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(509, 390);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(76, 22);
            this.btnCapNhat.TabIndex = 100;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(115, 389);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(148, 22);
            this.txtDonGia.TabIndex = 98;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 97;
            this.label3.Text = "Đơn Giá:";
            // 
            // btnCungUng
            // 
            this.btnCungUng.Location = new System.Drawing.Point(281, 187);
            this.btnCungUng.Name = "btnCungUng";
            this.btnCungUng.Size = new System.Drawing.Size(72, 22);
            this.btnCungUng.TabIndex = 96;
            this.btnCungUng.Text = "Cung Ứng";
            this.btnCungUng.UseVisualStyleBackColor = true;
            this.btnCungUng.Click += new System.EventHandler(this.btnCungUng_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(468, 187);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(72, 22);
            this.btnXacNhan.TabIndex = 95;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnHuyTao
            // 
            this.btnHuyTao.Location = new System.Drawing.Point(378, 151);
            this.btnHuyTao.Name = "btnHuyTao";
            this.btnHuyTao.Size = new System.Drawing.Size(72, 22);
            this.btnHuyTao.TabIndex = 94;
            this.btnHuyTao.Text = "Hủy Tạo";
            this.btnHuyTao.UseVisualStyleBackColor = true;
            this.btnHuyTao.Click += new System.EventHandler(this.btnHuyTao_Click);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Location = new System.Drawing.Point(280, 150);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(72, 23);
            this.btnTaoMoi.TabIndex = 93;
            this.btnTaoMoi.Text = "Tạo Mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // dgvCungUng
            // 
            this.dgvCungUng.AllowUserToAddRows = false;
            this.dgvCungUng.AllowUserToDeleteRows = false;
            this.dgvCungUng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCungUng.Location = new System.Drawing.Point(3, 224);
            this.dgvCungUng.Name = "dgvCungUng";
            this.dgvCungUng.ReadOnly = true;
            this.dgvCungUng.RowHeadersWidth = 51;
            this.dgvCungUng.RowTemplate.Height = 24;
            this.dgvCungUng.Size = new System.Drawing.Size(619, 149);
            this.dgvCungUng.TabIndex = 92;
            this.dgvCungUng.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCungUng_CellContentClick);
            // 
            // txtSTK
            // 
            this.txtSTK.Location = new System.Drawing.Point(392, 109);
            this.txtSTK.Name = "txtSTK";
            this.txtSTK.Size = new System.Drawing.Size(148, 22);
            this.txtSTK.TabIndex = 23;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(392, 68);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(148, 22);
            this.txtSDT.TabIndex = 22;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(136, 20);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(404, 22);
            this.txtTenNCC.TabIndex = 21;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(137, 150);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(111, 22);
            this.txtMaNCC.TabIndex = 20;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(136, 66);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(148, 22);
            this.txtEmail.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(317, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "STK:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ngân Hàng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Email:";
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(317, 68);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(35, 15);
            this.lab.TabIndex = 14;
            this.lab.Text = "SDT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tên NCC:";
            // 
            // MaNCC
            // 
            this.MaNCC.AutoSize = true;
            this.MaNCC.Location = new System.Drawing.Point(56, 153);
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.Size = new System.Drawing.Size(55, 15);
            this.MaNCC.TabIndex = 12;
            this.MaNCC.Text = "MaNCC:";
            // 
            // frmTaoNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 456);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmTaoNhaCungCap";
            this.Text = "frmTaoNhaCungCap";
            this.Load += new System.EventHandler(this.frmTaoNhaCungCap_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCungCap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCungUng)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvNhaCungCap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSTK;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label MaNCC;
        private System.Windows.Forms.DataGridView dgvNguyenLieu;
        private System.Windows.Forms.DataGridView dgvCungUng;
        private System.Windows.Forms.Button btnCungUng;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnHuyTao;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.ComboBox cmbTenLoai;
        private System.Windows.Forms.TextBox txtTenNguyenLieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLoaiNL;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cmbTTCU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_NganHang;
    }
}