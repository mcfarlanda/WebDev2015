using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Children : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int loadShoes = Convert.ToInt32(Session["cID"]);
        if (loadShoes == null)
        {
            FillPage();
            Session["cID"] = 0;
        }
        else
        {
            switch (loadShoes)
            {
                case 2:
                    GetRunningShoes();
                    Session["cID"] = 0;
                    break;
                case 3:
                    GetBballShoes();
                    Session["cID"] = 0;
                    break;
                default:
                    FillPage();
                    Session["cID"] = 0;
                    break;
            }
        }
    }
    private void FillPage()
    {
        //Get a list of all products pertaining to Children in db
        Shoe shoe = new Shoe();
        List<Sho> childShoes = shoe.GetShoeByWearer(1);

        //ensure shoes are actually in db
        if (childShoes != null)
        {
            //create a panel with an Image button and labels for the Shoe
            foreach (Sho s in childShoes)
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
        List<Sho> kidsRunShoes = shoe.GetShoeByTypeAndWearer(1, 1);

        //ensure shoes are actually in db
        if (kidsRunShoes != null)
        {
            //create a panel with an Image button and labels for the Shoe
            foreach (Sho s in kidsRunShoes)
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
    private void GetBballShoes()
    {
        //Get a list of all products pertaining to Children in db
        Shoe shoe = new Shoe();
        List<Sho> kidsBallShoes = shoe.GetShoeByTypeAndWearer(4, 1);

        //ensure shoes are actually in db
        if (kidsBallShoes != null)
        {
            //create a panel with an Image button and labels for the Shoe
            foreach (Sho s in kidsBallShoes)
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
        Session["cID"] = ddlCategories.SelectedIndex;
        Server.TransferRequest(Request.Url.AbsolutePath, false);
    }
}