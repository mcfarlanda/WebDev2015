<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Children.aspx.cs" Inherits="Pages_Children" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DropDownList ID="ddlCategories" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCategories_SelectedIndexChanged">
        <asp:ListItem Selected="True">--</asp:ListItem>
        <asp:ListItem>All Shoes</asp:ListItem>
        <asp:ListItem Value="Running">Running</asp:ListItem>
        <asp:ListItem Value="Basketball">Basketball</asp:ListItem>
    </asp:DropDownList>
    <asp:Panel ID="pnlShoes" runat="server">
    </asp:Panel>
    <p style="clear: both"></p>
</asp:Content>

