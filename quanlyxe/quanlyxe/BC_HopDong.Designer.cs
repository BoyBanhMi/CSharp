namespace quanlyxe
{
    partial class BC_HopDong
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
            this.demo = new quanlyxe.demo();
            this.tb_HopDongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_HopDongTableAdapter = new quanlyxe.demoTableAdapters.tb_HopDongTableAdapter();
            this.baocaohopdongnew = new quanlyxe.baocaohopdongnew();
            ((System.ComponentModel.ISupportInitialize)(this.demo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_HopDongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baocaohopdongnew)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "baocaohopdong";
            reportDataSource1.Value = this.tb_HopDongBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "quanlyxe.rptBaoCaoHopDong.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1259, 395);
            this.reportViewer1.TabIndex = 0;
            // 
            // demo
            // 
            this.demo.DataSetName = "demo";
            this.demo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_HopDongBindingSource
            // 
            this.tb_HopDongBindingSource.DataMember = "tb_HopDong";
            this.tb_HopDongBindingSource.DataSource = this.demo;
            // 
            // tb_HopDongTableAdapter
            // 
            this.tb_HopDongTableAdapter.ClearBeforeFill = true;
            // 
            // baocaohopdongnew
            // 
            this.baocaohopdongnew.DataSetName = "baocaohopdongnew";
            this.baocaohopdongnew.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BC_HopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 395);
            this.Controls.Add(this.reportViewer1);
            this.Name = "BC_HopDong";
            this.Text = "BC_HopDong";
            this.Load += new System.EventHandler(this.BC_HopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.demo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_HopDongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baocaohopdongnew)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tb_HopDongBindingSource;
        private demo demo;
        private demoTableAdapters.tb_HopDongTableAdapter tb_HopDongTableAdapter;
        private baocaohopdongnew baocaohopdongnew;
    }
}