using System.Data.Entity.ModelConfiguration;
using VarcalSysClient.Domain.Entities;

namespace VarcalSysClient.Data.Mappings
{
    public class EmailMap: EntityTypeConfiguration<Email>
    {
        public EmailMap()
        {
            ToTable("tbEmail");

            HasKey(p => p.Id);

            HasRequired(p => p.Pessoa)
                .WithMany(e => e.EmailCollection)
                .HasForeignKey(p => p.PessoaId);

            Property(p => p.Endereco)
                .HasColumnName("Endereco")
                .HasColumnType("varchar")
                .HasMaxLength(100)
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
