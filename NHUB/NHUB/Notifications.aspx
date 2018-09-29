<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Notifications.aspx.cs" Inherits="NHUB.Notifications" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script lang="javascript">

    </script>
        <div class="auto-style1" style="height: 699px; z-index: 1; width: 934px; position: relative; top: 2px; left: -5px; text-align: right;">
            <h1 class="text-left">Notifications:</h1>
               
            <div  style="width: 767px; height: 320px; position: relative; left: -241px; top: 71px; z-index: 1; margin-left: 240px; margin-top: 0px" class="text-left"> 

                
                    <asp:TreeView ID="TreeView1" runat="server" style="position: relative; left: 5px; top: -2px; height: 196px" Width="122px">
                    </asp:TreeView>
            

            </div>
             <br />

       <asp:Button ID="AddNotificationButton" runat="server" style="margin-top: 0;" Text="Add Notification" OnClick="AddNotificationButton_Click" Height="58px" />
    </div>
</asp:Content>