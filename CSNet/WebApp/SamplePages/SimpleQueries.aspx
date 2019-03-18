<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SimpleQueries.aspx.cs" Inherits="WebApp.SamplePages.SimpleQueries" %>
<asp:Content ID="Content1" 
    ContentPlaceHolderID="MainContent" 
    runat="server">
    <h1>Simple Queries</h1>
        <table align="center" style="width: 80%">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Enter A Product ID"></asp:Label>
&nbsp;
                    <asp:TextBox ID="SearchArg" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="ProductID:"></asp:Label>
&nbsp;
                    <asp:Label ID="ProductID" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" />
&nbsp;              <asp:Button ID="Clear" runat="server" Text="Clear" 
                                CausesValidation="false" OnClick="Clear_Click"/>
                </td>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Name:"></asp:Label>
&nbsp;
                    <asp:Label ID="ProductName" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Label ID="MessageLabel" runat="server" Text=""></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>


</asp:Content>
