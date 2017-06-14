<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TrangChu.aspx.cs" Inherits="TimKiem" %>

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
        .style6
        {
           
        }
        .style7
        {
            text-align: center;
        }
        .style8
        {
            height:480px;
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
                <td class="style6">
                    <asp:Button ID="btnTrangChu" runat="server" Font-Bold="False" ForeColor="Blue" 
                        Text="Trang chủ" Width="110px" Font-Size="12pt" 
                        onclick="btnTrangChu_Click" />
                    <asp:Button ID="btnHuongDan" runat="server" ForeColor="Blue" Text="Hướng dẫn" 
                        Font-Size="12pt" Width="110px" onclick="btnHuongDan_Click" />
                    <asp:Button ID="btnDangNhapHT" runat="server" ForeColor="Blue" Text="Đăng nhập" 
                        Font-Size="12pt" Width="110px" onclick="btnDangNhapHT_Click" />
                    <asp:Button ID="btnDangXuat" runat="server" ForeColor="Blue" Text="Đăng xuất" 
                        Font-Size="12pt" Width="110px" onclick="btnDangXuat_Click" />
                </td>
                <td style="text-align: right">
                    <font size="4">Tìm kiếm:</font>
                    <asp:DropDownList ID="dropTim" runat="server" Height="23px" Width="141px" 
                        Font-Size="12pt">
                        <asp:ListItem Value="0">Họ và tên</asp:ListItem>
                        <asp:ListItem Value="1">Mã sinh viên</asp:ListItem>
                    </asp:DropDownList>
                    <asp:TextBox ID="txtTim" runat="server" Width="187px" Font-Size="12pt"></asp:TextBox>
                    <asp:Button ID="btnTim" runat="server" Text="Tìm" Font-Size="12pt" 
                        onclick="btnTim_Click" />
                </td>
            </tr>
            <tr style="height: 60%">
                <td height="60%" class="style8" colspan="2" valign="top">
                    <asp:GridView ID="gridDS" runat="server" BackColor="White" 
                        BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" 
                        ForeColor="Black" GridLines="Vertical" Width="100%">
                        <AlternatingRowStyle BackColor="#CCCCCC" />
                        <FooterStyle BackColor="#CCCCCC" />
                        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#808080" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#383838" />
                    </asp:GridView>
                    <asp:Label ID="lblTB" runat="server" ForeColor="Blue"></asp:Label>
                    <br />
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                   
                    Website được thiết kế bởi ThanhBC</td>
            </tr>
        </table>

    </div>
    </form>
</body>
</html>
