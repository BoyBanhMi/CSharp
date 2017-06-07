namespace democode
{
    partial class frmTimKiemSinhVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_tenkhoa = new System.Windows.Forms.RadioButton();
            this.rb_Tensv = new System.Windows.Forms.RadioButton();
            this.rb_MaSV = new System.Windows.Forms.RadioButton();
            this.txt_tim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgv_timkiem = new System.Windows.Forms.DataGridView();
            this.lbl_thongke = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_timkiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÌM KIẾM SINH VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_tenkhoa);
            this.groupBox1.Controls.Add(this.rb_Tensv);
            this.groupBox1.Controls.Add(this.rb_MaSV);
            this.groupBox1.Location = new System.Drawing.Point(62, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 81);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn phương thức tìm kiếm";
            // 
            // rb_tenkhoa
            // 
            this.rb_tenkhoa.AutoSize = true;
            this.rb_tenkhoa.Location = new System.Drawing.Point(484, 47);
            this.rb_tenkhoa.Name = "rb_tenkhoa";
            this.rb_tenkhoa.Size = new System.Drawing.Size(92, 20);
            this.rb_tenkhoa.TabIndex = 0;
            this.rb_tenkhoa.TabStop = true;
            this.rb_tenkhoa.Text = "Tên Khoa";
            this.rb_tenkhoa.UseVisualStyleBackColor = true;
            // 
            // rb_Tensv
            // 
            this.rb_Tensv.AutoSize = true;
            this.rb_Tensv.Checked = true;
            this.rb_Tensv.Location = new System.Drawing.Point(249, 47);
            this.rb_Tensv.Name = "rb_Tensv";
            this.rb_Tensv.Size = new System.Drawing.Size(122, 20);
            this.rb_Tensv.TabIndex = 0;
            this.rb_Tensv.TabStop = true;
            this.rb_Tensv.Text = "Tên Sinh Viên";
            this.rb_Tensv.UseVisualStyleBackColor = true;
            // 
            // rb_MaSV
            // 
            this.rb_MaSV.AutoSize = true;
            this.rb_MaSV.Location = new System.Drawing.Point(43, 47);
            this.rb_MaSV.Name = "rb_MaSV";
            this.rb_MaSV.Size = new System.Drawing.Size(116, 20);
            this.rb_MaSV.TabIndex = 0;
            this.rb_MaSV.TabStop = true;
            this.rb_MaSV.Text = "Mã Sinh Viên";
            this.rb_MaSV.UseVisualStyleBackColor = true;
            // 
            // txt_tim
            // 
            this.txt_tim.Location = new System.Drawing.Point(195, 174);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(508, 22);
            this.txt_tim.TabIndex = 2;
            this.txt_tim.TextChanged += new System.EventHandler(this.txt_tim_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhập thông tin";
            // 
            // dtgv_timkiem
            // 
            this.dtgv_timkiem.AllowUserToAddRows = false;
            this.dtgv_timkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_timkiem.Location = new System.Drawing.Point(62, 218);
            this.dtgv_timkiem.Name = "dtgv_timkiem";
            this.dtgv_timkiem.Size = new System.Drawing.Size(641, 207);
            this.dtgv_timkiem.TabIndex = 5;
            // 
            // lbl_thongke
            // 
            this.lbl_thongke.AutoSize = true;
            this.lbl_thongke.ForeColor = System.Drawing.Color.Red;
            this.lbl_thongke.Location = new System.Drawing.Point(59, 472);
            this.lbl_thongke.Name = "lbl_thongke";
            this.lbl_thongke.Size = new System.Drawing.Size(0, 16);
            this.lbl_thongke.TabIndex = 4;
            this.lbl_thongke.Click += new System.EventHandler(this.lbl_thongke_Click);
            // 
            // frmTimKiemSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(797, 507);
            this.Controls.Add(this.dtgv_timkiem);
            this.Controls.Add(this.lbl_thongke);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tim);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTimKiemSinhVien";
            this.Text = "TÌM KIẾM";
            this.Load += new System.EventHandler(this.frmTimKiemSinhVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_timkiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_tenkhoa;
        private System.Windows.Forms.RadioButton rb_Tensv;
        private System.Windows.Forms.RadioButton rb_MaSV;
        private System.Windows.Forms.TextBox txt_tim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgv_timkiem;
        private System.Windows.Forms.Label lbl_thongke;
    }
}