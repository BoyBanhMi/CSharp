using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
/// <summary>
/// Summary description for dbconnect
/// </summary>
public class dbconnect
{
    public static string StrConn = @"Provider=IBMOLEDB.DB2COPY1;Data Source=QLBH;User ID=db2admin; Password=admin;Location=localhost";
}