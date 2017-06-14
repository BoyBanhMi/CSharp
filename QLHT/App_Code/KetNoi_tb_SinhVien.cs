using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

/// <summary>
/// Summary description for KetNoi_tb_SinhVien
/// </summary>
public class KetNoi_tb_SinhVien
{
    OleDbConnection conn = new OleDbConnection(DB2Connect.strconn);
	public KetNoi_tb_SinhVien()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}