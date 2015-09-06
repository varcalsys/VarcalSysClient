using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarcalSysCliente.Domain.Contracts.Core
{
    public interface IRepositoryBase<T> where T: class
    {
        void Add(T entity);
        void Update(T entity);
        T Get(int id);
        IEnumerable<T> Get();
        IEnumerable<T> GetAsNoTracking();
        void Commit();
    }
}
