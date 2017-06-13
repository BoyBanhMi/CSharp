<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TrangChu.aspx.cs" Inherits="TrangChu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 289px;
        }
        .auto-style2 {
            height: 219px;
        }
        .auto-style3 {
        }
        .auto-style4 {
            height: 40px;
        }
        .auto-style5 {
            width: 289px;
            height: 12px;
        }
        .auto-style6 {
            text-align: left;
            width: 434px;
            background-color: #99CCFF;
        }
        .auto-style7 {
            text-align: right;
            background-color: #99CCFF;
        }
        #Password1 {
            width: 165px;
        }
        .auto-style8 {
            width: 289px;
            height: 229px;
        }
        .auto-style9 {
            width: 135px;
            text-align: right;
        }
        .auto-style11 {
            text-align: center;
        }
        .auto-style12 {
            text-align: center;
            background-color: #99CCFF;
        }
        .auto-style13 {
            text-align: center;
            width: 135px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 707px; width: 1076px">
    
        <table style="width: 100%; height: 665px;">
            <tr>
                <td class="auto-style2" colspan="3">
                    <asp:Panel ID="Panel1" runat="server" BackColor="#0066FF" Height="194px">
                        <asp:Panel ID="Panel2" runat="server" BackImageUrl="~/img/logo.png" Height="194px" Width="193px">
                        </asp:Panel>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td class="auto-style4" colspan="3">
                    <asp:Button ID="Button1" runat="server" Text="Button" />
                    <asp:Button ID="Button2" runat="server" Text="Button" />
                    <asp:Button ID="Button3" runat="server" Text="Button" />
                    <asp:Button ID="Button4" runat="server" Text="Button" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5"></td>
                <td class="auto-style3" colspan="2" rowspan="2">
                    <table style="width: 100%; height: 191px;">
                        <tr>
                            <td class="auto-style13">
                                <blockquote>
                                </blockquote>
                            </td>
                            <td colspan="2" class="auto-style12">
                                <blockquote>
                                    ĐĂNG NHẬP HỆ THỐNG</blockquote>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style9">
                                <blockquote>
                                </blockquote>
                            </td>
                            <td class="auto-style7">
                                <blockquote>
                                    Mã Sinh Viên&nbsp;&nbsp;&nbsp;
                                </blockquote>
                            </td>
                            <td class="auto-style6">
                                <blockquote>
                                    <asp:TextBox ID="txt_MaSV" runat="server" TextMode="Date" type="Password" Width="249px"></asp:TextBox>
                                </blockquote>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style9">
                                <blockquote>
                                </blockquote>
                            </td>
                            <td class="auto-style7">
                                <blockquote>
                                    Mật khẩu&nbsp;&nbsp;&nbsp;
                                </blockquote>
                            </td>
                            <td class="auto-style6">
                                <blockquote>
                                    <asp:TextBox ID="txt_MatKhau" runat="server" TextMode="Password" Width="246px"></asp:TextBox>
                                </blockquote>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style9">
                                <blockquote>
                                    &nbsp;&nbsp;&nbsp;&nbsp;
                                </blockquote>
                            </td>
                            <td class="auto-style7" colspan="2">
                                <blockquote class="auto-style11">
                                    <asp:Label ID="lbl_Thongbao" runat="server" ForeColor="Red"></asp:Label>
                                </blockquote>
                                <blockquote class="auto-style11">
                                    <asp:Button ID="btn_DangNhap" runat="server" OnClick="btn_DangNhap_Click" Text="Đăng Nhập" />
                                    <asp:Button ID="btn_HuyBo" runat="server" Text="Hủy Bỏ" />
                                </blockquote>
                            </td>
                        </tr>
                    </table>
                    </td>
            </tr>
            <tr>
                <td class="auto-style8"></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
