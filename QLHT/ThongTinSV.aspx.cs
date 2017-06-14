using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
public partial class ThongTinSV : System.Web.UI.Page
{
    //string connString = "server=127.0.0.1:50000;database = QLHT;uid=thanh;pwd=abc121179";
    protected void Page_Load(object sender, EventArgs e)
    {
        OleDbConnection connString = new OleDbConnection(DB2Connect.strconn);
        connString.Open();
        if (Session["MaSV"] == null)
            Response.Redirect ("TrangChu.aspx");
        else
        {

            OleDbCommand cmd = new OleDbCommand("SELECT MaSV,HoSV,TenSV,NgaySinh,AnhSV,NoiSinh,Email,MaLop,CASE WHEN GioiTinh = 1 THEN N'Nam' ELSE N'Nữ' END GioiTinh,TenNganh FROM db2admin.SinhVien,db2admin.NganhHoc WHERE db2admin.SinhVien.MaNganh=db2admin.NganhHoc.MaNganh AND MaSV='" + Session["MaSV"].ToString() + "'", connString);
            OleDbDataReader reader;
            string str = "";
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    str = "<br>" + "- Mã sinh viên: " + reader["MaSV"] + "<br><br>"
                        + "- Họ tên: " + reader["HoSV"] + " " + reader["TenSV"] + "<br><br>"
                        + "- Ngày sinh: " + string.Format("{0,10:dd-MM-yyyy}", reader["NgaySinh"]) + "<br><br>"
                        + "- Giới tính: " + reader["GioiTinh"] + "<br><br>"
                        + "- Nơi sinh: " + reader["NoiSinh"] + "<br><br>"
                        + "- Email: " + reader["Email"] + "<br><br>"
                        + "- Ngành học: " + reader["TenNganh"] + "<br><br>"
                        + "- Lớp: " + reader["MaLop"] + "<br><br>";
                    Image2.ImageUrl = "~/Images/" + reader["AnhSV"];
                }
            }
            lblTTSV.Text = str;
        }
    }
}