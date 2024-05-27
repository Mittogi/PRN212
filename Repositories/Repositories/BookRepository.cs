using Repositories.Entities;
using Repositories.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class BookRepository : IBookRepository
    {
        private BookManagementDbContext _context;

        public void AddBook(Book book)
        {
            _context = new BookManagementDbContext();
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void DeleteBook(Book book)
        {
            _context = new BookManagementDbContext();
            _context.Books.Remove(book);
            _context.SaveChanges();
        }

        public List<Book> GetAllBooks()
        {
            _context = new BookManagementDbContext();
            return _context.Books.ToList();
        }

        public void UpdateBook(Book book)
        {
            _context = new BookManagementDbContext();
            _context.Books.Update(book);
            _context.SaveChanges();
        }
    }
}
