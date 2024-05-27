using Microsoft.EntityFrameworkCore;
using Repositories.Entities;
using Repositories.GenericRepository;
using Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.UnitOfWork
{
    public class UnitOfWork
    {
        private BookManagementDbContext _Context;
        private GenericRepository<Book> _Book;
        private GenericRepository<BookCategory> _BookCategory;
        private GenericRepository<UserAccount> _UserAccount;

        public UnitOfWork(BookManagementDbContext context) 
        {
            _Context = context;
        }

        public GenericRepository<Book> BookRepository
        {
            get
            {
                if (_Book == null)
                {
                    this._Book = new GenericRepository<Book>(_Context);
                }
                return _Book;
            }
        }

        public GenericRepository<BookCategory> BookCategoryRepository
        {
            get
            {
                if (_BookCategory == null)
                {
                    this._BookCategory = new GenericRepository<BookCategory>(_Context);
                }
                return _BookCategory;
            }
        }

        public GenericRepository<UserAccount> UserAccountRepository
        {
            get
            {
                if (_UserAccount == null)
                {
                    this._UserAccount = new GenericRepository<UserAccount>(_Context);
                }
                return _UserAccount;
            }
        }

        public void Save()
        {
            _Context.SaveChanges();
        }
    }
}
