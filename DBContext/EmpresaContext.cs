
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudAppEmpresa.BD;

namespace CrudAppEmpresa.DBContext
{
    class EmpresaContext : DbContext
    {


        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }
        public DbSet<Telefono> Telefonos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empresa>().ToTable("Empresa");
            modelBuilder.Entity<Telefono>().ToTable("Telefono");
            modelBuilder.Entity<Direccion>().ToTable("Direccion");
        }
    }

}
