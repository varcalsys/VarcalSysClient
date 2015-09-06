using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarcalSysCliente.Domain.Entities;

namespace VarcalSysCliente.Data.Mapping
{
    public class PlanoHostMap:EntityTypeConfiguration<PlanoHost>
    {
        public PlanoHostMap()
        {
            ToTable("PlanoHost");

            HasKey(p => p.Id);

            Property(p => p.Descricao)
                .HasColumnName("Descricao")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();
            Property(p => p.Valor)
                .HasColumnName("Valor")
                .HasColumnType("decimal")
                .IsRequired();
            Property(p => p.Ativo)
                .HasColumnName("Ativo")
                .HasColumnType("bit")
                .IsRequired();
        }
    }
}
