namespace WindowsFormsApplication1.GUI
{
    partial class frmLoaiMonAn
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
            this.dgrvLoaimonan = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenLMA = new System.Windows.Forms.TextBox();
            this.lblTenLMA = new System.Windows.Forms.Label();
            this.txtMaLMA = new System.Windows.Forms.TextBox();
            this.lblMaLMA = new System.Windows.Forms.Label();
            this.btnHuybo = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvLoaimonan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgrvLoaimonan);
            this.groupBox1.Controls.Add(this.txtTenLMA);
            this.groupBox1.Controls.Add(this.lblTenLMA);
            this.groupBox1.Controls.Add(this.txtMaLMA);
            this.groupBox1.Controls.Add(this.lblMaLMA);
            this.groupBox1.Controls.Add(this.btnHuybo);
            this.groupBox1.Controls.Add(this.btnCapnhat);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 408);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại món ăn";
            // 
            // dgrvLoaimonan
            // 
            this.dgrvLoaimonan.AllowUserToAddRows = false;
            this.dgrvLoaimonan.AllowUserToDeleteRows = false;
            this.dgrvLoaimonan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvLoaimonan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgrvLoaimonan.Location = new System.Drawing.Point(124, 110);
            this.dgrvLoaimonan.Name = "dgrvLoaimonan";
            this.dgrvLoaimonan.ReadOnly = true;
            this.dgrvLoaimonan.Size = new System.Drawing.Size(481, 180);
            this.dgrvLoaimonan.TabIndex = 121;
            this.dgrvLoaimonan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrvLoaimonan_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaLoai";
            this.Column1.HeaderText = "Mã loại món ăn";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 170;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenLoai";
            this.Column2.HeaderText = "Tên loại món ăn";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 170;
            // 
            // txtTenLMA
            // 
            this.txtTenLMA.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLMA.Location = new System.Drawing.Point(533, 50);
            this.txtTenLMA.Name = "txtTenLMA";
            this.txtTenLMA.Size = new System.Drawing.Size(175, 27);
            this.txtTenLMA.TabIndex = 120;
            // 
            // lblTenLMA
            // 
            this.lblTenLMA.AutoSize = true;
            this.lblTenLMA.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenLMA.Location = new System.Drawing.Point(386, 57);
            this.lblTenLMA.Name = "lblTenLMA";
            this.lblTenLMA.Size = new System.Drawing.Size(141, 20);
            this.lblTenLMA.TabIndex = 119;
            this.lblTenLMA.Text = "Tên loại nguyên liệu";
            // 
            // txtMaLMA
            // 
            this.txtMaLMA.Enabled = false;
            this.txtMaLMA.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLMA.Location = new System.Drawing.Point(160, 50);
            this.txtMaLMA.Name = "txtMaLMA";
            this.txtMaLMA.Size = new System.Drawing.Size(175, 27);
            this.txtMaLMA.TabIndex = 114;
            // 
            // lblMaLMA
            // 
            this.lblMaLMA.AutoSize = true;
            this.lblMaLMA.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLMA.Location = new System.Drawing.Point(8, 57);
            this.lblMaLMA.Name = "lblMaLMA";
            this.lblMaLMA.Size = new System.Drawing.Size(139, 20);
            this.lblMaLMA.TabIndex = 113;
            this.lblMaLMA.Text = "Mã loại nguyên liệu";
            // 
            // btnHuybo
            // 
            this.btnHuybo.BackColor = System.Drawing.Color.Red;
            this.btnHuybo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuybo.ForeColor = System.Drawing.Color.White;
            this.btnHuybo.Location = new System.Drawing.Point(595, 340);
            this.btnHuybo.Name = "btnHuybo";
            this.btnHuybo.Size = new System.Drawing.Size(113, 48);
            this.btnHuybo.TabIndex = 118;
            this.btnHuybo.Text = "HỦY BỎ";
            this.btnHuybo.UseVisualStyleBackColor = false;
            this.btnHuybo.Click += new System.EventHandler(this.btnHuybo_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.BackColor = System.Drawing.Color.Red;
            this.btnCapnhat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhat.ForeColor = System.Drawing.Color.White;
            this.btnCapnhat.Location = new System.Drawing.Point(401, 340);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(113, 48);
            this.btnCapnhat.TabIndex = 117;
            this.btnCapnhat.Text = "CẬP NHẬT";
            this.btnCapnhat.UseVisualStyleBackColor = false;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(207, 340);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(113, 48);
            this.btnXoa.TabIndex = 116;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Red;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(13, 340);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(113, 48);
            this.btnThem.TabIndex = 115;
            this.btnThem.Text = "THÊM MỚI";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmLoaiMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 438);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoaiMonAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoaiMonAn";
            this.Load += new System.EventHandler(this.frmLoaiMonAn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvLoaimonan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgrvLoaimonan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TextBox txtTenLMA;
        private System.Windows.Forms.Label lblTenLMA;
        private System.Windows.Forms.TextBox txtMaLMA;
        private System.Windows.Forms.Label lblMaLMA;
        private System.Windows.Forms.Button btnHuybo;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
    }
}