using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using congtrunhanchia;

namespace CongTruNhanChia2Lop
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void btn_thuchien_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt_a.Text);
            int b = Convert.ToInt32(txt_b.Text);

            if (rad_cong.Checked == true)
            {
                int kq = congtrunhanchia.Math.cong(a,b);
                lbl_KQ.Text = kq.ToString();
            }
            if (rad_tru.Checked == true)
            {
                int kq = congtrunhanchia.Math.tru(a, b);
                lbl_KQ.Text = kq.ToString();
            }
            if (rad_nhan.Checked == true)
            {
                Double kq = congtrunhanchia.Math.nhan(a, b);
                lbl_KQ.Text = kq.ToString();
            }
            if (rad_chia.Checked == true)
            {
                Double kq = congtrunhanchia.Math.chia(a, b);
                lbl_KQ.Text = kq.ToString();
            }
        }

        private void congtrunhanchia_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
