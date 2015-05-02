using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            setImageURL();
        }
    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        setImageURL();
    }

    private void setImageURL()
    {
        if (ViewState["ImageDisplayed"] == null)
        {
            Image1.ImageUrl = "~/Images/FrontPage/1.jpg";
            ViewState["ImageDisplayed"] = 1;
        }
        else
        {
            int i = (int)ViewState["ImageDisplayed"];
            if (i == 8)
            {
                Image1.ImageUrl = "~/Images/FrontPage/1.jpg";
                ViewState["ImageDisplayed"] = 1;
            }
            else
            {
                i++;
                Image1.ImageUrl = "~/Images/FrontPage/" + i.ToString() + ".jpg";
                ViewState["ImageDisplayed"] = i;
            }
        }
    }
}