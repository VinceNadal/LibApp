namespace LibApp.Application.Dtos;

public class AuthorDto
{
  public int Id { get; set; }
  public string FirstName { get; set; } = default!;
  public string LastName { get; set; } = default!;
  public string FullName => FirstName + LastName;
  public string? ImageUrl { get; set; }
}