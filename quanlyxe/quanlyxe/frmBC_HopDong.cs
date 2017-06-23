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
    public partial class frmBC_HopDong : Form
    {
        public frmBC_HopDong()
        {
            InitializeComponent();
        }

        private void frmBC_HopDong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlxDataSet.tb_HopDong' table. You can move, or remove it, as needed.
            this.tb_HopDongTableAdapter.Fill(this.qlxDataSet.tb_HopDong);

            this.reportViewer1.RefreshReport();
        }
    }
}
