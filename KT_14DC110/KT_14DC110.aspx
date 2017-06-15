<%@ Page Language="C#" AutoEventWireup="true" CodeFile="KT_14DC110.aspx.cs" Inherits="KT_14DC110" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 121px;
        }
        .auto-style3 {
            width: 121px;
            text-align: right;
        }
        .auto-style4 {
            width: 121px;
            height: 23px;
        }
        .auto-style5 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width: 100%; height: 31px;">
            <tr>
                <td colspan="2" style="font-weight: 700">
                    <h1 style="color: #0000FF">THÔNG TIN ĐIỆN THOẠI</h1>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label1" runat="server" Text="Mã điện thoại"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txt_MaDT" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label2" runat="server" Text="Tên điện thoại"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txt_TenDT" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label3" runat="server" Text="Đơn giá"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txt_DonGia" runat="server" TextMode="Number" Width="199px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label4" runat="server" Text="Phụ kiện kèm theo"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txt_PhuKien" runat="server" Height="22px" TextMode="MultiLine" Width="255px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label5" runat="server" Text="Mã loại điện thoại"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddl_LoaiDT" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lbl_ThongBao" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="btn_Them" runat="server" OnClick="btn_Them_Click" Text="Thêm" Width="102px" />
                    <asp:Button ID="btn_Sua" runat="server" OnClick="btn_Sua_Click" Text="Sửa" Width="101px" />
                    <asp:Button ID="btn_Xoa" runat="server" OnClick="btn_Xoa_Click" Text="Xóa" Width="114px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2" style="font-weight: 700; color: #0000FF">
                    <h1>DANH SÁCH ĐIỆN THOẠI HIỆN CÓ</h1>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:GridView ID="gr_DSDT" runat="server">
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style5"></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
