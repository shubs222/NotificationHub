<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Notifications.aspx.cs" Inherits="NHUB.Notifications" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script lang="javascript">

    </script>
        <div class="auto-style1" style="height: 699px; z-index: 1; width: 934px; position: relative; top: 2px; left: -5px; text-align: right;">
            <h1 class="text-left">Notifications:</h1>
               
            <div  style="width: 771px; height: 205px; position: relative; left: -237px; top: 10px; z-index: 1; margin-left: 240px; margin-top: 0px" class="text-left"> 

                
                    <asp:PlaceHolder ID="NotificationPlaceHolder" runat="server"></asp:PlaceHolder>
            

            </div>
             <br />

       <asp:Button ID="AddNotificationButton" runat="server" style="width: 136px; z-index: 1; position: absolute; top: 467px; left: 771px;" Text="Add Notification" OnClick="AddNotificationButton_Click" Height="49px" />
    </div>
</asp:Content>