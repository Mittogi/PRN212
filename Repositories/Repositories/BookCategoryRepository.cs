using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class BookCategoryRepository : IBookCategoryRepository
    {
        private BookManagementDbContext _context;

        public List<BookCategory> GetBookCategories()
        {
            _context = new BookManagementDbContext();

            return _context.BookCategories.ToList();
        }
    }
}
