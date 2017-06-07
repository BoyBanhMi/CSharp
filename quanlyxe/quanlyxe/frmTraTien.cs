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
    public partial class frmTraTien : Form 
    {
       // string strconnect = @"Data Source=BOYBNHMI;Initial Catalog=qlx;Integrated Security=True";
        //SqlConnection con;
        public frmTraTien()
        {
            InitializeComponent();
        }
        public static TextBox tb = new TextBox();
        private void Load_MaKH()
        {
            SqlConnection con = new SqlConnection(Program.strconn);
            con.Open();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from tb_KhachHang", con);
            //SqlDataAdapter da1 = new SqlDataAdapter("select MaKhachHang from tb_HopDong", con);
            DataTable dt1 = new DataTable();
            dt1.Clear();
            da1.Fill(dt1);
            txtMaKH.DataSource = dt1;
            txtMaKH.DisplayMember = "TenKhachHang";
            txtMaKH.ValueMember = "MaKhachHang";
            con.Close();
            da1.Dispose();
        }
        public void Load_MaNV()
        {
            SqlConnection con = new SqlConnection(Program.strconn);
           
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from tb_NhanVirn", con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            txtMaNhanVien.DataSource = dt;
            txtMaNhanVien.DisplayMember = "TenNhanVien";
            txtMaNhanVien.ValueMember = "MaNhanVien";
            con.Close();
            da.Dispose();
        }
        
        
        private void frmTraTien_Load(object sender, EventArgs e)
        {

            Load_MaKH();
            Load_MaNV();
           

            


            SqlConnection con = new SqlConnection(Program.strconn);
            con.Open();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from tb_HopDong", con);
            DataTable dt2 = new DataTable();
            dt2.Clear();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            con.Close();
            da2.Dispose();


            SqlDataAdapter da1 = new SqlDataAdapter("select Tb_PhieuTra.MaKhachHang as [Mã khách hàng], Tb_PhieuTra.MaHopDong as [Mã hợp đồng], Tb_PhieuTra.MaNhanVien as [Mã nhân viên], Tb_PhieuTra.NgayTraTienThucTe as [Ngày trả tiền thực tế],Tb_PhieuTra.TienPhatQuaHanTheoNgay as [Tiền phạt quá hạn theo ngày], datediff(dd,tb_HopDong.HanThanhToan,tb_PhieuTra.NgayTraTienThucTe) as [Số ngày quá hạn], tb_PhieuTra.TinhTrangThanhToan as [Tình trạng thanh toán] from tb_KhachHang,tb_HopDong,tb_PhieuTra where tb_KhachHang.MaKhachHang = tb_HopDong.MaKhachHang and tb_HopDong.MaKhachHang = tb_PhieuTra.MaKhachHang and tb_HopDong.MaHopDong = tb_PhieuTra.MaHopDong", con);
            DataTable dt1 = new DataTable();
            dt1.Clear();
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;
            con.Close();
            da1.Dispose();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /*
        DataTable DS_HD()
        {
            string cmd = "SELECT * FROM tb_HopDong";
            SqlDataAdapter adap = new SqlDataAdapter(cmd, Program.strconn);
            DataTable ds = new DataTable();
            adap.Fill(ds);
            return ds;
        }
        DataTable DS_NV()
        {
            string cmd = "SELECT * FROM tb_NhanVirn";
            SqlDataAdapter adap = new SqlDataAdapter(cmd, Program.strconn);
            DataTable ds = new DataTable();
            adap.Fill(ds);
            return ds;
        }
        DataTable DS_KH()
        {
            string cmd = "SELECT * FROM tb_KhachHang";
            SqlDataAdapter adap = new SqlDataAdapter(cmd, Program.strconn);
            DataTable ds = new DataTable();
            adap.Fill(ds);
            return ds;
        }*/
        private void cmdThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Program.strconn);
                con.Open();
                if (dtpNgayTraTienThucTe.Value > dtpHanTraTien.Value)
                {
                    SqlCommand cmd = new SqlCommand("insert into Tb_PhieuTra (MaHopDong, MaKhachHang, MaNhanVien, NgayTraTienThucTe, TinhTrangThanhToan) values ('" + txtMaHD.Text + "', '" + txtMaKhachHang.Text + "', '" + txtMaNhanVien.Text + "', '" + dtpNgayTraTienThucTe.Value + "', '" + cbTinhTrangThanhToan.Checked + "')   ", con);
                    cmd.ExecuteNonQuery();
                    SqlCommand cmd1 = new SqlCommand("update tb_HopDong set TinhTrangThanhToan = 'True' where MaHopDong = '" + txtMaHD.Text + "'", con);
                    cmd1.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter("select MaKhachHang as [Mã khách hàng], Tb_PhieuTra.MaHopDong as [Mã hợp đồng], MaNhanVien as [Mã nhân viên], NgayTraTienThucTe as [Ngày trả tiền thực tế], TinhTrangThanhToan as [Tình trạng thanh toán] from Tb_PhieuTra", con);
                    DataTable dt = new DataTable();
                    dt.Clear();
                    da.Fill(dt);
                    dataGridView2.DataSource = dt;
                    con.Close();
                    da.Dispose();
                }
                else
                {
                    SqlCommand cmd2 = new SqlCommand("insert into Tb_PhieuTra (MaHopDong, MaKhachHang, MaNhanVien, NgayTraTienThucTe,TienPhatQuaHanTheoNgay, TinhTrangThanhToan) values ('" + txtMaHD.Text + "', '" + txtMaKhachHang.Text + "', '" + txtMaNhanVien.Text + "', '" + dtpNgayTraTienThucTe.Text + "', '" + txtTienPhatTheoNgay.Text + "', '" + cbTinhTrangThanhToan.Checked + "')   ", con);
                    cmd2.ExecuteNonQuery();
                    SqlCommand cmd3 = new SqlCommand("update tb_HopDong set TinhTrangThanhToan = 'True' where MaHopDong = '" + txtMaHD.Text + "'", con);
                    cmd3.ExecuteNonQuery();
                    SqlDataAdapter da3 = new SqlDataAdapter("select Tb_PhieuTra.MaKhachHang as [Mã khách hàng], Tb_PhieuTra.MaHopDong as [Mã hợp đồng], Tb_PhieuTra.MaNhanVien as [Mã nhân viên], Tb_PhieuTra.NgayTraTienThucTe as [Ngày trả tiền thực tế],Tb_PhieuTra.TienPhatQuaHanTheoNgay as [Tiền phạt quá hạn theo ngày], datediff(dd,tb_HopDong.HanThanhToan,tb_PhieuTra.NgayTraTienThucTe) as [Số ngày quá hạn], TongTienTraMuon = datediff(dd,tb_HopDong.HanThanhToan,tb_PhieuTra.NgayTraTienThucTe)*TienPhatQuaHanTheoNgay from Tb_PhieuTra, tb_HopDong,tb_KhachHang where tb_KhachHang.MaKhachHang = tb_HopDong.MaKhachHang and tb_HopDong.MaKhachHang = tb_PhieuTra.MaKhachHang and tb_HopDong.MaHopDong = tb_PhieuTra.MaHopDong", con);
                    DataTable dt3 = new DataTable();
                    dt3.Clear();
                    da3.Fill(dt3);
                    dataGridView2.DataSource = dt3;
                    con.Close();
                    da3.Dispose();
                }
                MessageBox.Show("Thành công", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Xin lỗi, KH đã thanh toán rồi - Vui lòng kiểm tra lại, Lỗi CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdXemHD_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.strconn);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from tb_HopDong where MaKhachHang = '" + txtMaKH.SelectedValue.ToString() + "' ", con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            da.Dispose();
        }

        private void cbTinhTrangThanhToan_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTinhTrangThanhToan.Checked == true)
            {
                cmdThanhToan.Visible = true;
                cmdSua.Visible = true;
            }
            else
            {
                cmdThanhToan.Visible = false;
                cmdSua.Visible = false;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTienPhatTheoNgay_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpHanTraTien_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmdBaoCao_Click(object sender, EventArgs e)
        {
           // frmRe_ThanhToan f = new frmRe_ThanhToan();
          //  f.a = txtMaKH.Text;
           // f.Show();
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Program.strconn);
                con.Open();
                SqlCommand cmd = new SqlCommand("update  tb_PhieuTra set MaNhanVien = '" + txtMaNhanVien.Text + "', NgayTraTienThucTe = '" + dtpNgayTraTienThucTe.Text + "', TienPhatQuaHanTheoNgay = '" + txtTienPhatTheoNgay.Text + "', TinhTrangThanhToan = '" + cbTinhTrangThanhToan.Checked + "' where MaKhachHang = '" + txtMaKhachHang.Text + "' and MaHopDong = '" + txtMaHD.Text + "'", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("select * from tb_PhieuTra ", con);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                con.Close();
                da.Dispose();
                MessageBox.Show("Sửa thành công", "Thanh toán tiền", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Sửa thất bại, Lỗi CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.strconn);
            con.Open();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from tb_HopDong", con);
            DataTable dt2 = new DataTable();
            dt2.Clear();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            con.Close();
            da2.Dispose();


            SqlDataAdapter da1 = new SqlDataAdapter("select Tb_PhieuTra.MaKhachHang as [Mã khách hàng], Tb_PhieuTra.MaHopDong as [Mã hợp đồng], Tb_PhieuTra.MaNhanVien as [Mã nhân viên], Tb_PhieuTra.NgayTraTienThucTe as [Ngày trả tiền thực tế],Tb_PhieuTra.TienPhatQuaHanTheoNgay as [Tiền phạt quá hạn theo ngày], datediff(dd,tb_HopDong.HanThanhToan,tb_PhieuTra.NgayTraTienThucTe) as [Số ngày quá hạn], tb_PhieuTra.TinhTrangThanhToan as [Tình trạng thanh toán] from tb_KhachHang,tb_HopDong,tb_PhieuTra where tb_KhachHang.MaKhachHang = tb_HopDong.MaKhachHang and tb_HopDong.MaKhachHang = tb_PhieuTra.MaKhachHang and tb_HopDong.MaHopDong = tb_PhieuTra.MaHopDong and tb_PhieuTra.MaKhachHang = '" + txtMaKH.Text + "'", con);
            DataTable dt1 = new DataTable();
            dt1.Clear();
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;
            con.Close();
            da1.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtpNgayTraTienThucTe_ValueChanged(object sender, EventArgs e)
        {
            if (dtpHanTraTien.Value < dtpNgayTraTienThucTe.Value)
            {
                txtTienPhatTheoNgay.Visible = true;
                MessageBox.Show("Khách hàng thanh toán quá hạn hợp đồng, hãy phạt tiền khách hàng này :(", "Thanh Toán", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtTienPhatTheoNgay.Visible = false;
            }

        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
