using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarcalSysCliente.Domain.Entities;

namespace VarcalSysCliente.Data.Mapping
{
    public class PessoaFisicaMap: EntityTypeConfiguration<PessoaFisica>
    {
        public PessoaFisicaMap()
        {
            ToTable("PessoaFisica");

            HasKey(p => p.Id);

            Property(p => p.Nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();
            Property(p => p.Cpf)
                .HasColumnName("Cpf")
                .HasColumnType("char")
                .HasMaxLength(11)
                .IsRequired();
            Property(p => p.Rg)
                .HasColumnName("Rg")
                .HasColumnType("varchar")
                .HasMaxLength(20)
                .IsOptional();
        }
    }
}
