<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MatHang.aspx.cs" Inherits="MatHang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: left;
            width: 108px;
        }
        .auto-style2 {
        }
        .auto-style3 {
            text-align: right;
            width: 108px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 367px">
        <table style="width:100%;">
            <tr>
                <td colspan="2" style="text-align: left">
                    <asp:Label ID="Label1" runat="server" Font-Size="20pt" ForeColor="#0066FF" style="text-align: center" Text="Bảng Nhập Thông Tin Mặt Hàng"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label2" runat="server" Text="Mã Mặt Hàng"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txt_MaMH" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label3" runat="server" Text="Tên Mặt Hàng"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txt_TenMH" runat="server" Width="170px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label4" runat="server" Text="Đơn Giá"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txt_DonGia" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label5" runat="server" Text="Loại Mặt Hàng"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DDL_LMH" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="lbl_TB" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="btn_them" runat="server" OnClick="btn_them_Click" Text="Thêm" />
                    <asp:Button ID="btn_sua" runat="server" OnClick="btn_sua_Click" Text="Sửa" />
                    <asp:Button ID="btn_Xoa" runat="server" OnClick="btn_Xoa_Click" Text="Xóa" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="Label6" runat="server" Font-Size="22pt" ForeColor="Blue" style="text-align: left" Text="Danh Sách Măt Hàng Hiện Có"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="2" style="text-align: center">
                    <asp:GridView ID="gv_DSMH" runat="server" Width="287px">
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
