namespace Session_7_Assignment;
public static class StaticExtensions
{
      public static IEnumerable<TaskItem> filterByStatus(this IEnumerable<TaskItem> tasks, bool status) => tasks.Where(t => t.Status == status);
      public static IEnumerable<TaskItem> filterByPriority(this IEnumerable<TaskItem> tasks, Priority priority) => tasks.Where(t => t.Priority == priority);
      public static IEnumerable<TaskItem> filterByTag(this IEnumerable<TaskItem> tasks, Tag tag) => tasks.Where(t => t.Tags.HasFlag(tag));
}