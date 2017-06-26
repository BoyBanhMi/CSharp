namespace quanlyxe
{
    partial class frmBaoCao
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
            this.btn_HD = new System.Windows.Forms.Button();
            this.btn_KH = new System.Windows.Forms.Button();
            this.btn_LX = new System.Windows.Forms.Button();
            this.btn_NV = new System.Windows.Forms.Button();
            this.btn_Xe = new System.Windows.Forms.Button();
            this.btn_ChiTiet = new System.Windows.Forms.Button();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.pn_baocao = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_HD
            // 
            this.btn_HD.Location = new System.Drawing.Point(2, 3);
            this.btn_HD.Name = "btn_HD";
            this.btn_HD.Size = new System.Drawing.Size(110, 35);
            this.btn_HD.TabIndex = 0;
            this.btn_HD.Text = "Hợp Đồng";
            this.btn_HD.UseVisualStyleBackColor = true;
            this.btn_HD.Click += new System.EventHandler(this.btn_HD_Click);
            // 
            // btn_KH
            // 
            this.btn_KH.Location = new System.Drawing.Point(2, 45);
            this.btn_KH.Name = "btn_KH";
            this.btn_KH.Size = new System.Drawing.Size(110, 35);
            this.btn_KH.TabIndex = 0;
            this.btn_KH.Text = "Khách Hàng";
            this.btn_KH.UseVisualStyleBackColor = true;
            this.btn_KH.Click += new System.EventHandler(this.btn_KH_Click);
            // 
            // btn_LX
            // 
            this.btn_LX.Location = new System.Drawing.Point(2, 87);
            this.btn_LX.Name = "btn_LX";
            this.btn_LX.Size = new System.Drawing.Size(110, 35);
            this.btn_LX.TabIndex = 0;
            this.btn_LX.Text = "Lái Xe";
            this.btn_LX.UseVisualStyleBackColor = true;
            this.btn_LX.Click += new System.EventHandler(this.btn_LX_Click);
            // 
            // btn_NV
            // 
            this.btn_NV.Location = new System.Drawing.Point(2, 128);
            this.btn_NV.Name = "btn_NV";
            this.btn_NV.Size = new System.Drawing.Size(110, 35);
            this.btn_NV.TabIndex = 0;
            this.btn_NV.Text = "Nhân Viên";
            this.btn_NV.UseVisualStyleBackColor = true;
            this.btn_NV.Click += new System.EventHandler(this.btn_NV_Click);
            // 
            // btn_Xe
            // 
            this.btn_Xe.Location = new System.Drawing.Point(2, 170);
            this.btn_Xe.Name = "btn_Xe";
            this.btn_Xe.Size = new System.Drawing.Size(110, 35);
            this.btn_Xe.TabIndex = 0;
            this.btn_Xe.Text = "Xe";
            this.btn_Xe.UseVisualStyleBackColor = true;
            this.btn_Xe.Click += new System.EventHandler(this.btn_Xe_Click);
            // 
            // btn_ChiTiet
            // 
            this.btn_ChiTiet.Location = new System.Drawing.Point(2, 269);
            this.btn_ChiTiet.Name = "btn_ChiTiet";
            this.btn_ChiTiet.Size = new System.Drawing.Size(110, 54);
            this.btn_ChiTiet.TabIndex = 0;
            this.btn_ChiTiet.Text = "Chi Tiết Hợp Đồng";
            this.btn_ChiTiet.UseVisualStyleBackColor = true;
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Location = new System.Drawing.Point(2, 211);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(110, 51);
            this.btn_ThanhToan.TabIndex = 0;
            this.btn_ThanhToan.Text = "Phiếu Thanh Toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = true;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // pn_baocao
            // 
            this.pn_baocao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pn_baocao.Location = new System.Drawing.Point(136, 6);
            this.pn_baocao.Name = "pn_baocao";
            this.pn_baocao.Size = new System.Drawing.Size(1328, 612);
            this.pn_baocao.TabIndex = 1;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(118, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(12, 755);
            this.button8.TabIndex = 2;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.pn_baocao);
            this.Controls.Add(this.btn_NV);
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.btn_ChiTiet);
            this.Controls.Add(this.btn_KH);
            this.Controls.Add(this.btn_Xe);
            this.Controls.Add(this.btn_LX);
            this.Controls.Add(this.btn_HD);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBaoCao";
            this.Text = "Báo Cáo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_HD;
        private System.Windows.Forms.Button btn_KH;
        private System.Windows.Forms.Button btn_LX;
        private System.Windows.Forms.Button btn_NV;
        private System.Windows.Forms.Button btn_Xe;
        private System.Windows.Forms.Button btn_ChiTiet;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.Panel pn_baocao;
        private System.Windows.Forms.Button button8;
    }
}