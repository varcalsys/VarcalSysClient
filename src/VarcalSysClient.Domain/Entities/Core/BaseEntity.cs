namespace VarcalSysClient.Domain.Entities.Core
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
       
        public bool Ativo { get; set; }
    }
}
