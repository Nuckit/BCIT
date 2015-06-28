using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

/// <summary>
/// Summary description for TaskRepository
/// </summary>
public class TaskRepository
{
    private static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

    private static readonly Lazy<TaskRepository> InstanceHolder = new Lazy<TaskRepository>(() => new TaskRepository());

	private TaskRepository()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public static TaskRepository Instance
    {
        get { return InstanceHolder.Value; }
    }

    public int AddTask(Task task)
    {
        using (SqlConnection connection = GetConnection())
        {
            string commandText = "INSERT INTO Task VALUES (@Name, @CategoryId, @StartDate, @DueDate, @Completed, @Priority, @PercentComplete)";

            using (SqlCommand command = new SqlCommand(commandText, connection))
            {
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
    }

    public List<Task> GetTasks()
    {
        using (SqlConnection connection = GetConnection())
        {
            string commandText = "SELECT t.*, c.Name CategoryName FROM Task t JOIN Category c ON t.CategoryId = c.CategoryId";

            using (SqlCommand command = new SqlCommand(commandText, connection))
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<Task> tasks = new List<Task>();

                    while (reader.Read())
                    {
                        tasks.Add(new Task
                        {
                            TaskId = (int)reader["TaskId"],
                            Name = (string)reader["Name"],
                            CategoryId = (int)reader["CategoryId"],
                            Category = (string)reader["CategoryName"],
                            StartDate = (DateTime)reader["StartDate"],
                            DueDate = (DateTime)reader["DueDate"],
                            Completed = (bool)reader["Completed"],
                            Priority = (int)reader["Priority"],
                            PercentComplete = Convert.ToInt16(reader["PercentComplete"])
                        });
                    }

                    return tasks;
                }
            }            
        }    
    }

    public Task GetTask(int taskId)
    {
        return GetTasks().FirstOrDefault(task => task.TaskId == taskId);
    }

    public List<Task> GetCompletedTasks()
    {
        return GetTasks().Where(task => task.Completed).ToList();
    }

    public List<Task> GetPendingTasks()
    {
        return GetTasks().Where(task => !task.Completed).ToList();
    }

    public int UpdateTask(Task task)
    {
        using (SqlConnection connection = GetConnection())
        {
            string commandText = "UPDATE Task SET Name = @Name, CategoryId = @CategoryId, StartDate = @StartDate, DueDate = @DueDate, Completed = @Completed, Priority = @Priority, PercentComplete = @PercentComplete WHERE TaskId = @TaskId";

            using (SqlCommand command = new SqlCommand(commandText, connection))
            {
                command.Parameters.AddWithValue("@Name", task.Name);
                command.Parameters.AddWithValue("@CategoryId", task.CategoryId);
                command.Parameters.AddWithValue("@StartDate", task.StartDate);
                command.Parameters.AddWithValue("@DueDate", task.DueDate);
                command.Parameters.AddWithValue("@Completed", task.Completed);
                command.Parameters.AddWithValue("@Priority", task.Priority);
                command.Parameters.AddWithValue("@PercentComplete", task.PercentComplete);
                command.Parameters.AddWithValue("@TaskId", task.TaskId);
                connection.Open();

                return command.ExecuteNonQuery();
            }            
        }
    }

    public Dictionary<int, string> GetCategories()
    {
        using (SqlConnection connection = GetConnection())
        {
            string commandText = "SELECT * FROM Category";

            using (SqlCommand command = new SqlCommand(commandText, connection))
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Dictionary<int, string> categories = new Dictionary<int, string>();

                    while (reader.Read())
                    {
                        categories.Add((int)reader["CategoryId"], (string)reader["Name"]);
                    }

                    return categories;
                }
            }
        }
    }

    public List<Task> GetTasksByCategory(string category)
    {
        using (SqlConnection connection = GetConnection())
        {
            string commandText = "SELECT t.*, c.Name CategoryName FROM Task t JOIN Category c ON t.CategoryId = c.CategoryId WHERE c.Name = @CategoryName";

            using (SqlCommand command = new SqlCommand(commandText, connection))
            {
                command.Parameters.AddWithValue("@CategoryName", category);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<Task> tasks = new List<Task>();

                    while (reader.Read())
                    {
                        tasks.Add(new Task
                        {
                            TaskId = (int)reader["TaskId"],
                            Name = (string)reader["Name"],
                            CategoryId = (int)reader["CategoryId"],
                            Category = (string)reader["CategoryName"],
                            StartDate = (DateTime)reader["StartDate"],
                            DueDate = (DateTime)reader["DueDate"],
                            Completed = (bool)reader["Completed"],
                            Priority = (int)reader["Priority"],
                            PercentComplete = Convert.ToInt16(reader["PercentComplete"])
                        });
                    }

                    return tasks;
                }
            }
        } 
    }

    public DataSet ExportTasks()
    {
        using (SqlConnection connection = GetConnection())
        {
            string commandText = "SELECT * FROM Task";

            using (SqlDataAdapter adapter = new SqlDataAdapter(commandText, connection))
            {
                DataSet tasks = new DataSet();
                adapter.Fill(tasks);
                return tasks;                
            }            
        }
    }

    public int AddCategory(string category)
    {
        using (SqlConnection connection = GetConnection())
        {
            string commandText = "INSERT INTO Category VALUES (@Name)";

            using (SqlCommand command = new SqlCommand(commandText, connection))
            {
                command.Parameters.AddWithValue("@Name", category);
                connection.Open();

                return command.ExecuteNonQuery();
            }            
        }
    }

    private static SqlConnection GetConnection()
    {
        return new SqlConnection(ConnectionString);
    }
}