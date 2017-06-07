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
    public partial class frm_TraTien : Form
    {
        public frm_TraTien()
        {
            InitializeComponent();
        }

        private void frm_TraTien_Load(object sender, EventArgs e)
        {
            cbb_MaHD.DataSource = DS_HopDong();
            cbb_MaHD.DisplayMember = "MaHopDong";
            cbb_MaHD.ValueMember = "MaHopDong";

            cbb_MaKH.DataSource = DS_HopDong();
            cbb_MaKH.DisplayMember = "MaKhachHang";
            cbb_MaKH.ValueMember = "MaKhachHang";

            cbb_NhanVien.DataSource = DS_NhanVien();
            cbb_NhanVien.DisplayMember = "TenNhanVien";
            cbb_NhanVien.ValueMember = "MaNhanVien";

            dtgv_xemHD.DataSource = DS_HopDong();
        }
        void timHD(string mahd, string makh)
        {
            try
            {
                SqlConnection con = new SqlConnection(Program.strconn);
                con.Open();
                SqlDataAdapter sqladap = new SqlDataAdapter("select * from tb_HopDong where MaHopDong like '%" + mahd + "%' and MaKhachHang like '%" + makh + "%'", con);
                DataSet ds = new DataSet();
                sqladap.Fill(ds, "tb_HopDong");
                dtgv_xemHD.DataSource = ds.Tables["tb_HopDong"].DefaultView;
                
            }
            catch
            {
                MessageBox.Show("Lỗi CSDL","Lỗi !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        DataTable DS_NhanVien()
        {
            SqlConnection con = new SqlConnection(Program.strconn);
            con.Open();
            SqlDataAdapter adap = new SqlDataAdapter("select * from tb_NhanVirn", con);
            DataTable ds = new DataTable();
            adap.Fill(ds);
            return ds;
        }
        DataTable DS_HopDong()
        {
            SqlConnection con = new SqlConnection(Program.strconn);
            con.Open();
            SqlDataAdapter adap = new SqlDataAdapter("select * from tb_HopDong",con);
            DataTable ds = new DataTable();
            adap.Fill(ds);
            return ds;
        }
        private void thanhtoan()
        {
            int tongtien = 0;

            SqlConnection con = new SqlConnection(Program.strconn);
            con.Open();
            SqlCommand sqlcm = new SqlCommand("insert into tb_ChiTietHopDong values()");
            if (dtp_NgayThanhToan.Value > dtp_ThoihanHD.Value)
            {
                tongtien = 
            }
        }
        private void btn_XemHopDong_Click(object sender, EventArgs e)
        {
            if (cbb_MaHD.Text == "" || cbb_MaKH.Text== "") 
            { 
                MessageBox.Show("Các trường không được để trống","Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                timHD(cbb_MaHD.SelectedValue.ToString(), cbb_MaKH.SelectedValue.ToString());
                
            }
            
        }

        private void dtp_NgayThanhToan_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_ThoihanHD.Value < dtp_NgayThanhToan.Value)
            {
                txt_tienphat.Visible = true;
                lbl_tienphat.Visible = true;
            }
            else
            {
                txt_tienphat.Visible = false;
                lbl_tienphat.Visible = false;
            }
        }

        private void cb_xacnhan_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_xacnhan.Checked == true)
            {
                btn_thanhtoan.Visible = true;
            }
            else
            {
                btn_thanhtoan.Visible = false;
            }
        }
    }
}
