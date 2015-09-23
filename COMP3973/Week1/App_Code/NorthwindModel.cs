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

public partial class Alphabetical_list_of_product
{
    public int ProductID { get; set; }
    public string ProductName { get; set; }
    public Nullable<int> SupplierID { get; set; }
    public Nullable<int> CategoryID { get; set; }
    public string QuantityPerUnit { get; set; }
    public Nullable<decimal> UnitPrice { get; set; }
    public Nullable<short> UnitsInStock { get; set; }
    public Nullable<short> UnitsOnOrder { get; set; }
    public Nullable<short> ReorderLevel { get; set; }
    public bool Discontinued { get; set; }
    public string CategoryName { get; set; }
}

public partial class Category
{
    public Category()
    {
        this.Products = new HashSet<Product>();
    }

    public int CategoryID { get; set; }
    public string CategoryName { get; set; }
    public string Description { get; set; }
    public byte[] Picture { get; set; }

    public virtual ICollection<Product> Products { get; set; }
}

public partial class Category_Sales_for_1997
{
    public string CategoryName { get; set; }
    public Nullable<decimal> CategorySales { get; set; }
}

public partial class Current_Product_List
{
    public int ProductID { get; set; }
    public string ProductName { get; set; }
}

public partial class Customer
{
    public Customer()
    {
        this.Orders = new HashSet<Order>();
        this.CustomerDemographics = new HashSet<CustomerDemographic>();
    }

