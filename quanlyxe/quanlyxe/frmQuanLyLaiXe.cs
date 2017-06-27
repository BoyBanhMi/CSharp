﻿using System;
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
    public partial class frmQuanLyLaiXe : Form
    {
       
        public frmQuanLyLaiXe()
        {
            InitializeComponent();
        }
        private void Load_MaLaiXe()
        {
            SqlConnection con = new SqlConnection(Program.strconn);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select MaLaiXe from tb_LaiXe", con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            txtMaLaiXe.DataSource = dt;
            txtMaLaiXe.DisplayMember = "MaLaiXe";
            txtMaLaiXe.ValueMember = "MaLaiXe";
            con.Close();
            da.Dispose();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public DataTable DS_LaiXe()
        {
            SqlConnection con = new SqlConnection(Program.strconn);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select MaLaiXe as [Mã lái xe], TenLaiXe as [Tên lái xe], NgaySinh as [Ngày sinh], GioiTinh as [Giới tính], DiaChi as [ Địa chỉ], DienThoai as [Điện thoại], CMND, Email, NgayNhanViec as [Ngày nhận vệc] from tb_LaiXe ", con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            return dt;
            con.Close();
            da.Dispose();
        }
        private void cmdThem_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection(Program.strconn);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into tb_LaiXe (MaLaiXe, TenLaiXe, NgaySinh, GioiTinh, DiaChi, DienThoai, CMND,Email, NgayNhanViec,TinhTrangLaiXe) values ('" + txtMaLaiXe.Text + "', N'" + txtTenLaiXe.Text + "', '" + dtpNgaySinh.Text + "','" + txtGioiTinh.Text + "', N'" + txtDiaChi.Text + "', '" + txtDienThoai.Text + "', '" + txtCMND.Text + "', '" + txtEmail.Text + "', '" + dtpNgayNhanViec.Text + "', N'" + txtTinhTrangLaiXe.Text + "')", con);
                cmd.ExecuteNonQuery();
                dgvQuanLyLaiXe.DataSource = DS_LaiXe() ;
                con.Close();
                MessageBox.Show("Thêm thành công", "Quản lý lái xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
             catch
             {
               MessageBox.Show("Thêm thất bại, Lỗi CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            dgvQuanLyLaiXe.DataSource = DS_LaiXe();
        }

        private void cmdTimKiem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.strconn);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select MaLaiXe as [Mã lái xe], TenLaiXe as [Tên lái xe], NgaySinh as [Ngày sinh], GioiTinh as [Giới tính], DiaChi as [ Địa chỉ], DienThoai as [Điện thoại], CMND, Email, NgayNhanViec as [Ngày nhận vệc] from tb_LaiXe Where MaLaiXe = ('" + txtMaLaiXe.Text + "')", con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dgvQuanLyLaiXe.DataSource = dt;
            con.Close();
            da.Dispose();
        }

        private void frmQuanLyLaiXe_Load(object sender, EventArgs e)
        {
            Load_MaLaiXe();
            
            dgvQuanLyLaiXe.DataSource = DS_LaiXe();
            
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {

            try
            {

                SqlConnection con = new SqlConnection(Program.strconn);
                con.Open();
                SqlCommand cmd = new SqlCommand("update  tb_LaiXe set TenLaiXe = N'" + txtTenLaiXe.Text + "', NgaySinh = '" + dtpNgaySinh.Text + "', GioiTinh = '" + txtGioiTinh.Text + "', DiaChi = N'" + txtDiaChi.Text + "', DienThoai = '" + txtDienThoai.Text + "', CMND = '" + txtCMND.Text + "', Email = '" + txtEmail.Text + "', NgayNhanViec = '" + dtpNgayNhanViec.Text + "', TinhTrangLaiXe = N'" + txtTinhTrangLaiXe.Text + "' where MaLaiXe = '" + txtMaLaiXe.Text + "' ", con);
                cmd.ExecuteNonQuery();
                dgvQuanLyLaiXe.DataSource = DS_LaiXe();
                MessageBox.Show("Sửa thành công", "Quản lý lái xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Sửa thất bại, Lỗi CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(Program.strconn);
            con.Open();

            
            SqlCommand cmd = new SqlCommand("delete tb_LaiXe where Malaixe = '" + txtMaLaiXe.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();

            dgvQuanLyLaiXe.DataSource = DS_LaiXe();
            MessageBox.Show("Xóa lái xe thành công", "Quản lý lái xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
