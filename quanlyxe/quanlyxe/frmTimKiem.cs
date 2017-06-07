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
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }

        private void cmdTimKiemXePN_Click(object sender, EventArgs e)
        {
            frmtimxe tx = new frmtimxe();
            tx.TopLevel = false;
            tx.Show();
            pnTimKiem.Controls.Clear();
            pnTimKiem.Controls.Add(tx);
        }

        private void cmdTimKiemKhachHangPN_Click(object sender, EventArgs e)
        {
            frmtimKH kh = new frmtimKH();
            kh.TopLevel = false;
            kh.Show();
            pnTimKiem.Controls.Clear();
            pnTimKiem.Controls.Add(kh);
        }

        private void cmdTimKiemLaiXePN_Click(object sender, EventArgs e)
        {
            frmtimlaixe lx = new frmtimlaixe();
            lx.TopLevel = false;
            lx.Show();
            pnTimKiem.Controls.Clear();
            pnTimKiem.Controls.Add(lx);
        }

        private void cmdTimKiemNhanVienPN_Click(object sender, EventArgs e)
        {
            frmtimnhanvien nv = new frmtimnhanvien();
            nv.TopLevel = false;
            nv.Show();
            pnTimKiem.Controls.Clear();
            pnTimKiem.Controls.Add(nv);
        }

        private void cmdTimKiemHopDongPN_Click(object sender, EventArgs e)
        {
            frmtimhopdong hd = new frmtimhopdong();
            hd.TopLevel = false;
            hd.Show();
            pnTimKiem.Controls.Clear();
            pnTimKiem.Controls.Add(hd);
        }
    }
}
