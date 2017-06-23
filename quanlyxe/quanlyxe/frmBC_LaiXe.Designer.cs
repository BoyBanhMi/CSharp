namespace quanlyxe
{
    partial class frmBC_LaiXe{
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.qlxDataSet2 = new quanlyxe.qlxDataSet2();
            this.tb_LaiXeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_LaiXeTableAdapter = new quanlyxe.qlxDataSet2TableAdapters.tb_LaiXeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tb_KhachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlxDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_HopDongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlxDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlxDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_LaiXeBindingSource)).BeginInit();
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
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "BC_laixe";
            reportDataSource1.Value = this.tb_LaiXeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "quanlyxe.rptBC_LaiXe.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1138, 652);
            this.reportViewer1.TabIndex = 0;
            // 
            // qlxDataSet2
            // 
            this.qlxDataSet2.DataSetName = "qlxDataSet2";
            this.qlxDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_LaiXeBindingSource
            // 
            this.tb_LaiXeBindingSource.DataMember = "tb_LaiXe";
            this.tb_LaiXeBindingSource.DataSource = this.qlxDataSet2;
            // 
            // tb_LaiXeTableAdapter
            // 
            this.tb_LaiXeTableAdapter.ClearBeforeFill = true;
            // 
            // frmBC_LaiXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 652);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBC_LaiXe";
            this.Text = "frmAbout";
            this.Load += new System.EventHandler(this.frmBC_LaiXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_KhachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlxDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_HopDongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlxDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlxDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_LaiXeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource tb_HopDongBindingSource;
        private qlxDataSet qlxDataSet;
        private qlxDataSetTableAdapters.tb_HopDongTableAdapter tb_HopDongTableAdapter;
        private System.Windows.Forms.BindingSource tb_KhachHangBindingSource;
        private qlxDataSet1 qlxDataSet1;
        private qlxDataSet1TableAdapters.tb_KhachHangTableAdapter tb_KhachHangTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tb_LaiXeBindingSource;
        private qlxDataSet2 qlxDataSet2;
        private qlxDataSet2TableAdapters.tb_LaiXeTableAdapter tb_LaiXeTableAdapter;

    }
}