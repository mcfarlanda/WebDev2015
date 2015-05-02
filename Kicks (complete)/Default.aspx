<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Main.css" rel="stylesheet" />
    <title>Kicks Ultd Homepage</title>  
</head>

<body class="homepage">
        
    <form id="form1" runat="server">
        <div class="insidehome">
            <%--<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>--%>
            <ajaxToolkit:ToolkitScriptManager runat="server"></ajaxToolkit:ToolkitScriptManager>

            <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Always">
                <ContentTemplate>
                    <asp:Timer ID="Timer1" runat="server" Interval="10000" OnTick="Timer1_Tick"></asp:Timer>
                    <asp:Image ID="Image1" Width="1353px" Height="854" runat="server" CssClass="img1" />
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
        <asp:Button ID="Button1" runat="server" Text="Enter Site" CssClass="Button1" OnClick="Button1_Click" />
    </form>
</body>
</html>
