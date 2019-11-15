using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUD_Examen2.Models;

namespace CRUD_Examen2.Models
{
    public class SistemaContext : DbContext
    {
        public SistemaContext(DbContextOptions<SistemaContext> options) : base(options)
        {

        }
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Estudiante> Materias { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Estudiante>()
                .HasKey(e => e.estudiante_id);
            modelBuilder.Entity<Materia>()
                .HasKey(m => m.materia_id);
        }
        public DbSet<CRUD_Examen2.Models.Materia> Materia { get; set; }
    }
}
