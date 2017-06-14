<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DangNhapHeThong.aspx.cs" Inherits="DangNhapHeThong" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <style type="text/css">
        .style1
        {
            font-size: xx-large;
            font-family: Arial;
            background-color:#0066FF;
           
            
        }
        .style2
        {
            font-size: xx-large;
            font-family: Arial;
            background-color: #0066FF;
            color: #FFFFFF;
        }
        .style5
        {
            margin-top:0px;
            width:100%;
        }
                         
        a:link
       {
            color: blue;
            text-decoration: none;
      
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
    <div>
                    <table class="style5">
            <tr>
                <td colspan="3" class="style1" >
                    <strong>
                    <asp:Image ID="Image1" runat="server" CssClass="style1" Height="110px" 
                        ImageUrl="~/Images/icon-ttll.png" Width="102px" />
                    <span class="style2">TRƯỜNG ĐẠI HỌC THÔNG TIN LIÊN LẠC</span></strong></td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td style="text-align: right">
                  
                </td>
                <td style="text-align: right">
                    &nbsp;</td>
            </tr>
            <tr >
                <td height="60%" valign="top">

                    &nbsp;</td>
                <td height="60%" valign="top" align="center">
                            <font size="4">
                                <table style="width:30%;border-style:solid;border-width:thin;align:left;">
                                    <tr>
                                        <td colspan="2" style="text-align: center">
                                            <strong>ĐĂNG NHẬP HỆ THỐNG</strong></td>
                                    </tr>
                                    <tr>
                                        <td >
                                            Mã sinh viên</td>
                                        <td >
                                            <asp:TextBox ID="txtTenDN" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td >
                                            Mật khẩu</td>
                                        <td >
                                            <asp:TextBox ID="txtMatKhau" runat="server" TextMode="Password"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td >
                                            &nbsp;</td>
                                        <td >
                                            <asp:Button ID="btnDangNhap" runat="server" Font-Size="12pt" ForeColor="Blue" 
                                                Text="Đăng nhập" onclick="btnDangNhap_Click" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td  colspan="2">
                                            <asp:Label ID="lblTB" runat="server" ForeColor="Red"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                                </font>

                </td>
                <td height="60%" valign="top">
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    &nbsp;</td>
                <td style="text-align: center">
                    &nbsp;</td>
            </tr>
        </table>

    </div>
    </form>
</body>
</html>
