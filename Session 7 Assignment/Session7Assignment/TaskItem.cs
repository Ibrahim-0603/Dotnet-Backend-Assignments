namespace Session_7_Assignment;
public enum Priority
{
      Low,
      Medium,
      High,
      Critical
};

[Flags]
public enum Tag
{
      Bug = 1,
      Feature = 2,
      Urgent = 4
}
public class TaskItem
{
      public string Title { get; set; }
      public bool Status { get; set; }
      public Priority Priority { get; set; }
      public Tag Tags { get; set; }
}