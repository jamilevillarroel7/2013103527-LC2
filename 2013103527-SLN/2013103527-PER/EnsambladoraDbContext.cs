using _2013220746_ENT;
using _2013220746_PER.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013220746_PER
{
    public class EnsambladoraDbContext : DbContext
    {
        public DbSet<Asiento> Asientos { get; set; }
        public DbSet<Automovil> Automoviles { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Carro> Carros { get; set; }
        public DbSet<Cinturon> Cinturones { get; set; }
        public DbSet<Ensambladora> Ensambladoras { get; set; }
        public DbSet<Llanta> Llantas { get; set; }
        public DbSet<Parabrisas> Parabrisas { get; set; }
        public DbSet<Propietario> Propietarios { get; set; }
        public DbSet<Volante> Volantes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EnsambladoraConfiguration());

            modelBuilder.Entity<Cinturon>()
                .HasRequired(c => c.Asiento)
                .WithRequiredPrincipal(c => c.Cinturon);
            modelBuilder.Entity<Carro>()
                .HasRequired(c => c.Ensambladora)
                .WithMany(c => c.Carros);

            base.OnModelCreating(modelBuilder);
        }
    }
}
