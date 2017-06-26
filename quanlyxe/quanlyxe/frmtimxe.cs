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
    public partial class frmtimxe : Form
    {
        public frmtimxe()
        {
            InitializeComponent();
        }

        private void btntimxe_Click(object sender, EventArgs e)
        {
            if (rbTimKiemMaXe.Checked == true)
            {
                SqlConnection conn = new SqlConnection(Program.strconn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select MaXe as [Mã Xe], TenXe as [Tên Xe], NgaySanXuat as [Ngày sản xuất], HangXe as [Hãng Xe], BienKiemSoat as [Bản số xe], SucChua as [Số Ghế Ngồi], LoaiXe as [Loại Xe], NgayMuaXe as [Ngày mua Xe] from tb_Xe where MaXe like '%"+txtTimKiemXe.Text+"%'",conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_Xe");
                dgvTimKiemXe.DataSource = ds.Tables["tb_Xe"].DefaultView;
            }
            if (rbTimKiemTheoTenXe.Checked == true)
            {
                SqlConnection conn = new SqlConnection(Program.strconn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select MaXe as [Mã Xe], TenXe as [Tên Xe], NgaySanXuat as [Ngày sản xuất], HangXe as [Hãng Xe], BienKiemSoat as [Bản số xe], SucChua as [Số Ghế Ngồi], LoaiXe as [Loại Xe], NgayMuaXe as [Ngày mua Xe] from tb_Xe where TenXe like '%" + txtTimKiemXe.Text + "%'", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_Xe");
                dgvTimKiemXe.DataSource = ds.Tables["tb_Xe"].DefaultView;
            }
        }

        private void txtTimKiemXe_TextChanged(object sender, EventArgs e)
        {
            if (rbTimKiemMaXe.Checked == true)
            {
                SqlConnection conn = new SqlConnection(Program.strconn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select MaXe as [Mã Xe], TenXe as [Tên Xe], NgaySanXuat as [Ngày sản xuất], HangXe as [Hãng Xe], BienKiemSoat as [Bản số xe], SucChua as [Số Ghế Ngồi], LoaiXe as [Loại Xe], NgayMuaXe as [Ngày mua Xe] from tb_Xe where MaXe like '%" + txtTimKiemXe.Text + "%'", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_Xe");
                dgvTimKiemXe.DataSource = ds.Tables["tb_Xe"].DefaultView;
            }
            if (rbTimKiemTheoTenXe.Checked == true)
            {
                SqlConnection conn = new SqlConnection(Program.strconn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select MaXe as [Mã Xe], TenXe as [Tên Xe], NgaySanXuat as [Ngày sản xuất], HangXe as [Hãng Xe], BienKiemSoat as [Bản số xe], SucChua as [Số Ghế Ngồi], LoaiXe as [Loại Xe], NgayMuaXe as [Ngày mua Xe] from tb_Xe where TenXe like '%" + txtTimKiemXe.Text + "%'", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_Xe");
                dgvTimKiemXe.DataSource = ds.Tables["tb_Xe"].DefaultView;
            }
        }
    }
}
