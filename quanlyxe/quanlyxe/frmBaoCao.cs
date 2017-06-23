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
    public partial class frmBaoCao : Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }

        private void btn_HD_Click(object sender, EventArgs e)
        {
            frmBC_HopDong f = new frmBC_HopDong();
            f.TopLevel = false;
            f.Show();
            pn_baocao.Controls.Clear();
            pn_baocao.Controls.Add(f);
        }

        private void btn_KH_Click(object sender, EventArgs e)
        {
            frmBC_KH f = new frmBC_KH();
            f.TopLevel = false;
            f.Show();
            pn_baocao.Controls.Clear();
            pn_baocao.Controls.Add(f);
        }

        private void btn_LX_Click(object sender, EventArgs e)
        {
            frmBC_LaiXe f = new frmBC_LaiXe();
            f.TopLevel = false;
            f.Show();
            pn_baocao.Controls.Clear();
            pn_baocao.Controls.Add(f);
        }

        private void btn_NV_Click(object sender, EventArgs e)
        {
            frmBC_NhanVien f = new frmBC_NhanVien();
            f.TopLevel = false;
            f.Show();
            pn_baocao.Controls.Clear();
            pn_baocao.Controls.Add(f);
        }

        private void btn_Xe_Click(object sender, EventArgs e)
        {
            frmBC_Xe f = new frmBC_Xe();
            f.TopLevel = false;
            f.Show();
            pn_baocao.Controls.Clear();
            pn_baocao.Controls.Add(f);
        }
    }
}
