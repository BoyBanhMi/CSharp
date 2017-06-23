namespace quanlyxe
{
    partial class frmBC_KhachHang
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tb_KhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qlxDataSet1 = new quanlyxe.qlxDataSet1();
            this.tb_HopDongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qlxDataSet = new quanlyxe.qlxDataSet();
            this.tb_HopDongTableAdapter = new quanlyxe.qlxDataSetTableAdapters.tb_HopDongTableAdapter();
            this.tb_KhachHangTableAdapter = new quanlyxe.qlxDataSet1TableAdapters.tb_KhachHangTableAdapter();
            this.qlxDataSet3 = new quanlyxe.qlxDataSet3();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.tb_KhachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlxDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_HopDongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlxDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlxDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_KhachHangBindingSource
            // 
            this.tb_KhachHangBindingSource.DataMember = "tb_KhachHang";
            this.tb_KhachHangBindingSource.DataSource = this.qlxDataSet1;
            // 
            // qlxDataSet1
            // 
            this.qlxDataSet1.DataSetName = "qlxDataSet1";
            this.qlxDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_HopDongBindingSource
            // 
            this.tb_HopDongBindingSource.DataMember = "tb_HopDong";
            this.tb_HopDongBindingSource.DataSource = this.qlxDataSet;
            // 
            // qlxDataSet
            // 
            this.qlxDataSet.DataSetName = "qlxDataSet";
            this.qlxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_HopDongTableAdapter
            // 
            this.tb_HopDongTableAdapter.ClearBeforeFill = true;
            // 
            // tb_KhachHangTableAdapter
            // 
            this.tb_KhachHangTableAdapter.ClearBeforeFill = true;
            // 
            // qlxDataSet3
            // 
            this.qlxDataSet3.DataSetName = "qlxDataSet3";
            this.qlxDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "khachhang";
            reportDataSource1.Value = this.tb_KhachHangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "quanlyxe.BC_KhachHang.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1138, 652);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmBC_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 652);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBC_KhachHang";
            this.Text = "frmAbout";
            this.Load += new System.EventHandler(this.frmBC_KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_KhachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlxDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_HopDongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlxDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlxDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource tb_HopDongBindingSource;
        private qlxDataSet qlxDataSet;
        private qlxDataSetTableAdapters.tb_HopDongTableAdapter tb_HopDongTableAdapter;
        private System.Windows.Forms.BindingSource tb_KhachHangBindingSource;
        private qlxDataSet1 qlxDataSet1;
        private qlxDataSet1TableAdapters.tb_KhachHangTableAdapter tb_KhachHangTableAdapter;
        private qlxDataSet3 qlxDataSet3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;

    }
}