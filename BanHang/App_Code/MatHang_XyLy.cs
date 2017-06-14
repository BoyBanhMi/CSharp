using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
/// <summary>
/// Summary description for MatHang
/// </summary>
public static class MatHang_XuLy
{
    public static void Them(string Mamh, string Tenmh, int DonGia, string loaimh)
    {
        OleDbConnection con = new OleDbConnection(dbconnect.StrConn);
        con.Open();
        OleDbCommand cmd = new OleDbCommand("insert into admin.MatHang1 values('"+Mamh+"', '"+Tenmh+"', '"+DonGia+"','"+loaimh+"')",con);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public static void Sua(string Mamh, string Tenmh, int DonGia, string loaimh)
    {
        OleDbConnection con = new OleDbConnection(dbconnect.StrConn);
        con.Open();
        OleDbCommand cmd = new OleDbCommand("update admin.MatHang1 set TenMH='" + Tenmh + "',DonGia='" + DonGia + "', MaLMH='" + loaimh + "' where MaMH='" + Mamh + "' ", con);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public static void Xoa(string Mamh)
    {
        OleDbConnection con = new OleDbConnection(dbconnect.StrConn);
        con.Open();
        OleDbCommand cmd = new OleDbCommand("delete from admin.MatHang1 where MaMH='"+Mamh+"'", con);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public static DataTable DS_MatHang()
    {
        OleDbConnection con = new OleDbConnection(dbconnect.StrConn);
        con.Open();
        OleDbDataAdapter adap = new OleDbDataAdapter("select * from admin.MatHang1",con);
        DataTable ds = new DataTable();
        adap.Fill(ds);
        return ds;
    }
    public static DataTable DS_LoaiMH()
    {
        OleDbConnection con = new OleDbConnection(dbconnect.StrConn);
        con.Open();
        OleDbDataAdapter adap = new OleDbDataAdapter("select * from admin.LoaiMH", con);
        DataTable ds = new DataTable();
        adap.Fill(ds);
        return ds;
    }
}