using System.Collections.Generic;

/// <summary>
/// Summary description for ITaskList
/// </summary>
public interface ITaskList
{
    void AddTask(Task task);
    List<Task> GetTasks();
    Task GetTask(string taskName);
    List<Task> GetCompletedTasks();
    List<Task> GetPendingTasks();
    void WriteToXml(string path);
}