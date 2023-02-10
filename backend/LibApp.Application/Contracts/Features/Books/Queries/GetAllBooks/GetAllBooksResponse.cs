using LibApp.Application.Dtos;

namespace LibApp.Application.Features.Books.Queries.GetAllBooks
{
  public class GetAllBooksResponse
  {
    public int BookId { get; set; }
    public string Title { get; set; } = default!;
    public List<AuthorDto> Authors { get; set; } = new List<AuthorDto>();
    public string ISBN { get; set; } = default!;
    public string Description { get; set; } = default!;

    public string? ImageUrl { get; set; }
    public List<CategoryDto> Categories { get; set; } = new List<CategoryDto>();
    public int TotalPages { get; set; }
    public bool HaveRead { get; set; } = false;
    public bool IsFavourite { get; set; } = false;
  }
}