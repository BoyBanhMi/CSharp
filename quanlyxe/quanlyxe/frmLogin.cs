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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }
       
        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                      SqlConnection con = new SqlConnection(Program.strconn);
                    con.Open();
                    string sqlcn = "Select role from tb_Login Where userid='" + txtuser.Text + "' And pass='" + txtpass.Text + "'";
                    SqlCommand command = new SqlCommand(sqlcn, con);
                    SqlDataReader dr = command.ExecuteReader();
                    string quyen = "";
                    if (dr.Read())
                    {
                        quyen = dr[0].ToString();
                        if (quyen == "admin")
                        {
                            lbl_TB.Text = "Xin chào " + txtuser.Text + "đã đăng nhập thành công";
                            frmProgramMain pm = new frmProgramMain(1);
                            pm.Show();
                            this.Hide();
                        }
                        if (quyen == "nhanvien")
                        {
                            lbl_TB.Text = "Xin chào " + txtuser.Text + "đã đăng nhập thành công";
                            frmProgramMain pm1 = new frmProgramMain(2);
                            pm1.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        lbl_TB.Text = "Đăng nhập thất bại, Vui lòng kiểm tra lại tài khoản !";
                    }
                }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }
        
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
