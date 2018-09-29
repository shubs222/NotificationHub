﻿<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AddEvent.aspx.cs" Inherits="NHUB.AddEvent" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div class="text-center" style="height: 501px; position: relative; left: 2px; top: 9px; width: 921px; z-index: 1">

            <div class="text-center">
                <br />
                <strong>Add an Event</strong><br />
            </div>
            <div class="text-center">
                <table class="nav-justified" style="height: 276px">
                    <tr>
                        <td style="width: 360px; height: 40px">Source:</td>
                        <td style="width: 322px; height: 40px">
                            <asp:DropDownList ID="SourceDropList" runat="server" Height="27px" Width="200px" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="Id">
                            </asp:DropDownList>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NotificationHubConnectionString %>" SelectCommand="SELECT [Id], [Name] FROM [Source]"></asp:SqlDataSource>
                        </td>
                        <td class="text-left" style="height: 40px"></td>
                    </tr>
                    <tr>
                        <td style="width: 360px; height: 39px">Name:</td>
                        <td style="width: 322px; height: 39px">
                            <asp:TextBox ID="NameTextBox" runat="server" Width="200px"></asp:TextBox>
                        </td>
                        <td class="text-left" style="height: 39px">
                            <asp:RequiredFieldValidator ID="NameValidator" runat="server" ControlToValidate="NameTextBox" EnableViewState="False" ErrorMessage="Enter Name" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 360px; height: 66px">Available Channels:</td>
                        <td style="width: 322px; height: 66px">
                            <asp:CheckBox ID="IntranetCheckBox" runat="server" Text="Intranet" />
&nbsp;&nbsp;
                            <asp:CheckBox ID="EmailsCheckBox" runat="server" Text="Emails" />
                            <br />
                            <asp:CheckBox ID="UnabotCheckboc" runat="server" Text="Una bot" />
&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:CheckBox ID="SmsCheckBox" runat="server" Text="SMS" />
                        </td>
                        <td class="text-left" style="height: 66px"></td>
                    </tr>
                    <tr>
                        <td style="width: 360px">Confidential Event:</td>
                        <td style="width: 322px">
                            <asp:CheckBox ID="ConfidentialEventCheckBox" runat="server" />
                        </td>
                        <td class="text-left">&nbsp;</td>
                    </tr>
                    <tr>
                        <td style="width: 360px">Mandetory Event:</td>
                        <td style="width: 322px">
                            <asp:CheckBox ID="MandetoryEventCheckBox" runat="server" />
                        </td>
                        <td class="text-left">&nbsp;</td>
                    </tr>
                    <tr>
                        <td style="width: 360px">
                            <asp:Button ID="CancelButton" runat="server" Text="Cancel" Width="120px" Height="28px" />
                        </td>
                        <td style="width: 322px">
                            <asp:Button ID="AddButton" runat="server" Text="Add" Width="105px" Height="27px" OnClick="AddButton_Click" />
                        </td>
                        <td class="text-left">&nbsp;</td>
                    </tr>
                </table>
                <br />
            </div>

           </div>

</asp:Content>