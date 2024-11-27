namespace WindowsFormsApplication1.GUI
{
    partial class frmLichLamViec
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
            this.dgrvCalam = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenLMA = new System.Windows.Forms.TextBox();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblMaCL = new System.Windows.Forms.Label();
            this.btnHuybo = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgaylamviec = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvCalam)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrvCalam
            // 
            this.dgrvCalam.AllowUserToAddRows = false;
            this.dgrvCalam.AllowUserToDeleteRows = false;
            this.dgrvCalam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvCalam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgrvCalam.Location = new System.Drawing.Point(183, 166);
            this.dgrvCalam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgrvCalam.Name = "dgrvCalam";
            this.dgrvCalam.ReadOnly = true;
            this.dgrvCalam.RowHeadersWidth = 51;
            this.dgrvCalam.Size = new System.Drawing.Size(648, 222);
            this.dgrvCalam.TabIndex = 121;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaCaLam";
            this.Column1.HeaderText = "Mã ca làm";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 140;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaNhanVien";
            this.Column2.HeaderText = "Mã nhân viên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 140;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgayLamViec";
            this.Column3.HeaderText = "Ngày làm việc";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 160;
            // 
            // txtTenLMA
            // 
            this.txtTenLMA.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLMA.Location = new System.Drawing.Point(744, 28);
            this.txtTenLMA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenLMA.Name = "txtTenLMA";
            this.txtTenLMA.Size = new System.Drawing.Size(232, 32);
            this.txtTenLMA.TabIndex = 120;
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNV.Location = new System.Drawing.Point(540, 36);
            this.lblTenNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(98, 25);
            this.lblTenNV.TabIndex = 119;
            this.lblTenNV.Text = "Nhân viên";
            // 
            // lblMaCL
            // 
            this.lblMaCL.AutoSize = true;
            this.lblMaCL.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaCL.Location = new System.Drawing.Point(43, 36);
            this.lblMaCL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaCL.Name = "lblMaCL";
            this.lblMaCL.Size = new System.Drawing.Size(70, 25);
            this.lblMaCL.TabIndex = 113;
            this.lblMaCL.Text = "Ca làm";
            // 
            // btnHuybo
            // 
            this.btnHuybo.BackColor = System.Drawing.Color.Red;
            this.btnHuybo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuybo.ForeColor = System.Drawing.Color.White;
            this.btnHuybo.Location = new System.Drawing.Point(824, 425);
            this.btnHuybo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHuybo.Name = "btnHuybo";
            this.btnHuybo.Size = new System.Drawing.Size(151, 59);
            this.btnHuybo.TabIndex = 118;
            this.btnHuybo.Text = "HỦY BỎ";
            this.btnHuybo.UseVisualStyleBackColor = false;
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.BackColor = System.Drawing.Color.Red;
            this.btnCapnhat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhat.ForeColor = System.Drawing.Color.White;
            this.btnCapnhat.Location = new System.Drawing.Point(565, 425);
            this.btnCapnhat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(151, 59);
            this.btnCapnhat.TabIndex = 117;
            this.btnCapnhat.Text = "CẬP NHẬT";
            this.btnCapnhat.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(307, 425);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(151, 59);
            this.btnXoa.TabIndex = 116;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Red;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(48, 425);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(151, 59);
            this.btnThem.TabIndex = 115;
            this.btnThem.Text = "THÊM MỚI";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 122;
            this.label1.Text = "Ngày làm việc";
            // 
            // dtpNgaylamviec
            // 
            this.dtpNgaylamviec.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaylamviec.Location = new System.Drawing.Point(224, 98);
            this.dtpNgaylamviec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNgaylamviec.Name = "dtpNgaylamviec";
            this.dtpNgaylamviec.Size = new System.Drawing.Size(265, 22);
            this.dtpNgaylamviec.TabIndex = 123;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(224, 34);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(265, 24);
            this.comboBox1.TabIndex = 124;
            // 
            // frmLichLamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 498);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dtpNgaylamviec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgrvCalam);
            this.Controls.Add(this.txtTenLMA);
            this.Controls.Add(this.lblTenNV);
            this.Controls.Add(this.lblMaCL);
            this.Controls.Add(this.btnHuybo);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmLichLamViec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLichLamViec";
            ((System.ComponentModel.ISupportInitialize)(this.dgrvCalam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrvCalam;
        private System.Windows.Forms.TextBox txtTenLMA;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblMaCL;
        private System.Windows.Forms.Button btnHuybo;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgaylamviec;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}