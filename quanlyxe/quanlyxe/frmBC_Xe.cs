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
    public partial class frmBC_Xe : Form
    {
        public frmBC_Xe()
        {
            InitializeComponent();
        }

        private void frmBC_Xe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Xe_rpt.tb_Xe' table. You can move, or remove it, as needed.
            this.tb_XeTableAdapter.Fill(this.Xe_rpt.tb_Xe);
            
            this.reportViewer1.RefreshReport();
        }
    }
}
