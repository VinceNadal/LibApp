using MediatR;

namespace LibApp.Application.Features.Books.Queries.GetAllBooks
{
    public class GetAllBooksQuery : IRequest<List<GetAllBooksResponse>>
    {
    }
}