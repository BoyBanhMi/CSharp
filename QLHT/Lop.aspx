<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Lop.aspx.cs" Inherits="Lop" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td colspan="2">
                    THÔNG TIN LỚP HỌC</td>
            </tr>
            <tr>
                <td>
                    Mã lớp</td>
                <td>
                    <asp:TextBox ID="txtMaLop" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Tên lớp</td>
                <td>
                    <asp:TextBox ID="txtTenLop" runat="server" Width="302px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="btnThem" runat="server" onclick="btnThem_Click" Text="Thêm" />
                    <asp:Button ID="btnSua" runat="server" onclick="btnSua_Click" Text="Sửa" />
                    <asp:Button ID="btnXoa" runat="server" onclick="btnXoa_Click" Text="Xoá" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblTB" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
