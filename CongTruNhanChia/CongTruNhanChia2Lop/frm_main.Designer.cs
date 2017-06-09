namespace CongTruNhanChia2Lop
{
    partial class frm_main
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_KQ = new System.Windows.Forms.Label();
            this.btn_thuchien = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_chia = new System.Windows.Forms.RadioButton();
            this.rad_nhan = new System.Windows.Forms.RadioButton();
            this.rad_tru = new System.Windows.Forms.RadioButton();
            this.rad_cong = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(229, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHƯƠNG TRÌNH CHÍNH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "a = ";
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(190, 50);
            this.txt_a.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(164, 24);
            this.txt_a.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "b = ";
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(190, 82);
            this.txt_b.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(164, 24);
            this.txt_b.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 281);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kết Quả Là : ";
            // 
            // lbl_KQ
            // 
            this.lbl_KQ.AutoSize = true;
            this.lbl_KQ.Location = new System.Drawing.Point(153, 281);
            this.lbl_KQ.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_KQ.Name = "lbl_KQ";
            this.lbl_KQ.Size = new System.Drawing.Size(0, 18);
            this.lbl_KQ.TabIndex = 0;
            // 
            // btn_thuchien
            // 
            this.btn_thuchien.Location = new System.Drawing.Point(374, 46);
            this.btn_thuchien.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_thuchien.Name = "btn_thuchien";
            this.btn_thuchien.Size = new System.Drawing.Size(105, 32);
            this.btn_thuchien.TabIndex = 3;
            this.btn_thuchien.Text = "Thực Hiện";
            this.btn_thuchien.UseVisualStyleBackColor = true;
            this.btn_thuchien.Click += new System.EventHandler(this.btn_thuchien_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(374, 86);
            this.btn_Huy.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(105, 32);
            this.btn_Huy.TabIndex = 3;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_chia);
            this.groupBox1.Controls.Add(this.rad_nhan);
            this.groupBox1.Controls.Add(this.rad_tru);
            this.groupBox1.Controls.Add(this.rad_cong);
            this.groupBox1.Location = new System.Drawing.Point(62, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "chọn phương thức tính";
            // 
            // rad_chia
            // 
            this.rad_chia.AutoSize = true;
            this.rad_chia.Location = new System.Drawing.Point(430, 40);
            this.rad_chia.Name = "rad_chia";
            this.rad_chia.Size = new System.Drawing.Size(60, 22);
            this.rad_chia.TabIndex = 0;
            this.rad_chia.TabStop = true;
            this.rad_chia.Text = "Chia";
            this.rad_chia.UseVisualStyleBackColor = true;
            // 
            // rad_nhan
            // 
            this.rad_nhan.AutoSize = true;
            this.rad_nhan.Location = new System.Drawing.Point(289, 40);
            this.rad_nhan.Name = "rad_nhan";
            this.rad_nhan.Size = new System.Drawing.Size(65, 22);
            this.rad_nhan.TabIndex = 0;
            this.rad_nhan.TabStop = true;
            this.rad_nhan.Text = "Nhân";
            this.rad_nhan.UseVisualStyleBackColor = true;
            // 
            // rad_tru
            // 
            this.rad_tru.AutoSize = true;
            this.rad_tru.Location = new System.Drawing.Point(145, 40);
            this.rad_tru.Name = "rad_tru";
            this.rad_tru.Size = new System.Drawing.Size(51, 22);
            this.rad_tru.TabIndex = 0;
            this.rad_tru.TabStop = true;
            this.rad_tru.Text = "Trừ";
            this.rad_tru.UseVisualStyleBackColor = true;
            // 
            // rad_cong
            // 
            this.rad_cong.AutoSize = true;
            this.rad_cong.Location = new System.Drawing.Point(6, 40);
            this.rad_cong.Name = "rad_cong";
            this.rad_cong.Size = new System.Drawing.Size(66, 22);
            this.rad_cong.TabIndex = 0;
            this.rad_cong.TabStop = true;
            this.rad_cong.Text = "Cộng";
            this.rad_cong.UseVisualStyleBackColor = true;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 321);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_thuchien);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_KQ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frm_main";
            this.Text = "congtrunhanchia";
            this.Load += new System.EventHandler(this.congtrunhanchia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_KQ;
        private System.Windows.Forms.Button btn_thuchien;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rad_chia;
        private System.Windows.Forms.RadioButton rad_nhan;
        private System.Windows.Forms.RadioButton rad_tru;
        private System.Windows.Forms.RadioButton rad_cong;
    }
}