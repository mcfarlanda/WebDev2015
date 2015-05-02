<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Social.aspx.cs" Inherits="Pages_Social" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table id="social">
        <tr>
            <td><h3>We're on social media!</h3></td>
        </tr>
        <tr>
            <td>Follow us on Twitter!</td>
            <td><asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/Images/twitter.png" OnClick="ImageButton4_Click" /></td>
           <%-- login:olgetree_vincent@columbusstate.edu
            pw:kicksu--%>
        </tr>
        <tr>
            <td>Like us on Facebook!</td>
            <td><asp:ImageButton ID="ImageButton6" runat="server" ImageUrl="~/Images/facebook.png" OnClick="ImageButton2_Click" /></td>
            <%--login: mcfarland_andre@columbusstate.edu
            pw: kickultd--%>
        </tr>
        <tr>
            <td>Follow us on Instagram!</td>
            <td><asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="~/Images/instagram.png" OnClick="ImageButton5_Click" /></td>
            <%--login:kicksultd3
            pw:kicksu--%>
        </tr>
    </table>
</asp:Content>

