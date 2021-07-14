using ApplicationLayer.GenericRepository;
using InfrastructureLayer.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfrastructureLayer.GenericRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T: class
    {
        private readonly IStudentDbContext _DbContext;
  
        public GenericRepository(IStudentDbContext DbContext)
        {
            _DbContext = DbContext;

        }
        public void Delete(int entityToDeleteId)
        {
            var deletedEntity = _DbContext.Set<T>().Find(entityToDeleteId);
            _DbContext.Set<T>().Remove(deletedEntity);
            Save();
        }

        public IEnumerable<T> GetAll()
        {
            return _DbContext.Set<T>().ToList();
        }

        public T GetById(int Id)
        {
            return _DbContext.Set<T>().Find(Id);
        }

        public void Insert(T entityToInsert)
        {
            _DbContext.Set<T>().Add(entityToInsert);
            Save();
        }

        public void Save()
        {
            _DbContext.Save();
        }

        public void Update(int entityToUpdateId, T entity)
        {
            Delete(entityToUpdateId);
            Save();
            Insert(entity);
            Save();
        }
    }
}
