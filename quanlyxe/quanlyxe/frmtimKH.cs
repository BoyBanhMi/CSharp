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
    public partial class frmtimKH : Form
    {
        public frmtimKH()
        {
            InitializeComponent();
        }

        private void grbTimXe_Enter(object sender, EventArgs e)
        {

        }

        private void frmtimKH_Load(object sender, EventArgs e)
        {

        }

        private void btntimKH_Click(object sender, EventArgs e)
        {
            if (rbTimKiemMakh.Checked == true)
            {
                SqlConnection conn = new SqlConnection(Program.strconn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select MaKhachHang as [Mã Khách Hàng], TenKhachHang as [Tên Khách Hàng], NgaySinh as [Ngày Sinh], GioiTinh as [Giới Tính], DiaChi as [Địa Chỉ], CMND as [Số CMND], DienThoai as [Số Điện Thoại], Email as [Email] from tb_KhachHang where MaKhachHang like '%" + txtTimKiemKH.Text + "%'", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_KhachHang");
                dgvTimKiemKH.DataSource = ds.Tables["tb_KhachHang"].DefaultView;
            }
            if (rbTimKiemTheoTenkh.Checked == true)
            {
                SqlConnection conn = new SqlConnection(Program.strconn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select MaKhachHang as [Mã Khách Hàng], TenKhachHang as [Tên Khách Hàng], NgaySinh as [Ngày Sinh], GioiTinh as [Giới Tính], DiaChi as [Địa Chỉ], CMND as [Số CMND], DienThoai as [Số Điện Thoại], Email as [Email] from tb_KhachHang where TenKhachHang like '%" + txtTimKiemKH.Text + "%'", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_KhachHang");
                dgvTimKiemKH.DataSource = ds.Tables["tb_KhachHang"].DefaultView;
            }
            if (rbcmnd.Checked == true)
            {
                SqlConnection conn = new SqlConnection(Program.strconn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select MaKhachHang as [Mã Khách Hàng], TenKhachHang as [Tên Khách Hàng], NgaySinh as [Ngày Sinh], GioiTinh as [Giới Tính], DiaChi as [Địa Chỉ], CMND as [Số CMND], DienThoai as [Số Điện Thoại], Email as [Email] from tb_KhachHang where CMND like '%" + txtTimKiemKH.Text + "%'", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_KhachHang");
                dgvTimKiemKH.DataSource = ds.Tables["tb_KhachHang"].DefaultView;
            }
            if (rbdt.Checked == true)
            {
                SqlConnection conn = new SqlConnection(Program.strconn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select MaKhachHang as [Mã Khách Hàng], TenKhachHang as [Tên Khách Hàng], NgaySinh as [Ngày Sinh], GioiTinh as [Giới Tính], DiaChi as [Địa Chỉ], CMND as [Số CMND], DienThoai as [Số Điện Thoại], Email as [Email] from tb_KhachHang where DienThoai like '%" + txtTimKiemKH.Text + "%'", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_KhachHang");
                dgvTimKiemKH.DataSource = ds.Tables["tb_KhachHang"].DefaultView;
            }
        }
    }
}
