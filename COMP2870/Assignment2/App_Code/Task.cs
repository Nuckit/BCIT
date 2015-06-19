using System;

/// <summary>
/// Summary description for Task
/// </summary>
public class Task
{
    public string Name { get; set; }
    public int TaskId { get; set; }
    public string Category { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime DueDate { get; set; }
    public bool Completed { get; set; }
    public int Priority { get; set; }
    public short PercentComplete { get; set; }
    public int CategoryId { get; set; }

	public Task()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}