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
    public partial class frmBC_KhachHang : Form
    {
        public frmBC_KhachHang()
        {
            InitializeComponent();
        }

        private void frmBC_KhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlxDataSet1.tb_KhachHang' table. You can move, or remove it, as needed.
            this.tb_KhachHangTableAdapter.Fill(this.qlxDataSet1.tb_KhachHang);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
