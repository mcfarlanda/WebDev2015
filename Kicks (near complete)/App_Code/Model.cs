﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class Cart
{
    public int ID { get; set; }
    public string CustomerID { get; set; }
    public Nullable<int> ShoeID { get; set; }
    public Nullable<System.DateTime> Date_Purchased { get; set; }
    public bool IsInCart { get; set; }
    public Nullable<int> Quantity { get; set; }
    public string Size { get; set; }

    public virtual Sho Sho { get; set; }
}

public partial class Sho
{
    public Sho()
    {
        this.Carts = new HashSet<Cart>();
    }

    public int ShoeID { get; set; }
    public int TypeID { get; set; }
    public int WearerID { get; set; }
    public string Brand { get; set; }
    public string Name { get; set; }
    public Nullable<decimal> Price { get; set; }
    public string Image { get; set; }

    public virtual ICollection<Cart> Carts { get; set; }
    public virtual ShoeType ShoeType { get; set; }
    public virtual Wearer Wearer { get; set; }
}

public partial class ShoeType
{
    public ShoeType()
    {
        this.Shoes = new HashSet<Sho>();
    }

    public int TypeID { get; set; }
    public string Name { get; set; }

    public virtual ICollection<Sho> Shoes { get; set; }
}

public partial class Wearer
{
    public Wearer()
    {
        this.Shoes = new HashSet<Sho>();
    }

    public int WearerID { get; set; }
    public string Name { get; set; }

    public virtual ICollection<Sho> Shoes { get; set; }
}
