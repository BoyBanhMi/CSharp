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
    public partial class frmQuanLyNhanVien : Form
    {
        //string strconnect = @"Data Source=BOYBNHMI;Initial Catalog=qlx;Integrated Security=True";
        //SqlConnection conn;
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void Load_MaNV()
        {

                SqlConnection conn = new SqlConnection(Program.strconn);
                conn.Open();
                
                SqlDataAdapter da1 = new SqlDataAdapter("select MaNhanVien from tb_NhanVien", conn);
                DataTable dt1 = new DataTable();
                dt1.Clear();
                da1.Fill(dt1);
                txtMaNhanVien.DataSource = dt1;
                txtMaNhanVien.DisplayMember = "MaNhanVien";
                txtMaNhanVien.ValueMember = "MaNhanVien";
                conn.Close();
                da1.Dispose();
            

        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            try
            {
                int gt;
                if (rad_Nam.Checked == true)
                {
                     gt = 1;
                }
                else
                {
                    gt = 0;
                }
                SqlConnection conn = new SqlConnection(Program.strconn);
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into tb_NhanVien values ('" + txtMaNhanVien.Text + "', '" + txtTenNhanVien.Text + "', '" + gt + "', '" + dtpNgaySinh.Text + "', '" + txtDiaChi.Text + "', '" + txtDienThoai.Text + "', '" + txtEmail.Text + "', '" + txtbangCap.Text + "', '" + txtCMND.Text + "', '" + dtpNgayVaoLam.Text + "')", conn);
                cmd.ExecuteNonQuery();
                dtgQuanLyNhanVien.DataSource = DS_NhanVien();
                MessageBox.Show("Thêm thành công", "Quản lý nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Thêm nhân viên thất bại, Lỗi CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            private void frmQuanLyNhanVien_Load(object sender, EventArgs e){
                Load_MaNV();
                dtgQuanLyNhanVien.DataSource = DS_NhanVien();
            }

            private void cmdTimKiem_Click(object sender, EventArgs e)
            {
                SqlConnection conn = new SqlConnection(Program.strconn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from tb_NhanVien where MaNhanVien like '%" + txtMaNhanVien.Text + "&'", conn);
                dtgQuanLyNhanVien.DataSource = DS_NhanVien();
            }
           
            private void cmdSua_Click(object sender, EventArgs e)
            {
                try
                {
                    int gt;
                    if (rad_Nam.Checked == true)
                    {
                        gt = 1;
                    }
                    else
                    {
                        gt = 0;
                    }
                    SqlConnection conn = new SqlConnection(Program.strconn);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("update tb_NhanVien set TenNhanVien = '" + txtTenNhanVien.Text + "', GioiTinh = '" + gt + "', NgaySinh = '" + dtpNgaySinh.Text + "', DiaChi = '" + txtDiaChi.Text + "', DienThoai = '" + txtDienThoai.Text + "', Email = '" + txtEmail.Text + "', BangCap = '" + txtbangCap.Text + "', CMND = '" + txtCMND.Text + "', NgayVaoLam = '" + dtpNgayVaoLam.Text + "' where MaNhanVien = '" + txtMaNhanVien.Text + "'  ", conn);
                    //SqlCommand cmd = new SqlCommand("update tb_NhanVirn set TenNhanVien = '"+txtTenNhanVien.Text+"', GioiTinh = '"+txtGioiTinh.Text+"', NgaySinh = '"+dtpNgaySinh.Text+"', DiaChi = '"+txtDiaChi.Text+"', DienThoai = '"+txtDienThoai.Text+"', Email = '"+txtEmail.Text+", BangCap = '"+txtbangCap.Text+"', CMND = '"+txtCMND.Text+"', NgayVaoLam = '"+dtpNgayVaoLam.Text+"' where MaNhanVien = '"+txtMaNhanVien.Text+"' ", con);
                    cmd.ExecuteNonQuery();
                    dtgQuanLyNhanVien.DataSource = DS_NhanVien();
                    MessageBox.Show("Sửa thành công", "Quản lý  Xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Sửa thất bại, Lỗi CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            public DataTable DS_NhanVien()
            {
                SqlConnection conn = new SqlConnection(Program.strconn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select row_number() over (order by MaNhanVien) as STT, MaNhanVien as [Mã nhân viên], TenNhanVien as [Tên nhân viên], case when GioiTinh='1' then 'Nam' else N'Nữ' end as [Giới tính], NgaySinh as [Ngày sinh], DiaChi as  [Địa chỉ], DienThoai as [Điện thoại], Email, BangCap as [Bằng cấp], CMND, NgayVaoLam as [Ngày vào làm] from tb_NhanVien ", conn);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                da.Dispose();
                return dt;
            }
            private void cmdXoa_Click(object sender, EventArgs e)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(Program.strconn);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from tb_NhanVien where MaNhanVien = '" + txtMaNhanVien.Text + "'  ", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    dtgQuanLyNhanVien.DataSource = DS_NhanVien();
                    
                    MessageBox.Show("Xóa nhân viên thành công", "Quản lý  Xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Xóa nhân viên thất bại, Lỗi CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
    }
}