using AutoMapper;
using LibApp.Application.Dtos;
using LibApp.Application.Features.Books.Queries.GetAllBooks;
using LibApp.Domain.Entities;

namespace LibApp.Application.MappingProfiles;

public class BookProfile : Profile
{
  public BookProfile()
  {
    // Create a mapping between the Book entity and the GetAllBooksResponse object and vice versa, also for the Id property map it to the BookId property
    CreateMap<Book, GetAllBooksResponse>()
      .ForMember(dest => dest.BookId,
        opt => opt.MapFrom(src => src.Id))
      .ReverseMap();

    // Create a mapping between Author entity and the AuthorDto object and vice versa
    CreateMap<Author, AuthorDto>().ReverseMap();

    // Create a mapping between Category entity and the CategoryDto object and vice versa
    CreateMap<Category, CategoryDto>().ReverseMap();
  }
}