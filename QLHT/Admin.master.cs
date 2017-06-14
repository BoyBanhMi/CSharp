using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
public partial class Admin : System.Web.UI.MasterPage
{
    //string connString = "server=127.0.0.1:50000;database = QLHT;uid=thanh;pwd=abc121179";
    protected void Page_Load(object sender, EventArgs e)
    {
        OleDbConnection conn = new OleDbConnection(DB2Connect.strconn);
        conn.Open();
        OleDbCommand cmd = new OleDbCommand("SELECT * FROM db2admin.MenuHeThong ORDER BY Menu", conn);
        OleDbDataReader reader;
        string str = "";
        lblMenu.Text = "<br/>";
        reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            str = string.Format("<a href=" + reader["LinkWeb"] + ">{0}</a><br/><hr/>", reader["Menu"]);
            
            lblMenu.Text = lblMenu.Text + str;
        }
        lblNguoiDung.Text = "Người dùng: " + Session["TenDN"].ToString();
    }
    protected void btnTrangChu_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin.aspx");
    }
    protected void btnDangXuat_Click(object sender, EventArgs e)
    {
        Session["TenDN"] = null;
        Response.Redirect("DangNhapHeThong.aspx");
    }
}
