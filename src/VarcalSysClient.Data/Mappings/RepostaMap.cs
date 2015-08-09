using System.Data.Entity.ModelConfiguration;
using VarcalSysClient.Domain.Entities;

namespace VarcalSysClient.Data.Mappings
{
    public class RepostaMap: EntityTypeConfiguration<Resposta>
    {
        public RepostaMap ()
        {
            ToTable("tbResposta");

            HasRequired(p => p.Ticket)
                .WithMany(r => r.Repostas)
                .HasForeignKey(p => p.TicketId);

            Property(p => p.DataReposta)
                .HasColumnName("DataResposta")
                .HasColumnType("datetime")
                .IsRequired();
            Property(p => p.Texto)
                .HasColumnName("Texto")
                .HasColumnType("text")
                .IsRequired();
            Property(p => p.Ativo)
                .HasColumnName("Ativo")
                .HasColumnType("bit")
                .IsRequired();
        }
    }
}
