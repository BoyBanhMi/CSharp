namespace quanlyxe
{
    partial class frmTraTien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dtv_dsHD = new System.Windows.Forms.DataGridView();
            this.dtpNgayTraTienThucTe = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTinhTrangThanhToan = new System.Windows.Forms.CheckBox();
            this.cmdThanhToan = new System.Windows.Forms.Button();
            this.txtMaNhanVien = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmdSua = new System.Windows.Forms.Button();
            this.cmdRefresh = new System.Windows.Forms.Button();
            this.cmdBaoCao = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_TenKH = new System.Windows.Forms.TextBox();
            this.txt_MaHD = new System.Windows.Forms.TextBox();
            this.rad_coTX = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_dsHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập Mã Khách Hàng";
            // 
            // dtv_dsHD
            // 
            this.dtv_dsHD.AllowUserToAddRows = false;
            this.dtv_dsHD.AllowUserToDeleteRows = false;
            this.dtv_dsHD.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtv_dsHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtv_dsHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtv_dsHD.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtv_dsHD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtv_dsHD.Location = new System.Drawing.Point(0, 0);
            this.dtv_dsHD.Name = "dtv_dsHD";
            this.dtv_dsHD.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtv_dsHD.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtv_dsHD.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtv_dsHD.Size = new System.Drawing.Size(817, 202);
            this.dtv_dsHD.TabIndex = 5;
            // 
            // dtpNgayTraTienThucTe
            // 
            this.dtpNgayTraTienThucTe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTraTienThucTe.Location = new System.Drawing.Point(370, 279);
            this.dtpNgayTraTienThucTe.Name = "dtpNgayTraTienThucTe";
            this.dtpNgayTraTienThucTe.Size = new System.Drawing.Size(100, 20);
            this.dtpNgayTraTienThucTe.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(64, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã HĐ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(235, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ngày trả tiền thực tế";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(537, 539);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Xác nhận nhân viên";
            // 
            // cbTinhTrangThanhToan
            // 
            this.cbTinhTrangThanhToan.AutoSize = true;
            this.cbTinhTrangThanhToan.Location = new System.Drawing.Point(656, 541);
            this.cbTinhTrangThanhToan.Name = "cbTinhTrangThanhToan";
            this.cbTinhTrangThanhToan.Size = new System.Drawing.Size(15, 14);
            this.cbTinhTrangThanhToan.TabIndex = 6;
            this.cbTinhTrangThanhToan.UseVisualStyleBackColor = true;
            this.cbTinhTrangThanhToan.CheckedChanged += new System.EventHandler(this.cbTinhTrangThanhToan_CheckedChanged);
            // 
            // cmdThanhToan
            // 
            this.cmdThanhToan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmdThanhToan.ForeColor = System.Drawing.Color.Black;
            this.cmdThanhToan.Location = new System.Drawing.Point(702, 537);
            this.cmdThanhToan.Name = "cmdThanhToan";
            this.cmdThanhToan.Size = new System.Drawing.Size(71, 61);
            this.cmdThanhToan.TabIndex = 1;
            this.cmdThanhToan.Text = "Thanh toán";
            this.cmdThanhToan.UseVisualStyleBackColor = true;
            this.cmdThanhToan.Visible = false;
            this.cmdThanhToan.Click += new System.EventHandler(this.cmdThanhToan_Click);
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMaNhanVien.FormattingEnabled = true;
            this.txtMaNhanVien.Location = new System.Drawing.Point(431, 537);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(100, 21);
            this.txtMaNhanVien.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(347, 541);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "NV thanh toán";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.Location = new System.Drawing.Point(-17, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(829, 167);
            this.dataGridView2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(820, 10);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(-14, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(820, 10);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(31, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Chi tiết thanh toán";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(21, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 22);
            this.label9.TabIndex = 2;
            this.label9.Text = "Hợp đồng khách hàng";
            // 
            // cmdSua
            // 
            this.cmdSua.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmdSua.ForeColor = System.Drawing.Color.Black;
            this.cmdSua.Location = new System.Drawing.Point(189, 537);
            this.cmdSua.Name = "cmdSua";
            this.cmdSua.Size = new System.Drawing.Size(71, 61);
            this.cmdSua.TabIndex = 14;
            this.cmdSua.Text = "Sửa";
            this.cmdSua.UseVisualStyleBackColor = true;
            this.cmdSua.Visible = false;
            this.cmdSua.Click += new System.EventHandler(this.cmdSua_Click);
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmdRefresh.ForeColor = System.Drawing.Color.Black;
            this.cmdRefresh.Location = new System.Drawing.Point(122, 537);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(71, 61);
            this.cmdRefresh.TabIndex = 14;
            this.cmdRefresh.Text = "Refresh";
            this.cmdRefresh.UseVisualStyleBackColor = true;
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // cmdBaoCao
            // 
            this.cmdBaoCao.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmdBaoCao.ForeColor = System.Drawing.Color.Black;
            this.cmdBaoCao.Location = new System.Drawing.Point(256, 537);
            this.cmdBaoCao.Name = "cmdBaoCao";
            this.cmdBaoCao.Size = new System.Drawing.Size(71, 61);
            this.cmdBaoCao.TabIndex = 15;
            this.cmdBaoCao.Text = "In";
            this.cmdBaoCao.UseVisualStyleBackColor = true;
            this.cmdBaoCao.Click += new System.EventHandler(this.cmdBaoCao_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtv_dsHD);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(3, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 205);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(3, 343);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(817, 173);
            this.panel2.TabIndex = 17;
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.Location = new System.Drawing.Point(278, 6);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Size = new System.Drawing.Size(241, 20);
            this.txt_TenKH.TabIndex = 18;
            this.txt_TenKH.TextChanged += new System.EventHandler(this.txt_TenKH_TextChanged);
            // 
            // txt_MaHD
            // 
            this.txt_MaHD.Location = new System.Drawing.Point(114, 277);
            this.txt_MaHD.Name = "txt_MaHD";
            this.txt_MaHD.Size = new System.Drawing.Size(100, 20);
            this.txt_MaHD.TabIndex = 19;
            // 
            // rad_coTX
            // 
            this.rad_coTX.AutoSize = true;
            this.rad_coTX.ForeColor = System.Drawing.Color.White;
            this.rad_coTX.Location = new System.Drawing.Point(527, 280);
            this.rad_coTX.Name = "rad_coTX";
            this.rad_coTX.Size = new System.Drawing.Size(65, 17);
            this.rad_coTX.TabIndex = 20;
            this.rad_coTX.TabStop = true;
            this.rad_coTX.Text = "có tài xế";
            this.rad_coTX.UseVisualStyleBackColor = true;
            // 
            // frmTraTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(827, 599);
            this.Controls.Add(this.rad_coTX);
            this.Controls.Add(this.txt_MaHD);
            this.Controls.Add(this.txt_TenKH);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdBaoCao);
            this.Controls.Add(this.dtpNgayTraTienThucTe);
            this.Controls.Add(this.cmdRefresh);
            this.Controls.Add(this.cmdSua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbTinhTrangThanhToan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdThanhToan);
            this.Controls.Add(this.txtMaNhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTraTien";
            this.Text = "Thanh toán";
            this.Load += new System.EventHandler(this.frmTraTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_dsHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtv_dsHD;
        private System.Windows.Forms.DateTimePicker dtpNgayTraTienThucTe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbTinhTrangThanhToan;
        private System.Windows.Forms.Button cmdThanhToan;
        private System.Windows.Forms.ComboBox txtMaNhanVien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cmdSua;
        private System.Windows.Forms.Button cmdRefresh;
        private System.Windows.Forms.Button cmdBaoCao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_TenKH;
        private System.Windows.Forms.TextBox txt_MaHD;
        private System.Windows.Forms.RadioButton rad_coTX;
    }
}