using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarcalSysCliente.Domain.Entities;

namespace VarcalSysCliente.Data.Mapping
{
    public class EnderecoMap: EntityTypeConfiguration<Endereco>
    {
        public EnderecoMap()
        {
            ToTable("Endereco");

            HasKey(p => p.Id);
            


            Property(p => p.Logradouro)
                .HasColumnName("Logradouro")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();
            Property(p => p.Bairro)
                .HasColumnName("Bairro")
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsOptional();
            Property(p => p.Cidade)
                .HasColumnName("Cidade")
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();
            Property(p => p.Uf)
                .HasColumnName("Uf")
                .HasColumnType("int")
                .IsRequired();
        }
    }
}
