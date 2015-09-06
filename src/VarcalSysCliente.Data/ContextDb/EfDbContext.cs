using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarcalSysCliente.Data.Mapping;
using VarcalSysCliente.Domain.Entities;

namespace VarcalSysCliente.Data.ContextDb
{
    public class EfDbContext: DbContext
    {
        public EfDbContext():base("appStrConnection")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<PessoaFisica> ClientesPf { get; set; }
        public DbSet<PessoaJuridica> ClientesPj { get; set; }
        public DbSet<Endereco> Logradouros { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<PlanoHost> PlanosHost { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new PessoaFisicaMap());
            modelBuilder.Configurations.Add(new PessoaJuridicaMap());
            modelBuilder.Configurations.Add(new ContatoMap());
            modelBuilder.Configurations.Add(new EnderecoMap());
            modelBuilder.Configurations.Add(new PlanoHostMap());

           base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }

            return base.SaveChanges();
        }
    }
}
