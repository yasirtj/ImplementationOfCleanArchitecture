using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLayer.GenericRepository
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int Id);
        void Insert(T entityToInsert);
        void Update(int entityToUpdateId, T entity);
        void Delete(int entityToDeleteId);
        void Save();
    }
}
