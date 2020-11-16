namespace DatosAPI.Contexto
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using EntidadesAPI;

    public partial class ApiContextDb : DbContext
    {
        private static ApiContextDb bdContexto = null;
        private ApiContextDb()
            : base("name=ApiContextDb")
        {
        }
        public static ApiContextDb ObtenerContextoBD() {         
            bool validarInstanciaUnica = bdContexto == null;
            if (validarInstanciaUnica)
            {
                bdContexto = new ApiContextDb();
                bdContexto.Configuration.ProxyCreationEnabled = false;
            }
            return bdContexto;
        }



        public virtual DbSet<DEPARTMENT> DEPARTMENTS { get; set; }
        public virtual DbSet<EMPLOYEE> EMPLOYEES { get; set; }
        public virtual DbSet<JOB> JOBS { get; set; }
        public virtual DbSet<LOCATION> LOCATIONS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DEPARTMENT>()
                .Property(e => e.DEPARTMENT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<DEPARTMENT>()
                .Property(e => e.DEPARTMENT_DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<DEPARTMENT>()
                .HasMany(e => e.EMPLOYEES)
                .WithOptional(e => e.DEPARTMENT)
                .HasForeignKey(e => e.DEPARTMENT_ID);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.FIRST_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.LAST_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.SALARY)
                .HasPrecision(10, 2);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.JOB_ID)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .HasMany(e => e.EMPLOYEES1)
                .WithOptional(e => e.EMPLOYEE1)
                .HasForeignKey(e => e.MANAGER_ID);

            modelBuilder.Entity<JOB>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.JOB_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .HasMany(e => e.EMPLOYEES)
                .WithOptional(e => e.JOB)
                .HasForeignKey(e => e.JOB_ID);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.CITY)
                .IsUnicode(false);

            modelBuilder.Entity<LOCATION>()
                .HasMany(e => e.DEPARTMENTS)
                .WithRequired(e => e.LOCATION)
                .HasForeignKey(e => e.LOCATION_ID)
                .WillCascadeOnDelete(false);
        }
    }
}
