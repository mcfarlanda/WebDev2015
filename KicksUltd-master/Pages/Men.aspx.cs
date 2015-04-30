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
        FillPage();
    }
    private void FillPage()
    {
        //Get a list of all products pertaining to Children in db
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
}