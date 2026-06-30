using BooksApi.Models;
using System.Collections.Generic;

namespace BooksApi.Services.Interfaces
{
      public interface IBooksService
      {
            IEnumerable<Book> GetAll();
            Book? GetById(int id);
            int Create(Book book);
      }
}