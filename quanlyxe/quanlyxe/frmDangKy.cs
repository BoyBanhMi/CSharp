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
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            cbb_role.DataSource = DS_role();
            cbb_role.DisplayMember = "TenCV";
            //cbb_role.SelectedValue = "TenCV";

            dataGridViewdk.DataSource = DS_TK();
            dataGridViewdk.Columns[0].HeaderText = "Tên Tài Khoản";
            dataGridViewdk.Columns[1].HeaderText = "Mật Khẩu";
            dataGridViewdk.Columns[2].HeaderText = "Chức Vụ";
            dataGridViewdk.Columns[0].Width = 200;
            dataGridViewdk.Columns[1].Width = 200;
            dataGridViewdk.Columns[2].Width = 170;

        }
        void themTK(string user, string pass, string role)
        {
            try
            {


                SqlConnection connDB = new SqlConnection(Program.strconn);
                connDB.Open();
                string cmd = "INSERT INTO tb_Login VALUES(N'" + user + "',N'" + pass + "', N'" + role + "')";
                SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
                sqlCmd.ExecuteNonQuery();
                connDB.Close();
                MessageBox.Show("Thêm tài khoản thành công", "ĐAng Ký Tài Khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Không thên được","Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        void suaTK(string user, string pass)
        {
            try
            {
                SqlConnection connDB = new SqlConnection(Program.strconn);
                connDB.Open();
                string cmd = "UPDATE tb_Login SET pass='" + pass + "' WHERE userid='" + user + "'";
                SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
                sqlCmd.ExecuteNonQuery();
                connDB.Close();
                MessageBox.Show("sửa tài khoản thành công", "sửa Tài Khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Không sửa được", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        void xoaTK(string user)
        {
            try
            {
                SqlConnection connDB = new SqlConnection(Program.strconn);
                connDB.Open();
                string cmd = "DELETE FROM tb_Login WHERE userid='" + user + "'";
                SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
                sqlCmd.ExecuteNonQuery();
                connDB.Close();
                MessageBox.Show("xóa tài khoản thành công", "xóa Tài Khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Không xoá được", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        DataTable DS_role()
        {
            string cmd = "SELECT * FROM tb_role";
            SqlDataAdapter adap = new SqlDataAdapter(cmd, Program.strconn);
            DataTable ds = new DataTable();
            adap.Fill(ds);
            return ds;
        }
        DataTable DS_TK()
        {
            string cmd = "SELECT * FROM tb_Login";
            SqlDataAdapter adap = new SqlDataAdapter(cmd, Program.strconn);
            DataTable ds = new DataTable();
            adap.Fill(ds);
            return ds;
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            suaTK(txt_userid.Text, txt_pass.Text);
            dataGridViewdk.DataSource = DS_TK();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            themTK(txt_userid.Text, txt_pass.Text, cbb_role.Text);
            dataGridViewdk.DataSource = DS_TK();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            xoaTK(txt_userid.Text);
            dataGridViewdk.DataSource = DS_TK();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn chắc chắn muốn thoát", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            this.Close();
        }
    }
}
