namespace quanlyxe
{
    partial class frmtimnhanvien
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
            this.btntim = new System.Windows.Forms.Button();
            this.dgvTimKiemKH = new System.Windows.Forms.DataGridView();
            this.grbTimXe = new System.Windows.Forms.GroupBox();
            this.rbcmnd = new System.Windows.Forms.RadioButton();
            this.rbTimKiemMaNV = new System.Windows.Forms.RadioButton();
            this.rbdt = new System.Windows.Forms.RadioButton();
            this.rbTimKiemTheoTenNV = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTimKiemKH = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemKH)).BeginInit();
            this.grbTimXe.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btntim
            // 
            this.btntim.BackColor = System.Drawing.Color.Green;
            this.btntim.Location = new System.Drawing.Point(644, 144);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(70, 25);
            this.btntim.TabIndex = 0;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = false;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // dgvTimKiemKH
            // 
            this.dgvTimKiemKH.AllowUserToAddRows = false;
            this.dgvTimKiemKH.AllowUserToDeleteRows = false;
            this.dgvTimKiemKH.BackgroundColor = System.Drawing.Color.White;
            this.dgvTimKiemKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTimKiemKH.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTimKiemKH.Location = new System.Drawing.Point(63, 3);
            this.dgvTimKiemKH.Name = "dgvTimKiemKH";
            this.dgvTimKiemKH.ReadOnly = true;
            this.dgvTimKiemKH.Size = new System.Drawing.Size(846, 316);
            this.dgvTimKiemKH.TabIndex = 1;
            // 
            // grbTimXe
            // 
            this.grbTimXe.Controls.Add(this.rbcmnd);
            this.grbTimXe.Controls.Add(this.rbTimKiemMaNV);
            this.grbTimXe.Controls.Add(this.rbdt);
            this.grbTimXe.Controls.Add(this.rbTimKiemTheoTenNV);
            this.grbTimXe.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.grbTimXe.ForeColor = System.Drawing.Color.Yellow;
            this.grbTimXe.Location = new System.Drawing.Point(5, 13);
            this.grbTimXe.Name = "grbTimXe";
            this.grbTimXe.Size = new System.Drawing.Size(974, 71);
            this.grbTimXe.TabIndex = 2;
            this.grbTimXe.TabStop = false;
            this.grbTimXe.Text = "Tìm Kiếm Nhân Viên";
            // 
            // rbcmnd
            // 
            this.rbcmnd.AutoSize = true;
            this.rbcmnd.Location = new System.Drawing.Point(450, 24);
            this.rbcmnd.Name = "rbcmnd";
            this.rbcmnd.Size = new System.Drawing.Size(194, 21);
            this.rbcmnd.TabIndex = 5;
            this.rbcmnd.TabStop = true;
            this.rbcmnd.Text = "Tìm kiếm theo Số CMND";
            this.rbcmnd.UseVisualStyleBackColor = true;
            // 
            // rbTimKiemMaNV
            // 
            this.rbTimKiemMaNV.AutoSize = true;
            this.rbTimKiemMaNV.Location = new System.Drawing.Point(15, 24);
            this.rbTimKiemMaNV.Name = "rbTimKiemMaNV";
            this.rbTimKiemMaNV.Size = new System.Drawing.Size(216, 21);
            this.rbTimKiemMaNV.TabIndex = 5;
            this.rbTimKiemMaNV.TabStop = true;
            this.rbTimKiemMaNV.Text = "Tìm kiếm theo mã Nhân Viên";
            this.rbTimKiemMaNV.UseVisualStyleBackColor = true;
            // 
            // rbdt
            // 
            this.rbdt.AutoSize = true;
            this.rbdt.Location = new System.Drawing.Point(672, 24);
            this.rbdt.Name = "rbdt";
            this.rbdt.Size = new System.Drawing.Size(166, 21);
            this.rbdt.TabIndex = 5;
            this.rbdt.TabStop = true;
            this.rbdt.Text = "Tìm kiếm theo số ĐT";
            this.rbdt.UseVisualStyleBackColor = true;
            // 
            // rbTimKiemTheoTenNV
            // 
            this.rbTimKiemTheoTenNV.AutoSize = true;
            this.rbTimKiemTheoTenNV.Location = new System.Drawing.Point(237, 24);
            this.rbTimKiemTheoTenNV.Name = "rbTimKiemTheoTenNV";
            this.rbTimKiemTheoTenNV.Size = new System.Drawing.Size(218, 21);
            this.rbTimKiemTheoTenNV.TabIndex = 5;
            this.rbTimKiemTheoTenNV.TabStop = true;
            this.rbTimKiemTheoTenNV.Text = "Tìm kiếm theo tên Nhân Viên";
            this.rbTimKiemTheoTenNV.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(362, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập thông tin cần tìm kiếm";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvTimKiemKH);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(5, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 329);
            this.panel1.TabIndex = 4;
            // 
            // txtTimKiemKH
            // 
            this.txtTimKiemKH.Location = new System.Drawing.Point(257, 144);
            this.txtTimKiemKH.Name = "txtTimKiemKH";
            this.txtTimKiemKH.Size = new System.Drawing.Size(381, 20);
            this.txtTimKiemKH.TabIndex = 6;
            this.txtTimKiemKH.TextChanged += new System.EventHandler(this.txtTimKiemKH_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(745, 87);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 113);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(38, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 111);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmtimnhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(980, 547);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTimKiemKH);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbTimXe);
            this.Controls.Add(this.btntim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmtimnhanvien";
            this.Text = "frmtimnhanvien";
            this.Load += new System.EventHandler(this.frmtimnhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemKH)).EndInit();
            this.grbTimXe.ResumeLayout(false);
            this.grbTimXe.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.DataGridView dgvTimKiemKH;
        private System.Windows.Forms.GroupBox grbTimXe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbTimKiemMaNV;
        private System.Windows.Forms.TextBox txtTimKiemKH;
        private System.Windows.Forms.RadioButton rbTimKiemTheoTenNV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton rbcmnd;
        private System.Windows.Forms.RadioButton rbdt;
    }
}