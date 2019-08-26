<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exercise_7.aspx.cs" Inherits="Day3_4.Exercise_7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Exercise 7</title>
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
            <asp:DropDownList ID="DLEmployee" runat="server" Height="25px" Width="100px" AppendDataBoundItems="True">
                <asp:ListItem Value="0">Select Option</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
            <asp:Button ID="ButtonDetails" runat="server" Text="Details" Width="100px" OnClick="ButtonDetails_Click"/>
        </td>
    </tr>
    </table>
    </div>
    </form>
</body>
</html>