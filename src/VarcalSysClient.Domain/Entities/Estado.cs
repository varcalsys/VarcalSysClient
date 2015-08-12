using VarcalSysClient.Domain.Collections;
using VarcalSysClient.Domain.Entities.Core;

namespace VarcalSysClient.Domain.Entities
{

    public class Estado: BaseEntity
    {
        public string Uf { get; set; }

        public CidadeCollection CidadeCollection { get; set; } 
    }
}
