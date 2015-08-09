using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarcalSysClient.Domain.Entities;

namespace VarcalSysClient.Data.Mappings
{
    public class BoletoMap: EntityTypeConfiguration<Boleto>
    {
        public BoletoMap()
        {
            ToTable("tbBoleto");

            HasKey(p => p.Id);

            HasRequired(p => p.Cliente)
                .WithMany(b => b.Boletos)
                .HasForeignKey(p => p.ClienteId);

            Property(p => p.Id)
                .HasColumnName("Id")
                .HasColumnType("int");
            Property(p => p.DataVencimento)
                .HasColumnName("DataVencimento")
                .HasColumnType("date")
                .IsRequired();
            Property(p => p.Url)
                .HasColumnName("Url")
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();
           Property(p => p.Ativo)
                .HasColumnName("Ativo")
                .HasColumnType("bit")
                .IsRequired();
        }
    }
}
