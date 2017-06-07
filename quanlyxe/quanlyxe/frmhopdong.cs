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
    public partial class frmhopdong : Form
    {
        //string strconnect = @"Data Source=BOYBNHMI;Initial Catalog=qlx;Integrated Security=True";
        //SqlConnection con;
        public static TextBox tb = new TextBox();
        public frmhopdong()
        {
            InitializeComponent();
        }
        private void Load_MaKH()
        {
            SqlConnection con = new SqlConnection(Program.strconn);
            con.Open();
            SqlDataAdapter da1 = new SqlDataAdapter("select MaKhachHang from tb_KhachHang ", con);
            DataTable dt1 = new DataTable();
            dt1.Clear();
            da1.Fill(dt1);
            txtMaKhachHang.DataSource = dt1;
            txtMaKhachHang.DisplayMember = "MaKhachHang";
            txtMaKhachHang.ValueMember = "MaKhachHang";
            con.Close();
            da1.Dispose();
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Program.strconn);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into tb_KhachHang (MaKhachHang, TenKhachHang, NgaySinh, GioiTinh, DiaChi, CMND, DienThoai) values ('" + txtMaKhachHang.Text + "', '" + txtTenKhachhang.Text + "', '" + dtpNgaySinh.Text + "', '" + txtGioiTinh.Text + "', '" + txtDiaChi.Text + "', '" + txtCMND.Text + "', '" + txtDienThoai.Text + "')", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("select MaKhachHang as [Mã khách hàng], TenKhachHang as [Tên khách hàng], NgaySinh as [Ngày sinh], GioiTinh as [Giới tính], DiaChi as [ Địa chỉ], DienThoai as [Điện thoại], CMND from tb_KhachHang ", con);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                dtgThemKhachHang.DataSource = dt;
                con.Close();
                da.Dispose();
                MessageBox.Show("Thêm thành công,Chuyển sang bước tiếp theo để tiếp tục việc thêm hợp đồng", "Quản lý khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            SqlDataAdapter da = new SqlDataAdapter("select MaKhachHang as [Mã khách hàng], TenKhachHang as [Tên khách hàng], NgaySinh as [Ngày sinh], GioiTinh as [Giới tính], DiaChi as [ Địa chỉ], DienThoai as [Điện thoại], CMND from tb_KhachHang where MaKhachHang = '" + txtMaKhachHang.Text + "'", con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dtgThemKhachHang.DataSource = dt;
            con.Close();
            da.Dispose();
        }

        private void txtNext_Click(object sender, EventArgs e)
        {
            tb.Text = txtMaKhachHang.Text;
            frmLapHopDong f = new frmLapHopDong();
            f.TopLevel = false;
            f.Show();
            pnThemHopDong.Controls.Clear();
            pnThemHopDong.Controls.Add(f);
        }

        private void frmhopdong_Load(object sender, EventArgs e)
        {
            Load_MaKH();
            SqlConnection con = new SqlConnection(Program.strconn);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select tb_KhachHang.MaKhachHang as [Mã khách hàng], TenKhachHang as [Tên khách hàng], NgaySinh as [Ngày sinh], GioiTinh as [Giới tính], DiaChi as [ Địa chỉ], DienThoai as [Điện thoại], CMND  from tb_KhachHang,tb_HopDong ", con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dtgThemKhachHang.DataSource = dt;
            con.Close();
            da.Dispose();
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Program.strconn);
                con.Open();
                SqlCommand cmd1 = new SqlCommand("update tb_KhachHang set TenKhachHang = '" + txtTenKhachhang.Text + "',NgaySinh = '" + dtpNgaySinh.Text + "', GioiTinh ='" + txtGioiTinh.Text + "', DiaChi = '" + txtDiaChi.Text + "', CMND = '" + txtCMND.Text + "', DienThoai = '" + txtDienThoai.Text + "' where MaKhachHang = '" + txtMaKhachHang.Text + "'", con);
                cmd1.ExecuteNonQuery();
                con.Close();
                SqlDataAdapter da = new SqlDataAdapter("select MaKhachHang as [Mã khách hàng], TenKhachHang as [Tên khách hàng], NgaySinh as [Ngày sinh], GioiTinh as [Giới tính], DiaChi as [ Địa chỉ], DienThoai as [Điện thoại], CMND from tb_KhachHang ", con);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                dtgThemKhachHang.DataSource = dt;
                con.Close();
                da.Dispose();
                MessageBox.Show("Sửa khách hàng thành công", "Quản lý khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Sửa khách hàng thất bại, Lỗi CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
