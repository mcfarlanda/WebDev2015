using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Sho
/// </summary>
public class Shoe
{
    public Sho GetShoe(int id)
    {
        try
        {
            using (ShoesDBEntities db = new ShoesDBEntities())
            {
                return db.Shoes.Find(id);
            }
        }
        catch (Exception)
        {
            return null;
        }
    }

    public List<Sho> GetAllShoes(){
        try
        {
            using (ShoesDBEntities db = new ShoesDBEntities())
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
            using (ShoesDBEntities db = new ShoesDBEntities())
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

    public List<Sho> GetShoeByWearer(int wID)
    {
        try
        {
            using (ShoesDBEntities db = new ShoesDBEntities())
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