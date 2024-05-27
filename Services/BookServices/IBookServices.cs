using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.BookServices
{
    public interface IBookServices
    {
        public List<Book> GetAllBooks();

        public void AddBook(Book book);

        public void UpdateBook(Book book);

        public void DeleteBook(List<Book> bookList);
    }
}
