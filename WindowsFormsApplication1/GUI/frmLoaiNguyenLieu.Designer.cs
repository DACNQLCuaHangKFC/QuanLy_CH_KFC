namespace WindowsFormsApplication1.GUI
{
    partial class frmLoaiNguyenLieu
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
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgrvLoainguyenlieu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenLNL = new System.Windows.Forms.TextBox();
            this.lblTenLNL = new System.Windows.Forms.Label();
            this.txtMaLNL = new System.Windows.Forms.TextBox();
            this.lblMaloainguyenlieu = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvLoainguyenlieu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCapnhat);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.dgrvLoainguyenlieu);
            this.groupBox1.Controls.Add(this.txtTenLNL);
            this.groupBox1.Controls.Add(this.lblTenLNL);
            this.groupBox1.Controls.Add(this.txtMaLNL);
            this.groupBox1.Controls.Add(this.lblMaloainguyenlieu);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(25, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1041, 518);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại nguyên liệu";
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.BackColor = System.Drawing.SystemColors.Control;
            this.btnCapnhat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhat.ForeColor = System.Drawing.Color.Black;
            this.btnCapnhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapnhat.Location = new System.Drawing.Point(840, 438);
            this.btnCapnhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(161, 59);
            this.btnCapnhat.TabIndex = 121;
            this.btnCapnhat.Text = "CẬP NHẬT";
            this.btnCapnhat.UseVisualStyleBackColor = false;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.Control;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(42, 438);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(173, 59);
            this.btnThem.TabIndex = 119;
            this.btnThem.Text = "THÊM MỚI";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgrvLoainguyenlieu
            // 
            this.dgrvLoainguyenlieu.AllowUserToAddRows = false;
            this.dgrvLoainguyenlieu.AllowUserToDeleteRows = false;
            this.dgrvLoainguyenlieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvLoainguyenlieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgrvLoainguyenlieu.Location = new System.Drawing.Point(151, 123);
            this.dgrvLoainguyenlieu.Margin = new System.Windows.Forms.Padding(4);
            this.dgrvLoainguyenlieu.Name = "dgrvLoainguyenlieu";
            this.dgrvLoainguyenlieu.ReadOnly = true;
            this.dgrvLoainguyenlieu.RowHeadersWidth = 51;
            this.dgrvLoainguyenlieu.Size = new System.Drawing.Size(709, 274);
            this.dgrvLoainguyenlieu.TabIndex = 111;
            this.dgrvLoainguyenlieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrvLoainguyenlieu_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaLoaiNguyenLieu";
            this.Column1.HeaderText = "Mã loại nguyên liệu";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 170;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenLoaiNguyenLieu";
            this.Column2.HeaderText = "Tên loại nguyên liệu";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 260;
            // 
            // txtTenLNL
            // 
            this.txtTenLNL.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLNL.Location = new System.Drawing.Point(749, 49);
            this.txtTenLNL.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenLNL.Name = "txtTenLNL";
            this.txtTenLNL.Size = new System.Drawing.Size(232, 32);
            this.txtTenLNL.TabIndex = 110;
            // 
            // lblTenLNL
            // 
            this.lblTenLNL.AutoSize = true;
            this.lblTenLNL.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenLNL.ForeColor = System.Drawing.Color.Red;
            this.lblTenLNL.Location = new System.Drawing.Point(553, 58);
            this.lblTenLNL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenLNL.Name = "lblTenLNL";
            this.lblTenLNL.Size = new System.Drawing.Size(182, 25);
            this.lblTenLNL.TabIndex = 109;
            this.lblTenLNL.Text = "Tên loại nguyên liệu";
            // 
            // txtMaLNL
            // 
            this.txtMaLNL.Enabled = false;
            this.txtMaLNL.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLNL.Location = new System.Drawing.Point(252, 49);
            this.txtMaLNL.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaLNL.Name = "txtMaLNL";
            this.txtMaLNL.Size = new System.Drawing.Size(232, 32);
            this.txtMaLNL.TabIndex = 104;
            // 
            // lblMaloainguyenlieu
            // 
            this.lblMaloainguyenlieu.AutoSize = true;
            this.lblMaloainguyenlieu.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaloainguyenlieu.ForeColor = System.Drawing.Color.Red;
            this.lblMaloainguyenlieu.Location = new System.Drawing.Point(49, 58);
            this.lblMaloainguyenlieu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaloainguyenlieu.Name = "lblMaloainguyenlieu";
            this.lblMaloainguyenlieu.Size = new System.Drawing.Size(181, 25);
            this.lblMaloainguyenlieu.TabIndex = 103;
            this.lblMaloainguyenlieu.Text = "Mã loại nguyên liệu";
            // 
            // frmLoaiNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 548);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLoaiNguyenLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoaiNguyenLieu";
            this.Load += new System.EventHandler(this.frmLoaiNguyenLieu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvLoainguyenlieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgrvLoainguyenlieu;
        private System.Windows.Forms.TextBox txtTenLNL;
        private System.Windows.Forms.Label lblTenLNL;
        private System.Windows.Forms.TextBox txtMaLNL;
        private System.Windows.Forms.Label lblMaloainguyenlieu;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}