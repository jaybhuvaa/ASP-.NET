<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="comcal.aspx.cs" Inherits="WT_LAB_2.comcal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged" AutoPostBack="True"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" CommandArgument="+" onCommand="Button2_Command" Text="ADD" />
            <asp:Button ID="Button2" runat="server" CommandArgument="-" OnCommand="Button2_Command" Text="SUB" />
            <asp:Button ID="Button3" runat="server" CommandArgument="*" onCommand="Button2_Command" Text="MUL" />
            <asp:Button ID="Button4" runat="server" CommandArgument="/"  onCommand="Button2_Command" Text="DIV" />
        </p>
        <p>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
    </form>
</body>
</html>
