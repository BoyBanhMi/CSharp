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
    public partial class frmmonhoc : Form
    {
        public frmmonhoc()
        {
            InitializeComponent();
        }
        void themMH(string maMH, string tenMH, string sodvht)
        {
            SqlConnection con = new SqlConnection(Program.strconn);
            con.Open();
            string cmd = "insert into tb_MonHoc values('" + maMH + "',N'" + tenMH + "','"+sodvht+"')";
            SqlCommand sqlcmd = new SqlCommand(cmd, con);
            sqlcmd.ExecuteNonQuery();
            con.Close();
        }
        void suaMH(string maMH, string tenMH, string sodvht)
        {
            SqlConnection con = new SqlConnection(Program.strconn);
            con.Open();
            string cmd = "update tb_MonHoc set MaMonHoc='" + maMH + "', TenMonHoc='" + tenMH + "', SoDVHT='" + sodvht + "'";
            SqlCommand sqlcmd = new SqlCommand(cmd, con);
            sqlcmd.ExecuteNonQuery();
            con.Close();
        }
        void xoa(string maMH)
        {
            SqlConnection con = new SqlConnection(Program.strconn);
            con.Open();
            SqlCommand sql = new SqlCommand("delete from tb_MonHoc where MaMonHoc='"+maMH+"'");
            sql.ExecuteNonQuery();
            con.Close();
        }
        DataTable DS_MonHoc()
        {
            SqlDataAdapter adap = new SqlDataAdapter("select * from tb_MonHoc",Program.strconn);
            DataTable ds = new DataTable();
            adap.Fill(ds);
            return ds;
        }
        private void frmmonhoc_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DS_MonHoc();

            dataGridView1.Columns[0].HeaderText = "Mã Môn Học";
            dataGridView1.Columns[1].HeaderText = "Tên Môn Học";
            dataGridView1.Columns[2].HeaderText = "Số Đơn Vị Học trình";
            

        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            themMH(txt_MaMH.Text, txt_TenMH.Text,txt_dvht.Text);
            dataGridView1.DataSource = DS_MonHoc();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            suaMH(txt_MaMH.Text, txt_TenMH.Text, txt_dvht.Text);
            dataGridView1.DataSource = DS_MonHoc();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            xoa(txt_MaMH.Text);
            dataGridView1.DataSource = DS_MonHoc();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn muốn thoát","Thoát", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            this.Close();
        }
    }
}
