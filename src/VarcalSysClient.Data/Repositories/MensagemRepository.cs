﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarcalSysClient.Data.AppDbContext;
using VarcalSysClient.Data.Repositories.Core;
using VarcalSysClient.Domain.Contracts.Repositories;
using VarcalSysClient.Domain.Entities;

namespace VarcalSysClient.Data.Repositories
{
    public class MensagemRepository: BaseRepository<Mensagem>, IMensagemRepository
    {
        public MensagemRepository(EfContext dbContext) : base(dbContext)
        {
        }
    }
}
