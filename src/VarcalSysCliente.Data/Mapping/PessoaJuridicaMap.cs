using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarcalSysCliente.Domain.Entities;

namespace VarcalSysCliente.Data.Mapping
{
    public class PessoaJuridicaMap: EntityTypeConfiguration<PessoaJuridica>
    {
        public PessoaJuridicaMap()
        {
            ToTable("PessoaJuridica");

            HasKey(p => p.Id);

            Property(p => p.RazaoSocial)
                .HasColumnName("RazaoSocial")
                .HasColumnType("varchar")
                .HasMaxLength(150)
                .IsRequired();
            Property(p => p.NomeFantasia)
                .HasColumnName("NomeFantasia")
                .HasColumnType("varchar")
                .HasMaxLength(150)
                .IsOptional();
            Property(p => p.NomeResponsavel)
               .HasColumnName("NomeResponsavel")
               .HasColumnType("varchar")
               .HasMaxLength(100)
               .IsRequired();
            Property(p => p.Cnpj)
                .HasColumnName("Cnpj")
                .HasColumnType("char")
                .HasMaxLength(14)
                .IsRequired();
            Property(p => p.InscEst)
                .HasColumnName("InscEst")
                .HasColumnType("varchar")
                .HasMaxLength(20)
                .IsOptional();
        }
    }
}
