<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Pages_Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table id="frontpage">
        <tr>
            <td>
                <div class="bestshoes">
            <ajaxToolkit:ToolkitScriptManager runat="server"></ajaxToolkit:ToolkitScriptManager>

            <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Always">
                <ContentTemplate>
                    <asp:Timer ID="Timer1" runat="server" Interval="10000" OnTick="Timer1_Tick"></asp:Timer>
                    <asp:Image ID="Image1" Width="300px" Height="300" runat="server" CssClass="img1" />
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
                </Triggers>
            </asp:UpdatePanel>
        </div>
        <ajaxToolkit:UpdatePanelAnimationExtender runat="server" TargetControlID="UpdatePanel1">
            <Animations>
                <OnUpdating>
                    <FadeOut Duration="1" Fps="100" minimumOpacity="0" />
                </OnUpdating>
                <OnUpdated>
                    <FadeIn Duration="3" Fps="50" minimumOpacity="0" />
                </OnUpdated>
            </Animations>
        </ajaxToolkit:UpdatePanelAnimationExtender>
            </td>
        </tr>
        <tr>
            <td><h2>THIS MONTH'S HOTTEST SHOES!</h2></td>
        </tr>
    </table>
</asp:Content>

