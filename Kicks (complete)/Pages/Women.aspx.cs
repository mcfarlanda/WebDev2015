using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Women : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int loadShoes = Convert.ToInt32(Session["wID"]);
        if (loadShoes == null)
        {
            FillPage();
            Session["wID"] = 0;
        }
        else
        {
            switch (loadShoes)
            {
                case 2:
                    GetRunningShoes();
                    Session["wID"] = 0;
                    break;
                case 3:
                    GetBizShoes();
                    Session["wID"] = 0;
                    break;
                default:
                    FillPage();
                    Session["wID"] = 0;
                    break;
            }
        }
    }
    private void FillPage()
    {
        //Get a list of all products pertaining to Children in db
        Shoe shoe = new Shoe();
        List<Sho> womenShoes = shoe.GetShoeByWearer(3);

        //ensure shoes are actually in db
        if (womenShoes != null)
        {
            //create a panel with an Image button and labels for the Shoe
            foreach (Sho s in womenShoes)
            {
                Panel shoePanel = new Panel();
                ImageButton imageButton = new ImageButton();
                Label lblName = new Label();
                Label lblPrice = new Label();

                imageButton.ImageUrl = s.Image;
                imageButton.CssClass = "shoeImage";
                imageButton.PostBackUrl = "~/Pages/Shoe.aspx?id=" + s.ShoeID;

                lblName.Text = s.Name;
                lblName.CssClass = "shoeName";

                lblPrice.Text = "$ " + s.Price;
                lblPrice.CssClass = "shoePrice";

                shoePanel.Controls.Add(imageButton);
                shoePanel.Controls.Add(new Literal { Text = "<br />" });
                shoePanel.Controls.Add(lblName);
                shoePanel.Controls.Add(new Literal { Text = "<br />" });
                shoePanel.Controls.Add(lblPrice);

                pnlShoes.Controls.Add(shoePanel);
            }
        }
        else
        {
            pnlShoes.Controls.Add(new Literal { Text = "No shoes found!" });
        }
    }
    private void GetBizShoes()
    {
        //Get a list of all products pertaining to Women in db
        Shoe shoe = new Shoe();
        List<Sho> womenBizShoes = shoe.GetShoeByTypeAndWearer(2, 3);

        //ensure shoes are actually in db
        if (womenBizShoes != null)
        {
            //create a panel with an Image button and labels for the Shoe
            foreach (Sho s in womenBizShoes)
            {
                Panel shoePanel = new Panel();
                ImageButton imageButton = new ImageButton();
                Label lblName = new Label();
                Label lblPrice = new Label();

                imageButton.ImageUrl = s.Image;
                imageButton.CssClass = "shoeImage";
                imageButton.PostBackUrl = "~/Pages/Shoe.aspx?id=" + s.ShoeID;

                lblName.Text = s.Name;
                lblName.CssClass = "shoeName";

                lblPrice.Text = "$ " + s.Price;
                lblPrice.CssClass = "shoePrice";

                shoePanel.Controls.Add(imageButton);
                shoePanel.Controls.Add(new Literal { Text = "<br />" });
                shoePanel.Controls.Add(lblName);
                shoePanel.Controls.Add(new Literal { Text = "<br />" });
                shoePanel.Controls.Add(lblPrice);

                pnlShoes.Controls.Add(shoePanel);
            }
        }
        else
        {
            pnlShoes.Controls.Add(new Literal { Text = "No shoes found!" });
        }
    }
    private void GetRunningShoes()
    {
        //Get a list of all products pertaining to Men in db
        Shoe shoe = new Shoe();
        List<Sho> womenRunShoes = shoe.GetShoeByTypeAndWearer(1, 3);

        //ensure shoes are actually in db
        if (womenRunShoes != null)
        {
            //create a panel with an Image button and labels for the Shoe
            foreach (Sho s in womenRunShoes)
            {
                Panel shoePanel = new Panel();
                ImageButton imageButton = new ImageButton();
                Label lblName = new Label();
                Label lblPrice = new Label();

                imageButton.ImageUrl = s.Image;
                imageButton.CssClass = "shoeImage";
                imageButton.PostBackUrl = "~/Pages/Shoe.aspx?id=" + s.ShoeID;

                lblName.Text = s.Name;
                lblName.CssClass = "shoeName";

                lblPrice.Text = "$ " + s.Price;
                lblPrice.CssClass = "shoePrice";

                shoePanel.Controls.Add(imageButton);
                shoePanel.Controls.Add(new Literal { Text = "<br />" });
                shoePanel.Controls.Add(lblName);
                shoePanel.Controls.Add(new Literal { Text = "<br />" });
                shoePanel.Controls.Add(lblPrice);

                pnlShoes.Controls.Add(shoePanel);
            }
        }
        else
        {
            pnlShoes.Controls.Add(new Literal { Text = "No shoes found!" });
        }
    }
    protected void ddlCategories_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["wID"] = ddlCategories.SelectedIndex;
        Server.TransferRequest(Request.Url.AbsolutePath, false);
    }
}