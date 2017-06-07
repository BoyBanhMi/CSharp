namespace democode
{
    partial class frmDSSinhVienTheoKhoa
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_makhoa = new System.Windows.Forms.TextBox();
            this.btn_tim = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sinhvien_khoa = new democode.sinhvien_khoa();
            this.DSsinhvientheokhoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSsinhvientheokhoaTableAdapter = new democode.sinhvien_khoaTableAdapters.DSsinhvientheokhoaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvien_khoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSsinhvientheokhoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(95, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Mã Khoa";
            // 
            // txt_makhoa
            // 
            this.txt_makhoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_makhoa.Location = new System.Drawing.Point(209, 12);
            this.txt_makhoa.Name = "txt_makhoa";
            this.txt_makhoa.Size = new System.Drawing.Size(181, 25);
            this.txt_makhoa.TabIndex = 1;
            // 
            // btn_tim
            // 
            this.btn_tim.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim.Location = new System.Drawing.Point(419, 12);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(88, 25);
            this.btn_tim.TabIndex = 2;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "sinhvientheokhoa";
            reportDataSource2.Value = this.DSsinhvientheokhoaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "democode.rpt_DSSinhVienTheoKhoa.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 64);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(910, 267);
            this.reportViewer1.TabIndex = 3;
            // 
            // sinhvien_khoa
            // 
            this.sinhvien_khoa.DataSetName = "sinhvien_khoa";
            this.sinhvien_khoa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DSsinhvientheokhoaBindingSource
            // 
            this.DSsinhvientheokhoaBindingSource.DataMember = "DSsinhvientheokhoa";
            this.DSsinhvientheokhoaBindingSource.DataSource = this.sinhvien_khoa;
            // 
            // DSsinhvientheokhoaTableAdapter
            // 
            this.DSsinhvientheokhoaTableAdapter.ClearBeforeFill = true;
            // 
            // frmDSSinhVienTheoKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 339);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.txt_makhoa);
            this.Controls.Add(this.label1);
            this.Name = "frmDSSinhVienTheoKhoa";
            this.Text = "Danh Sách Sinh Viên Theo Khoa";
            this.Load += new System.EventHandler(this.frmDSSinhVienTheoKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sinhvien_khoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSsinhvientheokhoaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_makhoa;
        private System.Windows.Forms.Button btn_tim;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DSsinhvientheokhoaBindingSource;
        private sinhvien_khoa sinhvien_khoa;
        private sinhvien_khoaTableAdapters.DSsinhvientheokhoaTableAdapter DSsinhvientheokhoaTableAdapter;
    }
}