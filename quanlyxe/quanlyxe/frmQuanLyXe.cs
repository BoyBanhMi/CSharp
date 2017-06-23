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
    public partial class frmQuanLyXe : Form
    {
        //string strconnect = @"Data Source=BOYBNHMI;Initial Catalog=qlx;Integrated Security=True";
       // SqlConnection con;
        public frmQuanLyXe()
        {
            InitializeComponent();
        }
        public void Load_maxe()
        {
            SqlConnection con = new SqlConnection(Program.strconn);
            con.Open();
            SqlDataAdapter da1 = new SqlDataAdapter("select MaXe from tb_Xe", con);
            DataTable dt1 = new DataTable();
            dt1.Clear();
            da1.Fill(dt1);
            txtMaXe.DataSource = dt1;
            txtMaXe.DisplayMember = "MaXe";
            txtMaXe.ValueMember = "MaXe";
            con.Close();
            da1.Dispose();
        }
        private void frmQuanLyXe_Load(object sender, EventArgs e)
        {
            Load_maxe();
            dgvQuanLyXe.DataSource = DS_Xe();
        }

        private void cmdTHem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Program.strconn);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into tb_Xe (MaXe, TenXe, NgaySanXuat, HangXe, BienKiemSoat, SucChua, LoaiXe, NgayMuaXe, TinhTrangXe) values ('" + txtMaXe.Text + "', '" + txtTenXe.Text + "', '" + dtpNgaySanXuat.Text + "', '" + txtHangXe.Text + "', '" + txtBienKiemSoat.Text + "', '" + txtSucChua.Text + "', '" + txtLoaiXe.Text + "', '" + dtpNgayMuaXe.Text + "',  '" + txtTinhTrangXe.Text + "')", con);
                cmd.ExecuteNonQuery();
                dgvQuanLyXe.DataSource = DS_Xe();
                MessageBox.Show("Thêm thành công", "Quản lý Xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Thêm thất bại, Lỗi CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.strconn);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select MaXe as [Mã xe], TenXe as [Tên Xe], NgaySanXuat as [Ngày sản xuất], HangXe as [Hãng xe], BienKiemSoat as [ Biển kiểm soát], SucChua as [SucChua], LoaiXe as [Loại xe], NgayMuaXe as [Ngày Mua Xe], TinhTrangXe as [Tình trạng xe] from tb_Xe ", con);
            SqlCommand cmd = new SqlCommand("insert into tb_Xe (MaXe, TenXe, NgaySanXuat, HangXe, BienKiemSoat, SucChua, LoaiXe, NgayMuaXe, TinhTrangXe) values ('" + txtMaXe.Text + "', '" + txtTenXe.Text + "', '" + dtpNgaySanXuat.Text + "', '" + txtHangXe.Text + "', '" + txtBienKiemSoat.Text + "', '" + txtSucChua.Text + "', '" + txtLoaiXe.Text + "', '" + dtpNgayMuaXe.Text + "', '" + txtTinhTrangXe.Text + "')", con);
            DataSet dt = new DataSet();
            da.Fill(dt, "tb_Xe");
            dgvQuanLyXe.DataSource = dt.Tables["tb_Xe"].DefaultView;
            da.Dispose();
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Program.strconn);
                con.Open();
                SqlCommand cmd = new SqlCommand("update  tb_Xe set TenXe = '" + txtTenXe.Text + "', NgaySanXuat = '" + dtpNgaySanXuat.Text + "', HangXe = '" + txtHangXe.Text + "', BienKiemSoat = '" + txtBienKiemSoat.Text + "', SucChua = '" + txtSucChua.Text + "', LoaiXe = '" + txtLoaiXe.Text + "', NgayMuaXe = '" + dtpNgayMuaXe.Text + "', TinhTrangXe = '" + txtTinhTrangXe.Text + "' Where  MaXe = '" + txtMaXe.Text + "' ", con);
                cmd.ExecuteNonQuery();
                dgvQuanLyXe.DataSource = DS_Xe();
                MessageBox.Show("Sửa thành công", "Quản lý  Xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Sửa thất bại, Lỗi CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdTimKiem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.strconn);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select MaXe as [Mã xe], TenXe as [Tên Xe], NgaySanXuat as [Ngày sản xuất], HangXe as [Hãng xe], BienKiemSoat as [ Biển kiểm soát], SucChua as [SucChua], LoaiXe as [Loại xe], NgayMuaXe as [Ngày Mua Xe] , TinhTrangXe as [Tình trạng xe] from tb_Xe Where MaXe = ('" + txtMaXe.Text + "') ", con);
            dgvQuanLyXe.DataSource = DS_Xe();
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.strconn);
            con.Open();
 
            SqlCommand cmd2 = new SqlCommand("delete from tb_Xe where MaXe = '" + txtMaXe.Text + "'", con);
            cmd2.ExecuteNonQuery();
            con.Close();

            dgvQuanLyXe.DataSource = DS_Xe();
            MessageBox.Show("Xóa xe thành công", "Quản lý xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public DataTable DS_Xe()
        {
            SqlConnection con = new SqlConnection(Program.strconn);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select MaXe as [Mã xe], TenXe as [Tên Xe], NgaySanXuat as [Ngày sản xuất], HangXe as [Hãng xe], BienKiemSoat as [ Biển kiểm soát], SucChua as [SucChua], LoaiXe as [Loại xe], NgayMuaXe as [Ngày Mua Xe] , TinhTrangXe as [Tình trạng xe] from tb_Xe Where MaXe = ('" + txtMaXe.Text + "') ", con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
           
            con.Close();
            da.Dispose();
            return dt;
        }
    }
}
