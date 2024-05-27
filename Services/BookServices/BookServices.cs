
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Repositories;
using Repositories.Entities;
using Repositories.Repositories;
using Repositories.Repository;
using Repositories.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.BookServices.BookServices
{
    public class BookServices : IBookServices
    {
        //private IBookRepository _repository = new BookRepository();

        //public List<Book> GetAllBooks() => _repository.GetAllBooks();

        //public void AddBook(Book book) => _repository.AddBook(book);

        //public void UpdateBook(Book book) => _repository.UpdateBook(book);

        //public void DeleteBook(Book book) => _repository.DeleteBook(book);

        //private UnitOfWork _unitOfWork = new UnitOfWork(new BookManagementDbContext());

        //private UnitOfWork _unitOfWork;
        //public BookServices()
        //{
        //    if (_unitOfWork == null)
        //    {
        //        _unitOfWork = new UnitOfWork(new BookManagementDbContext());
        //    }
        //}

        public List<Book> GetAllBooks()
        {
            UnitOfWork _unitOfWork = new UnitOfWork(new BookManagementDbContext());
            return _unitOfWork.BookRepository.GetAll();
        }

        public void AddBook(Book book)
        {
            UnitOfWork _unitOfWork = new UnitOfWork(new BookManagementDbContext());
            _unitOfWork.BookRepository.Insert(book);
            _unitOfWork.Save();
        }

        public void UpdateBook(Book book)
        {
            UnitOfWork _unitOfWork = new UnitOfWork(new BookManagementDbContext());
            _unitOfWork.BookRepository.Update(book);
            _unitOfWork.Save();
        }

        public void DeleteBook(List<Book> bookList)
        {
            UnitOfWork _unitOfWork = new UnitOfWork(new BookManagementDbContext());
            int count = 0;

            foreach (Book book in bookList)
            {
                _unitOfWork.BookRepository.Delete(book);
                count++;
                if (count == 2) 
                {
                    throw new Exception();
                }
            }

            _unitOfWork.Save();
        }
    }
}
