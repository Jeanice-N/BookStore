<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CartView.aspx.cs" Inherits="Bookstore.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Your Cart</h1>
    <p>
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" DataKeyNames="cartId" OnRowDeleted="GridView1_RowDeleted">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" />
                <asp:BoundField DataField="cartId" HeaderText="cartId" SortExpression="cartId" InsertVisible="False" ReadOnly="True" />
                <asp:BoundField DataField="bname" HeaderText="bname" SortExpression="bname" />
                <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
                <asp:BoundField DataField="qty" HeaderText="qty" SortExpression="qty" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Cart]" ConflictDetection="CompareAllValues" DeleteCommand="DELETE FROM [Cart] WHERE [cartId] = @original_cartId AND [bname] = @original_bname AND [price] = @original_price AND [qty] = @original_qty" InsertCommand="INSERT INTO [Cart] ([bname], [price], [qty]) VALUES (@bname, @price, @qty)" OldValuesParameterFormatString="original_{0}" UpdateCommand="UPDATE [Cart] SET [bname] = @bname, [price] = @price, [qty] = @qty WHERE [cartId] = @original_cartId AND [bname] = @original_bname AND [price] = @original_price AND [qty] = @original_qty">
            <DeleteParameters>
                <asp:Parameter Name="original_cartId" Type="Int32" />
                <asp:Parameter Name="original_bname" Type="String" />
                <asp:Parameter Name="original_price" Type="Double" />
                <asp:Parameter Name="original_qty" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="bname" Type="String" />
                <asp:Parameter Name="price" Type="Double" />
                <asp:Parameter Name="qty" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="bname" Type="String" />
                <asp:Parameter Name="price" Type="Double" />
                <asp:Parameter Name="qty" Type="Int32" />
                <asp:Parameter Name="original_cartId" Type="Int32" />
                <asp:Parameter Name="original_bname" Type="String" />
                <asp:Parameter Name="original_price" Type="Double" />
                <asp:Parameter Name="original_qty" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </p>
    <p>
        Subtotal: <asp:Label ID="lblSubtotal" runat="server"></asp:Label>
    </p>
    <p>
        Tax:
        <asp:Label ID="lblTax" runat="server"></asp:Label>
    </p>
    <p>
        Total:<asp:Label ID="lblTotal" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Button ID="btnCheckout" runat="server" Text="Checkout" PostBackUrl="~/CustomerForm.aspx" />
    </p>
</asp:Content>
