using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarcalSysClient.Domain.Entities;

namespace VarcalSysClient.Data.Mappings
{
    public class TicketMap: EntityTypeConfiguration<Ticket>
    {
        public TicketMap()
        {
            ToTable("tbTicket");

            HasKey(p => p.Id);
            HasRequired(p => p.Cliente)
                .WithMany()
                .HasForeignKey(p => p.ClienteId);
            HasOptional(p => p.Empresa)
                .WithMany()
                .HasForeignKey(p => p.EmpresaId);
            
            Property(p=>p.Id)
                .HasColumnName("Id")
                .HasColumnType("int");
            Property(p => p.DataCadastro)
                .HasColumnName("DataCadastro")
                .HasColumnType("datetime")
                .IsRequired();
            Property(p => p.DataResposta)
                .HasColumnName("DataResposta")
                .HasColumnType("datetime")
                .IsOptional();
            Property(p => p.EmAberto)
                .HasColumnName("EmAberto")
                .HasColumnType("bit")
                .IsRequired();         
            Property(p => p.Ativo)
                .HasColumnName("Ativo")
                .HasColumnType("bit")
                .IsRequired();
        }
    }
}
