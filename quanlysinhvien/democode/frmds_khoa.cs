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
    public partial class frmds_khoa : Form
    {
        public frmds_khoa()
        {
            InitializeComponent();
        }

        private void frmds_khoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'demoDataSet2.tb_Khoa' table. You can move, or remove it, as needed.
            this.tb_KhoaTableAdapter.Fill(this.demoDataSet2.tb_Khoa);

            this.reportViewer1.RefreshReport();
        }
    }
}
