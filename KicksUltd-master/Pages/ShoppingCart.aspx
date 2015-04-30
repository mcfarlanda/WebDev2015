<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ShoppingCart.aspx.cs" Inherits="Pages_ShoppingCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="pnlShopping" runat="server">

    </asp:Panel>
    <table>
        <tr>
            <td><b>Subtotal: </b>

            </td>
            <td>
                <asp:Literal ID="litSub" runat="server" Text="" />
            </td>
        </tr>
        <tr>
            <td><b>Tax: </b>

            </td>
            <td>
                <asp:Literal ID="litTax" runat="server" Text="" />
            </td>
        </tr>
        <tr>
            <td><b>Shipping: </b>

            </td>
            <td>
                $8
            </td>
        </tr>
        <tr>
            <td><b>Total: </b>

            </td>
            <td>
                <asp:Literal ID="litTot" runat="server" Text="" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:LinkButton ID="lnkContinue" runat="server" >Continue Shopping</asp:LinkButton> OR
                <asp:Button ID="checkoutBtn" runat="server" PostBackUrl="~/Pages/Success.aspx" CssClass="button" Width="250px" Text="Check Out" />
            </td>
        </tr>
    </table>
</asp:Content>

