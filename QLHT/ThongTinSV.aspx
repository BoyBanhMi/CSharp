<%@ Page Title="" Language="C#" MasterPageFile="~/SinhVien.master" AutoEventWireup="true" CodeFile="ThongTinSV.aspx.cs" Inherits="ThongTinSV" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style8
        {
            color: #0000FF;
            text-align: left;
            font-size: large;
            vertical-align:top;
        }
        .style9
        {
            font-size: large;
            vertical-align:top;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td class="style9" width="20%">
                &nbsp;</td>
            <td class="style9" width="20">
                &nbsp;&nbsp;</td>
            <td class="style8">
                <strong style="text-align: left">THÔNG TIN SINH VIÊN</strong>
                <hr />
                </td>
            <td class="style9">
                &nbsp;&nbsp;</td>
        </tr>
        <tr>
            <td width="20%">
                &nbsp;&nbsp;</td>
            <td width="20" valign="top">
                <asp:Image ID="Image2" runat="server" AlternateText="Chưa có ảnh" 
                    Height="125px" Width="134px" />
            </td>
            <td>
    <asp:Label ID="lblTTSV" runat="server" ForeColor="Blue" Width="100%" Font-Size="14pt"></asp:Label>
            </td>
            <td>
                &nbsp;&nbsp;</td>
        </tr>
        <tr>
            <td width="20%">
                &nbsp;</td>
            <td width="20">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <br />
    </asp:Content>

