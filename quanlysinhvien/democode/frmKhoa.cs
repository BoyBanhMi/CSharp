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
    public partial class frmKhoa : Form
    {
        public frmKhoa()
        {
            InitializeComponent();
        }
        void themkhoa(string makhoa, string tenkhoa)
        {

            SqlConnection connDB = new SqlConnection(Program.strconn);
            connDB.Open();
            string cmd = "INSERT INTO tb_Khoa VALUES(N'" + makhoa + "',N'" + tenkhoa + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }
        void suaKhoa(string maKhoa, string tenKhoa)
        {
            SqlConnection connDB = new SqlConnection(Program.strconn);
            connDB.Open();
            string cmd = "UPDATE tb_Khoa SET TenKhoa='" + tenKhoa + "' WHERE MaKhoa='" + maKhoa + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }
        void xoaKhoa(string maKhoa)
        {
            SqlConnection connDB = new SqlConnection(Program.strconn);
            connDB.Open();
            string cmd = "DELETE FROM tb_Khoa WHERE MaKhoa='" + maKhoa + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }
        DataTable dskhoa()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tb_Khoa order by TenKhoa",Program.strconn);
            DataTable ds = new DataTable();
            da.Fill(ds);
            return ds;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            themkhoa(txtMK.Text, txtTenKhoa.Text);
            GridViewkhoa.DataSource = dskhoa();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            suaKhoa(txtMK.Text, txtTenKhoa.Text);
            GridViewkhoa.DataSource = dskhoa();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoaKhoa(txtMK.Text);
            GridViewkhoa.DataSource = dskhoa();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridViewkhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            GridViewkhoa.DataSource = dskhoa();
        }

    }
}
