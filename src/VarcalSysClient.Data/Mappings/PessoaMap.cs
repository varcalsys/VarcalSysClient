using System.Data.Entity.ModelConfiguration;
using VarcalSysClient.Domain.Entities;

namespace VarcalSysClient.Data.Mappings
{
    public class PessoaMap: EntityTypeConfiguration<Pessoa>
    {
        public PessoaMap()
        {
            ToTable("tbPessoa");

            #region Keys

            HasKey(p => p.Id);
            HasOptional(p => p.PessoaFisica)
                .WithRequired(s => s.Pessoa);
            HasOptional(p => p.PessoaJuridica)
                .WithRequired(s => s.Pessoa);

            #endregion

            #region Properties

            Property(p => p.Id)
                    .HasColumnName("Id")
                    .HasColumnType("int");
            Property(p => p.PessoaTipo)
                .HasColumnName("PessoaTipo")
                .HasColumnType("int")
                .IsRequired();
            Property(p => p.DataCadastro)
                .HasColumnName("DataCadastro")
                .HasColumnType("datetime")
                .IsRequired();
            Property(p => p.Ativo)
                .HasColumnName("Ativo")
                .HasColumnType("bit")
                .IsRequired(); 

            #endregion


       }
    }
}