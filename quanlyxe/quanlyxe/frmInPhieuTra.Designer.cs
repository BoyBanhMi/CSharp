namespace quanlyxe
{
    partial class frmInPhieuTra
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.qlxDataSet4 = new quanlyxe.qlxDataSet4();
            this.tb_PhieuTraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_PhieuTraTableAdapter = new quanlyxe.qlxDataSet4TableAdapters.tb_PhieuTraTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.qlxDataSet5 = new quanlyxe.qlxDataSet5();
            this.inchiphieuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inchiphieuTableAdapter = new quanlyxe.qlxDataSet5TableAdapters.inchiphieuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qlxDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_PhieuTraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlxDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inchiphieuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "InPhieuTraTheoHD";
            reportDataSource2.Value = this.inchiphieuBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "quanlyxe.rptPhieuTraTheoHD.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(5, 84);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1348, 187);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(122, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập Mã Hợp Đồng";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(261, 13);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(172, 20);
            this.txtMa.TabIndex = 2;
            this.txtMa.TextChanged += new System.EventHandler(this.txtMa_TextChanged);
            // 
            // qlxDataSet5
            // 
            this.qlxDataSet5.DataSetName = "qlxDataSet5";
            this.qlxDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inchiphieuBindingSource
            // 
            this.inchiphieuBindingSource.DataMember = "inchiphieu";
            this.inchiphieuBindingSource.DataSource = this.qlxDataSet5;
            // 
            // inchiphieuTableAdapter
            // 
            this.inchiphieuTableAdapter.ClearBeforeFill = true;
            // 
            // frmInPhieuTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 283);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmInPhieuTra";
            this.Text = "Thông tin thanh toán";
            this.Load += new System.EventHandler(this.frmInPhieuTra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qlxDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_PhieuTraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlxDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inchiphieuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tb_PhieuTraBindingSource;
        private qlxDataSet4 qlxDataSet4;
        private qlxDataSet4TableAdapters.tb_PhieuTraTableAdapter tb_PhieuTraTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.BindingSource inchiphieuBindingSource;
        private qlxDataSet5 qlxDataSet5;
        private qlxDataSet5TableAdapters.inchiphieuTableAdapter inchiphieuTableAdapter;
    }
}