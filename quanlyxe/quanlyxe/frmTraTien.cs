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
    public partial class frmTraTien : Form 
    {
       
        public frmTraTien()
        {
            InitializeComponent();
        }
       
       
        public void Load_MaNV()
        {
            SqlConnection con = new SqlConnection(Program.strconn);
           
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from tb_NhanVien", con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            txtMaNhanVien.DataSource = dt;
            txtMaNhanVien.DisplayMember = "TenNhanVien";
            txtMaNhanVien.ValueMember = "MaNhanVien";
            con.Close();
            da.Dispose();
        }
        
        
        private void frmTraTien_Load(object sender, EventArgs e)
        {

            Load_MaNV();
        }

        private void cmdThanhToan_Click(object sender, EventArgs e)
        {
            if (rad_coTX.Checked == true)
            {

            }
            else
            {

            }
            SqlConnection con = new SqlConnection(Program.strconn);
            con.Open();

            SqlCommand cmd = new SqlCommand("update tb_HopDong set TinhTrangThanhToan='1' where MaHopDong = '"+txt_MaHD.Text+"'",con);
            cmd.ExecuteNonQuery();

           // SqlCommand cmd2 = new SqlCommand("insert into tb_ChiTietHopDong values('"++"','"++"','"++"','"++"','"++"','"++"','"++"','"++"','"++"')",con);
            //cmd.ExecuteNonQuery();
        }


        private void cbTinhTrangThanhToan_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTinhTrangThanhToan.Checked == true)
            {
                cmdThanhToan.Visible = true;
                cmdSua.Visible = true;
            }
            else
            {
                cmdThanhToan.Visible = false;
                cmdSua.Visible = false;
            }
        }

       
        private void cmdBaoCao_Click(object sender, EventArgs e)
        {
           // frmRe_ThanhToan f = new frmRe_ThanhToan();
          //  f.a = txtMaKH.Text;
           // f.Show();
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            try
            {
                
                MessageBox.Show("Sửa thành công", "Thanh toán tiền", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Sửa thất bại, Lỗi CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.strconn);
            con.Open();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from tb_HopDong", con);
            DataTable dt2 = new DataTable();
            dt2.Clear();
            da2.Fill(dt2);
            dtv_dsHD.DataSource = dt2;
            con.Close();
            da2.Dispose();


           
        }
        public DataTable DS_HopDong()
        {
            SqlConnection con = new SqlConnection(Program.strconn);
            con.Open();
            SqlDataAdapter adap = new SqlDataAdapter("select * from tb_HopDong",con);
            DataTable ds = new DataTable();
            adap.Fill(ds);
            return ds;
        }
        private void txt_TenKH_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.strconn);
            con.Open();
            SqlDataAdapter adap = new SqlDataAdapter("select * from tb_HopDong where MaKhachHang like '%" + txt_TenKH.Text + "%'", con);
            DataTable ds = new DataTable();
            ds.Clear();
            adap.Fill(ds);
            dtv_dsHD.DataSource = ds;
            con.Close();
        }
    }
}
