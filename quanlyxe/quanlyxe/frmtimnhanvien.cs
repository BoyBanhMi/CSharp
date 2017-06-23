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
    public partial class frmtimnhanvien : Form
    {
        public frmtimnhanvien()
        {
            InitializeComponent();
        }

        private void frmtimnhanvien_Load(object sender, EventArgs e)
        {

        }

        private void btntim_Click(object sender, EventArgs e)
        {
            if (rbTimKiemMaNV.Checked == true)
            {
                SqlConnection conn = new SqlConnection(Program.strconn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select MaNhanVien as [Mã Nhân Viên], TenNhanVien as [Tên Nhân Viên], NgaySinh as [Ngày Sinh], GioiTinh as [Giới Tính], DiaChi as [Địa Chỉ], CMND as [Số CMND], DienThoai as [Số Điện Thoại], Email as [Email] from tb_NhanVien where MaNhanVien like '%" + txtTimKiemKH.Text + "%'", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_NhanVien");
                dgvTimKiemKH.DataSource = ds.Tables["tb_NhanVien"].DefaultView;
            }
            if (rbTimKiemTheoTenNV.Checked == true)
            {
                SqlConnection conn = new SqlConnection(Program.strconn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select MaNhanVien as [Mã Nhân Viên], TenNhanVien as [Tên Nhân Viên], NgaySinh as [Ngày Sinh], GioiTinh as [Giới Tính], DiaChi as [Địa Chỉ], CMND as [Số CMND], DienThoai as [Số Điện Thoại], Email as [Email] from tb_NhanVien where tenNhanVien like '%" + txtTimKiemKH.Text + "%'", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_NhanVien");
                dgvTimKiemKH.DataSource = ds.Tables["tb_NhanVien"].DefaultView;
            }
            if (rbcmnd.Checked == true)
            {
                SqlConnection conn = new SqlConnection(Program.strconn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select MaNhanVien as [Mã Nhân Viên], TenNhanVien as [Tên Nhân Viên], NgaySinh as [Ngày Sinh], GioiTinh as [Giới Tính], DiaChi as [Địa Chỉ], CMND as [Số CMND], DienThoai as [Số Điện Thoại], Email as [Email] from tb_LaiXe where CMND like '%" + txtTimKiemKH.Text + "%'", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_NhanVien");
                dgvTimKiemKH.DataSource = ds.Tables["tb_NhanVien"].DefaultView;
            }
            if (rbdt.Checked == true)
            {
                SqlConnection conn = new SqlConnection(Program.strconn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select MaNhanVien as [Mã Nhân Viên], TenNhanVien as [Tên Nhân Viên], NgaySinh as [Ngày Sinh], GioiTinh as [Giới Tính], DiaChi as [Địa Chỉ], CMND as [Số CMND], DienThoai as [Số Điện Thoại], Email as [Email] from tb_LaiXe where DienThoai like '%" + txtTimKiemKH.Text + "%'", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_NhanVien");
                dgvTimKiemKH.DataSource = ds.Tables["tb_NhanVien"].DefaultView;
            }
        }
    }
}
