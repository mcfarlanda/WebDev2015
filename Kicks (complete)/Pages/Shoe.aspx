<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Shoe.aspx.cs" Inherits="Pages_Shoe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <td rowspan="4">
                <asp:Image ID="imgShoe" runat="server" CssClass="detailsImage"/>

            </td>
            <td>
                <h2><asp:Label ID="lblTitle" runat="server" Text="Label"></asp:Label></h2>
                <hr />
            </td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="ddlSizes" runat="server">
                    <asp:ListItem Selected="True">Choose Size</asp:ListItem>
                    <asp:ListItem Value="4.0">4.0</asp:ListItem>
                    <asp:ListItem Value="4.5">4.5</asp:ListItem>
                    <asp:ListItem Value="5.0">5.0</asp:ListItem>
                    <asp:ListItem Value="5.0">5.5</asp:ListItem>
                    <asp:ListItem Value="6.0">6.0</asp:ListItem>
                    <asp:ListItem Value="6.0">6.5</asp:ListItem>
                    <asp:ListItem Value="7.0">7.0</asp:ListItem>
                    <asp:ListItem Value="7.0">7.5</asp:ListItem>
                    <asp:ListItem Value="8.0">8.0</asp:ListItem>
                    <asp:ListItem Value="8.0">8.5</asp:ListItem>
                    <asp:ListItem Value="9.0">9.0</asp:ListItem>
                    <asp:ListItem Value="9.0">9.5</asp:ListItem>
                    <asp:ListItem Value="10.0">10.0</asp:ListItem>
                    <asp:ListItem Value="10.0">10.5</asp:ListItem>
                    <asp:ListItem Value="11.0">11.0</asp:ListItem>
                    <asp:ListItem Value="11.0">11.5</asp:ListItem>
                    <asp:ListItem Value="12.0">12.0</asp:ListItem>
                    <asp:ListItem Value="12.0">12.5</asp:ListItem>
                    <asp:ListItem Value="13.0">13.0</asp:ListItem>
                    <asp:ListItem Value="13.0">13.5</asp:ListItem>
                    <asp:ListItem Value="14.0">14.0</asp:ListItem>
                    <asp:ListItem Value="14.0">14.5</asp:ListItem>
                    <asp:ListItem Value="15.0">15.0</asp:ListItem>
                    <asp:ListItem Value="15.0">15.5</asp:ListItem>
                    <asp:ListItem Value="16.0">16.0</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfvSize" runat="server" ErrorMessage="Please select shoe size!" Font-Bold="True" ForeColor="Red" ControlToValidate="ddlSizes" Display="Dynamic" InitialValue="Choose Size"></asp:RequiredFieldValidator>
            </td>
            <td>
                Quantity:
                <asp:DropDownList ID="ddlQuant" runat="server"></asp:DropDownList><br />
                <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblPrice" runat="server" Text="Label" CssClass="detailsPrice"></asp:Label><br />
            </td>
            <td>
                <asp:Button ID="addBtn" runat="server" Text="Add to Cart" CssClass="button" OnClick="addBtn_Click" />
            </td>
        </tr>
        <tr>
            <td></td>
            <td></td>
        </tr>
    </table>
</asp:Content>

