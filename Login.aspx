<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Day6.Login" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Login_Ex12</title>
        <style type="text/css">
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
        td
        {
            text-align:center;
        }
        .auto-style1 {
            height: 258px;
            width: 604px;
        }
        .auto-style2 {
            width: 346px;
        }
            .auto-style3 {
                height: 25px;
            }
        </style>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css">
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
</head>
<body>
    <div class="container-fluid">
    <div class="Center shadow-lg p-3 mb-5 bg-white">
    <form id="form1" runat="server">
        <table class="auto-style1 table">
        <tr>
            <td colspan="2">
                <asp:Label ID="LabelLogin" runat="server" style="text-align:center; font-size:28px" Text="<h1>Login</h1>"></asp:Label>             
                <asp:Button ID="ButtonLanguage" runat="server" class="btn btn-info" style="text-align:center; float:right" Text="日本語" onclick="BtnLanguage_Click" CausesValidation="false" Width="80px" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="LabelLoginID" style="font-size:20px" Text="<h2>Login ID</h2>" Width="145px"></asp:Label>
            </td>                        
            <td class="auto-style2">
                <asp:TextBox runat="server" ID="textLoginID" class="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ID="ReqLoginID" ControlToValidate="textLoginID" ErrorMessage="Enter LoginID" ForeColor="Red" Width="344px"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="LabelPassword" style="font-size:20px" Text="<h2>Password</h2>" Width="145px"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:TextBox runat="server" ID="textPassword" class="form-control" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ID="ReqPassword" ControlToValidate="textPassword" ErrorMessage="Enter Password" ForeColor="Red" Width="347px"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="2" class="auto-style3">
                 <asp:Label ID="LabelInvalid" runat="server" Text="*Invalid Login ID or Password" ForeColor="Red" Visible="false"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button runat="server" ID="ButtonSubmit" Text="Submit" class="btn btn-primary" Width="100px" onclick="BtnSubmit_Click" style="margin-right:100px"/>
                <asp:Button ID="ButtonCancel" runat="server" Text="Cancel" class="btn btn-danger" Width="100px" CausesValidation="False" onclick="BtnCancel_Click"/>
            </td>
        </tr>          
    </table>
    </form>
    </div>
    </div>    
</body>
</html>