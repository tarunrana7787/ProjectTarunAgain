<%@ Page Title="login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ProjectTarunAgain.login" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="sign">
        <div class="loginText">Login</div>
        <asp:TextBox runat="server" CssClass="sign" ID="UserNameTextBox" placeholder="Username" required="true" TabIndex="0"></asp:TextBox>
        <asp:TextBox runat="server" TextMode="Password" CssClass="sign" ID="PasswordTextBox" placeholder="Password" required="true" TabIndex="0"></asp:TextBox>
         <asp:Button Text="Signin" ID="LoginButton" runat="server" CssClass="btn btn-primary loginButton" OnClick="LoginButton_Click" TabIndex="0" />
        <br />
        <a href="#">Sign Up It's free! </a>
    </div>
</asp:Content>
