<%@ Page Language="C#"  MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="trainee.aspx.cs" Inherits="task622020.trainee" %>

<asp:Content ID="cont1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <asp:Label ID="Label1" Text="Id" runat="server"></asp:Label>
         <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
         <asp:Label ID="Label2" runat="server" Text="name"></asp:Label>
         <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="location"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="domain"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
         <asp:Label ID="Label5" runat="server" Text="sdate"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1"  runat="server" Text="insert" Height="47px" Width="115px" OnClick="Button1_Click" />
       
    </div>
        </asp:Content>
