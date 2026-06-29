namespace Session_7_Assignment;

public class Repository<T>
{
      List<T> items = new List<T>();

      public void Add(T item)
      {
            items.Add(item);
      }
      public IEnumerable<T> GetAll()
      {
            return items;
      }
      public List<T> FindAll(Predicate<T> predicate)
      {
            return items.FindAll(predicate);
      }
}