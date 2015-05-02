using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Shoe
/// </summary>
public class Shoe
{
    public Sho GetShoe(int id)
    {
        try
        {
            using (ShoeDBEntities db = new ShoeDBEntities())
            {
                return db.Shoes.Find(id);
            }
        }
        catch (Exception)
        {
            return null;
        }
    }

    public List<Sho> GetAllShoes()
    {
        try
        {
            using (ShoeDBEntities db = new ShoeDBEntities())
            {
                List<Sho> shoes = (from x in db.Shoes select x).ToList();
                return shoes;
            }
        }
        catch (Exception)
        {
            return null;
        }
    }

    public List<Sho> GetShoeByType(int tID)
    {
        try
        {
            using (ShoeDBEntities db = new ShoeDBEntities())
            {
                List<Sho> shoes = (from x in db.Shoes where x.TypeID == tID select x).ToList();
                return shoes;
            }
        }
        catch (Exception)
        {
            return null;
        }
    }

    public List<Sho> GetShoeByTypeAndWearer(int tID, int wID)
    {
        try
        {
            using (ShoeDBEntities db = new ShoeDBEntities())
            {
                List<Sho> shoes = (from x in db.Shoes where x.TypeID == tID & x.WearerID == wID select x).ToList();
                return shoes;
            }
        }
        catch (Exception)
        {
            return null;
        }
    }

    public List<Sho> GetShoeByWearer(int wID)
    {
        try
        {
            using (ShoeDBEntities db = new ShoeDBEntities())
            {
                List<Sho> shoes = (from x in db.Shoes where x.WearerID == wID select x).ToList();
                return shoes;
            }
        }
        catch (Exception)
        {
            return null;
        }
    }
}