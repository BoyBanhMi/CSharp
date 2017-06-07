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

namespace democode
{
    public partial class frmTimKiemSinhVien : Form
    {
        public frmTimKiemSinhVien()
        {
            InitializeComponent();
        }

        private void frmTimKiemSinhVien_Load(object sender, EventArgs e)
        {
            //dtgv_timkiem.DataSource = timtensinhvien(txt_tim.Text);
            lbl_thongke.Text = "Tổng số sinh viên " + dtgv_timkiem.RowCount.ToString();
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {/*
            SqlConnection con = new SqlConnection(Program.strconn);
            con.Open();
            if (rb_MaSV.Checked == true)
            {
                
                SqlDataAdapter adap = new SqlDataAdapter("select * from tb_SinhVien where MaSinhVien like '%"+txt_tim+"%'",con);
                DataSet ds = new DataSet();
                adap.Fill(ds, "tb_SinhVien");
                dtgv_timkiem.DataSource = ds.Tables["tb_SinhVien"].DefaultView;
                
            }
            if (rb_Tensv.Checked == true)
            {

            }
            if (rb_tenkhoa.Checked == true)
            {

            }*/
        }

        DataTable timtensinhvien(string tensv)
        {
            SqlConnection con = new SqlConnection(Program.strconn);
            con.Open();
            SqlDataAdapter adap = new SqlDataAdapter("select row_number() over (order by MaSinhVien) as STT, MaSinhVien as [Mã Sinh Viên], HoSinhVien as [Họ Sinh Vien], TenSinhVien as [Tên Sinh Viên], GioiTinh as [Giới Tính], NgaySinh as [Ngày Sinh], Noisinh as [Nơi Sinh], MaKhoa as [Mã Khoa] from tb_SinhVien where TenSinhVien like '"+txt_tim.Text+"'",con);
            DataTable ds = new DataTable();
            adap.Fill(ds);
            return ds;
        }

        private void txt_tim_TextChanged(object sender, EventArgs e)
        {
            //dtgv_timkiem.DataSource = timtensinhvien(txt_tim.Text);
            
            SqlConnection con = new SqlConnection(Program.strconn);
            con.Open();
            lbl_thongke.Text = "Tổng số sinh viên " + dtgv_timkiem.RowCount.ToString();
            if (rb_Tensv.Checked == true)
            {

                SqlDataAdapter adap = new SqlDataAdapter("select row_number() over (order by MaSinhVien) as STT,  MaSinhVien as [Mã Sinh Viên], HoSinhVien as [Họ Sinh Viên], TenSinhVien as [Tên Sinh Viên], GioiTinh as [Giới Tính], NgaySinh as [Ngày Sinh], Noisinh as [Nơi Sinh], MaKhoa as [Mã Khoa] from tb_SinhVien where TenSinhVien like '%" + txt_tim.Text + "%'", con);
                DataSet ds = new DataSet();
                adap.Fill(ds, "tb_SinhVien");
                dtgv_timkiem.DataSource = ds.Tables["tb_SinhVien"].DefaultView;
                con.Close();
            }
            if (rb_MaSV.Checked == true)
            { //case when gioitinh = 1 then 'Nam' else n'Nữ' end as gioitinh
                SqlDataAdapter adap = new SqlDataAdapter("select row_number() over (order by MaSinhVien) as STT,  MaSinhVien as [Mã Sinh Viên], HoSinhVien as [Họ Sinh Viên], TenSinhVien as [Tên Sinh Viên], GioiTinh as [Giới Tính], NgaySinh as [Ngày Sinh], Noisinh as [Nơi Sinh], MaKhoa as [Mã Khoa] from tb_SinhVien where MaSinhVien like '%" + txt_tim.Text + "%'", con);
                DataSet ds = new DataSet();
                adap.Fill(ds, "tb_SinhVien");
                dtgv_timkiem.DataSource = ds.Tables["tb_SinhVien"].DefaultView;
                con.Close();
            }
            if (rb_tenkhoa.Checked == true)
            {
                SqlDataAdapter adap = new SqlDataAdapter("select row_number() over (order by MaSinhVien) as STT,  MaSinhVien as [Mã Sinh Viên], HoSinhVien as [Họ Sinh Viên], TenSinhVien as [Tên Sinh Viên], GioiTinh as [Giới Tính], NgaySinh as [Ngày Sinh], Noisinh as [Nơi Sinh], MaKhoa as [Mã Khoa] from tb_SinhVien where MaKhoa like '%" + txt_tim.Text + "%'", con);
                DataSet ds = new DataSet();
                adap.Fill(ds, "tb_SinhVien");
                dtgv_timkiem.DataSource = ds.Tables["tb_SinhVien"].DefaultView;
                con.Close();
            }
             
        }

        private void lbl_thongke_Click(object sender, EventArgs e)
        {

        }
    }
}
