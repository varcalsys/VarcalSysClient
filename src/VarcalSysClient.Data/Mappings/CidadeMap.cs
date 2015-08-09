using System.Data.Entity.ModelConfiguration;
using VarcalSysClient.Domain.Entities;

namespace VarcalSysClient.Data.Mappings
{
    public class CidadeMap: EntityTypeConfiguration<Cidade>
    {
        public CidadeMap()
        {
            ToTable("tbCidade");

            HasKey(p => p.Id);
            HasRequired(p => p.Estado)
                .WithMany()
                .HasForeignKey(p => p.EstadoId);

            Property(p => p.Id)
                .HasColumnName("Id")
                .HasColumnType("int");
            Property(p => p.Nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar")
                .HasMaxLength(30);
            Property(p => p.EstadoId)
                .HasColumnName("EstadoId")
                .HasColumnType("int")
                .IsRequired();
            Property(p => p.Ativo)
                .HasColumnName("Ativo")
                .HasColumnType("bit");

        }
    }
}
