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
    public partial class frm_TK : Form
    {
        public frm_TK()
        {
            InitializeComponent();
        }

        private void txt_tim_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.strconn);
            con.Open();
            if (rb_MaSV.Checked == true)
            {
                SqlDataAdapter adap = new SqlDataAdapter("select * from tb_SinhVien where MaSinhVien like '%"+txt_tim.Text+"%'",con);
                DataSet ds = new DataSet();
                adap.Fill(ds, "tb_SinhVien");
                dtgv_dssv.DataSource = ds.Tables["tb_SinhVien"].DefaultView;
                con.Close();
            }
            if (rb_tenSV.Checked == true)
            {
                SqlDataAdapter adap = new SqlDataAdapter("select * from tb_SinhVien where TenSinhVien like '%" + txt_tim.Text + "%'", con);
                DataSet ds = new DataSet();
                adap.Fill(ds, "tb_SinhVien");
                dtgv_dssv.DataSource = ds.Tables["tb_SinhVien"].DefaultView;
                con.Close();
            }
            if (rb_MaKhoa.Checked == true)
            {
                SqlDataAdapter adap = new SqlDataAdapter("select * from tb_SinhVien where MaKhoa like '%" + txt_tim.Text + "%'", con);
                DataSet ds = new DataSet();
                adap.Fill(ds, "tb_SinhVien");
                dtgv_dssv.DataSource = ds.Tables["tb_SinhVien"].DefaultView;
                con.Close();
            }
        }
    }
}
