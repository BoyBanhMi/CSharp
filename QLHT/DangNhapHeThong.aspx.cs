using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

public partial class DangNhapHeThong : System.Web.UI.Page
{
    //string connString = "server=127.0.0.1:50000;database = QLHT;uid=thanh;pwd=abc121179";
    bool KiemTraDN(string tenDN, string matKhau)
    {
        
            OleDbConnection conn = new OleDbConnection(DB2Connect.strconn);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT TenSV FROM db2admin.SinhVien WHERE MaSV='" + tenDN + "' AND MatKhau='" + matKhau + "'", conn);
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
                return true;
            else
                return false;
            
        
        
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnDangNhap_Click(object sender, EventArgs e)
    {
        if (KiemTraDN(txtTenDN.Text, txtMatKhau.Text) == true)
        {
            try
            {

                WebMsgBox.Show("Đăng nhập thành công");
                Session["TenDN"] = txtTenDN.Text;
                Response.Redirect("Admin.aspx");

            }
            catch
            {
                WebMsgBox.Show("Đăng nhậpthất bại");
            } 
            
        }
        else
        {
            Session["TenDN"] = "";
            lblTB.Text = "Thông tin đăng nhập không chính xác!";
        }

    }
}