    public string CustomerID { get; set; }
    public string CompanyName { get; set; }
    public string ContactName { get; set; }
    public string ContactTitle { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Region { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
    public string Phone { get; set; }
    public string Fax { get; set; }

    public virtual ICollection<Order> Orders { get; set; }
    public virtual ICollection<CustomerDemographic> CustomerDemographics { get; set; }
}

public partial class Customer_and_Suppliers_by_City
{
    public string City { get; set; }
    public string CompanyName { get; set; }
    public string ContactName { get; set; }
    public string Relationship { get; set; }
}

public partial class CustomerDemographic
{
    public CustomerDemographic()
    {
        this.Customers = new HashSet<Customer>();
    }

    public string CustomerTypeID { get; set; }
    public string CustomerDesc { get; set; }

    public virtual ICollection<Customer> Customers { get; set; }
}

public partial class Employee
{
    public Employee()
    {
        this.Employees1 = new HashSet<Employee>();
        this.Orders = new HashSet<Order>();
        this.Territories = new HashSet<Territory>();
    }

    public int EmployeeID { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Title { get; set; }
    public string TitleOfCourtesy { get; set; }
    public Nullable<System.DateTime> BirthDate { get; set; }
    public Nullable<System.DateTime> HireDate { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Region { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
    public string HomePhone { get; set; }
    public string Extension { get; set; }
    public byte[] Photo { get; set; }
    public string Notes { get; set; }
    public Nullable<int> ReportsTo { get; set; }
    public string PhotoPath { get; set; }

    public virtual ICollection<Employee> Employees1 { get; set; }
    public virtual Employee Employee1 { get; set; }
    public virtual ICollection<Order> Orders { get; set; }
    public virtual ICollection<Territory> Territories { get; set; }
}

public partial class Invoice
{
    public string ShipName { get; set; }
    public string ShipAddress { get; set; }
    public string ShipCity { get; set; }
    public string ShipRegion { get; set; }
    public string ShipPostalCode { get; set; }
    public string ShipCountry { get; set; }
    public string CustomerID { get; set; }
    public string CustomerName { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Region { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
    public string Salesperson { get; set; }
    public int OrderID { get; set; }
    public Nullable<System.DateTime> OrderDate { get; set; }
    public Nullable<System.DateTime> RequiredDate { get; set; }
    public Nullable<System.DateTime> ShippedDate { get; set; }
    public string ShipperName { get; set; }
    public int ProductID { get; set; }
    public string ProductName { get; set; }
    public decimal UnitPrice { get; set; }
    public short Quantity { get; set; }
    public float Discount { get; set; }
    public Nullable<decimal> ExtendedPrice { get; set; }
    public Nullable<decimal> Freight { get; set; }
}

public partial class Order
{
    public Order()
    {
        this.Order_Details = new HashSet<Order_Detail>();
    }

    public int OrderID { get; set; }
    public string CustomerID { get; set; }
    public Nullable<int> EmployeeID { get; set; }
    public Nullable<System.DateTime> OrderDate { get; set; }
    public Nullable<System.DateTime> RequiredDate { get; set; }
    public Nullable<System.DateTime> ShippedDate { get; set; }
    public Nullable<int> ShipVia { get; set; }
    public Nullable<decimal> Freight { get; set; }
    public string ShipName { get; set; }
    public string ShipAddress { get; set; }
    public string ShipCity { get; set; }
    public string ShipRegion { get; set; }
    public string ShipPostalCode { get; set; }
    public string ShipCountry { get; set; }

    public virtual Customer Customer { get; set; }
    public virtual Employee Employee { get; set; }
    public virtual ICollection<Order_Detail> Order_Details { get; set; }
    public virtual Shipper Shipper { get; set; }
}

public partial class Order_Detail
{
    public int OrderID { get; set; }
    public int ProductID { get; set; }
    public decimal UnitPrice { get; set; }
    public short Quantity { get; set; }
    public float Discount { get; set; }

    public virtual Order Order { get; set; }
    public virtual Product Product { get; set; }
}

public partial class Order_Details_Extended
{
    public int OrderID { get; set; }
    public int ProductID { get; set; }
    public string ProductName { get; set; }
    public decimal UnitPrice { get; set; }
    public short Quantity { get; set; }
    public float Discount { get; set; }
    public Nullable<decimal> ExtendedPrice { get; set; }
}

public partial class Order_Subtotal
{
    public int OrderID { get; set; }
    public Nullable<decimal> Subtotal { get; set; }
}

public partial class Orders_Qry
{
    public int OrderID { get; set; }
    public string CustomerID { get; set; }
    public Nullable<int> EmployeeID { get; set; }
    public Nullable<System.DateTime> OrderDate { get; set; }
    public Nullable<System.DateTime> RequiredDate { get; set; }
    public Nullable<System.DateTime> ShippedDate { get; set; }
    public Nullable<int> ShipVia { get; set; }
    public Nullable<decimal> Freight { get; set; }
    public string ShipName { get; set; }
    public string ShipAddress { get; set; }
    public string ShipCity { get; set; }
    public string ShipRegion { get; set; }
    public string ShipPostalCode { get; set; }
    public string ShipCountry { get; set; }
    public string CompanyName { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Region { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
}

public partial class Product
{
    public Product()
    {
        this.Order_Details = new HashSet<Order_Detail>();
    }

    public int ProductID { get; set; }
    public string ProductName { get; set; }
    public Nullable<int> SupplierID { get; set; }
    public Nullable<int> CategoryID { get; set; }
    public string QuantityPerUnit { get; set; }
    public Nullable<decimal> UnitPrice { get; set; }
    public Nullable<short> UnitsInStock { get; set; }
    public Nullable<short> UnitsOnOrder { get; set; }
    public Nullable<short> ReorderLevel { get; set; }
    public bool Discontinued { get; set; }

    public virtual Category Category { get; set; }
    public virtual ICollection<Order_Detail> Order_Details { get; set; }
    public virtual Supplier Supplier { get; set; }
}

public partial class Product_Sales_for_1997
{
    public string CategoryName { get; set; }
    public string ProductName { get; set; }
    public Nullable<decimal> ProductSales { get; set; }
}

public partial class Products_Above_Average_Price
{
    public string ProductName { get; set; }
    public Nullable<decimal> UnitPrice { get; set; }
}

public partial class Products_by_Category
{
    public string CategoryName { get; set; }
    public string ProductName { get; set; }
    public string QuantityPerUnit { get; set; }
    public Nullable<short> UnitsInStock { get; set; }
    public bool Discontinued { get; set; }
}

public partial class Region
{
    public Region()
    {
        this.Territories = new HashSet<Territory>();
    }

    public int RegionID { get; set; }
    public string RegionDescription { get; set; }

    public virtual ICollection<Territory> Territories { get; set; }
}

public partial class Sales_by_Category
{
    public int CategoryID { get; set; }
    public string CategoryName { get; set; }
    public string ProductName { get; set; }
    public Nullable<decimal> ProductSales { get; set; }
}

public partial class Sales_Totals_by_Amount
{
    public Nullable<decimal> SaleAmount { get; set; }
    public int OrderID { get; set; }
    public string CompanyName { get; set; }
    public Nullable<System.DateTime> ShippedDate { get; set; }
}

public partial class Shipper
{
    public Shipper()
    {
        this.Orders = new HashSet<Order>();
    }

    public int ShipperID { get; set; }
    public string CompanyName { get; set; }
    public string Phone { get; set; }

    public virtual ICollection<Order> Orders { get; set; }
}

public partial class Summary_of_Sales_by_Quarter
{
    public Nullable<System.DateTime> ShippedDate { get; set; }
    public int OrderID { get; set; }
    public Nullable<decimal> Subtotal { get; set; }
}

public partial class Summary_of_Sales_by_Year
{
    public Nullable<System.DateTime> ShippedDate { get; set; }
    public int OrderID { get; set; }
    public Nullable<decimal> Subtotal { get; set; }
}

public partial class Supplier
{
    public Supplier()
    {
        this.Products = new HashSet<Product>();
    }

    public int SupplierID { get; set; }
    public string CompanyName { get; set; }
    public string ContactName { get; set; }
    public string ContactTitle { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Region { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
    public string Phone { get; set; }
    public string Fax { get; set; }
    public string HomePage { get; set; }

    public virtual ICollection<Product> Products { get; set; }
}

public partial class Territory
{
    public Territory()
    {
        this.Employees = new HashSet<Employee>();
    }

    public string TerritoryID { get; set; }
    public string TerritoryDescription { get; set; }
    public int RegionID { get; set; }

    public virtual Region Region { get; set; }
    public virtual ICollection<Employee> Employees { get; set; }
}

public partial class CustOrderHist_Result
{
    public string ProductName { get; set; }
    public Nullable<int> Total { get; set; }
}

public partial class CustOrdersDetail_Result
{
    public string ProductName { get; set; }
    public decimal UnitPrice { get; set; }
    public short Quantity { get; set; }
    public Nullable<int> Discount { get; set; }
    public Nullable<decimal> ExtendedPrice { get; set; }
}

public partial class CustOrdersOrders_Result
{
    public int OrderID { get; set; }
    public Nullable<System.DateTime> OrderDate { get; set; }
    public Nullable<System.DateTime> RequiredDate { get; set; }
    public Nullable<System.DateTime> ShippedDate { get; set; }
}

public partial class Employee_Sales_by_Country_Result
{
    public string Country { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public Nullable<System.DateTime> ShippedDate { get; set; }
    public int OrderID { get; set; }
    public Nullable<decimal> SaleAmount { get; set; }
}

public partial class Sales_by_Year_Result
{
    public Nullable<System.DateTime> ShippedDate { get; set; }
    public int OrderID { get; set; }
    public Nullable<decimal> Subtotal { get; set; }
    public string Year { get; set; }
}

public partial class SalesByCategory_Result
{
    public string ProductName { get; set; }
    public Nullable<decimal> TotalPurchase { get; set; }
}

public partial class Ten_Most_Expensive_Products_Result
{
    public string TenMostExpensiveProducts { get; set; }
    public Nullable<decimal> UnitPrice { get; set; }
}
