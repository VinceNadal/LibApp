using LibApp.Domain.Entities;

namespace LibApp.Application.Contracts.Persistence;

public interface IAuthorRepository
{
  Task<List<Author>> GetAuthors();
  Task<Author> GetAuthorById(int id);
  Task<Author> AddAuthor(Author author);
  Task<Author> UpdateAuthor(Author author);
  Task DeleteAuthor(Author author);
}

