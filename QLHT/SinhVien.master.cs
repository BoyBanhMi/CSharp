using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SinhVien : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnDangXuat_Click(object sender, EventArgs e)
    {
        Session["MaSV"] = "";
        Response.Redirect("DangNhap.aspx");
    }
    protected void btnTrangChu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TrangChu.aspx");
    }
}
