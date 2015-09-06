using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarcalSysCliente.Domain.Entities;

namespace VarcalSysCliente.Data.Mapping
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            ToTable("Cliente");

            HasKey(p => p.Id);

            HasOptional(p => p.PessoaFisica)
                .WithRequired(s => s.Cliente);
            HasOptional(p => p.PessoaJuridica)
                .WithRequired(s => s.Cliente);

            HasRequired(p => p.Endereco)
                .WithMany()
                .HasForeignKey(p => p.EnderecoId);
            HasRequired(p => p.Contato)
                .WithMany()
                .HasForeignKey(p => p.ContatoId);
            HasRequired(p => p.PlanoHost)
                .WithMany()
                .HasForeignKey(p => p.PlanoHostId);

            Property(p => p.PessoaTipo)
                .HasColumnName("ClienteTipo")
                .HasColumnType("int")
                .IsRequired();
            Property(p => p.Dominio)
                .HasColumnName("Dominio")
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();
            Property(p => p.DataCadastro)
                .HasColumnName("DataCadastro")
                .HasColumnType("datetime")
                .IsRequired();
            Property(p => p.Ativo)
                .HasColumnName("Ativo")
                .HasColumnType("bit")
                .IsRequired();
            Property(p => p.EnderecoId)
                .HasColumnName("LogradouroId")
                .HasColumnType("int")
                .IsRequired();
            Property(p => p.ContatoId)
                .HasColumnName("ContatoId")
                .HasColumnType("int")
                .IsRequired();
            Property(p => p.PlanoHostId)
                .HasColumnName("PlanoHostId")
                .HasColumnType("int")
                .IsRequired();

        }
    }
}
