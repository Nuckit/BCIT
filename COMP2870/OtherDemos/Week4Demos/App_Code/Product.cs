using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Product
/// </summary>
public class Product
{
    public string ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }


    public static List<Product> GetSampleProducts()
    {
        return new List<Product> {
            new Product { ID = "1", Name="iPad", Description="iPad", Price=599},
            new Product { ID = "2", Name="iPod", Description="iPod", Price=299},
            new Product { ID = "3", Name="iMac", Description="iMac", Price=2599},
            new Product { ID = "4", Name="iWatch", Description="iWatch", Price=299},

        };
    }
}