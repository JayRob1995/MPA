<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeckSearch.aspx.cs" Inherits="MainProjectWeb.DeckSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 40px">
            <asp:Label ID="Label1" runat="server" Text="Card ID"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCardID" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtDebug" runat="server" Width="603px"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Card Name"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCardName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Card Text"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCardText" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Color"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="dpdnColor" runat="server">
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Level"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="dpdnLevel" runat="server">
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label6" runat="server" Text="Cost"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCost" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label7" runat="server" Text="Card Type"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="dpdnCardType" runat="server">
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label8" runat="server" Text="Triggers"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="dpdnTrigger1" runat="server">
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="dpdnTrigger2" runat="server">
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label9" runat="server" Text="Soul"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtSoul" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label10" runat="server" Text="Franchise"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="dpdnFranchise" runat="server">
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label11" runat="server" Text="Side"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="dpdnSide" runat="server">
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label12" runat="server" Text="Special Attributes"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtSpecialAttribute1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
&nbsp;<asp:TextBox ID="txtSpecialAttribute2" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label13" runat="server" Text="Results"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label14" runat="server" Text="Deck List"></asp:Label>
            <br />
            <asp:ListBox ID="lstSearchResults" runat="server" Height="298px" Width="289px"></asp:ListBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Add To Deck" />
&nbsp;&nbsp;&nbsp;
            <asp:ListBox ID="lstDeckList" runat="server" Height="296px" Width="278px"></asp:ListBox>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtDeckName" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="bnSaveDeck" runat="server" Text="Save Deck" />
        </div>
    </form>
</body>
</html>
