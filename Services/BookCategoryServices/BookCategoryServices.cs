using Repositories.Entities;
using Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.BookCategoryServices
{
    public class BookCategoryServices :IBookCategoryServices
    {
        private BookCategoryRepository _repo = new BookCategoryRepository();

        public List<BookCategory> GetAllBookCategories()
        {
            return _repo.GetBookCategories();
        }
    }
}
