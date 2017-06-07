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
    public partial class frmThanhToanHD : Form
    {
        public frmThanhToanHD()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdTraTien_Click(object sender, EventArgs e)
        {
            frmTraTien tt = new frmTraTien();
            tt.TopLevel = false;
            tt.Show();
            pnThanhToan.Controls.Clear();
            pnThanhToan.Controls.Add(tt);
        }
    }
}
