<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CacheEx7.aspx.cs" Inherits="Day3_4.CacheEx7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cache Exercise 7</title>
    <style type="text/css">
        .Center
        {
            margin: 0;
            position: absolute;
            top: 50%;
            left: 50%;
            margin-right: -50%;
            transform: translate(-50%, -50%);
        }
        td
        {
            text-align:center;
        }
    </style>
    </head>
    <body>
    <form id="form1" runat="server">
        <div class="Center">
        <table>
        <tr>
        <td>
            <asp:DropDownList ID="DLEmployeeCache" runat="server" Height="25px" Width="100px" AppendDataBoundItems="True">
                <asp:ListItem Value="0">Select Option</asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="ButtonDetails" runat="server" Text="Details" style="font-weight: 700" Width="100px" onclick="ButtonDetails_Click" />
                <br />
            <asp:Label runat="server" ID="LabelCache" Visible="false" Text="Cache Is Empty" ForeColor="Red"></asp:Label>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" Width="507px">
            <Columns>
                <asp:BoundField DataField="EmployeeID" HeaderText="EmployeeID" />
                <asp:BoundField DataField="Name" HeaderText="Name" />
                <asp:BoundField DataField="Address" HeaderText="Address" />
                <asp:BoundField DataField="Salary" HeaderText="Salary" />
            </Columns>
                <FooterStyle BackColor="White" ForeColor="#333333" />
                <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#487575" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#275353" />
            </asp:GridView>
        </td>
    </tr>
    </table>
    </div>
</form>
</body>
</html>
