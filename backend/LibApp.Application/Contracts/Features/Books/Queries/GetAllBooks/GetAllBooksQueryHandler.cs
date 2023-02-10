using AutoMapper;
using LibApp.Application.Contracts.Persistence;
using MediatR;

namespace LibApp.Application.Features.Books.Queries.GetAllBooks
{
  public class GetAllBooksQueryHandler : IRequestHandler<GetAllBooksQuery, List<GetAllBooksResponse>>
  {
    private readonly IMapper mapper;
    private readonly IBookRepository bookRepository;
    public GetAllBooksQueryHandler(IMapper mapper, IBookRepository bookRepository)
    {
      this.mapper = mapper;
      this.bookRepository = bookRepository;
    }
    public async Task<List<GetAllBooksResponse>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
    {
      var bookList = await bookRepository.GetBooks();
      return mapper.Map<List<GetAllBooksResponse>>(bookList);
    }
  }
}