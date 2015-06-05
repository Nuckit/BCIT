using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

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

                    yield return new Category()
                }
            }                        
        }
    }

    public List<Product> GetProductsByCategory(string category)
    {

    }
}