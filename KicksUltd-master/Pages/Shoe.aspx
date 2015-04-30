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
                <asp:TextBox ID="txtSize" runat="server" placeholder="Enter shoe size (4-18)"></asp:TextBox>
                <asp:RangeValidator ID="rvSize" runat="server" ErrorMessage=" Size must be 4-18!" ControlToValidate="txtSize"></asp:RangeValidator>
                <asp:RequiredFieldValidator ID="rfvSize" runat="server" ErrorMessage="Shoe size cannot be left blank!" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
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

