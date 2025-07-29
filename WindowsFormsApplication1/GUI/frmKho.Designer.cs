namespace WindowsFormsApplication1
{
    partial class frmKho
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
            this.cmbTenLNL = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvBep = new System.Windows.Forms.DataGridView();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.btnNhapBep = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.dgvKho = new System.Windows.Forms.DataGridView();
            this.lblManl = new System.Windows.Forms.Label();
            this.txtManl = new System.Windows.Forms.TextBox();
            this.txtTennl = new System.Windows.Forms.TextBox();
            this.lblTennl = new System.Windows.Forms.Label();
            this.lblDvt = new System.Windows.Forms.Label();
            this.txtDvt = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.Kho = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.grpTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).BeginInit();
            this.Kho.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Controls.Add(this.cmbTenLNL);
            this.grpTimKiem.Controls.Add(this.txtTimKiem);
            this.grpTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.grpTimKiem.Location = new System.Drawing.Point(16, 7);
            this.grpTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Padding = new System.Windows.Forms.Padding(4);
            this.grpTimKiem.Size = new System.Drawing.Size(476, 101);
            this.grpTimKiem.TabIndex = 88;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Tìm kiếm";
            // 
            // cmbTenLNL
            // 
            this.cmbTenLNL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenLNL.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenLNL.FormattingEnabled = true;
            this.cmbTenLNL.Location = new System.Drawing.Point(306, 46);
            this.cmbTenLNL.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTenLNL.Name = "cmbTenLNL";
            this.cmbTenLNL.Size = new System.Drawing.Size(147, 33);
            this.cmbTenLNL.TabIndex = 31;
            this.cmbTenLNL.SelectedIndexChanged += new System.EventHandler(this.cmbTenLNL_SelectedIndexChanged);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(17, 46);
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
            this.dgvBep.Location = new System.Drawing.Point(3, 7);
            this.dgvBep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBep.Name = "dgvBep";
            this.dgvBep.ReadOnly = true;
            this.dgvBep.RowHeadersWidth = 51;
            this.dgvBep.RowTemplate.Height = 24;
            this.dgvBep.Size = new System.Drawing.Size(690, 362);
            this.dgvBep.TabIndex = 87;
            this.dgvBep.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBep_CellContentClick);
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.ForeColor = System.Drawing.Color.Red;
            this.lblSoLuong.Location = new System.Drawing.Point(756, 188);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(77, 20);
            this.lblSoLuong.TabIndex = 86;
            this.lblSoLuong.Text = "Số Lượng:";
            // 
            // btnNhapBep
            // 
            this.btnNhapBep.BackColor = System.Drawing.SystemColors.Control;
            this.btnNhapBep.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapBep.ForeColor = System.Drawing.Color.Black;
            this.btnNhapBep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapBep.Location = new System.Drawing.Point(772, 230);
            this.btnNhapBep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhapBep.Name = "btnNhapBep";
            this.btnNhapBep.Size = new System.Drawing.Size(196, 53);
            this.btnNhapBep.TabIndex = 85;
            this.btnNhapBep.Text = "Nhập Vào Bếp";
            this.btnNhapBep.UseVisualStyleBackColor = false;
            this.btnNhapBep.Click += new System.EventHandler(this.btnNhapBep_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(893, 186);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(130, 22);
            this.txtSoLuong.TabIndex = 84;
            // 
            // dgvKho
            // 
            this.dgvKho.AllowUserToAddRows = false;
            this.dgvKho.AllowUserToDeleteRows = false;
            this.dgvKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKho.Location = new System.Drawing.Point(4, 5);
            this.dgvKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvKho.Name = "dgvKho";
            this.dgvKho.ReadOnly = true;
            this.dgvKho.RowHeadersWidth = 51;
            this.dgvKho.RowTemplate.Height = 24;
            this.dgvKho.Size = new System.Drawing.Size(672, 535);
            this.dgvKho.TabIndex = 83;
            this.dgvKho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKho_CellContentClick);
            // 
            // lblManl
            // 
            this.lblManl.AutoSize = true;
            this.lblManl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManl.ForeColor = System.Drawing.Color.Red;
            this.lblManl.Location = new System.Drawing.Point(756, 60);
            this.lblManl.Name = "lblManl";
            this.lblManl.Size = new System.Drawing.Size(126, 20);
            this.lblManl.TabIndex = 89;
            this.lblManl.Text = "Mã Nguyên Liệu:";
            // 
            // txtManl
            // 
            this.txtManl.Location = new System.Drawing.Point(890, 54);
            this.txtManl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtManl.Name = "txtManl";
            this.txtManl.Size = new System.Drawing.Size(231, 22);
            this.txtManl.TabIndex = 90;
            // 
            // txtTennl
            // 
            this.txtTennl.Location = new System.Drawing.Point(893, 97);
            this.txtTennl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTennl.Name = "txtTennl";
            this.txtTennl.Size = new System.Drawing.Size(231, 22);
            this.txtTennl.TabIndex = 91;
            // 
            // lblTennl
            // 
            this.lblTennl.AutoSize = true;
            this.lblTennl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTennl.ForeColor = System.Drawing.Color.Red;
            this.lblTennl.Location = new System.Drawing.Point(756, 100);
            this.lblTennl.Name = "lblTennl";
            this.lblTennl.Size = new System.Drawing.Size(128, 20);
            this.lblTennl.TabIndex = 92;
            this.lblTennl.Text = "Tên Nguyên Liệu:";
            // 
            // lblDvt
            // 
            this.lblDvt.AutoSize = true;
            this.lblDvt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDvt.ForeColor = System.Drawing.Color.Red;
            this.lblDvt.Location = new System.Drawing.Point(756, 144);
            this.lblDvt.Name = "lblDvt";
            this.lblDvt.Size = new System.Drawing.Size(42, 20);
            this.lblDvt.TabIndex = 93;
            this.lblDvt.Text = "DVT:";
            // 
            // txtDvt
            // 
            this.txtDvt.Location = new System.Drawing.Point(890, 142);
            this.txtDvt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDvt.Name = "txtDvt";
            this.txtDvt.Size = new System.Drawing.Size(231, 22);
            this.txtDvt.TabIndex = 94;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(756, 15);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(47, 19);
            this.lblTime.TabIndex = 99;
            this.lblTime.Text = "Time";
            // 
            // Kho
            // 
            this.Kho.Controls.Add(this.dgvKho);
            this.Kho.Location = new System.Drawing.Point(12, 137);
            this.Kho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Kho.Name = "Kho";
            this.Kho.Size = new System.Drawing.Size(679, 542);
            this.Kho.TabIndex = 102;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvBep);
            this.panel1.Location = new System.Drawing.Point(697, 308);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 371);
            this.panel1.TabIndex = 103;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.SystemColors.Control;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.Black;
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(512, 48);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(163, 53);
            this.btnCapNhat.TabIndex = 104;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // frmKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 703);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Kho);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtDvt);
            this.Controls.Add(this.lblDvt);
            this.Controls.Add(this.lblTennl);
            this.Controls.Add(this.txtTennl);
            this.Controls.Add(this.txtManl);
            this.Controls.Add(this.lblManl);
            this.Controls.Add(this.grpTimKiem);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.btnNhapBep);
            this.Controls.Add(this.txtSoLuong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmKho";
            this.Text = "frmKho";
            this.Load += new System.EventHandler(this.frmKho_Load_1);
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).EndInit();
            this.Kho.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvBep;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Button btnNhapBep;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.DataGridView dgvKho;
        private System.Windows.Forms.Label lblManl;
        private System.Windows.Forms.TextBox txtManl;
        private System.Windows.Forms.TextBox txtTennl;
        private System.Windows.Forms.Label lblTennl;
        private System.Windows.Forms.Label lblDvt;
        private System.Windows.Forms.TextBox txtDvt;
        private System.Windows.Forms.ComboBox cmbTenLNL;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel Kho;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCapNhat;
    }
}

