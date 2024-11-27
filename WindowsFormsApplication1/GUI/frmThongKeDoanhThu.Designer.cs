namespace WindowsFormsApplication1.GUI
{
    partial class frmThongKeDoanhThu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMadoanhthu = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTongdoanhthu = new System.Windows.Forms.TextBox();
            this.lblDoanhthu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgrvDoanhthu = new System.Windows.Forms.DataGridView();
            this.dtpNgaydt = new System.Windows.Forms.DateTimePicker();
            this.btnThongke = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDoanhthu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgrvKettoan = new System.Windows.Forms.DataGridView();
            this.dtpNgaykt = new System.Windows.Forms.DateTimePicker();
            this.btnKettoanngay = new System.Windows.Forms.Button();
            this.cboCa = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoakettoan = new System.Windows.Forms.Button();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvDoanhthu)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvKettoan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTimkiem);
            this.groupBox1.Controls.Add(this.txtMadoanhthu);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtTongdoanhthu);
            this.groupBox1.Controls.Add(this.lblDoanhthu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgrvDoanhthu);
            this.groupBox1.Controls.Add(this.dtpNgaydt);
            this.groupBox1.Controls.Add(this.btnThongke);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 494);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doanh thu";
            // 
            // txtMadoanhthu
            // 
            this.txtMadoanhthu.Enabled = false;
            this.txtMadoanhthu.Location = new System.Drawing.Point(126, 33);
            this.txtMadoanhthu.Name = "txtMadoanhthu";
            this.txtMadoanhthu.Size = new System.Drawing.Size(200, 27);
            this.txtMadoanhthu.TabIndex = 101;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Red;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(10, 426);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(113, 48);
            this.btnThem.TabIndex = 100;
            this.btnThem.Text = "THÊM MỚI";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTongdoanhthu
            // 
            this.txtTongdoanhthu.Enabled = false;
            this.txtTongdoanhthu.Location = new System.Drawing.Point(126, 143);
            this.txtTongdoanhthu.Name = "txtTongdoanhthu";
            this.txtTongdoanhthu.Size = new System.Drawing.Size(200, 27);
            this.txtTongdoanhthu.TabIndex = 99;
            // 
            // lblDoanhthu
            // 
            this.lblDoanhthu.AutoSize = true;
            this.lblDoanhthu.Location = new System.Drawing.Point(2, 40);
            this.lblDoanhthu.Name = "lblDoanhthu";
            this.lblDoanhthu.Size = new System.Drawing.Size(101, 20);
            this.lblDoanhthu.TabIndex = 98;
            this.lblDoanhthu.Text = "Mã doanh thu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 97;
            this.label2.Text = "Ngày kết toán";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 96;
            this.label1.Text = "Tổng doanh thu";
            // 
            // dgrvDoanhthu
            // 
            this.dgrvDoanhthu.AllowUserToAddRows = false;
            this.dgrvDoanhthu.AllowUserToDeleteRows = false;
            this.dgrvDoanhthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvDoanhthu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgrvDoanhthu.Location = new System.Drawing.Point(6, 186);
            this.dgrvDoanhthu.Name = "dgrvDoanhthu";
            this.dgrvDoanhthu.ReadOnly = true;
            this.dgrvDoanhthu.Size = new System.Drawing.Size(454, 205);
            this.dgrvDoanhthu.TabIndex = 95;
            this.dgrvDoanhthu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrvDoanhthu_CellClick);
            // 
            // dtpNgaydt
            // 
            this.dtpNgaydt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaydt.Location = new System.Drawing.Point(126, 92);
            this.dtpNgaydt.Name = "dtpNgaydt";
            this.dtpNgaydt.Size = new System.Drawing.Size(200, 27);
            this.dtpNgaydt.TabIndex = 94;
            this.dtpNgaydt.ValueChanged += new System.EventHandler(this.dtpNgaydt_ValueChanged);
            // 
            // btnThongke
            // 
            this.btnThongke.BackColor = System.Drawing.Color.Red;
            this.btnThongke.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongke.ForeColor = System.Drawing.Color.White;
            this.btnThongke.Location = new System.Drawing.Point(160, 426);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(113, 48);
            this.btnThongke.TabIndex = 93;
            this.btnThongke.Text = "KẾT TOÁN";
            this.btnThongke.UseVisualStyleBackColor = false;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoakettoan);
            this.groupBox2.Controls.Add(this.txtDoanhthu);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dgrvKettoan);
            this.groupBox2.Controls.Add(this.dtpNgaykt);
            this.groupBox2.Controls.Add(this.btnKettoanngay);
            this.groupBox2.Controls.Add(this.cboCa);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(530, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 494);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết toán ngày";
            // 
            // txtDoanhthu
            // 
            this.txtDoanhthu.Enabled = false;
            this.txtDoanhthu.Location = new System.Drawing.Point(113, 143);
            this.txtDoanhthu.Name = "txtDoanhthu";
            this.txtDoanhthu.Size = new System.Drawing.Size(200, 27);
            this.txtDoanhthu.TabIndex = 99;
            this.txtDoanhthu.TextChanged += new System.EventHandler(this.txtDoanhthu_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 98;
            this.label3.Text = "Ca làm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 97;
            this.label4.Text = "Ngày thống kê";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 96;
            this.label5.Text = "Doanh thu";
            // 
            // dgrvKettoan
            // 
            this.dgrvKettoan.AllowUserToAddRows = false;
            this.dgrvKettoan.AllowUserToDeleteRows = false;
            this.dgrvKettoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvKettoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgrvKettoan.Location = new System.Drawing.Point(10, 186);
            this.dgrvKettoan.Name = "dgrvKettoan";
            this.dgrvKettoan.ReadOnly = true;
            this.dgrvKettoan.Size = new System.Drawing.Size(454, 205);
            this.dgrvKettoan.TabIndex = 95;
            this.dgrvKettoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrvKettoan_CellClick);
            // 
            // dtpNgaykt
            // 
            this.dtpNgaykt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaykt.Location = new System.Drawing.Point(113, 99);
            this.dtpNgaykt.Name = "dtpNgaykt";
            this.dtpNgaykt.Size = new System.Drawing.Size(200, 27);
            this.dtpNgaykt.TabIndex = 94;
            // 
            // btnKettoanngay
            // 
            this.btnKettoanngay.BackColor = System.Drawing.Color.Red;
            this.btnKettoanngay.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKettoanngay.ForeColor = System.Drawing.Color.White;
            this.btnKettoanngay.Location = new System.Drawing.Point(10, 426);
            this.btnKettoanngay.Name = "btnKettoanngay";
            this.btnKettoanngay.Size = new System.Drawing.Size(113, 48);
            this.btnKettoanngay.TabIndex = 93;
            this.btnKettoanngay.Text = "KẾT TOÁN NGÀY";
            this.btnKettoanngay.UseVisualStyleBackColor = false;
            this.btnKettoanngay.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // cboCa
            // 
            this.cboCa.FormattingEnabled = true;
            this.cboCa.Location = new System.Drawing.Point(113, 37);
            this.cboCa.Name = "cboCa";
            this.cboCa.Size = new System.Drawing.Size(200, 28);
            this.cboCa.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaDoanhThu";
            this.Column1.HeaderText = "Mã doanh thu";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaCaLam";
            this.Column2.HeaderText = "Mã ca làm";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DoanhThuTheoCa";
            dataGridViewCellStyle1.NullValue = "0";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column3.HeaderText = "Tổng doanh thu theo ca";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 120;
            // 
            // btnXoakettoan
            // 
            this.btnXoakettoan.BackColor = System.Drawing.Color.Red;
            this.btnXoakettoan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoakettoan.ForeColor = System.Drawing.Color.White;
            this.btnXoakettoan.Location = new System.Drawing.Point(184, 426);
            this.btnXoakettoan.Name = "btnXoakettoan";
            this.btnXoakettoan.Size = new System.Drawing.Size(113, 48);
            this.btnXoakettoan.TabIndex = 100;
            this.btnXoakettoan.Text = "XÓA KẾT TOÁN";
            this.btnXoakettoan.UseVisualStyleBackColor = false;
            this.btnXoakettoan.Click += new System.EventHandler(this.btnXoakettoan_Click);
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MaDoanhThu";
            this.Column4.HeaderText = "Mã doanh thu";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NgayKetToan";
            this.Column5.HeaderText = "Ngày kết toán";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 120;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TongDoanhThu";
            this.Column6.HeaderText = "Tổng doanh thu";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 120;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(332, 33);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(200, 27);
            this.txtTimkiem.TabIndex = 102;
            this.txtTimkiem.TextChanged += new System.EventHandler(this.txtTimkiem_TextChanged);
            // 
            // frmThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 536);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThongKeDoanhThu";
            this.Text = "frmThongKeDoanhThu";
            this.Load += new System.EventHandler(this.frmThongKeDoanhThu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvDoanhthu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvKettoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgrvDoanhthu;
        private System.Windows.Forms.DateTimePicker dtpNgaydt;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDoanhthu;
        private System.Windows.Forms.TextBox txtTongdoanhthu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDoanhthu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgrvKettoan;
        private System.Windows.Forms.DateTimePicker dtpNgaykt;
        private System.Windows.Forms.Button btnKettoanngay;
        private System.Windows.Forms.ComboBox cboCa;
        private System.Windows.Forms.TextBox txtMadoanhthu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnXoakettoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox txtTimkiem;
    }
}