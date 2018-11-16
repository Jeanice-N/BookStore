<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AboutUs.aspx.cs" Inherits="Bookstore.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="companyInfo" style="float:left; margin: 70px 0px 0px 20px;  max-width: 600px; font-size: 23px; font-weight:bold;">
       <p>This project will create and implement an online application for 
           a book store. The outcome of this project will create a website 
           which will allow its customers to shop and purchase books online. 
           The website’s users will be able to browse the book store’s 
           current inventory of available books and refine their search by 
           category. Once the user finds a book they would like to purchase
           they are able to place the book into their virtual cart and adjust
           the quantity if needed. When the user is done shopping they areable
           to checkout and enter their information, confirm their order and 
           receive an invoice with their purchase and payment details.
       </p>
       <p>
          In addition to browsing and purchasing books, the customer can also
           contribute to the website by providing feedback through a five-star
           rating system on the books they’ve read. Moreover, the user canalso 
           leave general comments and inquiries to the company. 
       </p>


   </div>
    <div id="feedback" style="font-weight:bold; float:right; width: 50%; margin-top: 90px;  max-width: 600px; font-size: 23px;" aria-hidden="False">
        
        <asp:Label ID="lblLabel" runat="server" Text="Email"></asp:Label>
         &nbsp;&nbsp&nbsp;&nbsp;&nbsp;&nbsp&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtemail" runat="server" AutoCompleteType="Email" CausesValidation="True" Height="20px" Width="200px" ValidateRequestMode="Enabled"></asp:TextBox>
        <asp:Label ID="lblvalidateEmail" runat="server" ForeColor="Red" Text="Enter Email " Visible="False"></asp:Label>
        <br><br>
         <asp:Label ID="lblComment" runat="server" Text="Comments : "></asp:Label>
          <asp:TextBox ID="TxtComment" runat="server" CausesValidation="True" Height="70px" Width="300px"></asp:TextBox>

        <br />

       <br /><br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" style="background-color: #4CAF50; color: white; padding: 15px 32px; text-align: center; font-size: 17px; border-radius: 25px;" OnClick="btnSubmit_Click" />
        <br />
        <asp:Image ID="thanks" runat="server" EnableTheming="True" ImageAlign="Top" ImageUrl="http://www.desicomments.com/wp-content/uploads/2017/02/Nice-Image-Of-Thank-You.png" Visible="False" Height="200px" Width="500px"/>
        <br />

    </div>
</asp:Content>
