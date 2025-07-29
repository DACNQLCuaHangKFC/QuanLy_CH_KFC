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
            this.btnCapnhat = new System.Windows.Forms.Button();
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
            this.groupBox1.Controls.Add(this.btnCapnhat);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(15, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(956, 502);
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
            this.dgrvLoaimonan.Location = new System.Drawing.Point(165, 135);
            this.dgrvLoaimonan.Margin = new System.Windows.Forms.Padding(4);
            this.dgrvLoaimonan.Name = "dgrvLoaimonan";
            this.dgrvLoaimonan.ReadOnly = true;
            this.dgrvLoaimonan.RowHeadersWidth = 51;
            this.dgrvLoaimonan.Size = new System.Drawing.Size(641, 222);
            this.dgrvLoaimonan.TabIndex = 121;
            this.dgrvLoaimonan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrvLoaimonan_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaLoai";
            this.Column1.HeaderText = "Mã loại món ăn";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 170;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenLoai";
            this.Column2.HeaderText = "Tên loại món ăn";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 170;
            // 
            // txtTenLMA
            // 
            this.txtTenLMA.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLMA.Location = new System.Drawing.Point(711, 62);
            this.txtTenLMA.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenLMA.Name = "txtTenLMA";
            this.txtTenLMA.Size = new System.Drawing.Size(232, 32);
            this.txtTenLMA.TabIndex = 120;
            // 
            // lblTenLMA
            // 
            this.lblTenLMA.AutoSize = true;
            this.lblTenLMA.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenLMA.ForeColor = System.Drawing.Color.Red;
            this.lblTenLMA.Location = new System.Drawing.Point(515, 70);
            this.lblTenLMA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenLMA.Name = "lblTenLMA";
            this.lblTenLMA.Size = new System.Drawing.Size(180, 25);
            this.lblTenLMA.TabIndex = 119;
            this.lblTenLMA.Text = "Tên loại nguyên liệu";
            // 
            // txtMaLMA
            // 
            this.txtMaLMA.Enabled = false;
            this.txtMaLMA.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLMA.Location = new System.Drawing.Point(213, 62);
            this.txtMaLMA.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaLMA.Name = "txtMaLMA";
            this.txtMaLMA.Size = new System.Drawing.Size(232, 32);
            this.txtMaLMA.TabIndex = 114;
            // 
            // lblMaLMA
            // 
            this.lblMaLMA.AutoSize = true;
            this.lblMaLMA.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLMA.ForeColor = System.Drawing.Color.Red;
            this.lblMaLMA.Location = new System.Drawing.Point(11, 70);
            this.lblMaLMA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaLMA.Name = "lblMaLMA";
            this.lblMaLMA.Size = new System.Drawing.Size(177, 25);
            this.lblMaLMA.TabIndex = 113;
            this.lblMaLMA.Text = "Mã loại nguyên liệu";
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.BackColor = System.Drawing.SystemColors.Control;
            this.btnCapnhat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhat.ForeColor = System.Drawing.Color.Black;
            this.btnCapnhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapnhat.Location = new System.Drawing.Point(767, 418);
            this.btnCapnhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(161, 59);
            this.btnCapnhat.TabIndex = 117;
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
            this.btnThem.Location = new System.Drawing.Point(465, 418);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(173, 59);
            this.btnThem.TabIndex = 115;
            this.btnThem.Text = "THÊM MỚI";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmLoaiMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 539);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnThem;
    }
}