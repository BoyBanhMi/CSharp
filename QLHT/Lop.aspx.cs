using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.OleDb;
using System.Data;

public partial class Lop : System.Web.UI.Page
{
    //string strConn= "Provider=IBMDADB2.DB2COPY1;Data Source=QLHT; Password=abc121179;User ID=thanh; Location=localhost";
    void lopHoc_ThemOleDB(string maLop, string tenLop)
    {
        OleDbConnection connDB = new OleDbConnection(DB2Connect.strconn);
        OleDbCommand cmd = new OleDbCommand("INSERT INTO db2admin.LopHoc VALUES(N'" + maLop + "','" + tenLop + "')", connDB);
        connDB.Open();
        cmd.ExecuteNonQuery();
        connDB.Close();
    }
    //Ham sua
    void lopHoc_SuaOleDB(string maLop, string tenLop)
    {
        OleDbConnection connDB = new OleDbConnection(DB2Connect.strconn);
        OleDbCommand cmd = new OleDbCommand("UPDATE db2admin.LopHoc SET TenLop='" + tenLop + "' WHERE MaLop='" + maLop + "'", connDB);
        connDB.Open();
        cmd.ExecuteNonQuery();
        connDB.Close();
    }
    //Ham xoa
    void lopHoc_XoaOleDB(string maLop)
    {
        OleDbConnection connDB = new OleDbConnection(DB2Connect.strconn);
        OleDbCommand cmd = new OleDbCommand("DELETE FROM db2admin.LopHoc WHERE MaLop='" + maLop + "'", connDB);
        connDB.Open();
        cmd.ExecuteNonQuery();
        connDB.Close();
    }

    //Hàm trả về danh sách các lớp có trong CSDL
    DataTable LopDS()
    {
        OleDbDataAdapter da = new OleDbDataAdapter("SELECT ROW_NUMBER() OVER (ORDER BY db2admin.LopHoc.TenLop)  STT, MaLop,TenLop FROM db2admin.LopHoc ORDER BY TenLop", DB2Connect.strconn);
        DataTable ds = new DataTable();
        da.Fill(ds);
        return ds;
    }


    protected void Page_Load(object sender, EventArgs e)
    {
        GridView1.DataSource = LopDS();
        GridView1.DataBind();
        GridView1.HeaderRow.Cells[1].Text = "Mã lớp";
        GridView1.HeaderRow.Cells[2].Text = "Tên lớp";

    }
    protected void btnThem_Click(object sender, EventArgs e)
    {
        try
        {
            lopHoc_ThemOleDB(txtMaLop.Text, txtTenLop.Text);
            lblTB.Text = "Đã thêm vào thành công.";
            GridView1.DataSource = LopDS();
            GridView1.DataBind();
            GridView1.HeaderRow.Cells[1].Text = "Mã lớp";
            GridView1.HeaderRow.Cells[2].Text = "Tên lớp";

        }
        catch
        {
            lblTB.Text = "Không thể thêm thông tin này. Vui lòng kiểm tra lại.";
        }
    }
    protected void btnSua_Click(object sender, EventArgs e)
    {
        lopHoc_SuaOleDB(txtMaLop.Text, txtTenLop.Text);
        GridView1.DataSource = LopDS();
        GridView1.DataBind();
        GridView1.HeaderRow.Cells[1].Text = "Mã lớp";
        GridView1.HeaderRow.Cells[2].Text = "Tên lớp";

    }
    protected void btnXoa_Click(object sender, EventArgs e)
    {
        lopHoc_XoaOleDB(txtMaLop.Text);
        GridView1.DataSource = LopDS();
        GridView1.DataBind();
        GridView1.HeaderRow.Cells[1].Text = "Mã lớp";
        GridView1.HeaderRow.Cells[2].Text = "Tên lớp";

    }
}