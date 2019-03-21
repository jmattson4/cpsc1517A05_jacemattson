<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CdLibrary.aspx.cs" Inherits="WebApp.SamplePages.CdLibrary" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:RequiredFieldValidator 
        ID="TitleRequiredFieldValidator" runat="server" 
        ErrorMessage="Title is required."
        ControlToValidate="TitleTextbox" ForeColor="Firebrick"
        Display="Dynamic" SetFocusOnError="true">
    </asp:RequiredFieldValidator>
    <asp:RequiredFieldValidator 
        ID="YearRequiredFieldValidator" runat="server" 
        ErrorMessage="Year is required."
        ControlToValidate="YearTextbox" ForeColor="Firebrick"
        Display="Dynamic" SetFocusOnError="true">
    </asp:RequiredFieldValidator>
    <asp:RequiredFieldValidator 
        ID="NumberOfTracksRequiredFieldValidator" runat="server" 
        ErrorMessage="Number Of tracks is required."
        ControlToValidate="NumberOfTracksTextbox" ForeColor="Firebrick"
        Display="Dynamic" SetFocusOnError="true">
    </asp:RequiredFieldValidator>
    <asp:RangeValidator 
        ID="YearRangeValidator" runat="server" 
        ErrorMessage="Year must be greater than 1900" ControlToValidate="YearTextbox"
        Display="Dynamic" ForeColor="Firebrick" Type="String" MinimumValue="1900"
        MaximumValue="2019"
        SetFocusOnError="true">
    </asp:RangeValidator>
    <asp:RangeValidator 
        ID="NumberOfTracksRangeValidator" runat="server" 
        ErrorMessage="You must have more than 0 tracks" ControlToValidate="NumberOfTracksTextbox"
        Display="Dynamic" ForeColor="Firebrick" Type="String" MinimumValue="1" MaximumValue="150"
        SetFocusOnError="true">
    </asp:RangeValidator>

    <table class="nav-justified">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="ISPN(Barcode)"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="BarcodeTextbox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="BarcodeSearchBtn" runat="server" Text="Search for CD" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Title"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TitleTextbox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Artist(s)"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="ArtistTextbox" runat="server" CssClass="col-xs-offset-0" Height="36px" Width="152px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 20px">
                <asp:Label ID="Label4" runat="server" Text="Year"></asp:Label>
            </td>
            <td style="height: 20px">
                <asp:TextBox ID="YearTextbox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Number Of Tracks"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="NumberOfTracksTextbox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="AddToLibraryBtn" runat="server" Text="Add to Library" OnClick="AddToLibraryBtn_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Literal ID="Message" runat="server"></asp:Literal>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <asp:GridView ID="LibraryGridView" runat="server" ></asp:GridView>
</asp:Content>

