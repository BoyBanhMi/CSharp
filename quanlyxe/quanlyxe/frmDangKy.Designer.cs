namespace quanlyxe
{
    partial class frmDangKy
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
            this.txt_userid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_role = new System.Windows.Forms.ComboBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.dataGridViewdk = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdk)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG KÝ TÀI KHOẢN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Tài Khoản";
            // 
            // txt_userid
            // 
            this.txt_userid.Location = new System.Drawing.Point(373, 77);
            this.txt_userid.Margin = new System.Windows.Forms.Padding(5);
            this.txt_userid.Name = "txt_userid";
            this.txt_userid.Size = new System.Drawing.Size(339, 27);
            this.txt_userid.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật Khẩu";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(373, 116);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(5);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(339, 27);
            this.txt_pass.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Chức Vụ";
            // 
            // cbb_role
            // 
            this.cbb_role.FormattingEnabled = true;
            this.cbb_role.Location = new System.Drawing.Point(373, 159);
            this.cbb_role.Margin = new System.Windows.Forms.Padding(5);
            this.cbb_role.Name = "cbb_role";
            this.cbb_role.Size = new System.Drawing.Size(199, 28);
            this.cbb_role.TabIndex = 3;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(194, 214);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(90, 38);
            this.btn_them.TabIndex = 4;
            this.btn_them.Text = "THÊM";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(335, 214);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(90, 38);
            this.btn_sua.TabIndex = 4;
            this.btn_sua.Text = "SỬA";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(501, 214);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(90, 38);
            this.btn_xoa.TabIndex = 4;
            this.btn_xoa.Text = "XÓA";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(671, 214);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(90, 38);
            this.btn_huy.TabIndex = 4;
            this.btn_huy.Text = "HỦY";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // dataGridViewdk
            // 
            this.dataGridViewdk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewdk.Location = new System.Drawing.Point(194, 280);
            this.dataGridViewdk.Name = "dataGridViewdk";
            this.dataGridViewdk.Size = new System.Drawing.Size(616, 272);
            this.dataGridViewdk.TabIndex = 5;
            // 
            // frmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1250, 600);
            this.Controls.Add(this.dataGridViewdk);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.cbb_role);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_userid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmDangKy";
            this.Text = "frmQuanLyHopDong";
            this.Load += new System.EventHandler(this.frmDangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_userid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_role;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.DataGridView dataGridViewdk;

    }
}