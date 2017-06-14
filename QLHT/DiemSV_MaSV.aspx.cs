using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;
public partial class DiemSV_MaSV : System.Web.UI.Page
{
    //string connString = "server=127.0.0.1:50000;database = QLSV;uid=db2admin;pwd=admin";
    
    DataTable SinhVienDS(string maSV)
    {
        OleDbConnection connString = new OleDbConnection(DB2Connect.strconn);
        connString.Open();
        string sql = "SELECT ROW_NUMBER() OVER (ORDER BY db2admin.MonHoc.MaMH)  STT, db2admin.MonHoc.MaMH,TenMH,SoDVHT,DiemKT,DiemThi,(DiemKT+DiemThi)/2 DiemTK FROM db2admin.MonHoc,db2admin.KetQua WHERE (db2admin.MonHoc.MaMH=qlsv.KetQua.MaMH) and (MaSV='" + maSV + "')";
        OleDbDataAdapter ad = new OleDbDataAdapter(sql, connString);
        DataTable ds = new DataTable();
        ad.Fill(ds);
        return ds;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["MaSV"] == null)
            Response.Redirect("TrangChu.aspx");
        else
        {
            string MaSV = Session["MaSV"].ToString();
            gridDiem.DataSource = SinhVienDS(MaSV);
            gridDiem.DataBind();
            if (gridDiem.Rows.Count > 0)
            {
                gridDiem.HeaderRow.Cells[1].Text = "Mã MH";
                gridDiem.HeaderRow.Cells[2].Text = "Tên môn học";
                gridDiem.HeaderRow.Cells[3].Text = "Số ĐVHT";
                gridDiem.HeaderRow.Cells[4].Text = "Điểm KT";
                gridDiem.HeaderRow.Cells[5].Text = "Điểm thi";
                gridDiem.HeaderRow.Cells[6].Text = "Điểm KQ";
            }
        }
    }
}