using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Men : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int loadShoes = Convert.ToInt32(Session["mID"]);
        if (loadShoes == null)
        {
            FillPage();
            Session["mID"] = 0;
        }
        else
        {
            switch (loadShoes)
            {
                case 2:
                    GetRunningShoes();
                    Session["mID"] = 0;
                    break;
                case 3:
                    GetBballShoes();
                    Session["mID"] = 0;
                    break;
                case 4:
                    GetCasualShoes();
                    Session["mID"] = 0;
                    break;
                default:
                    FillPage();
                    Session["mID"] = 0;
                    break;
            }
        }
    }
    private void FillPage()
    {
        //Get a list of all products pertaining to Men in db
        Shoe shoe = new Shoe();
        List<Sho> menShoes = shoe.GetShoeByWearer(2);

        //ensure shoes are actually in db
        if (menShoes != null)
        {
            //create a panel with an Image button and labels for the Shoe
            foreach (Sho s in menShoes)
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
        List<Sho> menRunShoes = shoe.GetShoeByTypeAndWearer(1,2);

        //ensure shoes are actually in db
        if (menRunShoes != null)
        {
            //create a panel with an Image button and labels for the Shoe
            foreach (Sho s in menRunShoes)
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
        //Get a list of all products pertaining to Men in db
        Shoe shoe = new Shoe();
        List<Sho> menBallShoes = shoe.GetShoeByTypeAndWearer(4,2);

        //ensure shoes are actually in db
        if (menBallShoes != null)
        {
            //create a panel with an Image button and labels for the Shoe
            foreach (Sho s in menBallShoes)
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
    private void GetCasualShoes()
    {
        //Get a list of all products pertaining to Men in db
        Shoe shoe = new Shoe();
        List<Sho> menCasualShoes = shoe.GetShoeByTypeAndWearer(3,2);

        //ensure shoes are actually in db
        if (menCasualShoes != null)
        {
            //create a panel with an Image button and labels for the Shoe
            foreach (Sho s in menCasualShoes)
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
        Session["mID"] = ddlCategories.SelectedIndex;
        Server.TransferRequest(Request.Url.AbsolutePath, false);
    }
}