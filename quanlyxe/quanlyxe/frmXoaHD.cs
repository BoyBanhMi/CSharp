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
    public partial class frmXoaHD : Form
    {
        //string strconnect = @"Data Source=BOYBNHMI;Initial Catalog=qlx;Integrated Security=True";
       // SqlConnection conn;
        public frmXoaHD()
        {
            InitializeComponent();
        }
        
        private void frmXoaHD_Load(object sender, EventArgs e)
        {
            //tao ket noi
           
            //SqlCommand command;

            try
            {
               SqlConnection conn = new SqlConnection(Program.strconn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select tb_HopDong.MaKhachHang as [Mã khách hàng], tb_HopDong.MaHopDong as [Mã hợp đồng], tb_HopDong.TenHopDong as [Tên hợp đồng], NgayLapHopDong as [Ngày lập hợp đồng], tb_HopDong.MaNhanVien as [Mã nhân viên] , HanThanhToan as [Hạn thanh toán] ,TinhTrangThanhToan as [Tình trạng thanh toán] from tb_HopDong ", conn);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
                da.Dispose();
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }

            
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Program.strconn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select tb_HopDong.MaKhachHang as [Mã khách hàng], MahopDong as [Mã hợp đồng], TenHopDong as [Tên hợp đồng], NgayLapHopDong as [Ngày lập hợp đồng], MaNhanVien as [Mã nhân viên] , HanThanhToan as [Hạn thanh toán] ,TinhTrangThanhToan as [Tình trạng thanh toán] from tb_HopDong where MahopDong = ('" +txtinsert.Text+ "')", conn);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
                da.Dispose();

            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Program.strconn);
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete tb_ChiTietPhieuTra where MaHopDong = '" + txtinsert.Text + "' ", conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                //con.Open();
                //SqlCommand cmd8 = new SqlCommand("update tb_Xe set tb_Xe.TinhTrangXe = 'NOT BUSY' where MaXe = '" + txtMaXe.Text + "'", con);
                //cmd8.ExecuteNonQuery();
                //con.Close();

                conn.Open();
                SqlCommand cmd2 = new SqlCommand("delete tb_PhieuTra where MaHopDong = '" + txtinsert.Text + "'  ", conn);
                cmd2.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                SqlCommand cmd3 = new SqlCommand("delete tb_ChiTietHopDong where MaHopDong = '" + txtinsert.Text + "'  ", conn);
                cmd3.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                SqlCommand cmd4 = new SqlCommand("delete tb_HopDong where MaHopDOng = '" + txtinsert.Text + "'  ", conn);
                cmd4.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select tb_HopDong.MaKhachHang as [Mã khách hàng], tb_HopDong.MaHopDong as [Mã hợp đồng], tb_HopDong.TenHopDong as [Tên hợp đồng], NgayLapHopDong as [Ngày lập hợp đồng], tb_HopDong.MaNhanVien as [Mã nhân viên] , HanThanhToan as [Hạn thanh toán] ,TinhTrangThanhToan as [Tình trạng thanh toán] from tb_HopDong ", conn);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
                da.Dispose();
                MessageBox.Show("Xóa hợp đồng thành công", "Quản lý hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Xóa nhân viên thất bại, Lỗi CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
