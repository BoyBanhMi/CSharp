<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="MonHoc.aspx.cs" Inherits="MonHoc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style7
        {
            font-size: large;
            color: #0000FF;
            text-align: left;
        }
        .style9
        {
        }
        .style10
        {
            width: 183px;
            font-size: 14pt;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <table style="width:100%;">
        <tr>
            <td class="style7" colspan="2">
                <strong style="text-align: left">THÔNG TIN MÔN HỌC</strong></td>
        </tr>
        <tr>
            <td class="style10">
                Mã môn học</td>
            <td>
                <asp:TextBox ID="txtMaMH" runat="server" Font-Size="13pt"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style10">
                Tên môn học</td>
            <td>
                <asp:TextBox ID="txtTenMH" runat="server" Width="270px" Font-Size="13pt"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style10">
                Số đơn vị học trình</td>
            <td>
                <asp:TextBox ID="txtDVHT" runat="server" Font-Size="13pt"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style10">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td class="style9">
                <asp:Button ID="btnThem" runat="server" ForeColor="Blue" 
                    onclick="btnThem_Click" Text="Thêm" Width="90px" Font-Size="13pt" />
                <asp:Button ID="btnSua" runat="server" ForeColor="Blue" onclick="btnSua_Click" 
                    Text="Sửa" Width="90px" Font-Size="13pt" />
                <asp:Button ID="btnXoa" runat="server" ForeColor="Blue" onclick="btnXoa_Click" 
                    onclientclick="return confirm(&quot;Bạn có chắc chắn xóa không ?&quot;)" 
                    Text="Xoá" Width="90px" Font-Size="13pt" />
            </td>
        </tr>
        <tr>
            <td class="style9" colspan="2">
                <asp:Label ID="lblTB" runat="server" ForeColor="Blue"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style7" colspan="2">
                <strong style="text-align: left">DANH SÁCH MÔN HỌC</strong></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="gridMH" runat="server" AllowPaging="True" AllowSorting="True" 
                    AutoGenerateColumns="False" DataKeyNames="MAMH" DataSourceID="SqlDataSource1" 
                    Font-Size="13pt" onselectedindexchanging="gridMH_SelectedIndexChanging" 
                    Width="70%">
                    <Columns>
                        <asp:CommandField CancelText="Huỷ" DeleteText="Xoá" EditText="Sửa" 
                            HeaderText="Chức năng" SelectText="Chọn" ShowDeleteButton="True" 
                            ShowEditButton="True" ShowSelectButton="True" UpdateText="Cập nhật" />
                        <asp:BoundField DataField="MAMH" HeaderText="Mã MH" ReadOnly="True" 
                            SortExpression="MAMH" />
                        <asp:BoundField DataField="TENMH" HeaderText="Tên môn học" 
                            SortExpression="TENMH" />
                        <asp:BoundField DataField="SODVHT" HeaderText="Số ĐVHT" 
                            SortExpression="SODVHT" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>" 
                    DeleteCommand="DELETE FROM MONHOC WHERE MAMH = ?" 
                    InsertCommand="INSERT INTO MONHOC (MAMH, TENMH, SODVHT) VALUES (?, ?, ?)" 
                    ProviderName="<%$ ConnectionStrings:ConnectionString2.ProviderName %>" 
                    SelectCommand="SELECT * FROM MONHOC" 
                    UpdateCommand="UPDATE MONHOC SET TENMH = ?, SODVHT = ? WHERE MAMH = ?">
                    <DeleteParameters>
                        <asp:Parameter Name="MAMH" Type="String" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="MAMH" Type="String" />
                        <asp:Parameter Name="TENMH" Type="String" />
                        <asp:Parameter Name="SODVHT" Type="Int16" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="TENMH" Type="String" />
                        <asp:Parameter Name="SODVHT" Type="Int16" />
                        <asp:Parameter Name="MAMH" Type="String" />
                    </UpdateParameters>
                </asp:SqlDataSource>
            </td>
        </tr>
    </table>
</asp:Content>

