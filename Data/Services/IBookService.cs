using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace dotnetcoreapi.Data
{
    public interface IBookService
    {
        List<Book> GetAllBooks();
        Book GetBookById(int id);
        void UpdateBook(int id, Book newBook);
        void DeleteBook(int id);
        void AddBook(Book newBook);

    }
}
