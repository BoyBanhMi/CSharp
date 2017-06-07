namespace quanlyxe
{
    partial class frmtimKH
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btntimKH = new System.Windows.Forms.Button();
            this.dgvTimKiemKH = new System.Windows.Forms.DataGridView();
            this.grbTimXe = new System.Windows.Forms.GroupBox();
            this.rbTimKiemMakh = new System.Windows.Forms.RadioButton();
            this.rbTimKiemTheoTenkh = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTimKiemKH = new System.Windows.Forms.TextBox();
            this.rbdt = new System.Windows.Forms.RadioButton();
            this.rbcmnd = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemKH)).BeginInit();
            this.grbTimXe.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btntimKH
            // 
            this.btntimKH.BackColor = System.Drawing.Color.Green;
            this.btntimKH.Location = new System.Drawing.Point(644, 144);
            this.btntimKH.Name = "btntimKH";
            this.btntimKH.Size = new System.Drawing.Size(70, 25);
            this.btntimKH.TabIndex = 0;
            this.btntimKH.Text = "Tìm";
            this.btntimKH.UseVisualStyleBackColor = false;
            this.btntimKH.Click += new System.EventHandler(this.btntimKH_Click);
            // 
            // dgvTimKiemKH
            // 
            this.dgvTimKiemKH.AllowUserToAddRows = false;
            this.dgvTimKiemKH.AllowUserToDeleteRows = false;
            this.dgvTimKiemKH.BackgroundColor = System.Drawing.Color.White;
            this.dgvTimKiemKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTimKiemKH.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTimKiemKH.Location = new System.Drawing.Point(63, 3);
            this.dgvTimKiemKH.Name = "dgvTimKiemKH";
            this.dgvTimKiemKH.ReadOnly = true;
            this.dgvTimKiemKH.Size = new System.Drawing.Size(846, 316);
            this.dgvTimKiemKH.TabIndex = 1;
            // 
            // grbTimXe
            // 
            this.grbTimXe.Controls.Add(this.rbcmnd);
            this.grbTimXe.Controls.Add(this.rbTimKiemMakh);
            this.grbTimXe.Controls.Add(this.rbdt);
            this.grbTimXe.Controls.Add(this.rbTimKiemTheoTenkh);
            this.grbTimXe.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.grbTimXe.ForeColor = System.Drawing.Color.Yellow;
            this.grbTimXe.Location = new System.Drawing.Point(5, 13);
            this.grbTimXe.Name = "grbTimXe";
            this.grbTimXe.Size = new System.Drawing.Size(974, 71);
            this.grbTimXe.TabIndex = 2;
            this.grbTimXe.TabStop = false;
            this.grbTimXe.Text = "Tìm Kiếm Khách Hàng";
            this.grbTimXe.Enter += new System.EventHandler(this.grbTimXe_Enter);
            // 
            // rbTimKiemMakh
            // 
            this.rbTimKiemMakh.AutoSize = true;
            this.rbTimKiemMakh.Location = new System.Drawing.Point(15, 24);
            this.rbTimKiemMakh.Name = "rbTimKiemMakh";
            this.rbTimKiemMakh.Size = new System.Drawing.Size(173, 21);
            this.rbTimKiemMakh.TabIndex = 5;
            this.rbTimKiemMakh.TabStop = true;
            this.rbTimKiemMakh.Text = "Tìm kiếm theo mã KH";
            this.rbTimKiemMakh.UseVisualStyleBackColor = true;
            // 
            // rbTimKiemTheoTenkh
            // 
            this.rbTimKiemTheoTenkh.AutoSize = true;
            this.rbTimKiemTheoTenkh.Location = new System.Drawing.Point(237, 24);
            this.rbTimKiemTheoTenkh.Name = "rbTimKiemTheoTenkh";
            this.rbTimKiemTheoTenkh.Size = new System.Drawing.Size(175, 21);
            this.rbTimKiemTheoTenkh.TabIndex = 5;
            this.rbTimKiemTheoTenkh.TabStop = true;
            this.rbTimKiemTheoTenkh.Text = "Tìm kiếm theo tên KH";
            this.rbTimKiemTheoTenkh.UseVisualStyleBackColor = true;
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
            // frmtimKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(980, 547);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTimKiemKH);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbTimXe);
            this.Controls.Add(this.btntimKH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmtimKH";
            this.Text = "frmTimKiemHopDong";
            this.Load += new System.EventHandler(this.frmtimKH_Load);
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

        private System.Windows.Forms.Button btntimKH;
        private System.Windows.Forms.DataGridView dgvTimKiemKH;
        private System.Windows.Forms.GroupBox grbTimXe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbTimKiemMakh;
        private System.Windows.Forms.TextBox txtTimKiemKH;
        private System.Windows.Forms.RadioButton rbTimKiemTheoTenkh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton rbcmnd;
        private System.Windows.Forms.RadioButton rbdt;
    }
}