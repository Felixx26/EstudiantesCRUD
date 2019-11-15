﻿// <auto-generated />
using System;
using CRUD_Examen2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRUD_Examen2.Migrations
{
    [DbContext(typeof(SistemaContext))]
    [Migration("20191115013048_materiasDB_Damaso")]
    partial class materiasDB_Damaso
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CRUD_Examen2.Models.Estudiante", b =>
                {
                    b.Property<int>("estudiante_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("apellido");

                    b.Property<string>("estado");

                    b.Property<string>("nombre");

                    b.HasKey("estudiante_id");

                    b.ToTable("Estudiante");
                });

            modelBuilder.Entity("CRUD_Examen2.Models.Materia", b =>
                {
                    b.Property<int>("materia_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("codigo");

                    b.Property<int>("creditos");

                    b.Property<int?>("estudiante_id");

                    b.Property<string>("nombre_materia");

                    b.HasKey("materia_id");

                    b.HasIndex("estudiante_id");

                    b.ToTable("Materia");
                });

            modelBuilder.Entity("CRUD_Examen2.Models.Materia", b =>
                {
                    b.HasOne("CRUD_Examen2.Models.Estudiante")
                        .WithMany("materias")
                        .HasForeignKey("estudiante_id");
                });
#pragma warning restore 612, 618
        }
    }
}
