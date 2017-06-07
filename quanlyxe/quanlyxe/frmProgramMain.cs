using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace quanlyxe
{
    public partial class frmProgramMain : Form
    {
        public int quyentruycap;
        public frmProgramMain(int quyentruycap)
        {
            InitializeComponent();
            this.quyentruycap = quyentruycap;
        }

        private void frmProgramMain_Load(object sender, EventArgs e)
        {

        }

        private void btnQLTT_Click(object sender, EventArgs e)
        {
            if (quyentruycap == 1 || quyentruycap == 2)
            {

                frmQLThongTin qltt = new frmQLThongTin(quyentruycap);
                qltt.TopLevel = false;
                qltt.Show();
                pnProMain.Controls.Clear();
                pnProMain.Controls.Add(qltt);
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy suất vào đây !!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn chác chán muốn thoát !!!", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            this.Close();
        }

        private void btnLapHD_Click(object sender, EventArgs e)
        {
            if (quyentruycap == 2 || quyentruycap == 1)
            {
                frmhopdong HD = new frmhopdong();
                HD.TopLevel = false;
                HD.Show();
                pnProMain.Controls.Clear();
                pnProMain.Controls.Add(HD);

            }
            else
            {
                MessageBox.Show( "Bạn không có quyền truy suất vào đây !!");
            }
        }

        private void btnThanhToanHD_Click(object sender, EventArgs e)
        {
            if (quyentruycap == 2 || quyentruycap == 1)
            {
                frmThanhToanHD tt = new frmThanhToanHD();
                tt.TopLevel = false;
                tt.Show();
                pnProMain.Controls.Clear();
                pnProMain.Controls.Add(tt);
            }
            else
            {
                MessageBox.Show( "Bạn không có quyền truy cập !!!");

            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (quyentruycap == 1 || quyentruycap == 2 || quyentruycap == 3)
            {
                frmTimKiem tk = new frmTimKiem();
                tk.TopLevel = false;
                tk.Show();
                pnProMain.Controls.Clear();
                pnProMain.Controls.Add(tk);
            }
        }

        private void btnABout_Click(object sender, EventArgs e)
        {
            if (quyentruycap == 1 || quyentruycap == 2)
            {
                frmAbout ab = new frmAbout();
                ab.TopLevel = false;
                ab.Show();
                pnProMain.Controls.Clear();
                pnProMain.Controls.Add(ab);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (quyentruycap == 1)
            {
                frmDangKy lg = new frmDangKy();
                lg.TopLevel = false;
                lg.Show();
                pnProMain.Controls.Clear();
                pnProMain.Controls.Add(lg);
            }
            else
            {
                MessageBox.Show("Bạn Không Có quyền truy cập","Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
         }
        }
    }

