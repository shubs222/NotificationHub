<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Notifications.aspx.cs" Inherits="NHUB.Notifications" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script lang="javascript">

    </script>
        <div class="auto-style1" style="height: 520px; z-index: 1; width: 919px; position: relative; top: 30px; left: 4px">
            <h1>Notifications:</h1>
               
            <div style="width: 771px; height: 266px; position: relative; left: -237px; top: 21px; z-index: 1; margin-left: 240px; margin-top: 0px"> 

                <asp:Button ID="TestButton" runat="server" OnClick="TestButton_Click" Text="Click1" Width="149px" />
             
                <br />
             
                <asp:PlaceHolder ID="NotificationPlaceHolder" runat="server"></asp:PlaceHolder>
              
                <br />
              
                <asp:Button ID="Test2" runat="server" OnClick="Test2_Click" Text="Click2" Width="161px" />

            </div>

        &nbsp;</div>
</asp:Content>