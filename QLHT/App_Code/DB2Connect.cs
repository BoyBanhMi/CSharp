using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
/// <summary>
/// Summary description for DB2Connect
/// </summary>
public class DB2Connect
{
    public static string strconn = @"Provider=IBMOLEDB.DB2COPY1;Data Source=demoDB; Password=admin; User ID=db2admin;Location=localhost";
          
            
    public static void DangNhap(string maSV, string MatKhau)
    {
        try
        {
            OleDbConnection conn = new OleDbConnection(strconn);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("select TenSV from DB2ADMIN.SinhVien where MaSV = '" + maSV + "' and MatKhau = '" + MatKhau + "'", conn);
            OleDbDataReader dr = cmd.ExecuteReader();
            string tenSV = "";
            if (dr.Read())
            {
                tenSV = dr[0].ToString();
                WebMsgBox.Show(tenSV);
            }
        }
        catch
        {
            WebMsgBox.Show("Loi CSDL");
        }
    }
    public static void NhapSV(string masv, string hosv, string tensv,string matkhau, string anhsv, string ngaysinh, bool gioitinh, string noisinh, string email, string manganh, string malop)
    {
        try
        {
            OleDbConnection conn = new OleDbConnection(strconn);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("insert into qlsv.SinhVien values ('"+masv+"','"+hosv+"','"+tensv+"','"+matkhau+"','"+anhsv+"','"+ngaysinh+"','"+gioitinh+"','"+noisinh+"','"+email+"','"+manganh+"','"+malop+"')",conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            WebMsgBox.Show("Thêm thành công");
        }
        catch
        {
            WebMsgBox.Show("Lỗi CSDL");
        }
    }

}