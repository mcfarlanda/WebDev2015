using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_ShoppingCart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //get guest id
        string userId = "1";
        GetCartShoes(userId);
    }

    private void GetCartShoes(string userId)
    {
        CartModel model = new CartModel();
        double subtotal = 0;

        List<Cart> purchases = model.GetOrders(userId);
        CreateShopTable(purchases, out subtotal);

        //add taxes
        double tax = subtotal * 0.15;
        double total = subtotal + tax + 8;

        litTot.Text = "$" + total;
        litSub.Text = "$" + subtotal;
        litTax.Text = "$" + tax;
    }

    private void CreateShopTable(List<Cart> purchases, out double subtotal)
    {
        subtotal = new Double();
        Shoe shoeModel = new Shoe();

        foreach (Cart cart in purchases)
        {
            Sho shoe = shoeModel.GetShoe((int)cart.ShoeID);
            ImageButton btnImage = new ImageButton
            {
                ImageUrl = shoe.Image,
                PostBackUrl = string.Format("~/Pages/Shoe.aspx?id={0}", shoe.ShoeID)
            };
            LinkButton lnkDelete = new LinkButton
            {
                PostBackUrl = string.Format("~/Pages/Shoe.aspx?id={0}", shoe.ShoeID),
                Text = "Delete Item",
                ID = "del" + cart.ID
            };

            lnkDelete.Click += Delete_Item;

            int[] numbers = Enumerable.Range(1, 20).ToArray();
            DropDownList ddlQuant = new DropDownList
            {
                DataSource = numbers,
                AppendDataBoundItems = true,
                AutoPostBack = true,
                ID = cart.ID.ToString()
            };

            ddlQuant.DataBind();
            ddlQuant.SelectedValue = cart.Quantity.ToString();
            ddlQuant.SelectedIndexChanged += ddlQuant_SelectedIndexChanged;

            Table table = new Table { CssClass = "cartTable" };
            TableRow a = new TableRow();
            TableRow b = new TableRow();

            TableCell a1 = new TableCell { RowSpan = 2, Width = 50 };
            TableCell a2 = new TableCell { Text = string.Format("<h4>{0}</h4><br/>{1}<br/>In Stock", shoe.Name),
            HorizontalAlign = HorizontalAlign.Left, Width = 350};
            TableCell a3 = new TableCell { Text = "Price<hr/>"};
            TableCell a4 = new TableCell { Text = "Quantity<hr/>"};
            TableCell a5 = new TableCell { Text = "Item Total<hr/>"};
            TableCell a6 = new TableCell { };

            TableCell b1 = new TableCell { };
            TableCell b2 = new TableCell { Text = "$" + shoe.Price};
            TableCell b3 = new TableCell { };
            TableCell b4 = new TableCell { Text = "$" + Math.Round((cart.Quantity * shoe.Price),2)};
            TableCell b5 = new TableCell { };
            TableCell b6 = new TableCell { };

            a1.Controls.Add(btnImage);
            a6.Controls.Add(lnkDelete);
            b3.Controls.Add(ddlQuant);

            a.Cells.Add(a1);
            a.Cells.Add(a2);
            a.Cells.Add(a3);
            a.Cells.Add(a4);
            a.Cells.Add(a5);
            a.Cells.Add(a6);

            b.Cells.Add(b1);
            b.Cells.Add(b2);
            b.Cells.Add(b3);
            b.Cells.Add(b4);
            b.Cells.Add(b5);
            b.Cells.Add(b6);

            table.Rows.Add(a);
            table.Rows.Add(b);

            pnlShopping.Controls.Add(table);

            subtotal += (cart.Quantity * shoe.Price);
        }
        Session["1"] = purchases;
    }

    private void ddlQuant_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList selectedList = (DropDownList)sender;
        int quantity = Convert.ToInt32(selectedList.SelectedValue);
        int cartId = Convert.ToInt32(selectedList.ID);

        CartModel model = new CartModel();
        model.UpdateQuantity(cartId, quantity);

        Response.Redirect("~/Pages/ShoppingCart.aspx");
    }

    private void Delete_Item(object sender, EventArgs e)
    {
        LinkButton selectedLink = (LinkButton)sender;
        string link = selectedLink.ID.Replace("del", "");
        int CartId = Convert.ToInt32(link);
       
        CartModel model = new CartModel();
        model.DeleteCart(CartId);

        Response.Redirect("~/Pages/ShoppingCart.aspx");
    }
}