namespace quanlyxe
{
    partial class frmhopdong
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
            this.cmdThem = new System.Windows.Forms.Button();
            this.txtMaKhachHang = new System.Windows.Forms.ComboBox();
            this.dtgThemKhachHang = new System.Windows.Forms.DataGridView();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenKhachhang = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNext = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdSua = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rad_Nu = new System.Windows.Forms.RadioButton();
            this.rad_Nam = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.cmdRefresh = new System.Windows.Forms.Button();
            this.pnThemHopDong = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgThemKhachHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdThem
            // 
            this.cmdThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdThem.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmdThem.ForeColor = System.Drawing.Color.White;
            this.cmdThem.Location = new System.Drawing.Point(754, 32);
            this.cmdThem.Name = "cmdThem";
            this.cmdThem.Size = new System.Drawing.Size(59, 40);
            this.cmdThem.TabIndex = 0;
            this.cmdThem.Text = "Thêm";
            this.cmdThem.UseVisualStyleBackColor = false;
            this.cmdThem.Click += new System.EventHandler(this.cmdThem_Click);
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.FormattingEnabled = true;
            this.txtMaKhachHang.Location = new System.Drawing.Point(109, 23);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(113, 26);
            this.txtMaKhachHang.TabIndex = 1;
            // 
            // dtgThemKhachHang
            // 
            this.dtgThemKhachHang.AllowUserToAddRows = false;
            this.dtgThemKhachHang.AllowUserToDeleteRows = false;
            this.dtgThemKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dtgThemKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgThemKhachHang.Location = new System.Drawing.Point(7, 161);
            this.dtgThemKhachHang.Name = "dtgThemKhachHang";
            this.dtgThemKhachHang.ReadOnly = true;
            this.dtgThemKhachHang.Size = new System.Drawing.Size(902, 82);
            this.dtgThemKhachHang.TabIndex = 2;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(109, 76);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(113, 24);
            this.dtpNgaySinh.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã khách hàng";
            // 
            // txtTenKhachhang
            // 
            this.txtTenKhachhang.Location = new System.Drawing.Point(109, 51);
            this.txtTenKhachhang.Name = "txtTenKhachhang";
            this.txtTenKhachhang.Size = new System.Drawing.Size(113, 24);
            this.txtTenKhachhang.TabIndex = 5;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(316, 23);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(112, 24);
            this.txtDiaChi.TabIndex = 5;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(316, 49);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(112, 24);
            this.txtCMND.TabIndex = 5;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(316, 76);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(112, 24);
            this.txtDienThoai.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(3, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(35, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(35, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(260, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "CMND";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(243, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Điện thoại";
            // 
            // txtNext
            // 
            this.txtNext.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNext.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtNext.ForeColor = System.Drawing.Color.White;
            this.txtNext.Location = new System.Drawing.Point(754, 90);
            this.txtNext.Name = "txtNext";
            this.txtNext.Size = new System.Drawing.Size(59, 40);
            this.txtNext.TabIndex = 0;
            this.txtNext.Text = "Lập HD";
            this.txtNext.UseVisualStyleBackColor = false;
            this.txtNext.Click += new System.EventHandler(this.txtNext_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.cmdSua);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cmdRefresh);
            this.groupBox1.Controls.Add(this.dtgThemKhachHang);
            this.groupBox1.Controls.Add(this.txtNext);
            this.groupBox1.Controls.Add(this.cmdThem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(922, 272);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hợp đồng có lái xe";
            // 
            // cmdSua
            // 
            this.cmdSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdSua.ForeColor = System.Drawing.Color.White;
            this.cmdSua.Location = new System.Drawing.Point(829, 90);
            this.cmdSua.Name = "cmdSua";
            this.cmdSua.Size = new System.Drawing.Size(67, 40);
            this.cmdSua.TabIndex = 9;
            this.cmdSua.Text = "Sửa";
            this.cmdSua.UseVisualStyleBackColor = false;
            this.cmdSua.Click += new System.EventHandler(this.cmdSua_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 136);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rad_Nu);
            this.groupBox2.Controls.Add(this.rad_Nam);
            this.groupBox2.Controls.Add(this.dtpNgaySinh);
            this.groupBox2.Controls.Add(this.txtMaKhachHang);
            this.groupBox2.Controls.Add(this.txtDienThoai);
            this.groupBox2.Controls.Add(this.txtCMND);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtTenKhachhang);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(314, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 140);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng";
            // 
            // rad_Nu
            // 
            this.rad_Nu.AutoSize = true;
            this.rad_Nu.Location = new System.Drawing.Point(172, 105);
            this.rad_Nu.Name = "rad_Nu";
            this.rad_Nu.Size = new System.Drawing.Size(46, 22);
            this.rad_Nu.TabIndex = 7;
            this.rad_Nu.TabStop = true;
            this.rad_Nu.Text = "Nữ";
            this.rad_Nu.UseVisualStyleBackColor = true;
            // 
            // rad_Nam
            // 
            this.rad_Nam.AutoSize = true;
            this.rad_Nam.Checked = true;
            this.rad_Nam.Location = new System.Drawing.Point(109, 105);
            this.rad_Nam.Name = "rad_Nam";
            this.rad_Nam.Size = new System.Drawing.Size(57, 22);
            this.rad_Nam.TabIndex = 6;
            this.rad_Nam.TabStop = true;
            this.rad_Nam.Text = "Nam";
            this.rad_Nam.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(259, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Địa chỉ";
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdRefresh.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmdRefresh.ForeColor = System.Drawing.Color.White;
            this.cmdRefresh.Location = new System.Drawing.Point(829, 30);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(66, 40);
            this.cmdRefresh.TabIndex = 6;
            this.cmdRefresh.Text = "Tải Lại";
            this.cmdRefresh.UseVisualStyleBackColor = false;
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // pnThemHopDong
            // 
            this.pnThemHopDong.BackColor = System.Drawing.SystemColors.Control;
            this.pnThemHopDong.Location = new System.Drawing.Point(0, 279);
            this.pnThemHopDong.Name = "pnThemHopDong";
            this.pnThemHopDong.Size = new System.Drawing.Size(1247, 304);
            this.pnThemHopDong.TabIndex = 9;
            // 
            // frmhopdong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1250, 532);
            this.Controls.Add(this.pnThemHopDong);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmhopdong";
            this.Text = "frmQuanLyHopDong";
            this.Load += new System.EventHandler(this.frmhopdong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgThemKhachHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdThem;
        private System.Windows.Forms.ComboBox txtMaKhachHang;
        private System.Windows.Forms.DataGridView dtgThemKhachHang;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenKhachhang;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button txtNext;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdRefresh;
        private System.Windows.Forms.Panel pnThemHopDong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdSua;
        private System.Windows.Forms.RadioButton rad_Nu;
        private System.Windows.Forms.RadioButton rad_Nam;
    }
}