namespace WindowsFormsApplication1
{
    partial class frmBep
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
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvBep = new System.Windows.Forms.DataGridView();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.dgvHoaDonThanHToan = new System.Windows.Forms.DataGridView();
            this.cmbTrangThai = new System.Windows.Forms.ComboBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.dgvChiTietHDTT = new System.Windows.Forms.DataGridView();
            this.dtpNgayThanhToan = new System.Windows.Forms.DateTimePicker();
            this.grpTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonThanHToan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHDTT)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Controls.Add(this.cmbFilter);
            this.grpTimKiem.Controls.Add(this.txtTimKiem);
            this.grpTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.grpTimKiem.Location = new System.Drawing.Point(13, 13);
            this.grpTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Padding = new System.Windows.Forms.Padding(4);
            this.grpTimKiem.Size = new System.Drawing.Size(529, 101);
            this.grpTimKiem.TabIndex = 102;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Tìm kiếm";
            // 
            // cmbFilter
            // 
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(343, 46);
            this.cmbFilter.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(147, 33);
            this.cmbFilter.TabIndex = 30;
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
            // dgvBep
            // 
            this.dgvBep.AllowUserToAddRows = false;
            this.dgvBep.AllowUserToDeleteRows = false;
            this.dgvBep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBep.Location = new System.Drawing.Point(13, 121);
            this.dgvBep.Name = "dgvBep";
            this.dgvBep.ReadOnly = true;
            this.dgvBep.RowHeadersWidth = 51;
            this.dgvBep.RowTemplate.Height = 24;
            this.dgvBep.Size = new System.Drawing.Size(699, 418);
            this.dgvBep.TabIndex = 111;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(578, 59);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(134, 42);
            this.btnCapNhat.TabIndex = 121;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnTroVe
            // 
            this.btnTroVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.btnTroVe.ForeColor = System.Drawing.Color.White;
            this.btnTroVe.Location = new System.Drawing.Point(578, 11);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(134, 42);
            this.btnTroVe.TabIndex = 122;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = false;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // dgvHoaDonThanHToan
            // 
            this.dgvHoaDonThanHToan.AllowUserToAddRows = false;
            this.dgvHoaDonThanHToan.AllowUserToDeleteRows = false;
            this.dgvHoaDonThanHToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDonThanHToan.Location = new System.Drawing.Point(718, 121);
            this.dgvHoaDonThanHToan.Name = "dgvHoaDonThanHToan";
            this.dgvHoaDonThanHToan.ReadOnly = true;
            this.dgvHoaDonThanHToan.RowHeadersWidth = 51;
            this.dgvHoaDonThanHToan.RowTemplate.Height = 24;
            this.dgvHoaDonThanHToan.Size = new System.Drawing.Size(572, 203);
            this.dgvHoaDonThanHToan.TabIndex = 123;
            this.dgvHoaDonThanHToan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDonThanHToan_CellClick);
            this.dgvHoaDonThanHToan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDonThanHToan_CellContentClick);
            this.dgvHoaDonThanHToan.SelectionChanged += new System.EventHandler(this.dgvHoaDonThanHToan_SelectionChanged);
            // 
            // cmbTrangThai
            // 
            this.cmbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrangThai.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTrangThai.FormattingEnabled = true;
            this.cmbTrangThai.Location = new System.Drawing.Point(1142, 68);
            this.cmbTrangThai.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTrangThai.Name = "cmbTrangThai";
            this.cmbTrangThai.Size = new System.Drawing.Size(147, 33);
            this.cmbTrangThai.TabIndex = 31;
            this.cmbTrangThai.SelectedIndexChanged += new System.EventHandler(this.cmbTrangThai_SelectedIndexChanged_1);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(735, 59);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(134, 42);
            this.btnXacNhan.TabIndex = 124;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // dgvChiTietHDTT
            // 
            this.dgvChiTietHDTT.AllowUserToAddRows = false;
            this.dgvChiTietHDTT.AllowUserToDeleteRows = false;
            this.dgvChiTietHDTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHDTT.Location = new System.Drawing.Point(718, 330);
            this.dgvChiTietHDTT.Name = "dgvChiTietHDTT";
            this.dgvChiTietHDTT.ReadOnly = true;
            this.dgvChiTietHDTT.RowHeadersWidth = 51;
            this.dgvChiTietHDTT.RowTemplate.Height = 24;
            this.dgvChiTietHDTT.Size = new System.Drawing.Size(572, 209);
            this.dgvChiTietHDTT.TabIndex = 125;
            // 
            // dtpNgayThanhToan
            // 
            this.dtpNgayThanhToan.Location = new System.Drawing.Point(907, 72);
            this.dtpNgayThanhToan.Name = "dtpNgayThanhToan";
            this.dtpNgayThanhToan.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayThanhToan.TabIndex = 126;
            this.dtpNgayThanhToan.ValueChanged += new System.EventHandler(this.dtpNgayThanhToan_ValueChanged_1);
            // 
            // frmBep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 554);
            this.Controls.Add(this.dtpNgayThanhToan);
            this.Controls.Add(this.dgvChiTietHDTT);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.cmbTrangThai);
            this.Controls.Add(this.dgvHoaDonThanHToan);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.dgvBep);
            this.Controls.Add(this.grpTimKiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmBep";
            this.Text = "frmBep";
            this.Load += new System.EventHandler(this.frmBep_Load);
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonThanHToan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHDTT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvBep;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.DataGridView dgvHoaDonThanHToan;
        private System.Windows.Forms.ComboBox cmbTrangThai;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.DataGridView dgvChiTietHDTT;
        private System.Windows.Forms.DateTimePicker dtpNgayThanhToan;
    }
}