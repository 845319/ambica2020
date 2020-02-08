<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="control.aspx.cs" Inherits="controls.control" %>

<asp:Content ID="id12" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">

    </div>
    <div class="jumbotron">
        <asp:Label ID="Label1" runat="server" Text="Enter Name"></asp:Label>
        <br />
       
        <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
        <br />
         <asp:Label ID="Label2" runat="server" Text="Enter DOB"></asp:Label>
        <br />
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <br />
          <asp:Label ID="Label3" runat="server" Text="Enter Gender"></asp:Label>
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
            <asp:ListItem>Others</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Tick CheckBox List"></asp:Label>
        <br />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem>singing</asp:ListItem>
            <asp:ListItem>dancing</asp:ListItem>
            <asp:ListItem>cooking</asp:ListItem>
            <asp:ListItem>writing</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Education"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>High School</asp:ListItem>
            <asp:ListItem>Pre University</asp:ListItem>
            <asp:ListItem>Graduation</asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Button ID="submit" runat="server" Text="Submit" OnClick="submit_Click" />
    </div>
</asp:Content>