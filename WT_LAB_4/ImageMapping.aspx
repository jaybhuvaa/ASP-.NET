<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ImageMapping.aspx.cs" Inherits="WT_LAB_4.ImageMapping" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ImageMap ID="ImageMap1" runat="server" BorderColor="Red" BorderStyle="Solid" ImageUrl="~/mm.jpg" OnClick="ImageMap1_Click" Height="500px" Width="500px">
                <asp:RectangleHotSpot Bottom="190" Right="500" HotSpotMode="Navigate" NavigateUrl="~/Clouds.aspx" PostBackValue="clouds" />
                <asp:PolygonHotSpot Coordinates="0,225 ; 54,214 ; 118,212 ; 158,220 ; 182,220 ; 209,209 ; 245,188 ; 286,211 ; 330,215 ; 374,212 ; 398,207 ; 500,235" HotSpotMode="Navigate" NavigateUrl="~/Mountains.aspx" PostBackValue="mountains" />
                <asp:CircleHotSpot HotSpotMode="Navigate" NavigateUrl="~/Grass.aspx" PostBackValue="grass" Radius="250" X="258" Y="392" />
            </asp:ImageMap>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            ImageButton<br />
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/mm.jpg" OnClick="ImageButton1_Click" Height="500px" Width="500px" />
        </div>
    </form>
</body>
</html>
