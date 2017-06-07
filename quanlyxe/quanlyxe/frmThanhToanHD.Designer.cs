namespace quanlyxe
{
    partial class frmThanhToanHD
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
            this.pnThanhToan = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdTraXe = new System.Windows.Forms.Button();
            this.cmdTraTien = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnThanhToan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnThanhToan
            // 
            this.pnThanhToan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnThanhToan.Controls.Add(this.label3);
            this.pnThanhToan.Controls.Add(this.pictureBox4);
            this.pnThanhToan.Controls.Add(this.pictureBox3);
            this.pnThanhToan.Controls.Add(this.pictureBox2);
            this.pnThanhToan.Controls.Add(this.pictureBox1);
            this.pnThanhToan.Location = new System.Drawing.Point(133, -2);
            this.pnThanhToan.Name = "pnThanhToan";
            this.pnThanhToan.Size = new System.Drawing.Size(898, 613);
            this.pnThanhToan.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(164, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(499, 46);
            this.label3.TabIndex = 8;
            this.label3.Text = "THANH TOÁN HỢP ĐỒNG";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(644, 117);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(128, 128);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(56, 117);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(128, 128);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(468, 139);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(350, 350);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 350);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // cmdTraXe
            // 
            this.cmdTraXe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdTraXe.Location = new System.Drawing.Point(4, 247);
            this.cmdTraXe.Name = "cmdTraXe";
            this.cmdTraXe.Size = new System.Drawing.Size(115, 115);
            this.cmdTraXe.TabIndex = 0;
            this.cmdTraXe.Text = "TRẢ XE";
            this.cmdTraXe.UseVisualStyleBackColor = false;
            // 
            // cmdTraTien
            // 
            this.cmdTraTien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdTraTien.Location = new System.Drawing.Point(7, 95);
            this.cmdTraTien.Name = "cmdTraTien";
            this.cmdTraTien.Size = new System.Drawing.Size(115, 115);
            this.cmdTraTien.TabIndex = 0;
            this.cmdTraTien.Text = "TRẢ TIỀN";
            this.cmdTraTien.UseVisualStyleBackColor = false;
            this.cmdTraTien.Click += new System.EventHandler(this.cmdTraTien_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 610);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmThanhToanHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1255, 623);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdTraTien);
            this.Controls.Add(this.cmdTraXe);
            this.Controls.Add(this.pnThanhToan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThanhToanHD";
            this.Text = "frmThanhToanVaTraXe";
            this.pnThanhToan.ResumeLayout(false);
            this.pnThanhToan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnThanhToan;
        private System.Windows.Forms.Button cmdTraXe;
        private System.Windows.Forms.Button cmdTraTien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}