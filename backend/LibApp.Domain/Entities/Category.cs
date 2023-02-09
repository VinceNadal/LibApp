namespace LibApp.Domain.Entities;

public class Category
{
  public int Id { get; set; }
  public string Name { get; set; } = default!;
  public List<Book> Books { get; set; } = new List<Book>();
}