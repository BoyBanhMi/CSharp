namespace quanlyxe
{
    partial class frm_TraTien
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
            this.label8 = new System.Windows.Forms.Label();
            this.cb_xacnhan = new System.Windows.Forms.CheckBox();
            this.btn_thanhtoan = new System.Windows.Forms.Button();
            this.cbb_NhanVien = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_in = new System.Windows.Forms.Button();
            this.cbb_MaHD = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_MaKH = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgv_xemHD = new System.Windows.Forms.DataGridView();
            this.dtp_chitiet = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_XemHopDong = new System.Windows.Forms.Button();
            this.txt_ghichu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_xemHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_chitiet)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(397, 572);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Xác nhận nhân viên";
            // 
            // cb_xacnhan
            // 
            this.cb_xacnhan.AutoSize = true;
            this.cb_xacnhan.Location = new System.Drawing.Point(535, 573);
            this.cb_xacnhan.Name = "cb_xacnhan";
            this.cb_xacnhan.Size = new System.Drawing.Size(15, 14);
            this.cb_xacnhan.TabIndex = 6;
            this.cb_xacnhan.UseVisualStyleBackColor = true;
            this.cb_xacnhan.CheckedChanged += new System.EventHandler(this.cb_xacnhan_CheckedChanged);
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_thanhtoan.ForeColor = System.Drawing.Color.Black;
            this.btn_thanhtoan.Location = new System.Drawing.Point(644, 538);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(177, 70);
            this.btn_thanhtoan.TabIndex = 1;
            this.btn_thanhtoan.Text = "Thanh toán";
            this.btn_thanhtoan.UseVisualStyleBackColor = true;
            this.btn_thanhtoan.Visible = false;
            this.btn_thanhtoan.Click += new System.EventHandler(this.btn_thanhtoan_Click);
            // 
            // cbb_NhanVien
            // 
            this.cbb_NhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_NhanVien.FormattingEnabled = true;
            this.cbb_NhanVien.Location = new System.Drawing.Point(495, 538);
            this.cbb_NhanVien.Name = "cbb_NhanVien";
            this.cbb_NhanVien.Size = new System.Drawing.Size(116, 23);
            this.cbb_NhanVien.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(397, 542);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "NV thanh toán";
            // 
            // btn_in
            // 
            this.btn_in.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_in.ForeColor = System.Drawing.Color.Black;
            this.btn_in.Location = new System.Drawing.Point(203, 538);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(179, 70);
            this.btn_in.TabIndex = 15;
            this.btn_in.Text = "In";
            this.btn_in.UseVisualStyleBackColor = true;
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // cbb_MaHD
            // 
            this.cbb_MaHD.FormattingEnabled = true;
            this.cbb_MaHD.Location = new System.Drawing.Point(181, 17);
            this.cbb_MaHD.Name = "cbb_MaHD";
            this.cbb_MaHD.Size = new System.Drawing.Size(140, 23);
            this.cbb_MaHD.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã Hợp Đồng";
            // 
            // cbb_MaKH
            // 
            this.cbb_MaKH.FormattingEnabled = true;
            this.cbb_MaKH.Location = new System.Drawing.Point(530, 17);
            this.cbb_MaKH.Name = "cbb_MaKH";
            this.cbb_MaKH.Size = new System.Drawing.Size(140, 23);
            this.cbb_MaKH.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // dtgv_xemHD
            // 
            this.dtgv_xemHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_xemHD.Location = new System.Drawing.Point(14, 63);
            this.dtgv_xemHD.Name = "dtgv_xemHD";
            this.dtgv_xemHD.Size = new System.Drawing.Size(1263, 137);
            this.dtgv_xemHD.TabIndex = 18;
            // 
            // dtp_chitiet
            // 
            this.dtp_chitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtp_chitiet.Location = new System.Drawing.Point(14, 269);
            this.dtp_chitiet.Name = "dtp_chitiet";
            this.dtp_chitiet.Size = new System.Drawing.Size(1263, 245);
            this.dtp_chitiet.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Ghi chú";
            // 
            // btn_XemHopDong
            // 
            this.btn_XemHopDong.Location = new System.Drawing.Point(747, 15);
            this.btn_XemHopDong.Name = "btn_XemHopDong";
            this.btn_XemHopDong.Size = new System.Drawing.Size(122, 27);
            this.btn_XemHopDong.TabIndex = 23;
            this.btn_XemHopDong.Text = "Xem Hợp Đồng";
            this.btn_XemHopDong.UseVisualStyleBackColor = true;
            this.btn_XemHopDong.Click += new System.EventHandler(this.btn_XemHopDong_Click);
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_ghichu.Location = new System.Drawing.Point(181, 228);
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(640, 21);
            this.txt_ghichu.TabIndex = 22;
            // 
            // frm_TraTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1309, 629);
            this.Controls.Add(this.btn_XemHopDong);
            this.Controls.Add(this.txt_ghichu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtp_chitiet);
            this.Controls.Add(this.dtgv_xemHD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_MaKH);
            this.Controls.Add(this.cbb_MaHD);
            this.Controls.Add(this.btn_in);
            this.Controls.Add(this.cb_xacnhan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_thanhtoan);
            this.Controls.Add(this.cbb_NhanVien);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_TraTien";
            this.Text = "Thanh toán";
            this.Load += new System.EventHandler(this.frm_TraTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_xemHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_chitiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cb_xacnhan;
        private System.Windows.Forms.Button btn_thanhtoan;
        private System.Windows.Forms.ComboBox cbb_NhanVien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_in;
        private System.Windows.Forms.ComboBox cbb_MaHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_MaKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgv_xemHD;
        private System.Windows.Forms.DataGridView dtp_chitiet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_XemHopDong;
        private System.Windows.Forms.TextBox txt_ghichu;
    }
}