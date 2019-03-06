<%@ Page Title="Basic Controls" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BasicControls.aspx.cs" Inherits="WebApp.SamplePages.BasicControls" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <table align="center" style="width: 80%">
        <tr>
            <td align="Right">TextBox</td>
            <td>
                <asp:TextBox ID="TextBoxNumberChoice" runat="server" ToolTip="Enter A Choice of 1-4"></asp:TextBox>
                 &nbsp;&nbsp
                <asp:Button ID="SubmitButtonChoice" runat="server" Text="Submit Choice" OnClick="SubmitButtonChoice_Click" />
            </td>
        </tr>
        <tr>
            <td align="Right">
                <asp:Label ID="RadioButtonLabel" runat="server" Text=" Choice (RadioButtonList): "
                     Font-Size="Medium" ForeColor="#33cc33" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:RadioButtonList ID="RadioButtonListChoice" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                    <asp:ListItem Value="1">COMP1008</asp:ListItem>
                    <asp:ListItem Value="2">CPSC1517</asp:ListItem>                   
                    <asp:ListItem Value="3">DMIT2018</asp:ListItem>
                    <asp:ListItem Value="4">DMIT1508</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td align="Right">
                <asp:Literal ID="CheckBoxLiteral" runat="server" Text="Choice (CheckBox):"></asp:Literal>
            </td>
            <td>
                <asp:CheckBox ID="CheckBoxChoice" runat="server" Font-Bold="True" Text="Programming Course if Active"/>
            </td>
        </tr>
        <tr>
            <td align="Right">
                <asp:Label ID="DisplayLabel" runat="server" Text="Display Label:"></asp:Label>
            </td>
            <td>
                <asp:Label ID="DisplayReadOnly" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="Right">
                <asp:Label ID="CollectionLabel" runat="server" Text="View Collection:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="CollectionList" runat="server">
                </asp:DropDownList>
                <asp:Button ID="CollectionButton" runat="server" Text="Submit Choice" OnClick="CollectionButton_Click" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td align="Center" colspan="2">
                <asp:Label ID="MessageLabel" runat="server"></asp:Label>
            </td>
        </tr>
    </table>



</asp:Content>
