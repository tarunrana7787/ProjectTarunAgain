<%@ Page Title="default" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ProjectTarunAgain._default" %>

<asp:Content runat="server" ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1">
    <div class="logo"></div>
    <div class="banner"></div>

    <asp:GridView runat="server" ID="GameGridView" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="WeekNumber" HeaderText="Week Number" Visible="true" />
            <asp:BoundField DataField="Team1" HeaderText="Team1" Visible="true" />
            <asp:BoundField DataField="Team2" HeaderText="Team2" Visible="true" />
            <asp:BoundField DataField="Team1Score" HeaderText="Team 1 score" Visible="true" />
            <asp:BoundField DataField="Team2Score" HeaderText="Team 2 score" Visible="true" />
        </Columns>
    </asp:GridView>

</asp:Content>
