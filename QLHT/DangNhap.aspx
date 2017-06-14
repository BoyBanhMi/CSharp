<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DangNhap.aspx.cs" Inherits="TrangChu" %>

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
        .style3
        {
            width: 130px;
        }
        .style4
        {
        }
        .style5
        {
            margin-top:0px;
            width:100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style5">
            <tr>
                <td colspan="2" class="style1" >
                    <strong>
                    <asp:Image ID="Image1" runat="server" CssClass="style1" Height="110px" 
                        ImageUrl="~/Images/icon-ttll.png" Width="102px" />
                    <span class="style2">TRƯỜNG ĐẠI HỌC THÔNG TIN LIÊN LẠC</span></strong></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnTrangChu" runat="server" Font-Bold="False" ForeColor="Blue" 
                        Text="Trang chủ" Width="110px" Font-Size="12pt" 
                        onclick="btnTrangChu_Click" />
                    <asp:Button ID="btnHuongDan" runat="server" ForeColor="Blue" Text="Hướng dẫn" 
                        Font-Size="12pt" Width="110px" />
                    <asp:Button ID="btnDangNhapHT" runat="server" ForeColor="Blue" Text="Đăng nhập" 
                        Font-Size="12pt" Width="110px" />
                    <asp:Button ID="btnDangXuat" runat="server" ForeColor="Blue" Text="Đăng xuất" 
                        Font-Size="12pt" Width="110px" />
                </td>
                <td style="text-align: right">
                   <!-- <font size="4">Tìm kiếm:</font>
                    <asp:DropDownList ID="dropTim" runat="server" Height="23px" Width="141px" 
                        Font-Size="12pt">
                        <asp:ListItem Value="0">Họ và tên</asp:ListItem>
                        <asp:ListItem Value="1">Mã sinh viên</asp:ListItem>
                    </asp:DropDownList>
                    <asp:TextBox ID="TextBox1" runat="server" Width="187px" Font-Size="12pt"></asp:TextBox>
                    <asp:Button ID="btnTim" runat="server" Text="Tìm" Font-Size="12pt" />-->
                </td>
            </tr>
            <tr height=60% style="height: 60%">
                <td height="60%">
                    &nbsp;
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                </td>
                <td height="60%">
                    <table style="width:100%;">
                        <tr>
                            <td>
                            <font size="4">
                                <table style="width:100%;border-style:solid;border-width:thin">
                                    <tr>
                                        <td colspan="2" style="text-align: center">
                                            <strong>ĐĂNG NHẬP HỆ THỐNG</strong></td>
                                    </tr>
                                    <tr>
                                        <td class="style4">
                                            Mã sinh viên</td>
                                        <td class="style3">
                                            <asp:TextBox ID="txtMaSV" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style4">
                                            Mật khẩu</td>
                                        <td class="style3">
                                            <asp:TextBox ID="txtMatKhau" runat="server" TextMode="Password"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style4">
                                            &nbsp;</td>
                                        <td class="style3">
                                            <asp:Button ID="btnDangNhap" runat="server" Font-Size="12pt" ForeColor="Blue" 
                                                Text="Đăng nhập" onclick="btnDangNhap_Click" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style4" colspan="2">
                                            <asp:Label ID="lblTB" runat="server" ForeColor="Red"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                                </font>
                            </td>
                            <td>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    Website được thiết kế bởi ThanhBC</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
