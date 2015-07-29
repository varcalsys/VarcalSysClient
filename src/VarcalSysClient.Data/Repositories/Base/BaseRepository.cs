using System;
using System.Collections.Generic;
using System.Data.Entity;
using VarcalSysClient.Data.AppDbContext;
using VarcalSysClient.Domain.Contracts.Repositories.Base;

namespace VarcalSysClient.Data.Repositories.Base
{
    public class BaseRepository<T>: IBaseRepository<T> where T: class
    {
        protected EfContext DbContext = new EfContext();

        public void Add(T entity)
        {
            try
            {
                DbContext.Set<T>().Add(entity);
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

        public void Update(T entity)
        {
            try
            {
                DbContext.Entry(entity).State = EntityState.Modified;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public T GetById(int id)
        {
            return DbContext.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return DbContext.Set<T>();
        }

        public IEnumerable<T> GetAllAsNoTracking()
        {
            return DbContext.Set<T>().AsNoTracking();
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}
