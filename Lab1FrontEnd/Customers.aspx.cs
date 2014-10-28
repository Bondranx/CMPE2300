using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Customers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            _ddlCustomers.Items.Add(new ListItem("Pick a Customer...", null));
            _ddlCustomers.AppendDataBoundItems = true;
        }
    }
    protected void _ddlCustomers_SelectedIndexChanged(object sender, EventArgs e)
    {
        _gvCustomerOrders.SelectedIndex = -1;
    }
}