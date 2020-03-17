<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="insert.aspx.cs" Inherits="opticals.insert" %>

<asp:Content ID="id1213" ContentPlaceHolderID="MainContent" runat="server">
    customer Id<asp:TextBox ID="TextBox1"  runat="server"></asp:TextBox>
    customer Name<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    sight type<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    sight range<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </asp:Content>
