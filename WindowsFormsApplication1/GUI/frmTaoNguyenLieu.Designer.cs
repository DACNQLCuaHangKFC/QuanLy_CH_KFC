namespace WindowsFormsApplication1
{
    partial class frmTaoNguyenLieu
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
            this.lblDvt = new System.Windows.Forms.Label();
            this.lblTennl = new System.Windows.Forms.Label();
            this.txtTennl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMaLNL = new System.Windows.Forms.ComboBox();
            this.cboDvt = new System.Windows.Forms.ComboBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnTao = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvKho = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDvt
            // 
            this.lblDvt.AutoSize = true;
            this.lblDvt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDvt.ForeColor = System.Drawing.Color.Red;
            this.lblDvt.Location = new System.Drawing.Point(24, 111);
            this.lblDvt.Name = "lblDvt";
            this.lblDvt.Size = new System.Drawing.Size(51, 25);
            this.lblDvt.TabIndex = 112;
            this.lblDvt.Text = "DVT:";
            // 
            // lblTennl
            // 
            this.lblTennl.AutoSize = true;
            this.lblTennl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTennl.ForeColor = System.Drawing.Color.Red;
            this.lblTennl.Location = new System.Drawing.Point(24, 66);
            this.lblTennl.Name = "lblTennl";
            this.lblTennl.Size = new System.Drawing.Size(156, 25);
            this.lblTennl.TabIndex = 111;
            this.lblTennl.Text = "Tên Nguyên Liệu:";
            // 
            // txtTennl
            // 
            this.txtTennl.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTennl.Location = new System.Drawing.Point(199, 64);
            this.txtTennl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTennl.Name = "txtTennl";
            this.txtTennl.Size = new System.Drawing.Size(215, 31);
            this.txtTennl.TabIndex = 110;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(24, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 115;
            this.label2.Text = "Loai Nguyên Liệu:";
            // 
            // cboMaLNL
            // 
            this.cboMaLNL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaLNL.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaLNL.FormattingEnabled = true;
            this.cboMaLNL.Location = new System.Drawing.Point(199, 154);
            this.cboMaLNL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMaLNL.Name = "cboMaLNL";
            this.cboMaLNL.Size = new System.Drawing.Size(215, 33);
            this.cboMaLNL.TabIndex = 116;
            // 
            // cboDvt
            // 
            this.cboDvt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDvt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDvt.FormattingEnabled = true;
            this.cboDvt.Location = new System.Drawing.Point(199, 108);
            this.cboDvt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboDvt.Name = "cboDvt";
            this.cboDvt.Size = new System.Drawing.Size(215, 33);
            this.cboDvt.TabIndex = 119;
            this.cboDvt.SelectedIndexChanged += new System.EventHandler(this.cboDvt_SelectedIndexChanged);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.Control;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.Black;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(89, 229);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(120, 44);
            this.btnHuy.TabIndex = 120;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTao
            // 
            this.btnTao.BackColor = System.Drawing.SystemColors.Control;
            this.btnTao.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTao.ForeColor = System.Drawing.Color.Black;
            this.btnTao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTao.Location = new System.Drawing.Point(273, 229);
            this.btnTao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(111, 44);
            this.btnTao.TabIndex = 121;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = false;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKho);
            this.groupBox1.Controls.Add(this.txtTennl);
            this.groupBox1.Controls.Add(this.lblTennl);
            this.groupBox1.Controls.Add(this.btnTao);
            this.groupBox1.Controls.Add(this.lblDvt);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.cboDvt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboMaLNL);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(61, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1091, 464);
            this.groupBox1.TabIndex = 124;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TẠO NGUYÊN LIỆU";
            // 
            // dgvKho
            // 
            this.dgvKho.AllowUserToAddRows = false;
            this.dgvKho.AllowUserToDeleteRows = false;
            this.dgvKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKho.Location = new System.Drawing.Point(420, 31);
            this.dgvKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvKho.Name = "dgvKho";
            this.dgvKho.ReadOnly = true;
            this.dgvKho.RowHeadersWidth = 51;
            this.dgvKho.RowTemplate.Height = 24;
            this.dgvKho.Size = new System.Drawing.Size(665, 429);
            this.dgvKho.TabIndex = 122;
            // 
            // frmTaoNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 522);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmTaoNguyenLieu";
            this.Text = "frmTaoNguyenLieu";
            this.Load += new System.EventHandler(this.frmTaoNguyenLieu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblDvt;
        private System.Windows.Forms.Label lblTennl;
        private System.Windows.Forms.TextBox txtTennl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMaLNL;
        private System.Windows.Forms.ComboBox cboDvt;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvKho;
    }
}