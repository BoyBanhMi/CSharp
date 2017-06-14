using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.OleDb;
public partial class TimKiem : System.Web.UI.Page
{
    OleDbConnection connString = new OleDbConnection(DB2Connect.strconn);
    DataTable SinhVienDS_MaSV(string maSV)
    {
        string sql = "SELECT ROW_NUMBER() OVER (ORDER BY MaSV)  STT, MaSV,HoSV,TenSV,Day(NgaySinh) CONCAT '/' CONCAT Month(NgaySinh) CONCAT '/' CONCAT Year(NgaySinh) NgaySinh,CASE WHEN GioiTinh = 1 THEN N'Nam' ELSE N'Nữ' END GioiTinh,NoiSinh,Email,MaLop,TenNganh FROM db2admin.SinhVien,db2admin.NganhHoc WHERE db2admin.SinhVien.MaNganh=db2admin.NganhHoc.MaNganh AND Upper(MaSV)=Upper('" + maSV + "') ORDER BY TenSV";
        OleDbDataAdapter ad = new OleDbDataAdapter(sql, connString);
        DataTable ds = new DataTable();
        ad.Fill(ds);
        return ds;
    }
    DataTable SinhVienDS_HoTen(string hoTen)
    {
        string sql = "SELECT ROW_NUMBER() OVER (ORDER BY MaSV)  STT,MaSV,HoSV,TenSV,NgaySinh,CASE WHEN GioiTinh = 1 THEN N'Nam' ELSE N'Nữ' END GioiTinh,NoiSinh,Email,MaLop,TenNganh FROM db2admin.SinhVien,db2admin.NganhHoc WHERE db2admin.SinhVien.MaNganh=db2admin.NganhHoc.MaNganh AND ((Upper(HoSV) LIKE Upper('%" + hoTen + "%')) OR (Upper(TenSV) LIKE Upper('%" + hoTen + "%')))ORDER BY TenSV";
        OleDbDataAdapter ad = new OleDbDataAdapter(sql, connString);
        DataTable ds = new DataTable();
        ad.Fill(ds);
        return ds;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        
        
    }
    protected void btnTim_Click(object sender, EventArgs e)
    {
        if (dropTim.SelectedValue.ToString() == "1")
           gridDS.DataSource = SinhVienDS_MaSV(txtTim.Text);
       
        else
            gridDS.DataSource = SinhVienDS_HoTen(txtTim.Text);
        gridDS.DataBind();
        if (gridDS.Rows.Count > 0)
        {
            lblTB.Text = "Danh sách có " + gridDS.Rows.Count.ToString() + " sinh viên.";
            gridDS.HeaderRow.Cells[1].Text = "Mã SV";
            gridDS.HeaderRow.Cells[2].Text = "Họ sinh viên";
            gridDS.HeaderRow.Cells[3].Text = "Tên SV";
            gridDS.HeaderRow.Cells[4].Text = "Ngày sinh";
            gridDS.HeaderRow.Cells[5].Text = "Giới tính";
            gridDS.HeaderRow.Cells[6].Text = "Nơi sinh";
            gridDS.HeaderRow.Cells[7].Text = "Email";
            gridDS.HeaderRow.Cells[8].Text = "Lớp học";
            gridDS.HeaderRow.Cells[9].Text = "Ngành học";
        }
        else
        {
            lblTB.Text = "Không có sinh viên cần tìm.";
        }
         
    }
    protected void btnDangNhapHT_Click(object sender, EventArgs e)
    {
        Response.Redirect("DangNhap.aspx");
    }
    protected void btnTrangChu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TrangChu.aspx");
    }
    protected void btnHuongDan_Click(object sender, EventArgs e)
    {

    }
    protected void btnDangXuat_Click(object sender, EventArgs e)
    {
        Session["MaSV"] = "";
        Response.Redirect("DangNhap.aspx");
    }
}