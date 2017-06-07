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

namespace democode
{
    public partial class frmloggin : Form
    {
        string strconnect = @"Data Source=BoyBnhMi;Initial Catalog=demo;Integrated Security=True";
        SqlConnection conn;
        public frmloggin()
        {
            InitializeComponent();
        }

        private void frmloggin_Load(object sender, EventArgs e)
        {

        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(strconnect);
                conn.Open();
                SqlCommand dn = new SqlCommand("select count(*) from tb_login where userid='" + txt_TK.Text + "' and pass='" + txt_MK.Text + "'", conn);
                int x =(int) dn.ExecuteScalar();
                if (x == 1)
                {
                    //MessageBox.Show("Đăng Nhập Thành Công !!!");
                    lbl_TB.Text = "Đăng Nhập Thành Công !!!";
                    frmmain k = new frmmain();
                    k.Show();
                    this.Hide();
                }
                else
                {
                    //MessageBox.Show("Đăng Nhập Thất Bại !!!");
                    lbl_TB.Text = "Đăng Nhập Thất Bại !!!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
