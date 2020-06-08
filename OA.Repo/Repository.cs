using Microsoft.EntityFrameworkCore;
using OA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OA.Repo
{
    public class Repository<T> :IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationContext context;
        private DbSet<T> entities;
        public Repository(ApplicationContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

        public void delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("empty");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }

        public T Get(long id)
        {
            return entities.SingleOrDefault(s => s.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public void insert(T entity)
        {
            if(entity==null)
            {
                throw new ArgumentNullException("empty");
            }
            entities.Add(entity);
            context.SaveChanges();
        }

        public void remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("empty");
            }
            context.Remove(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("empty");
            }
            context.SaveChanges();
        }
    }
}
