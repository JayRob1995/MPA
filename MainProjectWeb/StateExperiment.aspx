<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StateExperiment.aspx.cs" Inherits="MainProjectWeb.StateExperiment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        Viewstate:
        <asp:Literal ID="ltrView" runat="server"></asp:Literal>
        <br />
        SessionState:
        <asp:Literal ID="ltrSession" runat="server"></asp:Literal>
        <br />
        ApplicationState:
        <asp:Literal ID="ltrApplication" runat="server"></asp:Literal>
        <br />
        <asp:Button ID="bnRun" runat="server" Text="Run" />
        <br />
        <br />
        <br />
        <asp:Literal ID="ltrChat" runat="server"></asp:Literal>
        <br />
        <asp:TextBox ID="txtChatBox" runat="server"></asp:TextBox>
        <asp:Button ID="bnSend" runat="server" OnClick="bnSend_Click" Text="Send" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="bnRefresh" runat="server" OnClick="bnRefresh_Click" Text="Refresh" />
    </form>
</body>
</html>
