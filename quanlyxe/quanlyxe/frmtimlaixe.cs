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
    public partial class frmtimlaixe : Form
    {
        public frmtimlaixe()
        {
            InitializeComponent();
        }

        private void frmtimlaixe_Load(object sender, EventArgs e)
        {

        }

        private void btntimKH_Click(object sender, EventArgs e)
        {
            if (rbTimKiemMaLX.Checked == true)
            {
                SqlConnection conn = new SqlConnection(Program.strconn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select MaLaiXe as [Mã Lái Xe], TenLaiXe as [Tên Lái Xe], NgaySinh as [Ngày Sinh], GioiTinh as [Giới Tính], DiaChi as [Địa Chỉ], CMND as [Số CMND], DienThoai as [Số Điện Thoại], Email as [Email] from tb_LaiXe where MaLaiXe like '%" + txtTimKiemKH.Text + "%'", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_LaiXe");
                dgvTimKiemKH.DataSource = ds.Tables["tb_LaiXe"].DefaultView;
            }
            if (rbTimKiemTheoTenLX.Checked == true)
            {
                SqlConnection conn = new SqlConnection(Program.strconn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select MaLaiXe as [Mã Lái Xe], TenLaiXe as [Tên Lái Xe], NgaySinh as [Ngày Sinh], GioiTinh as [Giới Tính], DiaChi as [Địa Chỉ], CMND as [Số CMND], DienThoai as [Số Điện Thoại], Email as [Email] from tb_LaiXe where TenLaiXe like '%" + txtTimKiemKH.Text + "%'", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_LaiXe");
                dgvTimKiemKH.DataSource = ds.Tables["tb_LaiXe"].DefaultView;
            }
            if (rbcmnd.Checked == true)
            {
                SqlConnection conn = new SqlConnection(Program.strconn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select MaLaiXe as [Mã Lái Xe], TenLaiXe as [Tên Lái Xe], NgaySinh as [Ngày Sinh], GioiTinh as [Giới Tính], DiaChi as [Địa Chỉ], CMND as [Số CMND], DienThoai as [Số Điện Thoại], Email as [Email] from tb_LaiXe where CMND like '%" + txtTimKiemKH.Text + "%'", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_LaiXe");
                dgvTimKiemKH.DataSource = ds.Tables["tb_LaiXe"].DefaultView;
            }
            if (rbdt.Checked == true)
            {
                SqlConnection conn = new SqlConnection(Program.strconn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select MaLaiXe as [Mã Lái Xe], TenLaiXe as [Tên Lái Xe], NgaySinh as [Ngày Sinh], GioiTinh as [Giới Tính], DiaChi as [Địa Chỉ], CMND as [Số CMND], DienThoai as [Số Điện Thoại], Email as [Email] from tb_LaiXe where DienThoai like '%" + txtTimKiemKH.Text + "%'", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_LaiXe");
                dgvTimKiemKH.DataSource = ds.Tables["tb_LaiXe"].DefaultView;
            }
        }
    }
}
