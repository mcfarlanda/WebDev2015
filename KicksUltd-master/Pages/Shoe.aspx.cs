using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Shoe : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FillPage();
    }

    private void FillPage()
    {
        //getting the shoe's data
        if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            Shoe shoes = new Shoe();
            Sho shoe = shoes.GetShoe(id);

            //put shoe's data on page
            lblPrice.Text = "Price: <br/>$" + shoe.Price;
            lblTitle.Text = shoe.Name;
            imgShoe.ImageUrl = shoe.Image;

            int [] numbers = Enumerable.Range(1,20).ToArray();
            ddlQuant.DataSource = numbers;
            ddlQuant.AppendDataBoundItems = true;
            ddlQuant.DataBind();
        }
    }
    protected void addBtn_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
        {
            string custId = "1";
            int id = Convert.ToInt32(Request.QueryString["id"]);
            int amount = Convert.ToInt32(ddlQuant.SelectedValue);
            Cart cart = new Cart
            {
                CustomerID = custId,
                /*Quantity = amount,
                 Sizes = Convert.ToInt32(txtSize.Text),*/
                Date_Purchased = DateTime.Now,
                IsInCart = true,
                ShoeID = id
            };
            CartModel model = new CartModel();
            lblResult.Text = model.InsertCart(cart);
        }
    }
}