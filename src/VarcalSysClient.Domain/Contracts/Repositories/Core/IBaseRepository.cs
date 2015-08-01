using System.Collections.Generic;

namespace VarcalSysClient.Domain.Contracts.Repositories.Core
{
    public interface IBaseRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAllAsNoTracking();
        void Commit();
    }
}
