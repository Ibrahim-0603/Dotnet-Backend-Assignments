namespace Session_7_Assignment;
public class Program
{
      static async Task Main(string[] args)
      {
      var repository = new Repository<TaskItem>();
      repository.Add(new TaskItem { Title = "Fix login bug", Priority = Priority.High, Tags = Tag.Bug | Tag.Urgent, Status = false });
      repository.Add(new TaskItem { Title = "Add dark mode", Priority = Priority.Low, Tags = Tag.Feature, Status = true });

      await PrintReportAsync(repository);
      }
      static async Task PrintReportAsync(Repository<TaskItem> repository)
      {
            await Task.Delay(1000); 
            Func<TaskItem, string> summary = t => $"Task: {t.Title}, Status: {t.Status}, Priority: {t.Priority}, Tags: {t.Tags}";
            
            var summaries = repository.GetAll().Select(summary);
            foreach (var line in summaries)
            {
                  Console.WriteLine(line);
            }     
      }
      
}