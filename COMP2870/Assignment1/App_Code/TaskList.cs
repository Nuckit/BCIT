using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

/// <summary>
/// Summary description for TaskList
/// </summary>
public class TaskList : ITaskList
{
    private List<Task> Tasks { get; set; }

	public TaskList()
	{
		Tasks = new List<Task>();
	}

    public void AddTask(Task task)
    {
        string taskName = task.Name;

        if (Tasks.Exists(t => t.Name == taskName))
        {
            throw new Exception(string.Format("A task with the name '{0}' already exists", taskName));
        }

        Tasks.Add(task);
    }

    public List<Task> GetTasks()
    {
        return Tasks;
    }

    public Task GetTask(string taskName)
    {
        return Tasks.FirstOrDefault(task => task.Name == taskName);
    }

    public List<Task> GetCompletedTasks()
    {
        return Tasks.Where(task => task.TaskStatus == Task.Status.Completed).ToList();
    }

    public List<Task> GetPendingTasks()
    {
        return Tasks.Where(task => task.TaskStatus == Task.Status.Pending).ToList();
    }

    public void WriteToXml(string path)
    {
        using (XmlTextWriter xmlWriter = new XmlTextWriter(path, Encoding.UTF8))
        {
            xmlWriter.Formatting = Formatting.Indented;
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement(GetType().Name);

            foreach (Task task in Tasks)
            {
                xmlWriter.WriteStartElement(typeof(Task).Name);
                xmlWriter.WriteElementString("Name", task.Name);
                xmlWriter.WriteElementString("Category", task.Category);
                xmlWriter.WriteElementString("TaskStatus", task.TaskStatus.ToString());
            }

            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
        }
    }
}