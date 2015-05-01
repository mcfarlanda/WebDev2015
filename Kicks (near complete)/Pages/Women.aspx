<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Women.aspx.cs" Inherits="Pages_Women" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DropDownList ID="ddlCategories" runat="server" OnSelectedIndexChanged="ddlCategories_SelectedIndexChanged" AutoPostBack="True">
        <asp:ListItem Selected="True">--</asp:ListItem>
        <asp:ListItem>All Shoes</asp:ListItem>
        <asp:ListItem Value="Running">Running</asp:ListItem>
        <asp:ListItem Value="Business">Business</asp:ListItem>
    </asp:DropDownList>
    <asp:Panel ID="pnlShoes" runat="server">
    </asp:Panel>
    <p style="clear: both"></p>
</asp:Content>

