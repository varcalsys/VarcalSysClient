using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarcalSysClient.Domain.Entities.Base
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
       
        public bool Ativo { get; set; }
    }
}
