<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="Bookstore.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
       <div style=" margin-top: 4%; display: inline-block; margin-left:10%;">
        <asp:Button ID="btnGeneral" runat="server" Text="General" OnClick="btnGeneral_Click" style="background-image: url('http://www.clker.com/cliparts/4/5/2/5/1216180030913975458milovanderlinden_Nice_orange_glowy_button.svg.hi.png'); border-radius: 12px;" Font-Bold="False" Font-Size="35px" Font-Strikeout="False" Height="90px" Width="270px" /></span>
         &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnFiction" runat="server" Text="Fiction" OnClick="btnFiction_Click" style="background-image: url('http://www.clker.com/cliparts/4/5/2/5/1216180030913975458milovanderlinden_Nice_orange_glowy_button.svg.hi.png'); border-radius: 12px;" Font-Size="35px" Height="90px" Width="270px"/></span>
        &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDrama" runat="server" Text="Drama" OnClick="btnDrama_Click" style="background-image: url('http://www.clker.com/cliparts/4/5/2/5/1216180030913975458milovanderlinden_Nice_orange_glowy_button.svg.hi.png'); border-radius: 12px;" Font-Size="35px" Height="90px" Width="270px"/></span>
       </div>
    </p>
    <p>
       <div style=" margin-top: 4%; display: inline-block; margin-left:8%;">
        <asp:Button ID="btnMystery" runat="server" Text="Mystery" OnClick="btnMystery_Click" style="background-image: url('http://www.clker.com/cliparts/4/5/2/5/1216180030913975458milovanderlinden_Nice_orange_glowy_button.svg.hi.png'); border-radius: 12px;" Font-Size="35px" Height="90px" Width="250px"/></span>
         &nbsp;&nbsp;&nbsp; &nbsp; &nbsp;
        <asp:Button ID="btnHorror" runat="server" Text="Horror" OnClick="btnHorror_Click" style="background-image: url('http://www.clker.com/cliparts/4/5/2/5/1216180030913975458milovanderlinden_Nice_orange_glowy_button.svg.hi.png'); border-radius: 12px;" Font-Size="35px" Height="90px" Width="250px"/></span>
         &nbsp;&nbsp;&nbsp; &nbsp; &nbsp;
        <asp:Button ID="btnAction" runat="server" Text="Action" OnClick="btnAction_Click" style="background-image: url('http://www.clker.com/cliparts/4/5/2/5/1216180030913975458milovanderlinden_Nice_orange_glowy_button.svg.hi.png'); border-radius: 12px;" Font-Size="35px" Height="90px" Width="250px"/></span>
        &nbsp;&nbsp;&nbsp; &nbsp; &nbsp;
        <asp:Button ID="btnAcademic" runat="server" Text="Academic" OnClick="btnAcademic_Click" style="background-image: url('http://www.clker.com/cliparts/4/5/2/5/1216180030913975458milovanderlinden_Nice_orange_glowy_button.svg.hi.png'); border-radius: 12px;" Font-Size="35px" ForeColor="Black" Height="90px" Width="250px"/></span>
      </div>
       
    </p>
        
   
</asp:Content>
