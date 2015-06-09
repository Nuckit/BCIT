/// <summary>
/// Summary description for Task
/// </summary>
public class Task
{
    public string Name { get; set; }
    public string Category { get; set; }
    public Status TaskStatus { get; set; }

    public enum Status
    {
        Pending,
        Completed
    }

	public Task(string name)
	{
	    Name = name;
	}

    public override string ToString()
    {
        return string.Format("Name: {0}, Category: {1}, Status: {2}", Name, Category, TaskStatus);
    }
}