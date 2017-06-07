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
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhoa k = new frmKhoa();
            k.Show();
            
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSinhVien sv = new frmSinhVien();
            sv.Show();
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmmain_Load(object sender, EventArgs e)
        {

        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmonhoc mh = new frmmonhoc();
            mh.Show();
        }

        private void theoTênSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiemSinhVien tk = new frmTimKiemSinhVien();
            tk.Show();
        }

        private void inDanhSáchMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInDSMonHoc f = new frmInDSMonHoc();
            f.Show();
        }

        private void inDanhSáchSinhViênTheoKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSSinhVienTheoKhoa ds = new frmDSSinhVienTheoKhoa();
            ds.Show();
        }


    }
}
