using System.Collections.Generic;

namespace VarcalSysClient.Domain.Contracts.Services.Core
{
    public interface IDomainServiceBase<T> where T: class
    {
        void Add(T entity);
        void Update(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAllAsNoTracking();
        void Commit();
    }
}
