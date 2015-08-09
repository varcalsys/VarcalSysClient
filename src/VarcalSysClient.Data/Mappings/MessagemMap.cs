﻿using System.Data.Entity.ModelConfiguration;
using VarcalSysClient.Domain.Entities;

namespace VarcalSysClient.Data.Mappings
{
    public class MessagemMap: EntityTypeConfiguration<Mensagem>
    {
        public MessagemMap()
        {
            ToTable("tbMensagem");

            HasKey(p => p.Id);
            
            Property(p => p.Id)
                .HasColumnName("Id")
                .HasColumnType("int");
            Property(p => p.Texto)
                .HasColumnName("Texto")
                .HasColumnType("text")
                .IsRequired();
            Property(p => p.DataCadastro)
                .HasColumnName("DataCadastro")
                .HasColumnType("datetime")
                .IsRequired();
           
        }
    }
}
