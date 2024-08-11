<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="cp.aspx.cs" Inherits="Lab_4_MP.cp" %>
<%@ MasterType VirtualPath="~/master.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Content will be printed here"></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:AdRotator ID="AdRotator1" runat="server" DataSourceID="XmlDataSource1" />
    <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/data.XML"></asp:XmlDataSource>
</asp:Content>
