<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ThemMH.aspx.cs" Inherits="ThemMH" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
        .auto-style2 {
            height: 11px;
        }
    </style>
</head>
<body style="height: 436px">
    <form id="form1" runat="server">
    <div>
    
        <table style="width: 100%; height: 286px;">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <table style="width: 100%; height: 129px;">
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="Label1" runat="server" style="text-align: center" Text="NHẬP THÔNG TIN MÔN HỌC"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label2" runat="server" Text="Mã Môn Học"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txt_MaMH" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <asp:Label ID="Label3" runat="server" Text="Tên Môn Học"></asp:Label>
                            </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="txt_TenMH" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <asp:Label ID="Label4" runat="server" Text="Số DVHT"></asp:Label>
                            </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="txt_soDVHT" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lbl_thongbao" runat="server" ForeColor="Red"></asp:Label>
                            </td>
                            <td>
                                <asp:Button ID="btn_Them" runat="server" OnClick="btn_Them_Click" Text="Thêm" />
                                <asp:Button ID="btn_sua" runat="server" OnClick="btn_sua_Click" Text="Sửa" />
                                <asp:Button ID="btn_Xoa" runat="server" OnClick="btn_Xoa_Click" Text="Xóa" />
                            </td>
                        </tr>
                    </table>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style2">
                    <asp:GridView ID="gr_MonHoc" runat="server" Width="731px">
                    </asp:GridView>
                </td>
                <td class="auto-style2"></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
