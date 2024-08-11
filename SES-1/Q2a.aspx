<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Q2a.aspx.cs" Inherits="SES_1.Q2a" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:ImageMap ID="ImageMap1" runat="server" height="500px" Width="500px" ImageUrl="~/1.jpg" OnClick="ImageMap1_Click">
                <asp:CircleHotSpot HotSpotMode="PostBack" PostBackValue="0" Radius="40" X="383" Y="122" />
                <asp:PolygonHotSpot Coordinates="0,162 ; 145,140 ; 201,154 ; 258,136; 326 , 146 ; 375, 169 ; 441 , 144; 500, 148 ; 0,500 ; 228 ,443 ; 290, 336 ; 285 , 336; 285,314; 370, 311;494,349" HotSpotMode="PostBack" PostBackValue="1" />
                <asp:RectangleHotSpot Bottom="100" HotSpotMode="PostBack" PostBackValue="2" Right="500" />
            </asp:ImageMap>
            
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
            <asp:ImageButton ID="ImageButton1" runat="server" Height="500px" Width="500px" OnClick="ImageButton1_Click" ImageUrl="~/1.jpg"
                />
            
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            
        </div>
    </form>
</body>
</html>
