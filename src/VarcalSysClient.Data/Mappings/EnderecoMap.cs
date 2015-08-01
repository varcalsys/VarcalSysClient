using System.Data.Entity.ModelConfiguration;
using VarcalSysClient.Domain.Entities;

namespace VarcalSysClient.Data.Mappings
{
    public class EnderecoMap: EntityTypeConfiguration<Endereco>
    {
        public EnderecoMap()
        {
            ToTable("tbEndereco");
            HasKey(p => p.Id);

            HasRequired(p => p.Pessoa)
                .WithMany(e => e.Enderecos)
                .HasForeignKey(p => p.PessoaId);

            HasRequired(p => p.Cidade)
                .WithMany()
                .HasForeignKey(p => p.CidadeId);
           
            Property(p => p.Id)
                .HasColumnName("Id")
                .HasColumnType("int");
            Property(p => p.Logradouro)
                .HasColumnName("Logradouro")
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();
            Property(p => p.Numero)
                .HasColumnName("Numero")
                .HasColumnType("int")
                .IsRequired();
            Property(p => p.Complemento)
                .HasColumnName("Complemento")
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();
            Property(p => p.Cep)
                .HasColumnName("Cep")
                .HasColumnType("char")
                .HasMaxLength(8);
            Property(p => p.Bairro)
                .HasColumnName("Bairro")
                .HasColumnType("varchar")
                .HasMaxLength(100);
            Property(p => p.PessoaId)
               .HasColumnName("PessoaId")
               .HasColumnType("int")
               .IsRequired();
            Property(p => p.CidadeId)
                .HasColumnName("Cidade")
                .HasColumnType("int")
                .IsRequired();

        }
    }
}
