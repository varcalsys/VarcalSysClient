using System.Data.Entity.ModelConfiguration;
using VarcalSysClient.Domain.Entities;

namespace VarcalSysClient.Data.Mappings
{
    public class PessoaJuridicaMap: EntityTypeConfiguration<PessoaJuridica>
    {
        public PessoaJuridicaMap()
        {
            ToTable("tbPessoaJuridica");

            HasKey(p => p.Id);
           

            Property(p => p.Id)
                .HasColumnName("Id")
                .HasColumnType("int");
            Property(p => p.RazaoSocial)
                .HasColumnName("RazaoSocial")
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();
            Property(p => p.Cnpj)
                .HasColumnName("CNPJ")
                .HasColumnType("char")
                .HasMaxLength(14)
                .IsRequired();          
            Property(p => p.Ativo)
                .HasColumnName("Ativo")
                .HasColumnType("bit")
                .IsRequired();
        }
    }
}
