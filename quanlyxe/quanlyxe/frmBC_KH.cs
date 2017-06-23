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
    public partial class frmBC_KH : Form
    {
        public frmBC_KH()
        {
            InitializeComponent();
        }

        private void frmBC_KH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlxDataSet3.tb_KhachHang' table. You can move, or remove it, as needed.
            this.tb_KhachHangTableAdapter.Fill(this.qlxDataSet3.tb_KhachHang);
            this.reportViewer1.RefreshReport();
        }
    }
}
