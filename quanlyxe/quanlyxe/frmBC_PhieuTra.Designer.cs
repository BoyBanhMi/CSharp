namespace quanlyxe
{
    partial class frmBC_PhieuTra
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
            this.qlxDataSet4 = new quanlyxe.qlxDataSet4();
            this.tb_PhieuTraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_PhieuTraTableAdapter = new quanlyxe.qlxDataSet4TableAdapters.tb_PhieuTraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qlxDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_PhieuTraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "PhieuTra";
            reportDataSource1.Value = this.tb_PhieuTraBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "quanlyxe.rptPhieuTra.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1345, 419);
            this.reportViewer1.TabIndex = 0;
            // 
            // qlxDataSet4
            // 
            this.qlxDataSet4.DataSetName = "qlxDataSet4";
            this.qlxDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_PhieuTraBindingSource
            // 
            this.tb_PhieuTraBindingSource.DataMember = "tb_PhieuTra";
            this.tb_PhieuTraBindingSource.DataSource = this.qlxDataSet4;
            // 
            // tb_PhieuTraTableAdapter
            // 
            this.tb_PhieuTraTableAdapter.ClearBeforeFill = true;
            // 
            // frmBC_PhieuTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 419);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmBC_PhieuTra";
            this.Text = "frmBC_PhieuTra";
            this.Load += new System.EventHandler(this.frmBC_PhieuTra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qlxDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_PhieuTraBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tb_PhieuTraBindingSource;
        private qlxDataSet4 qlxDataSet4;
        private qlxDataSet4TableAdapters.tb_PhieuTraTableAdapter tb_PhieuTraTableAdapter;
    }
}