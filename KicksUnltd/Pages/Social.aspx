<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Social.aspx.cs" Inherits="Pages_Social" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    Follow us on Twitter!<asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/twitter.png" />
</p>
<p>
    Like us on Facebook!<asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Images/facebook.png" />
</p>
<p>
    Follow us on Instagram!<asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/Images/instagram.png" />
</p>
</asp:Content>

