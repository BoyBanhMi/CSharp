using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlyxe
{
    public partial class frmInPhieuTra : Form
    {
        public frmInPhieuTra()
        {
            InitializeComponent();
        }

        private void frmInPhieuTra_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlxDataSet5.inchiphieu' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'qlxDataSet4.tb_PhieuTra' table. You can move, or remove it, as needed.
            //this.tb_PhieuTraTableAdapter.Fill(this.qlxDataSet4.tb_PhieuTra);

            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {
            this.inchiphieuTableAdapter.Fill(this.qlxDataSet5.inchiphieu, txtMa.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
