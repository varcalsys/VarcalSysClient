using System.Data.Entity.ModelConfiguration;
using VarcalSysClient.Domain.Entities;

namespace VarcalSysClient.Data.Mappings
{
    public class ClienteMap: EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            ToTable("tbCliente");

            HasKey(p => p.Id);
            HasRequired(p => p.PlanoHost)
                .WithMany()
                .HasForeignKey(k => k.PlanoHostId);

            Property(p => p.Id)
                .HasColumnName("Id")
                .HasColumnType("int");
            Property(p => p.PessoaTipo)
                .HasColumnName("PessoaTipo")
                .HasColumnType("int")
                .IsRequired();
            Property(p => p.DataCadastro)
                .HasColumnName("DataCadastro")
                .HasColumnType("datetime")
                .IsRequired();
            Property(p => p.PlanoHostId)
                .HasColumnName("PlanoHostId")
                .HasColumnType("int")
                .IsRequired();
            Property(p => p.Ativo)
                .HasColumnName("Ativo")
                .HasColumnType("bit")
                .IsRequired();

       }
    }
}
