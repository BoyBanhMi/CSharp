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
    public partial class frmLapHopDong : Form
    {
        public frmLapHopDong()
        {
            InitializeComponent();
        }

        private void dataGridViewlapHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void themHD(string mahd, string tenhd, string ngaylap, string manv, string makh, string ngaythanhtoan, int x, string maxe, string malaixe, string magia, string tiencoc) 
        {
            try
            {
                SqlConnection con = new SqlConnection(Program.strconn);
                con.Open();
                string cmd = "INSERT INTO tb_HopDong VALUES(N'" + mahd + "',N'" + tenhd + "','" + ngaylap + "',N'" + manv + "',N'" + makh + "','" + ngaythanhtoan + "','" + x + "','"+maxe+"','"+malaixe+"','"+magia+"','"+tiencoc+"')";
                SqlCommand sqlCmd = new SqlCommand(cmd, con);
                sqlCmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Thêm Hợp Đồng thành công", "Lập Hợp Đồng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Thêm Hợp Đồng Thất bại ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void themHDKLX(string mahd, string tenhd, string ngaylap, string manv, string makh, string ngaythanhtoan, int x, string maxe, string magia, string tiencoc)
        {
            try
            {
                SqlConnection con = new SqlConnection(Program.strconn);
                con.Open();
                string cmd = "INSERT INTO tb_HopDong VALUES(N'" + mahd + "',N'" + tenhd + "','" + ngaylap + "',N'" + manv + "',N'" + makh + "','" + ngaythanhtoan + "','" + x + "','" + maxe + "','0','" + magia + "','" + tiencoc + "')";
                SqlCommand sqlCmd = new SqlCommand(cmd, con);
                sqlCmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Thêm Hợp Đồng thành công", "Lập Hợp Đồng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Thêm Hợp Đồng Thất bại ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        void suaHD(string mahd, string tenhd, string ngaylap, string manv, string makh, string ngaythanhtoan, int x, string maxe, string magia, string malaixe)
        {
            try
            {
                SqlConnection connDB = new SqlConnection(Program.strconn);
                connDB.Open();
                string cmd = "UPDATE tb_HopDong SET TenHopDong=N'" + tenhd + "', NgayLapHopDong='" + ngaylap + "', MaNhanVien='" + manv + "', MaKhachHang='" + makh + "', HanThanhToan='" + ngaythanhtoan + "', TinhTrangThanhToan='" + x + "' WHERE MaHopDong='" + mahd + "'";
                SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
                sqlCmd.ExecuteNonQuery();
                connDB.Close();
                MessageBox.Show("Sửa Hợp Đồng thành công", "Lập Hợp Đồng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Sửa Hợp Đồng thất bại, Lỗi CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void xoaHD(string mahd)
        {
            try
            {
                SqlConnection connDB = new SqlConnection(Program.strconn);
                connDB.Open();
                string cmd = "DELETE FROM tb_HopDong WHERE MaHopDong='" + mahd + "'";
                SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
                sqlCmd.ExecuteNonQuery();
                connDB.Close();
                MessageBox.Show("Xóa Hợp Đồng thành công", "Lập Hợp Đồng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Xóa Hợp Đồng thất bại", "Lỗi !!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        DataTable DS_NV()
        {
            string cmd = "SELECT * FROM tb_NhanVien";
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
        }
        private void pnThemHopDong_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (rb_coTX.Checked == true)
                {
                    themHD(cbbMaHD.Text, txtTenHD.Text, dtpNgayLap.Text, cbbMaNV.SelectedValue.ToString(), cbbMaKH.SelectedValue.ToString(), dtpHannThanhToan.Text, 0, cbb_chonxe.SelectedValue.ToString(), cbb_chonLX.SelectedValue.ToString(), txtGia.Text, txt_tiencoc.Text);
                    dataGridViewlapHD.DataSource = ds_HD();
                }
                else
                {
                    themHDKLX(cbbMaHD.Text, txtTenHD.Text, dtpNgayLap.Text, cbbMaNV.SelectedValue.ToString(), cbbMaKH.SelectedValue.ToString(), dtpHannThanhToan.Text, 0, cbb_chonxe.SelectedValue.ToString(), txtGia.Text, txt_tiencoc.Text);
                    dataGridViewlapHD.DataSource = ds_HD();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi !!");
            }
        }
        DataTable ds_HD()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tb_HopDong order by MaHopDong, TenHopDong", Program.strconn);
            DataTable ds = new DataTable();
            da.Fill(ds);
            return ds;
        }
        DataTable ds_Gia()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tb_Gia order by MaGia, DonGia", Program.strconn);
            DataTable ds = new DataTable();
            da.Fill(ds);
            return ds;
        }
        DataTable ds_LX()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tb_LaiXe order by MaLaiXe, TenLaiXe", Program.strconn);
            DataTable ds = new DataTable();
            da.Fill(ds);
            return ds;
        }
        DataTable ds_X()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tb_Xe order by MaXe, LoaiXe", Program.strconn);
            DataTable ds = new DataTable();
            da.Fill(ds);
            return ds;
        }
        private void frmLapHopDong_Load(object sender, EventArgs e)
        {
            cbbMaHD.DataSource = ds_HD();
            cbbMaHD.DisplayMember = "MaHopDong";
            cbbMaHD.ValueMember = "MaHopDong";

            cbbMaNV.DataSource = DS_NV();
            cbbMaNV.DisplayMember = "TenNhanVien";
            cbbMaNV.ValueMember = "MaNhanVien";
            
            cbbMaKH.DataSource = DS_KH();
            cbbMaKH.DisplayMember = "MaKhachHang";
            cbbMaKH.ValueMember = "MaKhachHang";

            

            cbb_chonLX.DataSource = ds_LX();
            cbb_chonLX.DisplayMember = "TenLaiXe";
            cbb_chonLX.ValueMember = "MaLaiXe";

            cbb_chonxe.DataSource = ds_X();
            cbb_chonxe.DisplayMember = "LoaiXe";
            cbb_chonxe.ValueMember = "MaXe";



            dataGridViewlapHD.DataSource = ds_HD();
            dataGridViewlapHD.Columns[0].HeaderText = "Mã Hợp Đồng";
            dataGridViewlapHD.Columns[1].HeaderText = "Tên Hợp Đồng";
            dataGridViewlapHD.Columns[2].HeaderText = "Ngày Lập";
            dataGridViewlapHD.Columns[3].HeaderText = "Mã Nhân Viên";
            dataGridViewlapHD.Columns[4].HeaderText = "MÃ Khách Hàng";
            dataGridViewlapHD.Columns[5].HeaderText = "Hạn Thanh Toán";
            dataGridViewlapHD.Columns[6].HeaderText = "Tình Trạng Thanh Toán";
            dataGridViewlapHD.Columns[7].HeaderText = "Mã Xe";
            dataGridViewlapHD.Columns[8].HeaderText = "Mã Lái Xe";
            dataGridViewlapHD.Columns[9].HeaderText = "Giá";

            lbl_LX.Visible = false;
            cbb_chonLX.Visible = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            suaHD(cbbMaHD.SelectedValue.ToString(), txtTenHD.Text, dtpNgayLap.Text, cbbMaNV.SelectedValue.ToString(), cbbMaKH.SelectedValue.ToString(), dtpHannThanhToan.Text, 0, cbb_chonxe.SelectedValue.ToString(), cbb_chonLX.SelectedValue.ToString(), txtGia.Text);
            dataGridViewlapHD.DataSource = ds_HD();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoaHD(cbbMaHD.SelectedValue.ToString());
            dataGridViewlapHD.DataSource = ds_HD();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn chác chán muốn thoát !!!", "Thoát",MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            this.Close();
        }

        private void rb_coTX_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_coTX.Checked == true){
                lbl_LX.Visible = true;
                cbb_chonLX.Visible = true;
            }
            else
            {
                lbl_LX.Visible = false;
                cbb_chonLX.Visible = false;
            }
        }
    }
}
