namespace WindowsFormsApplication1.GUI
{
    partial class frmDonViTinh
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgrvDonvitinh = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenDVT = new System.Windows.Forms.TextBox();
            this.lblTenDVT = new System.Windows.Forms.Label();
            this.txtMaDVT = new System.Windows.Forms.TextBox();
            this.lblMadonvitinh = new System.Windows.Forms.Label();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvDonvitinh)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgrvDonvitinh);
            this.groupBox1.Controls.Add(this.txtTenDVT);
            this.groupBox1.Controls.Add(this.lblTenDVT);
            this.groupBox1.Controls.Add(this.txtMaDVT);
            this.groupBox1.Controls.Add(this.lblMadonvitinh);
            this.groupBox1.Controls.Add(this.btnCapnhat);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(29, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(969, 514);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đơn vị tính";
            // 
            // dgrvDonvitinh
            // 
            this.dgrvDonvitinh.AllowUserToAddRows = false;
            this.dgrvDonvitinh.AllowUserToDeleteRows = false;
            this.dgrvDonvitinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvDonvitinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgrvDonvitinh.Location = new System.Drawing.Point(209, 97);
            this.dgrvDonvitinh.Margin = new System.Windows.Forms.Padding(4);
            this.dgrvDonvitinh.Name = "dgrvDonvitinh";
            this.dgrvDonvitinh.ReadOnly = true;
            this.dgrvDonvitinh.RowHeadersWidth = 51;
            this.dgrvDonvitinh.Size = new System.Drawing.Size(517, 298);
            this.dgrvDonvitinh.TabIndex = 101;
            this.dgrvDonvitinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrvDonvitinh_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaDVT";
            this.Column1.HeaderText = "Mã đơn vị tính";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 170;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenDVT";
            this.Column2.HeaderText = "Tên đơn vị tính";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 170;
            // 
            // txtTenDVT
            // 
            this.txtTenDVT.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDVT.Location = new System.Drawing.Point(651, 34);
            this.txtTenDVT.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDVT.Name = "txtTenDVT";
            this.txtTenDVT.Size = new System.Drawing.Size(232, 32);
            this.txtTenDVT.TabIndex = 100;
            // 
            // lblTenDVT
            // 
            this.lblTenDVT.AutoSize = true;
            this.lblTenDVT.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDVT.ForeColor = System.Drawing.Color.Red;
            this.lblTenDVT.Location = new System.Drawing.Point(496, 38);
            this.lblTenDVT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenDVT.Name = "lblTenDVT";
            this.lblTenDVT.Size = new System.Drawing.Size(136, 25);
            this.lblTenDVT.TabIndex = 99;
            this.lblTenDVT.Text = "Tên đơn vị tính";
            // 
            // txtMaDVT
            // 
            this.txtMaDVT.Enabled = false;
            this.txtMaDVT.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDVT.Location = new System.Drawing.Point(163, 34);
            this.txtMaDVT.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaDVT.Name = "txtMaDVT";
            this.txtMaDVT.Size = new System.Drawing.Size(232, 32);
            this.txtMaDVT.TabIndex = 94;
            // 
            // lblMadonvitinh
            // 
            this.lblMadonvitinh.AutoSize = true;
            this.lblMadonvitinh.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMadonvitinh.ForeColor = System.Drawing.Color.Red;
            this.lblMadonvitinh.Location = new System.Drawing.Point(8, 38);
            this.lblMadonvitinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMadonvitinh.Name = "lblMadonvitinh";
            this.lblMadonvitinh.Size = new System.Drawing.Size(134, 25);
            this.lblMadonvitinh.TabIndex = 93;
            this.lblMadonvitinh.Text = "Mã đơn vị tính";
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.BackColor = System.Drawing.SystemColors.Control;
            this.btnCapnhat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhat.ForeColor = System.Drawing.Color.Black;
            this.btnCapnhat.Location = new System.Drawing.Point(773, 425);
            this.btnCapnhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(165, 59);
            this.btnCapnhat.TabIndex = 97;
            this.btnCapnhat.Text = "CẬP NHẬT";
            this.btnCapnhat.UseVisualStyleBackColor = false;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.Control;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Location = new System.Drawing.Point(465, 425);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(167, 59);
            this.btnThem.TabIndex = 95;
            this.btnThem.Text = "THÊM MỚI";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmDonViTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 575);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDonViTinh";
            this.Text = "Đơn vị tính";
            this.Load += new System.EventHandler(this.frmDonViTinh_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvDonvitinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgrvDonvitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TextBox txtTenDVT;
        private System.Windows.Forms.Label lblTenDVT;
        private System.Windows.Forms.TextBox txtMaDVT;
        private System.Windows.Forms.Label lblMadonvitinh;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnThem;
    }
}