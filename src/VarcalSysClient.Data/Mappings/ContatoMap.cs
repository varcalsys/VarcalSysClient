using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarcalSysClient.Domain.Entities;

namespace VarcalSysClient.Data.Mappings
{
    public class ContatoMap: EntityTypeConfiguration<Contato>
    {
        public ContatoMap()
        {
            ToTable("tbContato");

            HasKey(p => p.Id);

            HasRequired(p => p.Pessoa)
                .WithMany(c=>c.Contatos)
                .HasForeignKey(p => p.PessoaId);

            

            Property(p => p.Id)
                .HasColumnName("Id")
                .HasColumnType("int");
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
            Property(p => p.Telefone)
                .HasColumnName("Telefone")
                .HasColumnType("char")
                .HasMaxLength(10)
                .IsRequired();
            Property(p => p.Celular)
                .HasColumnName("Celular")
                .HasColumnType("char")
                .HasMaxLength(11)
                .IsRequired();
            Property(p => p.Skype)
                .HasColumnName("Skype")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsOptional();
            Property(p => p.PessoaId)
               .HasColumnName("PessoaId")
               .HasColumnType("int")
               .IsRequired();
            Property(p => p.Ativo)
                .HasColumnName("Ativo")
                .HasColumnType("bit")
                .IsRequired();
        }
    }
}
