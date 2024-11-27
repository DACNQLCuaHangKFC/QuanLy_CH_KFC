namespace WindowsFormsApplication1.GUI
{
    partial class frmHeThong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHeThong));
            this.grpDuLieu = new System.Windows.Forms.GroupBox();
            this.grpPhucHoiDuLieu = new System.Windows.Forms.GroupBox();
            this.btnPhuchoi = new System.Windows.Forms.Button();
            this.grpSaoLuuDuLieu = new System.Windows.Forms.GroupBox();
            this.btnSaoluu = new System.Windows.Forms.Button();
            this.grpPhanquyen = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPhanquyen = new System.Windows.Forms.Button();
            this.grpDuLieu.SuspendLayout();
            this.grpPhucHoiDuLieu.SuspendLayout();
            this.grpSaoLuuDuLieu.SuspendLayout();
            this.grpPhanquyen.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDuLieu
            // 
            this.grpDuLieu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpDuLieu.BackColor = System.Drawing.Color.Transparent;
            this.grpDuLieu.Controls.Add(this.grpPhucHoiDuLieu);
            this.grpDuLieu.Controls.Add(this.grpSaoLuuDuLieu);
            this.grpDuLieu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDuLieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.grpDuLieu.Location = new System.Drawing.Point(161, 316);
            this.grpDuLieu.Margin = new System.Windows.Forms.Padding(4);
            this.grpDuLieu.Name = "grpDuLieu";
            this.grpDuLieu.Padding = new System.Windows.Forms.Padding(4);
            this.grpDuLieu.Size = new System.Drawing.Size(679, 238);
            this.grpDuLieu.TabIndex = 8;
            this.grpDuLieu.TabStop = false;
            this.grpDuLieu.Text = "Dữ liệu";
            // 
            // grpPhucHoiDuLieu
            // 
            this.grpPhucHoiDuLieu.Controls.Add(this.btnPhuchoi);
            this.grpPhucHoiDuLieu.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPhucHoiDuLieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.grpPhucHoiDuLieu.Location = new System.Drawing.Point(368, 27);
            this.grpPhucHoiDuLieu.Margin = new System.Windows.Forms.Padding(4);
            this.grpPhucHoiDuLieu.Name = "grpPhucHoiDuLieu";
            this.grpPhucHoiDuLieu.Padding = new System.Windows.Forms.Padding(4);
            this.grpPhucHoiDuLieu.Size = new System.Drawing.Size(219, 197);
            this.grpPhucHoiDuLieu.TabIndex = 1;
            this.grpPhucHoiDuLieu.TabStop = false;
            this.grpPhucHoiDuLieu.Text = "Phục hồi dữ liệu";
            // 
            // btnPhuchoi
            // 
            this.btnPhuchoi.BackColor = System.Drawing.Color.Transparent;
            this.btnPhuchoi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhuchoi.ForeColor = System.Drawing.Color.White;
            this.btnPhuchoi.Image = ((System.Drawing.Image)(resources.GetObject("btnPhuchoi.Image")));
            this.btnPhuchoi.Location = new System.Drawing.Point(37, 44);
            this.btnPhuchoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnPhuchoi.Name = "btnPhuchoi";
            this.btnPhuchoi.Size = new System.Drawing.Size(145, 145);
            this.btnPhuchoi.TabIndex = 2;
            this.btnPhuchoi.UseVisualStyleBackColor = false;
            this.btnPhuchoi.Click += new System.EventHandler(this.btnPhuchoi_Click);
            // 
            // grpSaoLuuDuLieu
            // 
            this.grpSaoLuuDuLieu.Controls.Add(this.btnSaoluu);
            this.grpSaoLuuDuLieu.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSaoLuuDuLieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.grpSaoLuuDuLieu.Location = new System.Drawing.Point(92, 27);
            this.grpSaoLuuDuLieu.Margin = new System.Windows.Forms.Padding(4);
            this.grpSaoLuuDuLieu.Name = "grpSaoLuuDuLieu";
            this.grpSaoLuuDuLieu.Padding = new System.Windows.Forms.Padding(4);
            this.grpSaoLuuDuLieu.Size = new System.Drawing.Size(219, 197);
            this.grpSaoLuuDuLieu.TabIndex = 0;
            this.grpSaoLuuDuLieu.TabStop = false;
            this.grpSaoLuuDuLieu.Text = "Sao lưu dữ liệu";
            // 
            // btnSaoluu
            // 
            this.btnSaoluu.BackColor = System.Drawing.Color.White;
            this.btnSaoluu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaoluu.ForeColor = System.Drawing.Color.White;
            this.btnSaoluu.Image = ((System.Drawing.Image)(resources.GetObject("btnSaoluu.Image")));
            this.btnSaoluu.Location = new System.Drawing.Point(33, 44);
            this.btnSaoluu.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaoluu.Name = "btnSaoluu";
            this.btnSaoluu.Size = new System.Drawing.Size(151, 145);
            this.btnSaoluu.TabIndex = 0;
            this.btnSaoluu.UseVisualStyleBackColor = false;
            this.btnSaoluu.Click += new System.EventHandler(this.btnSaoluu_Click);
            // 
            // grpPhanquyen
            // 
            this.grpPhanquyen.Controls.Add(this.groupBox1);
            this.grpPhanquyen.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPhanquyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.grpPhanquyen.Location = new System.Drawing.Point(161, 12);
            this.grpPhanquyen.Name = "grpPhanquyen";
            this.grpPhanquyen.Size = new System.Drawing.Size(679, 276);
            this.grpPhanquyen.TabIndex = 9;
            this.grpPhanquyen.TabStop = false;
            this.grpPhanquyen.Text = "Phân quyền";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPhanquyen);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.groupBox1.Location = new System.Drawing.Point(92, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(243, 197);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phân quyền người dùng";
            // 
            // btnPhanquyen
            // 
            this.btnPhanquyen.BackColor = System.Drawing.Color.White;
            this.btnPhanquyen.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanquyen.ForeColor = System.Drawing.Color.White;
            this.btnPhanquyen.Image = ((System.Drawing.Image)(resources.GetObject("btnPhanquyen.Image")));
            this.btnPhanquyen.Location = new System.Drawing.Point(33, 44);
            this.btnPhanquyen.Margin = new System.Windows.Forms.Padding(4);
            this.btnPhanquyen.Name = "btnPhanquyen";
            this.btnPhanquyen.Size = new System.Drawing.Size(151, 145);
            this.btnPhanquyen.TabIndex = 0;
            this.btnPhanquyen.UseVisualStyleBackColor = false;
            this.btnPhanquyen.Click += new System.EventHandler(this.btnPhanquyen_Click);
            // 
            // frmHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 593);
            this.Controls.Add(this.grpPhanquyen);
            this.Controls.Add(this.grpDuLieu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHeThong";
            this.Text = "Hệ thống";
            this.grpDuLieu.ResumeLayout(false);
            this.grpPhucHoiDuLieu.ResumeLayout(false);
            this.grpSaoLuuDuLieu.ResumeLayout(false);
            this.grpPhanquyen.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDuLieu;
        private System.Windows.Forms.GroupBox grpPhucHoiDuLieu;
        private System.Windows.Forms.GroupBox grpSaoLuuDuLieu;
        private System.Windows.Forms.Button btnPhuchoi;
        private System.Windows.Forms.Button btnSaoluu;
        private System.Windows.Forms.GroupBox grpPhanquyen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPhanquyen;
    }
}