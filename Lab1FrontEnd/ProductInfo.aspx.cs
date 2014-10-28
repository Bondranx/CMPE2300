using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProductInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            _ddlCategories.Items.Add(new ListItem("Show All", "0"));
            _ddlCategories.AppendDataBoundItems = true;
        }
    }
    protected void _ddlCategories_SelectedIndexChanged(object sender, EventArgs e)
    {
        _gvProducts.SelectedIndex = -1;
    }
}