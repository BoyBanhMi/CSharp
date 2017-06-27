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
            SqlDataAdapter adap = new SqlDataAdapter("select * from tb_NhanVien", con);
            DataTable ds = new DataTable();
            adap.Fill(ds);
            con.Close();
            return ds;
        }
        DataTable DS_HopDong()
        {
            SqlConnection con = new SqlConnection(Program.strconn);
            con.Open();
            SqlDataAdapter adap = new SqlDataAdapter("select * from tb_HopDong",con);
            DataTable ds = new DataTable();
            adap.Fill(ds);
            con.Close();
            return ds;
        }
        DataTable DS_PhieuTra()
        {
            SqlConnection con = new SqlConnection(Program.strconn);
            con.Open();
            SqlDataAdapter adap = new SqlDataAdapter("select * from tb_PhieuTra", con);
            DataTable ds = new DataTable();
            adap.Fill(ds);
            con.Close();
            return ds;
        }
        private void thanhtoan(string mahd, string makh, string manv, string ghichu)
        {
           try
           {

                int gia = 500;
                SqlConnection con = new SqlConnection(Program.strconn);
                
                SqlCommand sqlcm = new SqlCommand("select DAY(NgayLapHopDong),DAY(HanThanhToan), TienCoc, NgayLapHopDong, HanThanhToan,TinhTrangThanhToan,Gia from tb_HopDong where MaHopDong='" + mahd + "'", con);
                SqlCommand sqlc1m = new SqlCommand("select DonGia from tb_Gia where tb_HopDong.MaGia=tb_Gia.MaGia", con);
                con.Open();
                SqlDataReader dr = sqlcm.ExecuteReader();
               
                if (dr.Read())
                {
                    string ngaylapHD = dr[3].ToString();
                    string ngaytra = dr[4].ToString();
                    int ngaylap = Convert.ToInt32(dr[0]);
                    int ngaythanhtoan = Convert.ToInt32(dr[1]);
                    int tiencoc = Convert.ToInt32(dr[2]);
                    long giatien = Convert.ToInt64(dr[6]);
                    long tongtien = Math.Abs((ngaythanhtoan - ngaylap) * giatien - tiencoc);
                    int tinhtrang = Convert.ToInt16(dr[5]);
                    
                    
                    con.Close();
                    if (tinhtrang == 1)
                    {
                        MessageBox.Show("Hợp đồng đã thanh toán" +giatien);
                    }
                    else
                    {


                        SqlCommand nhap = new SqlCommand("insert into tb_PhieuTra values('" + manv + "','" + makh + "','" + mahd + "','" + ngaylapHD + "','" + ngaytra + "','" + tongtien + "','True','" + ghichu + "')", con);
                        con.Open();
                        nhap.ExecuteNonQuery();
                        SqlCommand update = new SqlCommand("update tb_HopDong set TinhTrangThanhToan = 'True' where MaHopDong = '" + mahd + "'", con);
                        update.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Thanh Toán Thành công");
                    }
                }
           }
           catch
           {
              MessageBox.Show("Hợp đồng đã được thanh toán");
          }
            
        }
        private void btn_XemHopDong_Click(object sender, EventArgs e)
        {
            try
            {


                if (cbb_MaHD.Text == "" || cbb_MaKH.Text == "")
                {
                    MessageBox.Show("Các trường không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    timHD(cbb_MaHD.SelectedValue.ToString(), cbb_MaKH.SelectedValue.ToString());

                }
            }
            catch
            {
                MessageBox.Show("Hợp dồng không tồn tại","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

        private void dtp_NgayThanhToan_ValueChanged(object sender, EventArgs e)
        {
            
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

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            thanhtoan(cbb_MaHD.Text, cbb_MaKH.Text, cbb_NhanVien.SelectedValue.ToString(), txt_ghichu.Text);
            dtp_chitiet.DataSource = DS_PhieuTra();
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            frmInPhieuTra f = new frmInPhieuTra();
            f.Show();
        }
    }
}
