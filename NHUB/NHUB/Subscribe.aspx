<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Subscribe.aspx.cs" Inherits="NHUB.Subscribe" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        <div style="height: 510px">


            <div style="position: relative; left: 0px; top: 0px; height: 503px">
                <br />
                <table class="nav-justified" style="height: 402px">
                    <tr>
                        <td class="text-center" style="width: 425px">Name:</td>
                        <td>
                            <asp:TextBox ID="EventName" runat="server" Enabled="False" Height="30px" Width="236px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="text-center" style="width: 425px; height: 58px">Available Channels:</td>
                        <td style="height: 58px">
                            <asp:CheckBox ID="IntranetCheck" runat="server" Text="Intranet" />
&nbsp;&nbsp;
                            <asp:CheckBox ID="EmailCheckbox" runat="server" Text="Emails" />
                            <br />
                            <asp:CheckBox ID="UnabotCheckBox" runat="server" Text="Una Bot" />
&nbsp;&nbsp;
                            <asp:CheckBox ID="SmsCheckBox" runat="server" Text="SMS" />
                        </td>
                    </tr>
                    <tr>
                        <td class="text-center" style="width: 425px">Confidential Events:</td>
                        <td>
                            <input id="Checkbox5" type="checkbox" /></td>
                    </tr>
                    <tr>
                        <td class="text-center" style="width: 425px">Mandetory Events: </td>
                        <td>
                            <input id="Checkbox6" style="width: 32px; height: 21px" type="checkbox" /></td>
                    </tr>
                    <tr>
                        <td class="text-center" style="width: 425px">Service LIne:</td>
                        <td>
                            <asp:DropDownList ID="DropDownList1" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="text-center" style="width: 425px">End User:</td>
                        <td>
                            <textarea id="TextArea1" name="S1" rows="2" style="width: 166px"></textarea>
                            <asp:CheckBoxList ID="CheckBoxList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="UserName" DataValueField="Id">
                            </asp:CheckBoxList>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NotificationHubConnectionString %>" SelectCommand="SELECT [Id], [UserName] FROM [AspNetUsers]"></asp:SqlDataSource>
                        </td>
                    </tr>
                    <tr>
                        <td class="text-center" style="width: 425px">
                            <asp:Button ID="CancleButton" runat="server" Text="Cancel" />
                        </td>
                        <td>
                            <asp:Button ID="UpdateButton" runat="server" Text="Update" />
                        </td>
                    </tr>
                </table>
            </div>


        </div>

    </asp:Content>