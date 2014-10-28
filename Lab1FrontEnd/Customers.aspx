<%@ Page Title="" Language="C#" MasterPageFile="~/Lab1FrontEnd.master" AutoEventWireup="true"
    CodeFile="Customers.aspx.cs" Inherits="Customers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:content id="Content2" contentplaceholderid="ContentPlaceHolder1" runat="Server">
    <h3>
        Customer Summary</h3>
    <table>
        <tr>
            <td align="right">
                <asp:label id="Label1" runat="server" text="Customer Name: "></asp:label>
            </td>
            <td>
                <asp:sqldatasource id="_dsCustomers" runat="server" connectionstring="<%$ ConnectionStrings:skelemen1ConnectionString %>"
                    selectcommand="GetCustomers" selectcommandtype="StoredProcedure"></asp:sqldatasource>
                <asp:dropdownlist id="_ddlCustomers" runat="server" autopostback="True" datasourceid="_dsCustomers"
                    datatextfield="Customer Name" datavaluefield="Customer ID" onselectedindexchanged="_ddlCustomers_SelectedIndexChanged">
                </asp:dropdownlist>
            </td>
        </tr>
    </table>
    <asp:sqldatasource id="_dsCustomer" runat="server" connectionstring="<%$ ConnectionStrings:skelemen1ConnectionString %>"
        selectcommand="GetCustomerInfo" selectcommandtype="StoredProcedure">
        <selectparameters>
            <asp:ControlParameter ControlID="_ddlCustomers" Name="Customer" PropertyName="SelectedValue"
                Type="String" />
        </selectparameters>
    </asp:sqldatasource>
    <asp:gridview id="_gvCustomer" runat="server" backcolor="White" bordercolor="#AAAAAA"
        borderstyle="Groove" borderwidth="1px" cellpadding="3" datasourceid="_dsCustomer"
        gridlines="Vertical" autogeneratecolumns="False">
        <alternatingrowstyle backcolor="#DCDCDC" />
        <columns>
            <asp:BoundField DataField="Customer Name" HeaderText="Customer Name" SortExpression="Customer Name" />
            <asp:BoundField DataField="Customer Contact" HeaderText="Customer Contact" SortExpression="Customer Contact" />
            <asp:BoundField DataField="Contact Title" HeaderText="Contact Title" SortExpression="Contact Title" />
            <asp:BoundField DataField="Phone Number" HeaderText="Phone Number" SortExpression="Phone Number" />
            <asp:BoundField DataField="Fax Number" HeaderText="Fax Number" SortExpression="Fax Number" />
            <asp:BoundField DataField="Customer Address" HeaderText="Customer Address" SortExpression="Customer Address" />
            <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
            <asp:BoundField DataField="Region" HeaderText="Region" SortExpression="Region" />
            <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country" />
            <asp:BoundField DataField="Postal Code" HeaderText="Postal Code" SortExpression="Postal Code" />
        </columns>
        <footerstyle backcolor="#CCCCCC" forecolor="Black" />
        <headerstyle backcolor="#000084" font-bold="True" forecolor="White" />
        <pagerstyle backcolor="#999999" forecolor="Black" horizontalalign="Center" />
        <rowstyle backcolor="#EEEEEE" forecolor="Black" />
        <selectedrowstyle backcolor="#008A8C" font-bold="True" forecolor="White" />
        <sortedascendingcellstyle backcolor="#F1F1F1" />
        <sortedascendingheaderstyle backcolor="#0000A9" />
        <sorteddescendingcellstyle backcolor="#CAC9C9" />
        <sorteddescendingheaderstyle backcolor="#000065" />
    </asp:gridview>
    <hr />
    <table>
        <tr>
            <td colspan="2">
                <h3>
                    Order History</h3>
                <asp:sqldatasource id="_dsCustomerOrders" runat="server" connectionstring="<%$ ConnectionStrings:skelemen1ConnectionString %>"
                    selectcommand="GetCustomerOrders" selectcommandtype="StoredProcedure">
                    <selectparameters>
            <asp:ControlParameter ControlID="_ddlCustomers" Name="Customer" PropertyName="SelectedValue"
                Type="String" />
        </selectparameters>
                </asp:sqldatasource>
                <asp:gridview id="_gvCustomerOrders" runat="server" allowpaging="True" allowsorting="True"
                    autogeneratecolumns="False" datakeynames="Order ID" backcolor="LightGoldenrodYellow"
                    bordercolor="Tan" borderwidth="1px" cellpadding="2" datasourceid="_dsCustomerOrders"
                    forecolor="Black" gridlines="None">
                    <alternatingrowstyle backcolor="PaleGoldenrod" />
                    <columns>
            <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
            <asp:BoundField DataField="Order ID" HeaderText="Order ID" InsertVisible="False"
                ReadOnly="True" SortExpression="Order ID" />
            <asp:BoundField DataField="Order Date" HeaderText="Order Date" SortExpression="Order Date" />
            <asp:BoundField DataField="Required Date" HeaderText="Required Date" SortExpression="Required Date" />
            <asp:BoundField DataField="Shipped Date" HeaderText="Shipped Date" SortExpression="Shipped Date" />
            <asp:BoundField DataField="Processing Employee" HeaderText="Processing Employee"
                ReadOnly="True" SortExpression="Processing Employee" />
            <asp:BoundField DataField="Employee ID" HeaderText="Employee ID" InsertVisible="False"
                ReadOnly="True" SortExpression="Employee ID" />
            <asp:BoundField DataField="Shipper's Name" HeaderText="Shipper's Name" SortExpression="Shipper's Name" />
            <asp:BoundField DataField="Days Overdue" HeaderText="Days Overdue" ReadOnly="True"
                SortExpression="Days Overdue" />
        </columns>
                    <footerstyle backcolor="Tan" />
                    <headerstyle backcolor="Tan" font-bold="True" />
                    <pagerstyle backcolor="PaleGoldenrod" forecolor="DarkSlateBlue" horizontalalign="Center" />
                    <selectedrowstyle backcolor="DarkSlateBlue" forecolor="GhostWhite" />
                    <sortedascendingcellstyle backcolor="#FAFAE7" />
                    <sortedascendingheaderstyle backcolor="#DAC09E" />
                    <sorteddescendingcellstyle backcolor="#E1DB9C" />
                    <sorteddescendingheaderstyle backcolor="#C2A47B" />
                </asp:gridview>
                <hr />
            </td>
        </tr>
        <tr>
            <td>
                <h3>
                    Items for Selected Order</h3>
            </td>
        </tr>
        <tr>
            <td>
                <asp:sqldatasource id="_dsOrderDetails" runat="server" connectionstring="<%$ ConnectionStrings:skelemen1ConnectionString %>"
                    selectcommand="GetOrderDetails" selectcommandtype="StoredProcedure">
                    <selectparameters>
                <asp:ControlParameter ControlID="_gvCustomerOrders" Name="OrderID" PropertyName="SelectedValue"
                    Type="Int32" />
            </selectparameters>
                </asp:sqldatasource>
                <asp:gridview id="_gvOrderDetails" runat="server" allowpaging="True" allowsorting="True"
                    autogeneratecolumns="False" backcolor="White" bordercolor="#999999" borderstyle="Solid"
                    borderwidth="1px" cellpadding="3" datasourceid="_dsOrderDetails" forecolor="Black"
                    gridlines="Vertical">
                    <alternatingrowstyle backcolor="#CCCCCC" />
                    <columns>
                <asp:BoundField DataField="Product Name" HeaderText="Product Name" SortExpression="Product Name" />
                <asp:BoundField DataField="Unit Price" HeaderText="Unit Price" SortExpression="Unit Price" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
                <asp:BoundField DataField="Discount" HeaderText="Discount" SortExpression="Discount" />
                <asp:BoundField DataField="Item Total" HeaderText="Item Total" ReadOnly="True" SortExpression="Item Total" />
            </columns>
                    <footerstyle backcolor="#CCCCCC" />
                    <headerstyle backcolor="Black" font-bold="True" forecolor="White" />
                    <pagerstyle backcolor="#999999" forecolor="Black" horizontalalign="Center" />
                    <selectedrowstyle backcolor="#000099" font-bold="True" forecolor="White" />
                    <sortedascendingcellstyle backcolor="#F1F1F1" />
                    <sortedascendingheaderstyle backcolor="#808080" />
                    <sorteddescendingcellstyle backcolor="#CAC9C9" />
                    <sorteddescendingheaderstyle backcolor="#383838" />
                </asp:gridview>
            </td>

        </tr>
    </table>
    
</asp:content>
