using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Success : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<Cart> carts = (List<Cart>)Session["1"];
        CartModel model = new CartModel();
        model.MarkPaid(carts);
        Session["1"] = null;
    }
}