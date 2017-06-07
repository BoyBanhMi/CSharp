namespace quanlyxe
{
    partial class frmtimxe
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
            this.btntimxe = new System.Windows.Forms.Button();
            this.dgvTimKiemXe = new System.Windows.Forms.DataGridView();
            this.grbTimXe = new System.Windows.Forms.GroupBox();
            this.rbTimKiemMaXe = new System.Windows.Forms.RadioButton();
            this.rbTimKiemTheoTenXe = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTimKiemXe = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemXe)).BeginInit();
            this.grbTimXe.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btntimxe
            // 
            this.btntimxe.BackColor = System.Drawing.Color.Green;
            this.btntimxe.Location = new System.Drawing.Point(644, 144);
            this.btntimxe.Name = "btntimxe";
            this.btntimxe.Size = new System.Drawing.Size(70, 25);
            this.btntimxe.TabIndex = 0;
            this.btntimxe.Text = "Tìm";
            this.btntimxe.UseVisualStyleBackColor = false;
            this.btntimxe.Click += new System.EventHandler(this.btntimxe_Click);
            // 
            // dgvTimKiemXe
            // 
            this.dgvTimKiemXe.AllowUserToAddRows = false;
            this.dgvTimKiemXe.AllowUserToDeleteRows = false;
            this.dgvTimKiemXe.BackgroundColor = System.Drawing.Color.White;
            this.dgvTimKiemXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTimKiemXe.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTimKiemXe.Location = new System.Drawing.Point(63, 3);
            this.dgvTimKiemXe.Name = "dgvTimKiemXe";
            this.dgvTimKiemXe.ReadOnly = true;
            this.dgvTimKiemXe.Size = new System.Drawing.Size(846, 316);
            this.dgvTimKiemXe.TabIndex = 1;
            // 
            // grbTimXe
            // 
            this.grbTimXe.Controls.Add(this.rbTimKiemMaXe);
            this.grbTimXe.Controls.Add(this.rbTimKiemTheoTenXe);
            this.grbTimXe.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.grbTimXe.ForeColor = System.Drawing.Color.Yellow;
            this.grbTimXe.Location = new System.Drawing.Point(5, 13);
            this.grbTimXe.Name = "grbTimXe";
            this.grbTimXe.Size = new System.Drawing.Size(974, 71);
            this.grbTimXe.TabIndex = 2;
            this.grbTimXe.TabStop = false;
            this.grbTimXe.Text = "Tìm Kiếm Xe";
            // 
            // rbTimKiemMaXe
            // 
            this.rbTimKiemMaXe.AutoSize = true;
            this.rbTimKiemMaXe.Location = new System.Drawing.Point(290, 24);
            this.rbTimKiemMaXe.Name = "rbTimKiemMaXe";
            this.rbTimKiemMaXe.Size = new System.Drawing.Size(167, 21);
            this.rbTimKiemMaXe.TabIndex = 5;
            this.rbTimKiemMaXe.TabStop = true;
            this.rbTimKiemMaXe.Text = "Tìm kiếm theo mã Xe";
            this.rbTimKiemMaXe.UseVisualStyleBackColor = true;
            // 
            // rbTimKiemTheoTenXe
            // 
            this.rbTimKiemTheoTenXe.AutoSize = true;
            this.rbTimKiemTheoTenXe.Location = new System.Drawing.Point(512, 24);
            this.rbTimKiemTheoTenXe.Name = "rbTimKiemTheoTenXe";
            this.rbTimKiemTheoTenXe.Size = new System.Drawing.Size(169, 21);
            this.rbTimKiemTheoTenXe.TabIndex = 5;
            this.rbTimKiemTheoTenXe.TabStop = true;
            this.rbTimKiemTheoTenXe.Text = "Tìm kiếm theo tên Xe";
            this.rbTimKiemTheoTenXe.UseVisualStyleBackColor = true;
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
            this.panel1.Controls.Add(this.dgvTimKiemXe);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(5, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 329);
            this.panel1.TabIndex = 4;
            // 
            // txtTimKiemXe
            // 
            this.txtTimKiemXe.Location = new System.Drawing.Point(257, 144);
            this.txtTimKiemXe.Name = "txtTimKiemXe";
            this.txtTimKiemXe.Size = new System.Drawing.Size(381, 20);
            this.txtTimKiemXe.TabIndex = 6;
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
            // frmtimxe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(980, 547);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTimKiemXe);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbTimXe);
            this.Controls.Add(this.btntimxe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmtimxe";
            this.Text = "frmTimKiemHopDong";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemXe)).EndInit();
            this.grbTimXe.ResumeLayout(false);
            this.grbTimXe.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntimxe;
        private System.Windows.Forms.DataGridView dgvTimKiemXe;
        private System.Windows.Forms.GroupBox grbTimXe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbTimKiemMaXe;
        private System.Windows.Forms.TextBox txtTimKiemXe;
        private System.Windows.Forms.RadioButton rbTimKiemTheoTenXe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}