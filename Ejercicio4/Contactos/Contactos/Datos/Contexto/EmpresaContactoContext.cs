namespace Datos.Contexto
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Models;

    public partial class EmpresaContactoContext : DbContext
    {
        public EmpresaContactoContext()
            : base("name=EmpresaContactoContext1")
        {
        }

        public virtual DbSet<Contacto> Contactos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contacto>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Contacto>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Contacto>()
                .Property(e => e.Genero)
                .IsUnicode(false);

            modelBuilder.Entity<Contacto>()
                .Property(e => e.Empresa)
                .IsUnicode(false);
        }
    }
}
