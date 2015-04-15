using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
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
            Image1.ImageUrl = "Images/1.jpg";
            ViewState["ImageDisplayed"] = 1;
        }
        else
        {
            int i = (int)ViewState["ImageDisplayed"];
            if (i == 4)
            {
                Image1.ImageUrl = "Images/1.jpg";
                ViewState["ImageDisplayed"] = 1;
            }
            else {
                i++;
                Image1.ImageUrl = "Images/" + i.ToString() + ".jpg";
                ViewState["ImageDisplayed"] = i;
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("www.google.com");
    }
}