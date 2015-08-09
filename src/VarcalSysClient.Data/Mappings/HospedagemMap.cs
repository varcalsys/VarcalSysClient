using System.Data.Entity.ModelConfiguration;
using VarcalSysClient.Domain.Entities;

namespace VarcalSysClient.Data.Mappings
{
    public class HospedagemMap: EntityTypeConfiguration<Hospedagem>
    {
        public HospedagemMap()
        {
            ToTable("tbHospedagem");

            HasKey(p => p.Id);

            HasRequired(p => p.Pessoa)
                .WithMany()
                .HasForeignKey(p => p.PessoaId);

            Property(p => p.Id)
                .HasColumnName("Id")
                .HasColumnType("int");
        }
    }
}
