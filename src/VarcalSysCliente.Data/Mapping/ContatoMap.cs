using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarcalSysCliente.Domain.Entities;

namespace VarcalSysCliente.Data.Mapping
{
    public class ContatoMap: EntityTypeConfiguration<Contato>
    {

        public ContatoMap()
        {
            ToTable("Contato");

            HasKey(p => p.Id);

            Property(p => p.Celular)
                .HasColumnName("Celular")
                .HasColumnType("char")
                .HasMaxLength(11)
                .IsRequired();
            Property(p => p.Telefone)
                .HasColumnName("Telefone")
                .HasColumnType("char")
                .HasMaxLength(10)
                .IsRequired();
            Property(p => p.Email)
                .HasColumnName("Email")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();
            Property(p => p.EmailCobranca)
                .HasColumnName("EmailCobranca")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();
        }
    }

}
