using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

/// <summary>
/// Summary description for MonHoc_XuLy
/// </summary>
public static class MonHoc_XuLy
{
	public static void Them(string Mamh, string tenmh, byte dvht)
	{
            OleDbConnection con = new OleDbConnection(DB_Connect.StrConn);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("insert into db2admin.MonHoc values('" + Mamh + "','" + tenmh + "','" + dvht + "') ", con);
            cmd.ExecuteNonQuery();
            con.Close();
        
	}
    public static void sua(string Mamh, string tenmh, byte dvht)
    {
        OleDbConnection con = new OleDbConnection(DB_Connect.StrConn);
        con.Open();
        OleDbCommand cmd = new OleDbCommand("update db2admin.MonHoc set TenMH='" + tenmh + "',SoDVHT='" + dvht + "' where MaMH='"+Mamh+"' ", con);
        cmd.ExecuteNonQuery();
        con.Close();

    }
    public static void xoa(string Mamh)
    {
        OleDbConnection con = new OleDbConnection(DB_Connect.StrConn);
        con.Open();
        OleDbCommand cmd = new OleDbCommand("delete from db2admin.MonHoc where MaMH='"+Mamh+"'", con);
        cmd.ExecuteNonQuery();
        con.Close();

    }
    public static DataTable DS_MonHoc()
    {
        OleDbConnection con = new OleDbConnection(DB_Connect.StrConn);
        con.Open();
        OleDbDataAdapter adap = new OleDbDataAdapter("select * from  db2admin.MonHoc", con);
        DataTable ds = new DataTable();
        adap.Fill(ds);
        return ds;
    }
}