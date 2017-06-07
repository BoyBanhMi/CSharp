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
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_in = new System.Windows.Forms.Button();
            this.cbb_MaHD = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_MaKH = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgv_xemHD = new System.Windows.Forms.DataGridView();
            this.dtp_ThoihanHD = new System.Windows.Forms.DateTimePicker();
            this.dtp_NgayThanhToan = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_tienphat = new System.Windows.Forms.Label();
            this.txt_tienphat = new System.Windows.Forms.TextBox();
            this.dtp_chitiet = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_XemHopDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_xemHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_chitiet)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(684, 502);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Xác nhận nhân viên";
            // 
            // cb_xacnhan
            // 
            this.cb_xacnhan.AutoSize = true;
            this.cb_xacnhan.Location = new System.Drawing.Point(730, 521);
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
            this.btn_thanhtoan.Location = new System.Drawing.Point(702, 537);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(71, 61);
            this.btn_thanhtoan.TabIndex = 1;
            this.btn_thanhtoan.Text = "Thanh toán";
            this.btn_thanhtoan.UseVisualStyleBackColor = true;
            this.btn_thanhtoan.Visible = false;
            // 
            // cbb_NhanVien
            // 
            this.cbb_NhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_NhanVien.FormattingEnabled = true;
            this.cbb_NhanVien.Location = new System.Drawing.Point(702, 476);
            this.cbb_NhanVien.Name = "cbb_NhanVien";
            this.cbb_NhanVien.Size = new System.Drawing.Size(100, 21);
            this.cbb_NhanVien.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(618, 480);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "NV thanh toán";
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_sua.ForeColor = System.Drawing.Color.Black;
            this.btn_sua.Location = new System.Drawing.Point(189, 537);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(71, 61);
            this.btn_sua.TabIndex = 14;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Visible = false;
            // 
            // btn_in
            // 
            this.btn_in.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_in.ForeColor = System.Drawing.Color.Black;
            this.btn_in.Location = new System.Drawing.Point(256, 537);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(71, 61);
            this.btn_in.TabIndex = 15;
            this.btn_in.Text = "In";
            this.btn_in.UseVisualStyleBackColor = true;
            // 
            // cbb_MaHD
            // 
            this.cbb_MaHD.FormattingEnabled = true;
            this.cbb_MaHD.Location = new System.Drawing.Point(155, 15);
            this.cbb_MaHD.Name = "cbb_MaHD";
            this.cbb_MaHD.Size = new System.Drawing.Size(121, 21);
            this.cbb_MaHD.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã Hợp Đồng";
            // 
            // cbb_MaKH
            // 
            this.cbb_MaKH.FormattingEnabled = true;
            this.cbb_MaKH.Location = new System.Drawing.Point(454, 15);
            this.cbb_MaKH.Name = "cbb_MaKH";
            this.cbb_MaKH.Size = new System.Drawing.Size(121, 21);
            this.cbb_MaKH.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // dtgv_xemHD
            // 
            this.dtgv_xemHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_xemHD.Location = new System.Drawing.Point(12, 55);
            this.dtgv_xemHD.Name = "dtgv_xemHD";
            this.dtgv_xemHD.Size = new System.Drawing.Size(803, 119);
            this.dtgv_xemHD.TabIndex = 18;
            // 
            // dtp_ThoihanHD
            // 
            this.dtp_ThoihanHD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ThoihanHD.Location = new System.Drawing.Point(196, 181);
            this.dtp_ThoihanHD.Name = "dtp_ThoihanHD";
            this.dtp_ThoihanHD.Size = new System.Drawing.Size(111, 20);
            this.dtp_ThoihanHD.TabIndex = 19;
            // 
            // dtp_NgayThanhToan
            // 
            this.dtp_NgayThanhToan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayThanhToan.Location = new System.Drawing.Point(503, 180);
            this.dtp_NgayThanhToan.Name = "dtp_NgayThanhToan";
            this.dtp_NgayThanhToan.Size = new System.Drawing.Size(125, 20);
            this.dtp_NgayThanhToan.TabIndex = 19;
            this.dtp_NgayThanhToan.ValueChanged += new System.EventHandler(this.dtp_NgayThanhToan_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Thời Hạn Hợp Đồng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ngày Thanh Toán";
            // 
            // lbl_tienphat
            // 
            this.lbl_tienphat.AutoSize = true;
            this.lbl_tienphat.Location = new System.Drawing.Point(414, 217);
            this.lbl_tienphat.Name = "lbl_tienphat";
            this.lbl_tienphat.Size = new System.Drawing.Size(64, 13);
            this.lbl_tienphat.TabIndex = 21;
            this.lbl_tienphat.Text = "Số tiền phạt";
            // 
            // txt_tienphat
            // 
            this.txt_tienphat.Location = new System.Drawing.Point(503, 214);
            this.txt_tienphat.Name = "txt_tienphat";
            this.txt_tienphat.Size = new System.Drawing.Size(125, 20);
            this.txt_tienphat.TabIndex = 22;
            // 
            // dtp_chitiet
            // 
            this.dtp_chitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtp_chitiet.Location = new System.Drawing.Point(12, 253);
            this.dtp_chitiet.Name = "dtp_chitiet";
            this.dtp_chitiet.Size = new System.Drawing.Size(803, 192);
            this.dtp_chitiet.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Tiền Cọc";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(196, 217);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 20);
            this.textBox1.TabIndex = 22;
            // 
            // btn_XemHopDong
            // 
            this.btn_XemHopDong.Location = new System.Drawing.Point(640, 13);
            this.btn_XemHopDong.Name = "btn_XemHopDong";
            this.btn_XemHopDong.Size = new System.Drawing.Size(105, 23);
            this.btn_XemHopDong.TabIndex = 23;
            this.btn_XemHopDong.Text = "Xem Hợp Đồng";
            this.btn_XemHopDong.UseVisualStyleBackColor = true;
            this.btn_XemHopDong.Click += new System.EventHandler(this.btn_XemHopDong_Click);
            // 
            // frm_TraTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(827, 599);
            this.Controls.Add(this.btn_XemHopDong);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_tienphat);
            this.Controls.Add(this.lbl_tienphat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_NgayThanhToan);
            this.Controls.Add(this.dtp_ThoihanHD);
            this.Controls.Add(this.dtp_chitiet);
            this.Controls.Add(this.dtgv_xemHD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_MaKH);
            this.Controls.Add(this.cbb_MaHD);
            this.Controls.Add(this.btn_in);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.cb_xacnhan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_thanhtoan);
            this.Controls.Add(this.cbb_NhanVien);
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
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_in;
        private System.Windows.Forms.ComboBox cbb_MaHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_MaKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgv_xemHD;
        private System.Windows.Forms.DateTimePicker dtp_ThoihanHD;
        private System.Windows.Forms.DateTimePicker dtp_NgayThanhToan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_tienphat;
        private System.Windows.Forms.TextBox txt_tienphat;
        private System.Windows.Forms.DataGridView dtp_chitiet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_XemHopDong;
    }
}