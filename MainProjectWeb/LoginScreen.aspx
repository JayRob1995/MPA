<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginScreen.aspx.cs" Inherits="MainProjectWeb.LoginScreen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Username&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="bnLogin" runat="server" Text="Login" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="bnRecovery" runat="server" Text="Forgot Password" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="bnCreateAccount" runat="server" Text="Create Account" />
        </div>
    </form>
</body>
</html>
