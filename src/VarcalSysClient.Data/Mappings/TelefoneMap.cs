using System.Data.Entity.ModelConfiguration;
using VarcalSysClient.Domain.Entities;

namespace VarcalSysClient.Data.Mappings
{
    public class TelefoneMap: EntityTypeConfiguration<Telefone>
    {
        public TelefoneMap()
        {
            ToTable("tbTelefone");

            HasKey(p => p.Id);

            HasRequired(p => p.Pessoa)
                .WithMany(c=>c.TelefoneCollection)
                .HasForeignKey(p => p.PessoaId);
          

            Property(p => p.Id)
                .HasColumnName("Id")
                .HasColumnType("int");
            Property(p => p.Numero)
                .HasColumnName("Numero")
                .HasColumnType("varchar")
                .HasMaxLength(10)
                .IsRequired();
            Property(p => p.TelefoneTipo)
                .HasColumnName("TelefoneTipo")
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
