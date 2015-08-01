using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarcalSysClient.Domain.Contracts.Repositories.Core;
using VarcalSysClient.Domain.Contracts.Services.Core;

namespace VarcalSysClient.Domain.Services.Core
{
    public class BaseDomainService<T>: IBaseDomainService<T> where T: class
    {
        private readonly IBaseRepository<T> _repository;

        public BaseDomainService(IBaseRepository<T> repository)
        {
            _repository = repository;
        }

        public void Add(T entity)
        {
            _repository.Add(entity);
        }

        public void Update(T entity)
        {
            _repository.Update(entity);
        }

        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public IEnumerable<T> GetAllAsNoTracking()
        {
            return _repository.GetAllAsNoTracking();
        }

        public void Commit()
        {
            _repository.Commit();
        }        
    }
}
