using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for TaskRepository
/// </summary>
public class TaskRepository
{
    private static readonly string ConnectionString =
        ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

	public TaskRepository()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public int AddTask(Task task)
    {
        using (SqlConnection connection = GetConnection())
        {
            SqlCommand command = new SqlCommand("INSERT INTO Task VALUES (@Name, @CategoryId, @StartDate, @DueDate, @Completed, @Priority, @PercentComplete)");
            command.Parameters.AddWithValue("@Name", task.Name);
            command.Parameters.AddWithValue("@CategoryId", task.CategoryId);
            command.Parameters.AddWithValue("@StartDate", task.StartDate);
            command.Parameters.AddWithValue("@DueDate", task.DueDate);
            command.Parameters.AddWithValue("@Completed", task.Completed);
            command.Parameters.AddWithValue("@Priority", task.Priority);
            command.Parameters.AddWithValue("@PercentComplete", task.PercentComplete);
            connection.Open();

            return command.ExecuteNonQuery();
        }        
    }

    public List<Task> GetTasks()
    {
        using (SqlConnection connection = GetConnection())
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Task");
            connection.Open();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                List<Task> tasks = new List<Task>();

                while (reader.Read())
                {
                    tasks.Add(new Task());
                }
            }
        }    
    }

    public Task GetTask(int taskId)
    {
        
    }

    public List<Task> GetCompletedTasks()
    {
        
    }

    public List<Task> GetPendingTasks()
    {

    }

    public int UpdateTask(Task task)
    {
        
    }

    public Dictionary<int, string> GetCategories()
    {
        
    }

    public List<Task> GetTasksByCategory(string category)
    {
        
    }

    public DataSet ExportTasks()
    {
        
    }

    public int AddCategory(string category)
    {
        
    }

    private SqlConnection GetConnection()
    {
        return new SqlConnection(ConnectionString);
    }
}