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
        
        public frmXoaHD()
        {
            InitializeComponent();
        }
        public DataTable DS_HD()
        {
            SqlConnection conn = new SqlConnection(Program.strconn);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select row_number() over (order by MaHopDong) as STT, tb_HopDong.MaKhachHang as [Mã khách hàng], tb_HopDong.MaHopDong as [Mã hợp đồng], tb_HopDong.TenHopDong as [Tên hợp đồng], NgayLapHopDong as [Ngày lập hợp đồng], tb_HopDong.MaNhanVien as [Mã nhân viên] , HanThanhToan as [Hạn thanh toán] ,TinhTrangThanhToan as [Tình trạng thanh toán] from tb_HopDong ", conn);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            
            conn.Close();
            da.Dispose();
            return dt;
        }
        private void frmXoaHD_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DS_HD();
 
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Program.strconn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select tb_HopDong.MaKhachHang as [Mã khách hàng], MahopDong as [Mã hợp đồng], TenHopDong as [Tên hợp đồng], NgayLapHopDong as [Ngày lập hợp đồng], MaNhanVien as [Mã nhân viên] , HanThanhToan as [Hạn thanh toán] ,TinhTrangThanhToan as [Tình trạng thanh toán] from tb_HopDong where MahopDong like '%" +txtinsert.Text+ "%'", conn);
                dataGridView1.DataSource = DS_HD();

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
               
                SqlCommand cmd4 = new SqlCommand("delete tb_HopDong where MaHopDOng = '" + txtinsert.Text + "'  ", conn);
                cmd4.ExecuteNonQuery();
                conn.Close();

                dataGridView1.DataSource = DS_HD();
                MessageBox.Show("Xóa hợp đồng thành công", "Quản lý hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Xóa nhân viên thất bại, Lỗi CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtinsert_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.strconn);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select tb_HopDong.MaKhachHang as [Mã khách hàng], MahopDong as [Mã hợp đồng], TenHopDong as [Tên hợp đồng], NgayLapHopDong as [Ngày lập hợp đồng], MaNhanVien as [Mã nhân viên] , HanThanhToan as [Hạn thanh toán] ,TinhTrangThanhToan as [Tình trạng thanh toán] from tb_HopDong where MahopDong like '%" + txtinsert.Text + "%'", conn);
            dataGridView1.DataSource = DS_HD();
        }
    }
}
