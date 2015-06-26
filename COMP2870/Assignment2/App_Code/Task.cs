using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Summary description for Task
/// </summary>
public class Task : IValidatableObject
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

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (StartDate >= DueDate)
        {
            yield return new ValidationResult("Due Date must be after the start date", new List<string>{ "StartDate", "DueDate"});
        }

        if (Completed && PercentComplete != 100)
        {
            yield return new ValidationResult("Percent complete must be at 100% if the task is completed", new List<string> { "Completed", "PercentComplete" });
        }
    }
}