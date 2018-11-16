<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SearchBooks.aspx.cs" Inherits="Bookstore.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style=" text-align: center;  margin-top: 80px;  font-size: 30px; font-weight:bold; ">
        <asp:SqlDataSource ID="bnameSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT DISTINCT [bname] FROM [Book] WHERE ([category] = @category)">
            <SelectParameters>
                <asp:QueryStringParameter Name="category" QueryStringField="category" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:Label ID="lblCategory" runat="server" Visible="False"></asp:Label>
        <asp:SqlDataSource ID="authorSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT DISTINCT [bauthor] FROM [Book] WHERE ([category] = @category)">
            <SelectParameters>
                <asp:QueryStringParameter Name="category" QueryStringField="category" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    <asp:Label ID="lblBookName" runat="server" Text="Book Name : "></asp:Label>
&nbsp;&nbsp;
    <asp:DropDownList AppendDataBoundItems="true" ID="ddlbname" runat="server" Width="208px" DataSourceID="bnameSqlDataSource" DataTextField="bname" DataValueField="bname">
        <asp:ListItem Value="-1">Select a Book</asp:ListItem>
    </asp:DropDownList>
        <asp:Label ID="lblvalBname" runat="server" Font-Size="Medium" ForeColor="Red" Text="Please enter or select any value" Visible="False" Font-Bold="True"></asp:Label>
    <br />
    <br />
    <asp:Label ID="lblAuthorName" runat="server" Text="Author Name : "></asp:Label>
&nbsp;<asp:DropDownList AppendDataBoundItems="true" ID="ddlaname" runat="server" Width="204px" DataSourceID="authorSqlDataSource" DataTextField="bauthor" DataValueField="bauthor">
            <asp:ListItem Value="-1">Select Author</asp:ListItem>
    </asp:DropDownList>
        <asp:Label ID="lblvalidateAname" runat="server" Font-Size="Medium" ForeColor="Red" Text="Please enter or select any value" Visible="False" Font-Bold="True"></asp:Label>
    <br />
    <br />
    <asp:Label ID="lblPrice" runat="server" Text="Price : "></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtprice" runat="server" Width="200px" Enabled="False">&gt;=10</asp:TextBox>
    <br />
&nbsp;
    <br />
    <asp:Label ID="lblRating" runat="server" Text="Rating : "></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;<asp:DropDownList AppendDataBoundItems="true" ID="ddlrating" runat="server" Width="202px">
        <asp:ListItem Value="-1">Select Rating</asp:ListItem>
        <asp:ListItem>1</asp:ListItem>
        <asp:ListItem>2</asp:ListItem>
        <asp:ListItem>3</asp:ListItem>
        <asp:ListItem>4</asp:ListItem>
        <asp:ListItem>5</asp:ListItem>
    </asp:DropDownList>
        <asp:Label ID="lblvalidateRating" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="Red" Text="Please enter or select any value" Visible="False"></asp:Label>
    <br />
    <br />
    <br />
       
    <asp:Button ID="btnAllBooks" runat="server" Text=" All Books" style="background-color: #4CAF50; color: white;  padding: 15px 32px; text-align: center;  display: inline-block;  font-size: 15px; border-radius: 25px;" OnClick="btnAllBooks_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnShow" runat="server" Text="Show" style="background-color: #4CAF50; color: white;  padding: 15px 32px; text-align: center;  display: inline-block;  font-size: 15px; border-radius: 25px;" OnClick="btnShow_Click"/>
&nbsp;
        
        </div>
</asp:Content>
