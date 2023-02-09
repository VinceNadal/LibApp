// Create a book repository interface
// Book repository interface
// Path: backend\LibApp.Application\Contracts\Persistence\IBookRepository.cs

using LibApp.Domain.Entities;

namespace LibApp.Application.Contracts.Persistence;

public interface IBookRepository
{
  Task<List<Book>> GetBooks();
  Task<Book> GetBookById(int id);
  Task<Book> AddBook(Book book);
  Task<Book> UpdateBook(Book book);
  Task DeleteBook(Book book);
}

