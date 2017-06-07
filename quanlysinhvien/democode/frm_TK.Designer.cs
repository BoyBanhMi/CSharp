namespace democode
{
    partial class frm_TK
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_MaSV = new System.Windows.Forms.RadioButton();
            this.rb_tenSV = new System.Windows.Forms.RadioButton();
            this.rb_MaKhoa = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tim = new System.Windows.Forms.TextBox();
            this.dtgv_dssv = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_dssv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_MaKhoa);
            this.groupBox1.Controls.Add(this.rb_tenSV);
            this.groupBox1.Controls.Add(this.rb_MaSV);
            this.groupBox1.Location = new System.Drawing.Point(115, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(541, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn cách tìm kiếm";
            // 
            // rb_MaSV
            // 
            this.rb_MaSV.AutoSize = true;
            this.rb_MaSV.Location = new System.Drawing.Point(92, 25);
            this.rb_MaSV.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rb_MaSV.Name = "rb_MaSV";
            this.rb_MaSV.Size = new System.Drawing.Size(124, 22);
            this.rb_MaSV.TabIndex = 0;
            this.rb_MaSV.TabStop = true;
            this.rb_MaSV.Text = "Mã Sinh Viên";
            this.rb_MaSV.UseVisualStyleBackColor = true;
            // 
            // rb_tenSV
            // 
            this.rb_tenSV.AutoSize = true;
            this.rb_tenSV.Checked = true;
            this.rb_tenSV.Location = new System.Drawing.Point(240, 25);
            this.rb_tenSV.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rb_tenSV.Name = "rb_tenSV";
            this.rb_tenSV.Size = new System.Drawing.Size(129, 22);
            this.rb_tenSV.TabIndex = 0;
            this.rb_tenSV.TabStop = true;
            this.rb_tenSV.Text = "Tên Sinh Viên";
            this.rb_tenSV.UseVisualStyleBackColor = true;
            // 
            // rb_MaKhoa
            // 
            this.rb_MaKhoa.AutoSize = true;
            this.rb_MaKhoa.Location = new System.Drawing.Point(403, 25);
            this.rb_MaKhoa.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rb_MaKhoa.Name = "rb_MaKhoa";
            this.rb_MaKhoa.Size = new System.Drawing.Size(93, 22);
            this.rb_MaKhoa.TabIndex = 0;
            this.rb_MaKhoa.TabStop = true;
            this.rb_MaKhoa.Text = "Mã Khoa";
            this.rb_MaKhoa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập ";
            // 
            // txt_tim
            // 
            this.txt_tim.Location = new System.Drawing.Point(174, 98);
            this.txt_tim.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(437, 24);
            this.txt_tim.TabIndex = 2;
            this.txt_tim.TextChanged += new System.EventHandler(this.txt_tim_TextChanged);
            // 
            // dtgv_dssv
            // 
            this.dtgv_dssv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_dssv.Location = new System.Drawing.Point(12, 146);
            this.dtgv_dssv.Name = "dtgv_dssv";
            this.dtgv_dssv.Size = new System.Drawing.Size(942, 257);
            this.dtgv_dssv.TabIndex = 3;
            // 
            // frm_TK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(968, 415);
            this.Controls.Add(this.dtgv_dssv);
            this.Controls.Add(this.txt_tim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frm_TK";
            this.Text = "Tìm Kiếm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_dssv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_MaKhoa;
        private System.Windows.Forms.RadioButton rb_tenSV;
        private System.Windows.Forms.RadioButton rb_MaSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tim;
        private System.Windows.Forms.DataGridView dtgv_dssv;
    }
}