using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarcalSysClient.Domain.Entities;

namespace VarcalSysClient.Data.Mappings
{
    public class PessoaFisicaMap: EntityTypeConfiguration<PessoaFisica>
    {
        public PessoaFisicaMap()
        {
            ToTable("tbPessoaFisica");

            HasKey(p => p.Id);

            Property(p => p.Id)
                .HasColumnName("Id")
                .HasColumnType("int");
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
            Property(p => p.DataNascimento)
                .HasColumnName("DataNascimento")
                .HasColumnType("date")
                .IsRequired();
            Property(p => p.Sexo)
                .HasColumnName("Sexo")
                .HasColumnType("int")
                .IsRequired();
            Property(p => p.ClienteId)
                .HasColumnName("ClienteId")
                .HasColumnType("int")
                .IsRequired();
            Property(p => p.Ativo)
                .HasColumnName("Ativo")
                .HasColumnType("bit")
                .IsRequired();
        }
    }
}
