using System.Data.Entity.ModelConfiguration;
using VarcalSysClient.Domain.Entities;

namespace VarcalSysClient.Data.Mappings
{
    public class TicketMap : EntityTypeConfiguration<Ticket>
    {
        public TicketMap()
        {
            ToTable("tbTicket");

            HasKey(p => p.Id);
            HasRequired(p => p.Cliente)
                .WithMany()
                .HasForeignKey(p => p.ClienteId);
            HasRequired(p => p.Mensagem)
                .WithMany()
                .HasForeignKey(p => p.MensagemId);

            Property(p => p.Id)
                .HasColumnName("Id")
                .HasColumnType("int");
            Property(p => p.DataCadastro)
                .HasColumnName("DataCadastro")
                .HasColumnType("datetime")
                .IsRequired();
            Property(p => p.MensagemId)
                .HasColumnName("MensagemId")
                .HasColumnType("int")
                .IsRequired();
            Property(p => p.ClienteId)
                .HasColumnName("ClienteId")
                .HasColumnType("int")
                .IsRequired();
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
