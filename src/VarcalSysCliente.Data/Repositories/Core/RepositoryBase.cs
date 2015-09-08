using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarcalSysCliente.Data.ContextDb;
using VarcalSysCliente.Domain.Contracts.Core;

namespace VarcalSysCliente.Data.Repositories.Core
{
    public class RepositoryBase<T>:IRepositoryBase<T> where T: class 
    {
        protected EfDbContext _db;

        public RepositoryBase(EfDbContext db)
        {
            _db = db;
        }

        public void Add(T entity)
        {
            _db.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
           _db.Entry(entity).State = EntityState.Modified;
        }

        public T Get(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public IEnumerable<T> Get()
        {
            return _db.Set<T>().AsNoTracking();
        }

        public IEnumerable<T> GetAsNoTracking()
        {
                return _db.Set<T>().AsNoTracking();
        }


        public void Commit()
        {
            _db.SaveChanges();
        }
    }
}
