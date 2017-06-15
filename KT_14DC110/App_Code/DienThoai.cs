using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

/// <summary>
/// Summary description for DienThoai
/// </summary>
public class DienThoai
{
    public static void Them(string madt, string tendt, int DonGia,string phukien, string loaidt)
    {
        OleDbConnection con = new OleDbConnection(connectDB.StrCon);
        con.Open();
        OleDbCommand cmd = new OleDbCommand("insert into db2admin.DienThoai values('" + madt + "', '" + tendt+ "', '" + DonGia + "','"+ phukien +"','" + loaidt + "')", con);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public static void Sua(string madt, string tendt, int DonGia, string phukien, string loaidt)
    {
        OleDbConnection con = new OleDbConnection(connectDB.StrCon);
        con.Open();
        OleDbCommand cmd = new OleDbCommand("update db2admin.DienThoai set TenDT='" + tendt + "',DonGia='" + DonGia + "',PhuKienKemTheo='" + phukien + "' where MaDT='" + madt + "' ", con);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public static void Xoa(string Madt)
    {
        OleDbConnection con = new OleDbConnection(connectDB.StrCon);
        con.Open();
        OleDbCommand cmd = new OleDbCommand("delete from db2admin.DienThoai where MaDT='" + Madt + "'", con);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public static DataTable DS_DienThoai()
    {
        OleDbConnection con = new OleDbConnection(connectDB.StrCon);
        con.Open();
        OleDbDataAdapter adap = new OleDbDataAdapter("select row_number() over (order by MaDT) as STT, MaDT, TenDT, DonGia,PhuKienKemTheo, TenLDT from db2admin.DienThoai, db2admin.LoaiDT where db2admin.DienThoai.MaLDT = db2admin.LoaiDT.MaLDT", con);
        DataTable ds = new DataTable();
        adap.Fill(ds);
        return ds;
    }
    public static DataTable DS_LoaiDT()
    {
        OleDbConnection con = new OleDbConnection(connectDB.StrCon);
        con.Open();
        OleDbDataAdapter adap = new OleDbDataAdapter("select * from db2admin.LoaiDT", con);
        DataTable ds = new DataTable();
        adap.Fill(ds);
        return ds;
    }
}