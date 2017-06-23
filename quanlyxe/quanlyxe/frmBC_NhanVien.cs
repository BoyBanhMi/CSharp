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
    public partial class frmBC_NhanVien : Form
    {
        public frmBC_NhanVien()
        {
            InitializeComponent();
        }

        private void frmBC_NhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'NhanVien_RPT.tb_NhanVien' table. You can move, or remove it, as needed.
            this.tb_NhanVienTableAdapter.Fill(this.NhanVien_RPT.tb_NhanVien);
            this.reportViewer1.RefreshReport();
        }
    }
}
