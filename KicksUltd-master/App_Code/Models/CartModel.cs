using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Cart
/// </summary>
public class CartModel
{
    public string InsertCart(Cart cart)
    {
        try{
            ShoesDBEntities db = new ShoesDBEntities();
            db.Carts.Add(cart);
            db.SaveChanges();
            return "Order was placed in the cart";
        }
        catch(Exception e) {
            return "Error: " + e;
        }
    }

    public string UpdateCart(int id, Cart cart)
    {
        try
        {
            ShoesDBEntities db = new ShoesDBEntities();
            //fetch object from db
            Cart c = db.Carts.Find(id);
            
            c.Date_Purchased = cart.Date_Purchased;
            c.CustomerID = cart.CustomerID;
            c.Quantity = cart.Quantity;
            c.Sizes = cart.Sizes;
            c.IsInCart = cart.IsInCart;
            c.ShoeID = cart.ShoeID;
            
            db.SaveChanges();
            return "Cart was successfully updated";

        } catch(Exception e) {
            return "Error: " + e;
        }
    }

    public string DeleteCart(int id)
    {
        try
        {
            ShoesDBEntities db = new ShoesDBEntities();
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
        ShoesDBEntities db = new ShoesDBEntities();
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
            ShoesDBEntities db = new ShoesDBEntities();
            int amount = (from x in db.Carts
                          where x.CustomerID == userId
                          && x.IsInCart
                          select x.Quantity).Sum();
            return amount;
        }
        catch
        { return 0; }
    }

    public void UpdateQuantity(int id, int qnt)
    {
        ShoesDBEntities db = new ShoesDBEntities();
        Cart cart = db.Carts.Find(id);
        cart.Quantity = qnt;
        db.SaveChanges();
    }

    public void MarkPaid(List<Cart> carts)
    {
        ShoesDBEntities db = new ShoesDBEntities();
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