using OA.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Repo
{
    public interface IRepository<T> where T:BaseEntity
    {
        IEnumerable<T> GetAll();
        T Get(long id);
        void insert(T entity);
        void update(T entity);
        void delete(T entity);
        void remove(T entity);
        void SaveChanges();
    }
}
