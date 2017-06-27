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
    public partial class BC_HopDong : Form
    {
        public BC_HopDong()
        {
            InitializeComponent();
        }

        private void BC_HopDong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'demo.tb_HopDong' table. You can move, or remove it, as needed.
            this.tb_HopDongTableAdapter.Fill(this.demo.tb_HopDong);

            this.reportViewer1.RefreshReport();
        }
    }
}
