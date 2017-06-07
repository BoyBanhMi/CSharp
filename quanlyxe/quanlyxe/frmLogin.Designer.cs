namespace quanlyxe
{
    partial class frmLogin
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
            this.lbluser = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_role = new System.Windows.Forms.ComboBox();
            this.lbl_TB = new System.Windows.Forms.Label();
            this.pnlicon = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Location = new System.Drawing.Point(272, 168);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(72, 15);
            this.lbluser.TabIndex = 0;
            this.lbluser.Text = "Tài Khoản";
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Location = new System.Drawing.Point(275, 204);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(68, 15);
            this.lblpass.TabIndex = 0;
            this.lblpass.Text = "Mật Khẩu";
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(387, 241);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(138, 27);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "ĐĂNG NHẬP";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.UseWaitCursor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(544, 241);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(99, 27);
            this.btnexit.TabIndex = 2;
            this.btnexit.Text = "HỦY";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(149, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chức Vụ";
            // 
            // cbb_role
            // 
            this.cbb_role.FormattingEnabled = true;
            this.cbb_role.Location = new System.Drawing.Point(387, 128);
            this.cbb_role.Name = "cbb_role";
            this.cbb_role.Size = new System.Drawing.Size(138, 23);
            this.cbb_role.TabIndex = 5;
            // 
            // lbl_TB
            // 
            this.lbl_TB.AutoSize = true;
            this.lbl_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TB.ForeColor = System.Drawing.Color.Red;
            this.lbl_TB.Location = new System.Drawing.Point(266, 89);
            this.lbl_TB.Name = "lbl_TB";
            this.lbl_TB.Size = new System.Drawing.Size(0, 20);
            this.lbl_TB.TabIndex = 0;
            // 
            // pnlicon
            // 
            this.pnlicon.BackgroundImage = global::quanlyxe.Properties.Resources.icon;
            this.pnlicon.Location = new System.Drawing.Point(39, 68);
            this.pnlicon.Name = "pnlicon";
            this.pnlicon.Size = new System.Drawing.Size(209, 203);
            this.pnlicon.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(262, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "(Phần mềm quản lý xe cho thuê)";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(387, 167);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(194, 21);
            this.txtuser.TabIndex = 6;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(387, 202);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(194, 21);
            this.txtpass.TabIndex = 7;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(712, 293);
            this.ControlBox = false;
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.cbb_role);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlicon);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.lbl_TB);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbluser);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Panel pnlicon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_role;
        private System.Windows.Forms.Label lbl_TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
    }
}

