using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for NWindRepository
/// </summary>
public class NWindRepository
{
	public NWindRepository()
	{
		
	}

    private string NWConnectionString
    {
        get { return ConfigurationManager.ConnectionStrings["NORTHWNDConnectionString1"].ConnectionString;  }
    }


    private SqlConnection Connection
    {
        get
        {
            return new SqlConnection(NWConnectionString);
        }
    }

    public void OpenAndCloseConnection()
    {
        var conn = Connection;

        conn.Open();
        //Do some work - query...
        conn.Close();
    }


    public List<Customer> GetCustomers()
    {
        var customers = new List<Customer>();
        using(var conn = Connection)
        {
            var query = "SELECT * FROM Customers";
            var sqlCmd = new SqlCommand(query, conn);
            conn.Open(); //Open Connection
            var rdr = sqlCmd.ExecuteReader();
            while (rdr.Read())
            {
                var customer = new Customer();
                customer.CustomerID = rdr["CustomerID"] as string;
                customer.CompanyName = rdr["CompanyName"] as string;
                customers.Add(customer);
            }

        }
            
        return customers;
    }

    public List<Supplier> GetSuppliersByCountry(string country)
    {
        var suppliers = new List<Supplier>();

        using (var conn = Connection)
        {
            var query = "SELECT * FROM Suppliers WHERE Country = @country";
            var sqlCmd = new SqlCommand(query, conn);
            sqlCmd.Parameters.AddWithValue("@country", country);

            conn.Open(); //Open Connection
            var rdr = sqlCmd.ExecuteReader();
            while (rdr.Read())
            {
                var supplier = new Supplier();
                supplier.ID = (int)rdr["SupplierID"];
                supplier.CompanyName = (string)rdr["CompanyName"];
                supplier.ContactName = (string)rdr["ContactName"];
                suppliers.Add(supplier);
            }

        }

        return suppliers;
    }

   
    public DataTable GetAllCustomerData()
    {
        var dt = new DataTable();
        var sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Customers", Connection);

        sqlDataAdapter.Fill(dt);

        return dt;
    }


}