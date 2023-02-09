namespace LibApp.Domain.Entities;

public class Book
{
  public int Id { get; set; }
  public string Title { get; set; } = default!;
  public List<Author> Author { get; set; } = new List<Author>();
  public string? ISBN { get; set; }
  public string Description { get; set; } = default!;
  public string? ImageUrl { get; set; }
  public List<Category> Category { get; set; } = new List<Category>();
  public int TotalPages { get; set; }
  public bool HaveRead { get; set; } = false;
  public bool IsFavourite { get; set; } = false;
}