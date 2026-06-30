using BooksApi.Models;
using BooksApi.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace BooksApi.Services
{
      public class BooksService : IBooksService
      {
            private readonly List<Book> _books = new()
            {
                  new Book { Id = 1, Title = "The Hobbit", Author = "J.R.R. Tolkien", Year = 1937 },
                  new Book { Id = 2, Title = "1984", Author = "George Orwell", Year = 1949 }
            };

            public IEnumerable<Book> GetAll() => _books;

            public Book? GetById(int id) => _books.FirstOrDefault(b => b.Id == id);

            public int Create(Book book)
            {
                  var nextId = (_books.LastOrDefault()?.Id ?? 0) + 1;
                  book.Id = nextId;
                  _books.Add(book);
                  return nextId;
            }
      }
}