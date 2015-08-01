using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarcalSysClient.Domain.Entities;

namespace VarcalSysClient.Data.Mappings
{
    public class ClienteMap: EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            ToTable("tbCliente");

            HasKey(p => p.Id);
            HasRequired(p => p.Pessoa)
                .WithMany()
                .HasForeignKey(p => p.PessoaId);
            HasRequired(p => p.PlanosHost)
                .WithMany()
                .HasForeignKey(p => p.PlanosHostId);

            Property(p => p.Id)
                .HasColumnName("Id")
                .HasColumnType("int");
            Property(p => p.PessoaId)
                .HasColumnName("PessoaId")
                .HasColumnType("int")
                .IsRequired();
            Property(p => p.PlanosHostId)
                .HasColumnName("PlanoHostId")
                .HasColumnType("int")
                .IsRequired();
        }
    }
}
