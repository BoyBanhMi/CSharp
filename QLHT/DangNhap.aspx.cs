using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using IBM.Data;
//using IBM.Data.DB2;
using System.Data;
using System.Data.OleDb;
public partial class TrangChu : System.Web.UI.Page
{
    string connString = @"Provider=IBMOLEDB.DB2COPY1;Data Source=demoDB;Password=admin ;User ID=db2admin;Location=localhost";
    bool KiemTraDN(string maSV, string matKhau)
    {
       OleDbConnection dbCon = new OleDbConnection(connString);
            dbCon.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT MaSV FROM db2admin.SinhVien WHERE MaSV='" + maSV + "' AND 	MatKhau='" + matKhau + "'", dbCon);
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows){
                return true;
            }

            else
            {
                return false;
            }
 
    }
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnDangNhap_Click(object sender, EventArgs e)
    {
        if (KiemTraDN(txtMaSV.Text, txtMatKhau.Text) == true)
        {
            Session["MaSV"] = txtMaSV.Text;
            Response.Redirect("ThongTinSV.aspx");
           
        }
        else
        {
            Session["MaSV"] = "";
            lblTB.Text = "Thông tin đăng nhập không chính xác!";
        }
    }
    protected void btnTrangChu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TrangChu.aspx");
    }
}