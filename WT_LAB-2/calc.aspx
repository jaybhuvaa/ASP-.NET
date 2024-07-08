<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calc.aspx.cs" Inherits="WT_LAB_2.calc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server" AutoPostBack="True" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ADD" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="SB" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="MUL" />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="DIV" />
        </p>
        <p>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
    </form>
</body>
</html>
