namespace WindowsFormsApplication1.GUI
{
    partial class frmRPHoaDonDatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRPHoaDonDatHang));
            this.cb_nganhang = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cb_nganhang
            // 
            this.cb_nganhang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_nganhang.FormattingEnabled = true;
            this.cb_nganhang.Location = new System.Drawing.Point(113, 85);
            this.cb_nganhang.Margin = new System.Windows.Forms.Padding(4);
            this.cb_nganhang.Name = "cb_nganhang";
            this.cb_nganhang.Size = new System.Drawing.Size(223, 24);
            this.cb_nganhang.TabIndex = 2;
            this.cb_nganhang.Visible = false;
            // 
            // frmRPHoaDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_nganhang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRPHoaDonDatHang";
            this.Text = "Hoá đơn đặt hàng từ nhà cung cấp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_nganhang;
    }
}