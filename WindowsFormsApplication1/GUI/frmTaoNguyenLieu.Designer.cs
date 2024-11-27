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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMaLNL = new System.Windows.Forms.ComboBox();
            this.cboDvt = new System.Windows.Forms.ComboBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnTao = new System.Windows.Forms.Button();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDvt
            // 
            this.lblDvt.AutoSize = true;
            this.lblDvt.Location = new System.Drawing.Point(73, 122);
            this.lblDvt.Name = "lblDvt";
            this.lblDvt.Size = new System.Drawing.Size(38, 16);
            this.lblDvt.TabIndex = 112;
            this.lblDvt.Text = "DVT:";
            // 
            // lblTennl
            // 
            this.lblTennl.AutoSize = true;
            this.lblTennl.Location = new System.Drawing.Point(73, 78);
            this.lblTennl.Name = "lblTennl";
            this.lblTennl.Size = new System.Drawing.Size(112, 16);
            this.lblTennl.TabIndex = 111;
            this.lblTennl.Text = "Tên Nguyên Liệu:";
            // 
            // txtTennl
            // 
            this.txtTennl.Location = new System.Drawing.Point(204, 75);
            this.txtTennl.Name = "txtTennl";
            this.txtTennl.Size = new System.Drawing.Size(215, 22);
            this.txtTennl.TabIndex = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 114;
            this.label1.Text = "TẠO NGUYÊN LIỆU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 115;
            this.label2.Text = "Loai Nguyên Liệu:";
            // 
            // cboMaLNL
            // 
            this.cboMaLNL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaLNL.FormattingEnabled = true;
            this.cboMaLNL.Location = new System.Drawing.Point(204, 165);
            this.cboMaLNL.Name = "cboMaLNL";
            this.cboMaLNL.Size = new System.Drawing.Size(215, 24);
            this.cboMaLNL.TabIndex = 116;
            // 
            // cboDvt
            // 
            this.cboDvt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDvt.FormattingEnabled = true;
            this.cboDvt.Location = new System.Drawing.Point(204, 119);
            this.cboDvt.Name = "cboDvt";
            this.cboDvt.Size = new System.Drawing.Size(215, 24);
            this.cboDvt.TabIndex = 119;
            this.cboDvt.SelectedIndexChanged += new System.EventHandler(this.cboDvt_SelectedIndexChanged);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(204, 223);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(101, 44);
            this.btnHuy.TabIndex = 120;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTao
            // 
            this.btnTao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.btnTao.ForeColor = System.Drawing.Color.White;
            this.btnTao.Location = new System.Drawing.Point(358, 223);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(101, 44);
            this.btnTao.TabIndex = 121;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = false;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // btnTroVe
            // 
            this.btnTroVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.btnTroVe.ForeColor = System.Drawing.Color.White;
            this.btnTroVe.Location = new System.Drawing.Point(59, 223);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(101, 44);
            this.btnTroVe.TabIndex = 123;
            this.btnTroVe.Text = "Trở Về";
            this.btnTroVe.UseVisualStyleBackColor = false;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // frmTaoNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 295);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.cboDvt);
            this.Controls.Add(this.cboMaLNL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDvt);
            this.Controls.Add(this.lblTennl);
            this.Controls.Add(this.txtTennl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTaoNguyenLieu";
            this.Text = "frmTaoNguyenLieu";
            this.Load += new System.EventHandler(this.frmTaoNguyenLieu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDvt;
        private System.Windows.Forms.Label lblTennl;
        private System.Windows.Forms.TextBox txtTennl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMaLNL;
        private System.Windows.Forms.ComboBox cboDvt;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Button btnTroVe;
    }
}