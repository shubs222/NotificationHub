<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="EditEvent.aspx.cs" Inherits="NHUB.EditEvent" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div style="height: 434px">
            <br />
            <br />
            <table class="nav-justified" style="height: 188px" align="center">
                <tr>
                    <td class="text-center" style="width: 339px">Source:</td>
                    <td style="width: 341px">
                        <asp:DropDownList ID="SourceList" runat="server" Height="28px" Width="129px">
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="text-center" style="width: 339px; height: 39px">Name:</td>
                    <td style="height: 39px; width: 341px;">
                        <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
                    </td>
                    <td style="height: 39px"></td>
                </tr>
                <tr>
                    <td class="text-center" style="width: 339px; height: 59px">Available Channels</td>
                    <td style="height: 59px; width: 341px;">
                        <asp:CheckBox ID="Intranet" runat="server" CausesValidation="True" Text="Intranet" />
                        &nbsp;
                        <asp:CheckBox ID="EmailsCheckBox" runat="server" Text="Emails" />
                        <br />
                        <asp:CheckBox ID="UnaBotCheckBox" runat="server" Text="Una Bot" />
                        &nbsp;
                        <asp:CheckBox ID="SmsCheckBox" runat="server" Text="SMS" />
                    </td>
                    <td style="height: 59px"></td>
                </tr>
                <tr>
                    <td class="text-center" style="width: 339px; height: 29px;">Confidential Event</td>
                    <td style="height: 29px; width: 341px">
                        <asp:CheckBox ID="ConfidentialCheckBox" runat="server" />
                    </td>
                    <td style="height: 29px"></td>
                </tr>
                <tr>
                    <td class="text-center" style="width: 339px">Mandetory Event</td>
                    <td style="width: 341px">
                        <asp:CheckBox ID="MandetoryCheckBox" runat="server" OnCheckedChanged="MandetoryCheckBox_CheckedChanged" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <div style="height: 69px; position: relative">
              
            </div>
            <table align="center" class="nav-justified" style="height: 41px; width: 101%">
                <tr>
                    <td class="text-center" style="width: 344px">
                        <asp:Button ID="CancelButton" runat="server" Height="31px" Text="Cancel" Width="89px" />
                    </td>
                    <td>
                        <asp:Button ID="UpdateButton" runat="server" Text="Update" />
                    </td>
                </tr>
            </table>
        </div>
</asp:Content>