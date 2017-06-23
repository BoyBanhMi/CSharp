namespace quanlyxe
{
    partial class frmBC_Xe
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
            this.tb_XeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Xe_rpt = new quanlyxe.Xe_rpt();
            this.tb_LaiXeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qlxDataSet2 = new quanlyxe.qlxDataSet2();
            this.tb_KhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qlxDataSet1 = new quanlyxe.qlxDataSet1();
            this.tb_HopDongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qlxDataSet = new quanlyxe.qlxDataSet();
            this.tb_HopDongTableAdapter = new quanlyxe.qlxDataSetTableAdapters.tb_HopDongTableAdapter();
            this.tb_KhachHangTableAdapter = new quanlyxe.qlxDataSet1TableAdapters.tb_KhachHangTableAdapter();
            this.tb_LaiXeTableAdapter = new quanlyxe.qlxDataSet2TableAdapters.tb_LaiXeTableAdapter();
            this.tb_XeTableAdapter = new quanlyxe.Xe_rptTableAdapters.tb_XeTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.tb_XeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xe_rpt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_LaiXeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlxDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_KhachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlxDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_HopDongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlxDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_XeBindingSource
            // 
            this.tb_XeBindingSource.DataMember = "tb_Xe";
            this.tb_XeBindingSource.DataSource = this.Xe_rpt;
            // 
            // Xe_rpt
            // 
            this.Xe_rpt.DataSetName = "Xe_rpt";
            this.Xe_rpt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_LaiXeBindingSource
            // 
            this.tb_LaiXeBindingSource.DataMember = "tb_Xe";
            this.tb_LaiXeBindingSource.DataSource = this.qlxDataSet2;
            // 
            // qlxDataSet2
            // 
            this.qlxDataSet2.DataSetName = "qlxDataSet2";
            this.qlxDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tb_LaiXeTableAdapter
            // 
            this.tb_LaiXeTableAdapter.ClearBeforeFill = true;
            // 
            // tb_XeTableAdapter
            // 
            this.tb_XeTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Xe";
            reportDataSource1.Value = this.tb_XeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "quanlyxe.rptXe.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1138, 652);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmBC_Xe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 652);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBC_Xe";
            this.Text = "frmAbout";
            this.Load += new System.EventHandler(this.frmBC_Xe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_XeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xe_rpt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_LaiXeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xe_rpt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_KhachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xe_rpt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_HopDongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xe_rpt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource tb_HopDongBindingSource;
        private qlxDataSet qlxDataSet;
        private qlxDataSetTableAdapters.tb_HopDongTableAdapter tb_HopDongTableAdapter;
        private System.Windows.Forms.BindingSource tb_KhachHangBindingSource;
        private qlxDataSet1 qlxDataSet1;
        private qlxDataSet1TableAdapters.tb_KhachHangTableAdapter tb_KhachHangTableAdapter;
        private System.Windows.Forms.BindingSource tb_LaiXeBindingSource;
        private qlxDataSet2 qlxDataSet2;
        private qlxDataSet2TableAdapters.tb_LaiXeTableAdapter tb_LaiXeTableAdapter;
        private System.Windows.Forms.BindingSource tb_XeBindingSource;
        private Xe_rpt Xe_rpt;
        private Xe_rptTableAdapters.tb_XeTableAdapter tb_XeTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;

    }
}