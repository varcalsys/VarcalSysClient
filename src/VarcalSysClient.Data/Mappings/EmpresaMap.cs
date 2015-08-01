using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarcalSysClient.Domain.Entities;

namespace VarcalSysClient.Data.Mappings
{
    public class EmpresaMap: EntityTypeConfiguration<Empresa>
    {
        public EmpresaMap()
        {
            ToTable("tbEmpresa");

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
