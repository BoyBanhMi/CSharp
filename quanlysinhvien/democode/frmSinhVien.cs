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
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            cbb_Khoa.DataSource = Khoa_DS();
            cbb_Khoa.DisplayMember = "TenKhoa";
            cbb_Khoa.ValueMember = "MaKhoa";

            dataGridViewSV.DataSource = SinhVien_DS();

        }
        public void Them_SV(string masv, string hosv, string tensv, string gioitinh, string ngaysinh, string noisinh, string makhoa)
        {
            try
            {
                if (txt_MaSV.Text == "")
                {
                    MessageBox.Show("Mã Sinh Viên Không được trống", "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlConnection con = new SqlConnection(Program.strconn);
                    con.Open();
                    string cmd = "INSERT INTO tb_SinhVien VALUES(N'" + masv + "',N'" + hosv + "',N'" + tensv + "',N'" + gioitinh + "','" + ngaysinh + "',N'" + noisinh + "','" + makhoa + "')";
                    SqlCommand sqlCmd = new SqlCommand(cmd, con);
                    sqlCmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Thêm thành công", "Thêm Sinh Viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Thêm thất bại", "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }
        void suasv(string masv, string hosv, string tensv, string gioitinh, string ngaysinh, string noisinh, string makhoa)
        {
            try
            {
                if (txt_MaSV.Text == "")
                {
                    MessageBox.Show("Mã Sinh Viên Không được trống", "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlConnection connDB = new SqlConnection(Program.strconn);
                    connDB.Open();
                    string cmd = "UPDATE tb_SinhVien SET MaSinhVien='" + masv + "',HoSinhVien='" + hosv + "',TenSinhVien='" + tensv + "', GioiTinh='" + gioitinh + "',NgaySinh = '" + ngaysinh + "', NoiSinh='" + noisinh + "', MaKhoa='" + makhoa + "'";
                    SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
                    sqlCmd.ExecuteNonQuery();
                    connDB.Close();
                    MessageBox.Show("Sửa thành công", "Thêm Sinh Viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Sửa thất bại", "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void xoasv(string masv)
        {
            try
            {
                if (txt_MaSV.Text == "")
                {
                    MessageBox.Show("Mã Sinh Viên Không được trống", "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlConnection connDB = new SqlConnection(Program.strconn);
                    connDB.Open();
                    string cmd = "DELETE FROM tb_SinhVien WHERE MaSinhVien='" + masv + "'";
                    SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
                    sqlCmd.ExecuteNonQuery();
                    connDB.Close();
                    MessageBox.Show("Xóa thành công", "Xóa Sinh Viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Xóa thất bại", "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        DataTable Khoa_DS()
        {
         string cmd = "SELECT * FROM tb_Khoa";
         SqlDataAdapter adap = new SqlDataAdapter(cmd, Program.strconn);
         DataTable ds = new DataTable ();
         adap.Fill(ds);
         return ds;
        }
        DataTable SinhVien_DS()
        {
            string cmd = "SELECT* FROM tb_SinhVien";
            SqlDataAdapter adap = new SqlDataAdapter(cmd, Program.strconn);
            DataTable ds = new DataTable();
            adap.Fill(ds);
            return ds;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            xoasv(txt_MaSV.Text);
            dataGridViewSV.DataSource = SinhVien_DS();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string gt = "Nam";
            if (rb_Nam.Checked)
                gt = "Nam";
            else
                gt = "Nữ";
            Them_SV(txt_MaSV.Text,txt_HoSV.Text,txt_TenSV.Text,gt.ToString(),txt_NgaySinh.Text,txt_NoiSInh.Text,cbb_Khoa.SelectedValue.ToString());
            dataGridViewSV.DataSource = SinhVien_DS();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string gt = "Nam";
            if (rb_Nam.Checked)
                gt = "Nam";
            else
                gt = "Nữ";
            suasv(txt_MaSV.Text, txt_HoSV.Text, txt_TenSV.Text, gt.ToString(), txt_NgaySinh.Text, txt_NoiSInh.Text, cbb_Khoa.SelectedValue.ToString());
            dataGridViewSV.DataSource = SinhVien_DS();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gb_GioiTinh_Enter(object sender, EventArgs e)
        {
           
        }

    }
}
// MaSinhVien as [Mã Sinh Viên], HoSinhVien as [Họ Sinh Viên], TenSinhVien as [Tên Sih Viên], GioiTinh as [Giới Tính], NgaySinh as [Ngày Sinh] NoiSinh as [Nơi SInh], MaKhoa as [Mã Khoa]