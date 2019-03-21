<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserRegistration.aspx.cs" Inherits="WebApp.SamplePages.UserRegistration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:RequiredFieldValidator 
        ID="RequiredFieldValidatorFirstName" 
        runat="server" 
        ErrorMessage="You must enter your first name."
        ControlToValidate="FirstNameTextbox"
        Display="Dynamic"
        SetFocusOnError="true"
        ForeColor="Firebrick">
    </asp:RequiredFieldValidator>&nbsp;<br />
        <asp:RequiredFieldValidator 
        ID="RequiredFieldValidatorLastName" 
        runat="server" 
        ErrorMessage="You must enter your last name."
        ControlToValidate="LastNameTextbox"
        Display="Dynamic"
        SetFocusOnError="true"
        ForeColor="Firebrick">
    </asp:RequiredFieldValidator>&nbsp;<br />
    <asp:RequiredFieldValidator 
        ID="RequiredFieldValidatorUserName" 
        runat="server" 
        ErrorMessage="You must enter your user name."
        ControlToValidate="UserNameTextbox"
        Display="Dynamic"
        SetFocusOnError="true"
        ForeColor="Firebrick">
    </asp:RequiredFieldValidator>&nbsp;<br />
    <asp:CompareValidator 
        ID="CompareValidatorEmail" runat="server" 
        ErrorMessage="Email address's do not match."
        ControlToValidate="ConfirmEmailTextbox"
        Display="Dynamic" SetFocusOnError="true" 
        ForeColor="Firebrick" Operator="Equal" 
        Type="String" ControlToCompare="EmailTextbox">
    </asp:CompareValidator>
    <asp:CompareValidator 
        ID="CompareValidatorPassword" runat="server" 
        ErrorMessage="Passwords do not match."
        ControlToValidate="ConfirmPasswordTextbox"
        Display="Dynamic" SetFocusOnError="true" 
        ForeColor="Firebrick" Operator="Equal" 
        Type="String" ControlToCompare="PasswordTextbox">
    </asp:CompareValidator>&nbsp;<br />
    <asp:RegularExpressionValidator 
        ID="RegularExpressionValidator1" runat="server" 
        ErrorMessage="Password must be between 4-8 characters and contain atleast 1 number"
        ValidationExpression="^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{4,8}$"
        ControlToValidate="PasswordTextbox" SetFocusOnError="true"
        ForeColor="Firebrick" Display="Dynamic">
    </asp:RegularExpressionValidator>&nbsp;<br />
    <table style="width: 80%">
        <tr>
            <td style="width: 216px">
                <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="FirstNameTextbox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 216px">
                <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="LastNameTextbox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 216px">
                <asp:Label ID="Label3" runat="server" Text="User Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="UserNameTextbox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 216px">
                <asp:Label ID="Label4" runat="server" Text="Email Address"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="EmailTextbox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 216px">
                <asp:Label ID="Label5" runat="server" Text="Confirm Email"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="ConfirmEmailTextbox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 216px">
                <asp:Label ID="Label6" runat="server" Text="Password"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="PasswordTextbox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 216px">
                <asp:Label ID="Label7" runat="server" Text="Confirm Password"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="ConfirmPasswordTextbox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 216px">
                <asp:CheckBox ID="ConfirmCheckbox" runat="server"/>
                <asp:Label ID="Label8" runat="server" Text="I confirm I wish to create an account"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 216px">
                <asp:Button ID="ConfirmRegistrationBtn" runat="server" OnClick="ConfirmRegistrationBtn_Click" Text="Confirm" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <asp:Literal ID="Message" runat="server" Text=""></asp:Literal>
    <asp:GridView ID="DisplayUserDataGrid" runat="server"></asp:GridView>
    <script src="../Scripts/bootwrap-freecode.js"></script> 
</asp:Content>
