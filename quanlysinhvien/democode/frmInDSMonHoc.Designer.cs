namespace democode
{
    partial class frmInDSMonHoc
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.demoDataSet = new democode.demoDataSet();
            this.tb_MonHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_MonHocTableAdapter = new democode.demoDataSetTableAdapters.tb_MonHocTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_MonHocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "rptMonHoc";
            reportDataSource1.Value = this.tb_MonHocBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "democode.rpt_monhoc.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(634, 204);
            this.reportViewer1.TabIndex = 0;
            // 
            // demoDataSet
            // 
            this.demoDataSet.DataSetName = "demoDataSet";
            this.demoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_MonHocBindingSource
            // 
            this.tb_MonHocBindingSource.DataMember = "tb_MonHoc";
            this.tb_MonHocBindingSource.DataSource = this.demoDataSet;
            // 
            // tb_MonHocTableAdapter
            // 
            this.tb_MonHocTableAdapter.ClearBeforeFill = true;
            // 
            // frmInDSMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 204);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmInDSMonHoc";
            this.Text = "Danh Sách Môn Học";
            this.Load += new System.EventHandler(this.frmInDSMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_MonHocBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tb_MonHocBindingSource;
        private demoDataSet demoDataSet;
        private demoDataSetTableAdapters.tb_MonHocTableAdapter tb_MonHocTableAdapter;
    }
}