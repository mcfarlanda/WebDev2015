using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Site : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CartModel model = new CartModel();
        string userId = "1";
        cartQnt.Text = string.Format("{0} ({1})", "Guest", model.GetAmountOfCart(userId));
    }
}
