using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.GenericRepository
{
    public class GenericRepository<TEntity> where TEntity : class
    {

        internal BookManagementDbContext _Context;
        internal DbSet<TEntity> _DbSet;

        public GenericRepository(BookManagementDbContext context)
        {
            _Context = context;
            _DbSet = _Context.Set<TEntity>();
        }

        public virtual List<TEntity> GetAll()
        {
            return _DbSet.AsQueryable().ToList();
        }

        public virtual void Insert(TEntity entity)
        {
            _DbSet.Add(entity);
        }

        public virtual void Update(TEntity entity) 
        {  
            _DbSet.Update(entity); 
        }

        public virtual void Delete(TEntity entity)
        {
            _DbSet.Remove(entity);
        }

        public void Save()
        {
            _Context.SaveChanges();
        }
    }
}
