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
            this.dgrvLoainguyenlieu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenLNL = new System.Windows.Forms.TextBox();
            this.lblTenLNL = new System.Windows.Forms.Label();
            this.txtMaLNL = new System.Windows.Forms.TextBox();
            this.lblMaloainguyenlieu = new System.Windows.Forms.Label();
            this.btnHuybo = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvLoainguyenlieu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgrvLoainguyenlieu);
            this.groupBox1.Controls.Add(this.txtTenLNL);
            this.groupBox1.Controls.Add(this.lblTenLNL);
            this.groupBox1.Controls.Add(this.txtMaLNL);
            this.groupBox1.Controls.Add(this.lblMaloainguyenlieu);
            this.groupBox1.Controls.Add(this.btnHuybo);
            this.groupBox1.Controls.Add(this.btnCapnhat);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 421);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại nguyên liệu";
            // 
            // dgrvLoainguyenlieu
            // 
            this.dgrvLoainguyenlieu.AllowUserToAddRows = false;
            this.dgrvLoainguyenlieu.AllowUserToDeleteRows = false;
            this.dgrvLoainguyenlieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvLoainguyenlieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgrvLoainguyenlieu.Location = new System.Drawing.Point(113, 100);
            this.dgrvLoainguyenlieu.Name = "dgrvLoainguyenlieu";
            this.dgrvLoainguyenlieu.ReadOnly = true;
            this.dgrvLoainguyenlieu.Size = new System.Drawing.Size(532, 223);
            this.dgrvLoainguyenlieu.TabIndex = 111;
            this.dgrvLoainguyenlieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrvLoainguyenlieu_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaLoaiNguyenLieu";
            this.Column1.HeaderText = "Mã loại nguyên liệu";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 170;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenLoaiNguyenLieu";
            this.Column2.HeaderText = "Tên loại nguyên liệu";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 170;
            // 
            // txtTenLNL
            // 
            this.txtTenLNL.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLNL.Location = new System.Drawing.Point(562, 40);
            this.txtTenLNL.Name = "txtTenLNL";
            this.txtTenLNL.Size = new System.Drawing.Size(175, 27);
            this.txtTenLNL.TabIndex = 110;
            // 
            // lblTenLNL
            // 
            this.lblTenLNL.AutoSize = true;
            this.lblTenLNL.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenLNL.Location = new System.Drawing.Point(415, 47);
            this.lblTenLNL.Name = "lblTenLNL";
            this.lblTenLNL.Size = new System.Drawing.Size(141, 20);
            this.lblTenLNL.TabIndex = 109;
            this.lblTenLNL.Text = "Tên loại nguyên liệu";
            // 
            // txtMaLNL
            // 
            this.txtMaLNL.Enabled = false;
            this.txtMaLNL.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLNL.Location = new System.Drawing.Point(189, 40);
            this.txtMaLNL.Name = "txtMaLNL";
            this.txtMaLNL.Size = new System.Drawing.Size(175, 27);
            this.txtMaLNL.TabIndex = 104;
            // 
            // lblMaloainguyenlieu
            // 
            this.lblMaloainguyenlieu.AutoSize = true;
            this.lblMaloainguyenlieu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaloainguyenlieu.Location = new System.Drawing.Point(37, 47);
            this.lblMaloainguyenlieu.Name = "lblMaloainguyenlieu";
            this.lblMaloainguyenlieu.Size = new System.Drawing.Size(139, 20);
            this.lblMaloainguyenlieu.TabIndex = 103;
            this.lblMaloainguyenlieu.Text = "Mã loại nguyên liệu";
            // 
            // btnHuybo
            // 
            this.btnHuybo.BackColor = System.Drawing.Color.Red;
            this.btnHuybo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuybo.ForeColor = System.Drawing.Color.White;
            this.btnHuybo.Location = new System.Drawing.Point(624, 354);
            this.btnHuybo.Name = "btnHuybo";
            this.btnHuybo.Size = new System.Drawing.Size(113, 48);
            this.btnHuybo.TabIndex = 108;
            this.btnHuybo.Text = "HỦY BỎ";
            this.btnHuybo.UseVisualStyleBackColor = false;
            this.btnHuybo.Click += new System.EventHandler(this.btnHuybo_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.BackColor = System.Drawing.Color.Red;
            this.btnCapnhat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhat.ForeColor = System.Drawing.Color.White;
            this.btnCapnhat.Location = new System.Drawing.Point(430, 354);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(113, 48);
            this.btnCapnhat.TabIndex = 107;
            this.btnCapnhat.Text = "CẬP NHẬT";
            this.btnCapnhat.UseVisualStyleBackColor = false;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(236, 354);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(113, 48);
            this.btnXoa.TabIndex = 106;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Red;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(42, 354);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(113, 48);
            this.btnThem.TabIndex = 105;
            this.btnThem.Text = "THÊM MỚI";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmLoaiNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 445);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TextBox txtTenLNL;
        private System.Windows.Forms.Label lblTenLNL;
        private System.Windows.Forms.TextBox txtMaLNL;
        private System.Windows.Forms.Label lblMaloainguyenlieu;
        private System.Windows.Forms.Button btnHuybo;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
    }
}