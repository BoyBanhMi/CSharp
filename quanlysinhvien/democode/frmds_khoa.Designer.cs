namespace democode
{
    partial class frmds_khoa
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
            this.demoDataSet2 = new democode.demoDataSet2();
            this.tb_KhoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_KhoaTableAdapter = new democode.demoDataSet2TableAdapters.tb_KhoaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_KhoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tb_KhoaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "democode.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(675, 307);
            this.reportViewer1.TabIndex = 0;
            // 
            // demoDataSet2
            // 
            this.demoDataSet2.DataSetName = "demoDataSet2";
            this.demoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_KhoaBindingSource
            // 
            this.tb_KhoaBindingSource.DataMember = "tb_Khoa";
            this.tb_KhoaBindingSource.DataSource = this.demoDataSet2;
            // 
            // tb_KhoaTableAdapter
            // 
            this.tb_KhoaTableAdapter.ClearBeforeFill = true;
            // 
            // frmds_khoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 307);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmds_khoa";
            this.Text = "frmds_khoa";
            this.Load += new System.EventHandler(this.frmds_khoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_KhoaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tb_KhoaBindingSource;
        private demoDataSet2 demoDataSet2;
        private demoDataSet2TableAdapters.tb_KhoaTableAdapter tb_KhoaTableAdapter;
    }
}