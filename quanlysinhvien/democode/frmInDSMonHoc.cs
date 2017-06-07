using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace democode
{
    public partial class frmInDSMonHoc : Form
    {
        public frmInDSMonHoc()
        {
            InitializeComponent();
        }

        private void frmInDSMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'demoDataSet.tb_MonHoc' table. You can move, or remove it, as needed.
            this.tb_MonHocTableAdapter.Fill(this.demoDataSet.tb_MonHoc);

            this.reportViewer1.RefreshReport();
        }
    }
}
