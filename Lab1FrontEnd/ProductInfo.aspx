<%@ Page Title="" Language="C#" MasterPageFile="~/Lab1FrontEnd.master" AutoEventWireup="true"
    CodeFile="ProductInfo.aspx.cs" Inherits="ProductInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h3>Product List</h3>
    <table>
        <tr>
            <td align="right">
                <asp:Label ID="Label1" runat="server" Text="Category of Products to Display: "></asp:Label>
            </td>
            <td>
                <asp:SqlDataSource ID="_dsCategories" runat="server" ConnectionString="<%$ ConnectionStrings:skelemen1ConnectionString %>"
                    SelectCommand="GetCategories" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
                <asp:DropDownList ID="_ddlCategories" runat="server" AutoPostBack="True" DataSourceID="_dsCategories"
                    DataTextField="Category Name" DataValueField="Category ID" OnSelectedIndexChanged="_ddlCategories_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
    </table>
    <asp:SqlDataSource ID="_dsProducts" runat="server" ConnectionString="<%$ ConnectionStrings:skelemen1ConnectionString %>"
        SelectCommand="GetProductsForCategory" 
    SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:ControlParameter ControlID="_ddlCategories" DefaultValue="0" Name="Category"
                PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:GridView ID="_gvProducts" runat="server" BackColor="White" BorderColor="#999999"
        BorderStyle="None" BorderWidth="1px" CellPadding="3" AllowPaging="True" AllowSorting="True"
        AutoGenerateColumns="False" DataKeyNames="Product ID" DataSourceID="_dsProducts"
        GridLines="Vertical">
        <AlternatingRowStyle BackColor="#DCDCDC" />
        <Columns>
            <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
            <asp:BoundField DataField="Product Name" HeaderText="Product Name" SortExpression="Product Name" />
            <asp:BoundField DataField="Quantity Per Unit" HeaderText="Quantity Per Unit" SortExpression="Quantity Per Unit" />
            <asp:BoundField DataField="Unit Price" HeaderText="Unit Price" SortExpression="Unit Price" />
            <asp:CheckBoxField DataField="Discontinued" HeaderText="Discontinued" SortExpression="Discontinued" />
        </Columns>
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#0000A9" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#000065" />
    </asp:GridView>
    <hr />
    <h3>
        Selected Product Supplier</h3>
    <asp:SqlDataSource ID="_dsSupplier" runat="server" ConnectionString="<%$ ConnectionStrings:skelemen1ConnectionString %>"
        SelectCommand="GetSupplierForProduct" 
    SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:ControlParameter ControlID="_gvProducts" DefaultValue="0" Name="Product" PropertyName="SelectedValue"
                Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:GridView ID="__gvSupplier" runat="server" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow"
        BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataKeyNames="Supplier ID"
        DataSourceID="_dsSupplier" ForeColor="Black" GridLines="None">
        <AlternatingRowStyle BackColor="PaleGoldenrod" />
        <Columns>
            <asp:BoundField DataField="Supplier Name" HeaderText="Supplier Name" SortExpression="Supplier Name" />
            <asp:BoundField DataField="Contact Name" HeaderText="Contact Name" SortExpression="Contact Name" />
            <asp:BoundField DataField="Phone Number" HeaderText="Phone Number" SortExpression="Phone Number" />
            <asp:BoundField DataField="Fax Number" HeaderText="Fax Number" SortExpression="Fax Number" />
            <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
            <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
            <asp:BoundField DataField="Region" HeaderText="Region" SortExpression="Region" />
            <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country" />
            <asp:BoundField DataField="Postal Code" HeaderText="Postal Code" SortExpression="Postal Code" />
        </Columns>
        <FooterStyle BackColor="Tan" />
        <HeaderStyle BackColor="Tan" Font-Bold="True" />
        <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
        <SortedAscendingCellStyle BackColor="#FAFAE7" />
        <SortedAscendingHeaderStyle BackColor="#DAC09E" />
        <SortedDescendingCellStyle BackColor="#E1DB9C" />
        <SortedDescendingHeaderStyle BackColor="#C2A47B" />
    </asp:GridView>
    <hr />
</asp:Content>
