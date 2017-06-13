using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class TrangChu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_DangNhap_Click(object sender, EventArgs e)
    {
        try
        {
            //Tạo kết nối
            OleDbConnection con = new OleDbConnection(DB_Connect.StrConn);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select TenSV from db2admin.SinhVien where MaSV='"+txt_MaSV.Text+"' and MatKhau='"+txt_MatKhau.Text+"'",con);
            OleDbDataReader dr = cmd.ExecuteReader();
            if(dr.HasRows)
            {
                //lbl_Thongbao.Text = "Đăng Nhập thành Công !!!!";
                Response.Redirect("ThemMH.aspx");
            }
            else
            {
                lbl_Thongbao.Text = "SAi Mật Khẩu hoặc tài Khoản ????";
            }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           

        }
        catch
        {
            lbl_Thongbao.Text = "Lỗi CSDL";
        }
    }
}