<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Display1.aspx.cs" Inherits="clgt.Display1" %>

<asp:Content ID="cont1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"></asp:GridView>
    </div>
        </asp:Content>
