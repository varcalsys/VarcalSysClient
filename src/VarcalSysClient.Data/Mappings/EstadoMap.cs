using System.Data.Entity.ModelConfiguration;
using VarcalSysClient.Domain.Entities;

namespace VarcalSysClient.Data.Mappings
{
    public class EstadoMap: EntityTypeConfiguration<Estado>
    {
        public EstadoMap()
        {
            ToTable("tbEstado");

            HasKey(p => p.Id);

            Property(p => p.Id)
                .HasColumnName("Id")
                .HasColumnType("int");
            Property(p => p.Uf)
                .HasColumnName("UF")
                .HasColumnType("char")
                .HasMaxLength(2)
                .IsRequired();
            Property(p => p.Ativo)
                .HasColumnName("Ativo")
                .HasColumnType("bit")
                .IsRequired();
        }
    }
}
