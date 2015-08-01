﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarcalSysClient.Domain.Contracts.Repositories;
using VarcalSysClient.Domain.Contracts.Services;
using VarcalSysClient.Domain.Entities;
using VarcalSysClient.Domain.Services.Core;

namespace VarcalSysClient.Domain.Services
{
    public class EmpresaDomainService: BaseDomainService<Empresa>, IEmpresaDomainService
    {
        private IEmpresaRepository _empresaRepository;

        public EmpresaDomainService(IEmpresaRepository empresaRepository) : base(empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }
    }
}
