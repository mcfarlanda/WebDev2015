using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CartModel
/// </summary>
public class CartModel
{
    public string InsertCart(Cart cart)
    {
        try
        {
            ShoeDBEntities db = new ShoeDBEntities();
            db.Carts.Add(cart);
            db.SaveChanges();
            return "Order was placed in the cart";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }

    public string UpdateCart(int id, Cart cart)
    {
        try
        {
            ShoeDBEntities db = new ShoeDBEntities();
            //fetch object from db
            Cart c = db.Carts.Find(id);

            c.Date_Purchased = cart.Date_Purchased;
            c.CustomerID = cart.CustomerID;
            c.Quantity = cart.Quantity;
            c.Size = cart.Size;
            c.IsInCart = cart.IsInCart;
            c.ShoeID = cart.ShoeID;

            db.SaveChanges();
            return "Cart was successfully updated";

        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }

    public string DeleteCart(int id)
    {
        try
        {
            ShoeDBEntities db = new ShoeDBEntities();
            Cart cart = db.Carts.Find(id);

            db.Carts.Attach(cart);
            db.Carts.Remove(cart);
            db.SaveChanges();
            return "Cart was removed";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }

    public List<Cart> GetOrders(string userId)
    {
        ShoeDBEntities db = new ShoeDBEntities();
        List<Cart> orders = (from x in db.Carts
                             where x.CustomerID == userId
                             && x.IsInCart
                             orderby x.Date_Purchased
                             select x).ToList();
        return orders;
    }

    public int GetAmountOfCart(string userId)
    {
        try
        {
            ShoeDBEntities db = new ShoeDBEntities();
            int amount = (from x in db.Carts
                          where x.CustomerID == userId
                          && x.IsInCart
                          select (int)x.Quantity).Sum();
            return amount;
        }
        catch
        { return 0; }
    }

    public void UpdateQuantity(int id, int qnt)
    {
        ShoeDBEntities db = new ShoeDBEntities();
        Cart cart = db.Carts.Find(id);
        cart.Quantity = qnt;
        db.SaveChanges();
    }

    public void MarkPaid(List<Cart> carts)
    {
        ShoeDBEntities db = new ShoeDBEntities();
        if (carts != null)
        {
            foreach (Cart cart in carts)
            {
                Cart oldCart = db.Carts.Find(cart.ID);
                oldCart.Date_Purchased = DateTime.Now;
                oldCart.IsInCart = false;
            }
            db.SaveChanges();
        }
    }
}