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
    public partial class frmBC_PhieuTra : Form
    {
        public frmBC_PhieuTra()
        {
            InitializeComponent();
        }

        private void frmBC_PhieuTra_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlxDataSet4.tb_PhieuTra' table. You can move, or remove it, as needed.
            this.tb_PhieuTraTableAdapter.Fill(this.qlxDataSet4.tb_PhieuTra);

            this.reportViewer1.RefreshReport();
        }
    }
}
