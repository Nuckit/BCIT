using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

/// <summary>
/// Summary description for TaskValidator
/// </summary>
public class TaskValidator
{
    public IEnumerable<string> ErrorMessages { get; private set; }

	public TaskValidator()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public bool Validate(Task task)
    {
        var results = new List<ValidationResult>();
        var context = new ValidationContext(task);
        bool isValid = Validator.TryValidateObject(task, context, results);
        ErrorMessages = results.Select(result => result.ErrorMessage);

        return isValid;
    }

}