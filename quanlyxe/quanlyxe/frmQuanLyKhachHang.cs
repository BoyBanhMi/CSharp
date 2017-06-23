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
    public partial class frmQuanLyKhachHang : Form
    {
        //string strconnect = @"Data Source=BOYBNHMI;Initial Catalog=qlx;Integrated Security=True";
       // SqlConnection con;
        public frmQuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
             try
                {
                    int gt = 1;
                    if (radNam.Checked)
                    {
                        gt = 1;
                    }
                    else {
                        gt = 0;
                    }

                    SqlConnection con = new SqlConnection(Program.strconn);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into tb_KhachHang  values ('" + Ma.Text + "','"+txtHoKH.Text+"' ,'" + Ten.Text + "', '" + NgaySinh.Text + "', '" + gt + "', '" + DiaChi.Text + "', '" + CMND.Text + "', '" + DienThoai.Text + "', '" + Email.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter("select row_number() over (order by MaKhachHang) as STT, MaKhachHang as [Mã khách hàng], TenKhachHang as [Tên khách hàng], NgaySinh as [Ngày sinh], GioiTinh as [Giới tính], DiaChi as [ Địa chỉ], DienThoai as [Điện thoại], CMND, Email from tb_KhachHang ", con);
                    DataTable dt = new DataTable();
                    dt.Clear();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                    da.Dispose();
                    MessageBox.Show("Thêm thành công", "Quản lý khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Thêm thất bại, Lỗi CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        private void Load_MaKH()
        {

            SqlConnection con = new SqlConnection(Program.strconn);
            
            con.Open();
            SqlDataAdapter da1 = new SqlDataAdapter("select MaKhachHang from tb_KhachHang", con);
            DataTable dt1 = new DataTable();
            dt1.Clear();
            da1.Fill(dt1);
            Ma.DataSource = dt1;
            Ma.DisplayMember = "MaKhachHang";
            Ma.ValueMember = "MaKhachHang";
            con.Close();
            da1.Dispose();
        }

        private void frmQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            Load_MaKH();
            SqlConnection con = new SqlConnection(Program.strconn);
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("select row_number() over (order by MaKhachHang) as STT, MaKhachHang as [Mã khách hàng], TenKhachHang as [Tên khách hàng], NgaySinh as [Ngày sinh], GioiTinh as [Giới tính], DiaChi as [ Địa chỉ], DienThoai as [Điện thoại], CMND, Email from tb_KhachHang ", con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            da.Dispose();
            //Tao combobox
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                int gt = 1;
                if (radNam.Checked)
                {
                    gt = 1;
                }
                else
                {
                    gt = 0;
                }

                SqlConnection con = new SqlConnection(Program.strconn);
                con.Open();
                SqlCommand cmd = new SqlCommand("update  tb_KhachHang set TenKhachHang = '" + Ten.Text + "', NgaySinh = '" + NgaySinh.Text + "', GioiTinh = '" + gt + "', DiaChi = '" + DiaChi.Text + "', CMND = '" + CMND.Text + "', DienThoai = '" + DienThoai.Text + "', Email = '" + Email.Text + "' where MaKhachHang = '" + Ma.Text + "' ", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("select row_number() over (order by MaKhachHang) as STT, MaKhachHang as [Mã khách hàng], TenKhachHang as [Tên khách hàng], NgaySinh as [Ngày sinh], GioiTinh as [Giới tính], DiaChi as [ Địa chỉ], DienThoai as [Điện thoại], CMND, Email from tb_KhachHang ", con);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                da.Dispose();
                //MessageBox.Show("Bạn có chắc chắn muốn sửa?", "Quản lý khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                MessageBox.Show("Sửa thành công", "Quản lý khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Sửa thất bại, Lỗi CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.strconn);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select row_number() over (order by MaKhachHang) as STT, MaKhachHang as [Mã khách hàng], TenKhachHang as [Tên khách hàng], NgaySinh as [Ngày sinh], GioiTinh as [Giới tính], DiaChi as [ Địa chỉ], DienThoai as [Điện thoại], CMND, Email from tb_KhachHang ", con);
            DataSet dt = new DataSet();
            da.Fill(dt, "tb_KhachHang");
            dataGridView1.DataSource = dt.Tables["tb_KhachHang"].DefaultView;
            con.Close();
            da.Dispose();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.strconn);
            con.Open();


            SqlDataAdapter da = new SqlDataAdapter("select row_number() over (order by MaKhachHang) as STT, MaKhachHang as [Mã khách hàng], TenKhachHang as [Tên khách hàng], NgaySinh as [Ngày sinh], GioiTinh as [Giới tính], DiaChi as [ Địa chỉ], DienThoai as [Điện thoại], CMND, Email from tb_KhachHang where MaKhachHang like '%" + Ma.Text + "%' ", con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            da.Dispose();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Program.strconn);
                con.Open();

                con.Open();
                SqlCommand cmd2 = new SqlCommand("delete from tb_KhachHang where MaKhachHang = '" + Ma.Text + "'", con);
                cmd2.ExecuteNonQuery();
                con.Close();

                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select row_number() over (order by MaKhachHang) as STT, MaKhachHang as [Mã khách hàng], TenKhachHang as [Tên khách hàng], NgaySinh as [Ngày sinh], GioiTinh as [Giới tính], DiaChi as [ Địa chỉ], DienThoai as [Điện thoại], CMND, Email from tb_KhachHang ", con);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                da.Dispose();
                MessageBox.Show("Xóa thành công", "Quản lý khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Xóa thất bại", "Lỗi cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
