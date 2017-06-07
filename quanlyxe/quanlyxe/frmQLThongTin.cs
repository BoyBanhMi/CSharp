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
    public partial class frmQLThongTin : Form
    {
        public int quyentruycap;
        public frmQLThongTin(int quyentruycap)
        {
            InitializeComponent();
            this.quyentruycap = quyentruycap;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
                    }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmdQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            if (quyentruycap == 1)
            {
                frmQuanLyNhanVien nv = new frmQuanLyNhanVien();
                nv.TopLevel = false;
                nv.Show();
                pnQuanLyThongTin.Controls.Clear();
                pnQuanLyThongTin.Controls.Add(nv);
            }
            else
            {
                MessageBox.Show("Bạn Không có quyền truy cập","Lỗi !!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("xác Nhận thông tin", "Lỗi !!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            this.Close();
        }

        private void cmdQuanLyHopDong_Click(object sender, EventArgs e)
        {
            if (quyentruycap == 1)
            {
                frmXoaHD xHD = new frmXoaHD();
                xHD.TopLevel = false;
                xHD.Show();
                pnQuanLyThongTin.Controls.Clear();
                pnQuanLyThongTin.Controls.Add(xHD);
            }
            else
            {
                MessageBox.Show("Bạn Không có quyền truy cập", "Lỗi !!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
        }

        private void cmdQuanLyKhachHang_Click(object sender, EventArgs e)
        {
            frmQuanLyKhachHang kh = new frmQuanLyKhachHang();
            kh.TopLevel = false;
            kh.Show();
            pnQuanLyThongTin.Controls.Clear();
            pnQuanLyThongTin.Controls.Add(kh);
        }

        private void cmdQuanLyXe_Click(object sender, EventArgs e)
        {
            frmQuanLyXe x = new frmQuanLyXe();
            x.TopLevel = false;
            x.Show();
            pnQuanLyThongTin.Controls.Clear();
            pnQuanLyThongTin.Controls.Add(x);
        }

        private void cmdQuanLyLaiXe_Click(object sender, EventArgs e)
        {
            frmQuanLyLaiXe lx = new frmQuanLyLaiXe();
            lx.TopLevel = false;
            lx.Show();
            pnQuanLyThongTin.Controls.Clear();
            pnQuanLyThongTin.Controls.Add(lx);
        }

        private void pnQuanLyThongTin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
