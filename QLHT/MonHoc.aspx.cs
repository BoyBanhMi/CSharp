using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.OleDb;

public partial class MonHoc : System.Web.UI.Page
{
    string connString2 = "Provider=IBMOLEDB.DB2COPY1;Data Source=qlsv;Password=admin;User ID=db2admin;Location=localhost";
    //string connString2 = "server=127.0.0.1:50000;database = qlsv;uid=db2admin;pwd=admin";
    void monHoc_ThemOleDB(string maMH, string tenMH, byte soDVHT)
    {
        OleDbConnection connDB = new OleDbConnection(connString2);
        OleDbCommand cmd = new OleDbCommand("INSERT INTO qlsv.MonHoc VALUES(N'" + maMH + "','" + tenMH + "','" + soDVHT + "')", connDB);
        connDB.Open();
        cmd.ExecuteNonQuery();
        connDB.Close();
    }
    void monHoc_ThemDB2(string maMH, string tenMH, byte soDVHT)
    {
        OleDbConnection connDB = new OleDbConnection(connString2);
        OleDbCommand cmd = new OleDbCommand("INSERT INTO qlsv.MonHoc VALUES(N'" + maMH + "','" + tenMH + "','" + soDVHT + "')", connDB);
        connDB.Open();
        cmd.ExecuteNonQuery();
        connDB.Close();
    }
    void monHoc_ThemDB2Proc(string maMH, string tenMH, int soDVHT)
    {
        OleDbConnection connDB = new OleDbConnection(connString2);
        OleDbCommand cmd = new OleDbCommand("MonHocThem", connDB);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("maMH", OleDbType.VarChar).Value = maMH;
        cmd.Parameters.Add("tenMH", OleDbType.Guid).Value = tenMH;
        cmd.Parameters.Add("soDVHT", OleDbType.Integer).Value = soDVHT;
        connDB.Open();
        cmd.ExecuteNonQuery();
        connDB.Close();
    }
    void monHoc_SuaDB2(string maMH, string tenMH, byte soDVHT)
    {
        OleDbConnection connDB = new OleDbConnection(connString2);
        OleDbCommand cmd = new OleDbCommand("UPDATE  qlsv.MonHoc SET TenMH='" + tenMH + "',SoDVHT='" + soDVHT + "'WHERE MaMH='" + maMH + "'", connDB);
        connDB.Open();
        cmd.ExecuteNonQuery();
        connDB.Close();
    }
    void monHoc_XoaDB2(string maMH)
    {
        OleDbConnection connDB = new OleDbConnection(connString2);
        OleDbCommand cmd = new OleDbCommand("DELETE FROM qlsv.MonHoc WHERE MaMH='" + maMH + "'", connDB);
        connDB.Open();
        cmd.ExecuteNonQuery();
        connDB.Close();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        gridMH.Columns[0].ItemStyle.Width = 100;
    }
    protected void gridMH_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        GridViewRow row;
        row = gridMH .Rows[e.NewSelectedIndex]; 
        txtMaMH.Text = Server.HtmlDecode(row.Cells[1].Text);
        txtTenMH.Text = Server.HtmlDecode(row.Cells[2].Text);
        txtDVHT.Text = Server.HtmlDecode(row.Cells[3].Text);

    }
    protected void btnThem_Click(object sender, EventArgs e)
    {
        try
        {
            monHoc_ThemDB2Proc(txtMaMH.Text, txtTenMH.Text, byte.Parse(txtDVHT.Text));
            //monHoc_ThemOleDB(txtMaMH.Text, txtTenMH.Text, byte.Parse(txtDVHT.Text));
            gridMH.DataBind();
            lblTB.Text = "Đã thêm dữ liệu thành công.";
        }
        catch
        {
            lblTB.Text = "Không thể thêm thông tin này, vui lòng kiểm tra lại.";
        }
    }
    protected void btnSua_Click(object sender, EventArgs e)
    {
        try
        {
        monHoc_SuaDB2(txtMaMH.Text, txtTenMH.Text, byte.Parse(txtDVHT.Text));
        gridMH.DataBind();
        lblTB.Text = "Đã sửa dữ liệu thành công.";
        }
        catch
        {
            lblTB.Text = "Không thể sửa thông tin này, vui lòng kiểm tra lại.";
        }
    }
    protected void btnXoa_Click(object sender, EventArgs e)
    {
        monHoc_XoaDB2(txtMaMH.Text);
        gridMH.DataBind();
    }
}