using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarcalSysCliente.Domain.Contracts.Core;

namespace VarcalSysCliente.Domain.Services.Core
{
    public class DomainServiceBase<T>: IDomainServiceBase<T> where T: class
    {
        private readonly IRepositoryBase<T> _repositoryBase;

        public DomainServiceBase(IRepositoryBase<T> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public void Add(T entity)
        {
            _repositoryBase.Add(entity);
        }

        public void Update(T entity)
        {
            _repositoryBase.Update(entity);
        }

        public T Get(int id)
        {
            return _repositoryBase.Get(id);
        }

        public IEnumerable<T> Get()
        {
            return _repositoryBase.Get();
        }

        public IEnumerable<T> GetAsNoTracking()
        {
            return _repositoryBase.GetAsNoTracking();
        }

        public void Commit()
        {
            _repositoryBase.Commit();
        }
    }
}
