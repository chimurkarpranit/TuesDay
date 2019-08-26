<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WelCome.aspx.cs" Inherits="Day6.WelCome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>WelCome Page</title>
    <style>
    .Center
        {
            position: absolute;
            top: 50%;
            left: 55%;
            margin-right: 0%;
            transform: translate(-50%, -50%);
            height: 328px;
            margin-left: 0;
            margin-top: 0;
            margin-bottom: 0;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="Center">
            <h2><asp:Label ID="LblLoginID" runat="server"></asp:Label></h2>
        </div>
    </form>
</body>
</html>
