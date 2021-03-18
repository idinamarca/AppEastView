﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiEastView.Models;

namespace AppEastView.Migrations
{
    [DbContext(typeof(ContextoDB))]
    [Migration("20210318152317_cf2")]
    partial class cf2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApiEastView.Models.Ciudadano", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("EstadoCiudadano")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("apellido")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ciudadano");
                });

            modelBuilder.Entity("WebApiEastView.Models.DiaTarea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Dia")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DiaTarea");
                });

            modelBuilder.Entity("WebApiEastView.Models.EstadoTarea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NombreTarea")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EstadoTarea");
                });

            modelBuilder.Entity("WebApiEastView.Models.PrioridadTarea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Prioridad")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PrioridadTarea");
                });

            modelBuilder.Entity("WebApiEastView.Models.Tarea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CiudadanoId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("DiaTareaId")
                        .HasColumnType("int");

                    b.Property<int>("EstadoTareaId")
                        .HasColumnType("int");

                    b.Property<int>("PrioridadTareaId")
                        .HasColumnType("int");

                    b.Property<int>("TipoTareaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CiudadanoId");

                    b.HasIndex("DiaTareaId");

                    b.HasIndex("EstadoTareaId");

                    b.HasIndex("PrioridadTareaId");

                    b.HasIndex("TipoTareaId");

                    b.ToTable("Tarea");
                });

            modelBuilder.Entity("WebApiEastView.Models.TipoTarea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tarea")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipoTarea");
                });

            modelBuilder.Entity("WebApiEastView.Models.Tarea", b =>
                {
                    b.HasOne("WebApiEastView.Models.Ciudadano", "Ciudadano")
                        .WithMany()
                        .HasForeignKey("CiudadanoId");

                    b.HasOne("WebApiEastView.Models.DiaTarea", "DiaTarea")
                        .WithMany()
                        .HasForeignKey("DiaTareaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApiEastView.Models.EstadoTarea", "EstadoTarea")
                        .WithMany()
                        .HasForeignKey("EstadoTareaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApiEastView.Models.PrioridadTarea", "PrioridadTarea")
                        .WithMany()
                        .HasForeignKey("PrioridadTareaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApiEastView.Models.TipoTarea", "TipoTarea")
                        .WithMany()
                        .HasForeignKey("TipoTareaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ciudadano");

                    b.Navigation("DiaTarea");

                    b.Navigation("EstadoTarea");

                    b.Navigation("PrioridadTarea");

                    b.Navigation("TipoTarea");
                });
#pragma warning restore 612, 618
        }
    }
}
