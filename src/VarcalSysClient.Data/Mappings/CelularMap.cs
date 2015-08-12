using System.Data.Entity.ModelConfiguration;
using VarcalSysClient.Domain.Entities;

namespace VarcalSysClient.Data.Mappings
{
    public class CelularMap: EntityTypeConfiguration<Celular>
    {
        public CelularMap()
        {
            ToTable("tbCelular");

            HasKey(p => p.Id);

            HasRequired(p => p.Pessoa)
                .WithMany(c => c.CelularCollection)
                .HasForeignKey(p => p.PessoaId);


            Property(p => p.Id)
                .HasColumnName("Id")
                .HasColumnType("int");
            Property(p => p.Numero)
                .HasColumnName("Numero")
                .HasColumnType("varchar")
                .HasMaxLength(10)
                .IsRequired();
            Property(p => p.Operadora)
                .HasColumnName("Operadora")
                .HasColumnType("int")
                .IsRequired();
            Property(p => p.PessoaId)
               .HasColumnName("PessoaId")
               .HasColumnType("int")
               .IsRequired();
            Property(p => p.Ativo)
                .HasColumnName("Ativo")
                .HasColumnType("bit")
                .IsRequired();
        }
    }
}
