namespace WindowsFormsApplication1
{
    partial class frmNhapKho
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
            this.txtDvt = new System.Windows.Forms.TextBox();
            this.lblDvt = new System.Windows.Forms.Label();
            this.lblTennl = new System.Windows.Forms.Label();
            this.txtTennl = new System.Windows.Forms.TextBox();
            this.txtManl = new System.Windows.Forms.TextBox();
            this.lblManl = new System.Windows.Forms.Label();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.cmbTrangThai = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.btnNhapKho = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.dgvDanhSachNhap = new System.Windows.Forms.DataGridView();
            this.dgvKho = new System.Windows.Forms.DataGridView();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.btnNhanHang = new System.Windows.Forms.Button();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.cmbTrangThaiKho = new System.Windows.Forms.ComboBox();
            this.grpTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDvt
            // 
            this.txtDvt.Location = new System.Drawing.Point(890, 106);
            this.txtDvt.Name = "txtDvt";
            this.txtDvt.Size = new System.Drawing.Size(215, 22);
            this.txtDvt.TabIndex = 107;
            // 
            // lblDvt
            // 
            this.lblDvt.AutoSize = true;
            this.lblDvt.Location = new System.Drawing.Point(759, 109);
            this.lblDvt.Name = "lblDvt";
            this.lblDvt.Size = new System.Drawing.Size(38, 16);
            this.lblDvt.TabIndex = 106;
            this.lblDvt.Text = "DVT:";
            // 
            // lblTennl
            // 
            this.lblTennl.AutoSize = true;
            this.lblTennl.Location = new System.Drawing.Point(759, 65);
            this.lblTennl.Name = "lblTennl";
            this.lblTennl.Size = new System.Drawing.Size(112, 16);
            this.lblTennl.TabIndex = 105;
            this.lblTennl.Text = "Tên Nguyên Liệu:";
            // 
            // txtTennl
            // 
            this.txtTennl.Location = new System.Drawing.Point(890, 62);
            this.txtTennl.Name = "txtTennl";
            this.txtTennl.Size = new System.Drawing.Size(215, 22);
            this.txtTennl.TabIndex = 104;
            // 
            // txtManl
            // 
            this.txtManl.Location = new System.Drawing.Point(890, 19);
            this.txtManl.Name = "txtManl";
            this.txtManl.Size = new System.Drawing.Size(215, 22);
            this.txtManl.TabIndex = 103;
            // 
            // lblManl
            // 
            this.lblManl.AutoSize = true;
            this.lblManl.Location = new System.Drawing.Point(759, 22);
            this.lblManl.Name = "lblManl";
            this.lblManl.Size = new System.Drawing.Size(107, 16);
            this.lblManl.TabIndex = 102;
            this.lblManl.Text = "Mã Nguyên Liệu:";
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Controls.Add(this.cmbTrangThai);
            this.grpTimKiem.Controls.Add(this.txtTimKiem);
            this.grpTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.grpTimKiem.Location = new System.Drawing.Point(21, 12);
            this.grpTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Padding = new System.Windows.Forms.Padding(4);
            this.grpTimKiem.Size = new System.Drawing.Size(529, 101);
            this.grpTimKiem.TabIndex = 101;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Tìm kiếm";
            // 
            // cmbTrangThai
            // 
            this.cmbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrangThai.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTrangThai.FormattingEnabled = true;
            this.cmbTrangThai.Location = new System.Drawing.Point(343, 46);
            this.cmbTrangThai.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTrangThai.Name = "cmbTrangThai";
            this.cmbTrangThai.Size = new System.Drawing.Size(147, 33);
            this.cmbTrangThai.TabIndex = 30;
            this.cmbTrangThai.SelectedIndexChanged += new System.EventHandler(this.cmbTrangThai_SelectedIndexChanged);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(52, 46);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(281, 32);
            this.txtTimKiem.TabIndex = 11;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(759, 159);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(67, 16);
            this.lblSoLuong.TabIndex = 100;
            this.lblSoLuong.Text = "Số Lượng:";
            // 
            // btnNhapKho
            // 
            this.btnNhapKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.btnNhapKho.ForeColor = System.Drawing.Color.White;
            this.btnNhapKho.Location = new System.Drawing.Point(905, 192);
            this.btnNhapKho.Name = "btnNhapKho";
            this.btnNhapKho.Size = new System.Drawing.Size(130, 55);
            this.btnNhapKho.TabIndex = 99;
            this.btnNhapKho.Text = "Nhập Vào Kho";
            this.btnNhapKho.UseVisualStyleBackColor = false;
            this.btnNhapKho.Click += new System.EventHandler(this.btnNhapKho_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(890, 156);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(60, 22);
            this.txtSoLuong.TabIndex = 98;
            // 
            // dgvDanhSachNhap
            // 
            this.dgvDanhSachNhap.AllowUserToAddRows = false;
            this.dgvDanhSachNhap.AllowUserToDeleteRows = false;
            this.dgvDanhSachNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachNhap.Location = new System.Drawing.Point(21, 272);
            this.dgvDanhSachNhap.Name = "dgvDanhSachNhap";
            this.dgvDanhSachNhap.ReadOnly = true;
            this.dgvDanhSachNhap.RowHeadersWidth = 51;
            this.dgvDanhSachNhap.RowTemplate.Height = 24;
            this.dgvDanhSachNhap.Size = new System.Drawing.Size(652, 270);
            this.dgvDanhSachNhap.TabIndex = 97;
            // 
            // dgvKho
            // 
            this.dgvKho.AllowUserToAddRows = false;
            this.dgvKho.AllowUserToDeleteRows = false;
            this.dgvKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKho.Location = new System.Drawing.Point(679, 272);
            this.dgvKho.Name = "dgvKho";
            this.dgvKho.ReadOnly = true;
            this.dgvKho.RowHeadersWidth = 51;
            this.dgvKho.RowTemplate.Height = 24;
            this.dgvKho.Size = new System.Drawing.Size(696, 270);
            this.dgvKho.TabIndex = 110;
            this.dgvKho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKho_CellContentClick);
            // 
            // btnTroVe
            // 
            this.btnTroVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.btnTroVe.ForeColor = System.Drawing.Color.White;
            this.btnTroVe.Location = new System.Drawing.Point(1078, 192);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(130, 55);
            this.btnTroVe.TabIndex = 123;
            this.btnTroVe.Text = "Trở Về";
            this.btnTroVe.UseVisualStyleBackColor = false;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // btnNhanHang
            // 
            this.btnNhanHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.btnNhanHang.ForeColor = System.Drawing.Color.White;
            this.btnNhanHang.Location = new System.Drawing.Point(720, 192);
            this.btnNhanHang.Name = "btnNhanHang";
            this.btnNhanHang.Size = new System.Drawing.Size(130, 55);
            this.btnNhanHang.TabIndex = 124;
            this.btnNhanHang.Text = "Nhận Hàng";
            this.btnNhanHang.UseVisualStyleBackColor = false;
            this.btnNhanHang.Click += new System.EventHandler(this.btnNhanHang_Click);
            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.AllowUserToAddRows = false;
            this.dgvPhieuNhap.AllowUserToDeleteRows = false;
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhap.Location = new System.Drawing.Point(21, 116);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.ReadOnly = true;
            this.dgvPhieuNhap.RowHeadersWidth = 51;
            this.dgvPhieuNhap.RowTemplate.Height = 24;
            this.dgvPhieuNhap.Size = new System.Drawing.Size(652, 150);
            this.dgvPhieuNhap.TabIndex = 125;
            this.dgvPhieuNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuNhap_CellClick);
            // 
            // cmbTrangThaiKho
            // 
            this.cmbTrangThaiKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrangThaiKho.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTrangThaiKho.FormattingEnabled = true;
            this.cmbTrangThaiKho.Location = new System.Drawing.Point(1216, 214);
            this.cmbTrangThaiKho.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTrangThaiKho.Name = "cmbTrangThaiKho";
            this.cmbTrangThaiKho.Size = new System.Drawing.Size(147, 33);
            this.cmbTrangThaiKho.TabIndex = 31;
            this.cmbTrangThaiKho.SelectedIndexChanged += new System.EventHandler(this.cmbTrangThaiKho_SelectedIndexChanged);
            // 
            // frmNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 554);
            this.Controls.Add(this.cmbTrangThaiKho);
            this.Controls.Add(this.dgvPhieuNhap);
            this.Controls.Add(this.btnNhanHang);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.dgvKho);
            this.Controls.Add(this.txtDvt);
            this.Controls.Add(this.lblDvt);
            this.Controls.Add(this.lblTennl);
            this.Controls.Add(this.txtTennl);
            this.Controls.Add(this.txtManl);
            this.Controls.Add(this.lblManl);
            this.Controls.Add(this.grpTimKiem);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.btnNhapKho);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.dgvDanhSachNhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmNhapKho";
            this.Text = "frmNhapKho";
            this.Load += new System.EventHandler(this.frmNhapKho_Load);
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDvt;
        private System.Windows.Forms.Label lblDvt;
        private System.Windows.Forms.Label lblTennl;
        private System.Windows.Forms.TextBox txtTennl;
        private System.Windows.Forms.TextBox txtManl;
        private System.Windows.Forms.Label lblManl;
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.ComboBox cmbTrangThai;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Button btnNhapKho;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.DataGridView dgvDanhSachNhap;
        private System.Windows.Forms.DataGridView dgvKho;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Button btnNhanHang;
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private System.Windows.Forms.ComboBox cmbTrangThaiKho;
    }
}