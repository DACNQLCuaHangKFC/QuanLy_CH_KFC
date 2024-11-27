
namespace WindowsFormsApplication1.GUI
{
    partial class frmQRCodeNcc
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
            this.btnTaoMa = new System.Windows.Forms.Button();
            this.cb_nganhang = new System.Windows.Forms.ComboBox();
            this.cb_template = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSTK = new System.Windows.Forms.TextBox();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTaoMa
            // 
            this.btnTaoMa.Location = new System.Drawing.Point(115, 368);
            this.btnTaoMa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTaoMa.Name = "btnTaoMa";
            this.btnTaoMa.Size = new System.Drawing.Size(100, 28);
            this.btnTaoMa.TabIndex = 0;
            this.btnTaoMa.Text = "Tạo Mã";
            this.btnTaoMa.UseVisualStyleBackColor = true;
            this.btnTaoMa.Click += new System.EventHandler(this.btnTaoMa_Click);
            // 
            // cb_nganhang
            // 
            this.cb_nganhang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_nganhang.FormattingEnabled = true;
            this.cb_nganhang.Location = new System.Drawing.Point(53, 44);
            this.cb_nganhang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_nganhang.Name = "cb_nganhang";
            this.cb_nganhang.Size = new System.Drawing.Size(223, 24);
            this.cb_nganhang.TabIndex = 1;
            // 
            // cb_template
            // 
            this.cb_template.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_template.FormattingEnabled = true;
            this.cb_template.Items.AddRange(new object[] {
            "compact",
            "compact2",
            "qr_only",
            "print"});
            this.cb_template.Location = new System.Drawing.Point(639, 44);
            this.cb_template.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_template.Name = "cb_template";
            this.cb_template.Size = new System.Drawing.Size(160, 24);
            this.cb_template.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(555, 167);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(533, 492);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtSTK
            // 
            this.txtSTK.Location = new System.Drawing.Point(327, 44);
            this.txtSTK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSTK.Name = "txtSTK";
            this.txtSTK.Size = new System.Drawing.Size(215, 22);
            this.txtSTK.TabIndex = 4;
            this.txtSTK.Text = "170303300403";
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(327, 123);
            this.txtTenTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(215, 22);
            this.txtTenTaiKhoan.TabIndex = 5;
            this.txtTenTaiKhoan.Text = "CHE MANH KHANG";
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(53, 123);
            this.txtSoTien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(223, 22);
            this.txtSoTien.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ngân Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Số tài Khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(635, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Template";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Số Tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 103);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tên Tài Khoản";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(635, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Thông tin Thêm";
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(639, 123);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(215, 22);
            this.txtInfo.TabIndex = 13;
            this.txtInfo.Text = "test";
            // 
            // frmQRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 663);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoTien);
            this.Controls.Add(this.txtTenTaiKhoan);
            this.Controls.Add(this.txtSTK);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cb_template);
            this.Controls.Add(this.cb_nganhang);
            this.Controls.Add(this.btnTaoMa);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmQRCode";
            this.Text = "frmQRCode";
            this.Load += new System.EventHandler(this.frmQRCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTaoMa;
        private System.Windows.Forms.ComboBox cb_nganhang;
        private System.Windows.Forms.ComboBox cb_template;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSTK;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInfo;
    }
}