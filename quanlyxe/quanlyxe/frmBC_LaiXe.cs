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
    public partial class frmBC_LaiXe : Form
    {
        public frmBC_LaiXe()
        {
            InitializeComponent();
        }

        private void frmBC_LaiXe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlxDataSet2.tb_LaiXe' table. You can move, or remove it, as needed.
            this.tb_LaiXeTableAdapter.Fill(this.qlxDataSet2.tb_LaiXe);

            this.reportViewer1.RefreshReport();
        }
    }
}
