using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

/// <summary>
/// Summary description for Repository
/// </summary>
public class Repository
{
    private static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["NORTHWNDConnectionString"].ConnectionString;

    private SqlConnection Connection { get; set; }

	public Repository()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public List<Category> GetCategories()
    {
        List<Category> categories = new List<Category>();

        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
            connection.Open();
            string query = "SELECT * FROM Categories";
            SqlCommand command = new SqlCommand(query, connection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string name = (string) reader["CategoryName"];
                    int id = (int) reader["CategoryID"];
                    string description = (string) reader["Description"];
                    categories.Add(new Category
                    {
                        Name = name,
                        Id = id,
                        Description = description
                    });
                    
                }
            }                        
        }

        return categories;
    }

    public List<Product> GetProductsByCategory(string category)
    {
        List<Product> categories = new List<Product>();

        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
            connection.Open();
            string query = "SELECT * FROM Products p JOIN Categories c ON p.CategoryID = c.CategoryID WHERE c.CategoryName = @category";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@category", category);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string name = (string)reader["ProductName"];
                    int id = (int)reader["ProductID"];                    
                    int unitsInStock = Convert.ToInt32(reader["UnitsInStock"]);
                    decimal unitPrice = (decimal)reader["UnitPrice"];
                    categories.Add(new Product
                    {
                        Name = name,
                        Id = id,
                        UnitsInStock = unitsInStock,
                        UnitPrice = unitPrice
                    });
                }
            }
        }

        return categories;
    }

    public void AddCategory(Category category)
    {
        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
            connection.Open();
            string query = "INSERT INTO Categories (CategoryName, Description) values (@name, @description)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", category.Name);
            command.Parameters.AddWithValue("@description", category.Description);
            command.ExecuteNonQuery();
        }
    }
}