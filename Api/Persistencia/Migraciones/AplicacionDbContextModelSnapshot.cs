﻿// <auto-generated />
using System;
using Api.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Api.Persistencia.Migraciones
{
    [DbContext(typeof(AplicacionDbContext))]
    partial class AplicacionDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Aplicacion.Dominio.Domicilio", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("Altura")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<string>("Calle")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("CodigoPostal")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Domicilio");

                    b.HasData(
                        new
                        {
                            Id = new Guid("39d3ff4d-5e01-4a42-a7b9-59f4b71beec9"),
                            Altura = 1,
                            Calle = "Domicilio1",
                            CodigoPostal = 1
                        },
                        new
                        {
                            Id = new Guid("ac495f01-1cab-43f9-ab70-b38d8e1ed1c4"),
                            Altura = 2,
                            Calle = "Domicilio2",
                            CodigoPostal = 2
                        });
                });

            modelBuilder.Entity("Aplicacion.Dominio.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<Guid?>("IdDomicilio")
                        .HasColumnType("char(36)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdDomicilio");

                    b.ToTable("Usuario");

                    b.HasData(
                        new
                        {
                            Id = new Guid("657d5a0e-bf98-4d84-b949-9092d453daa5"),
                            Apellido = "ApellidoA",
                            Direccion = "Dirección1",
                            Nombre = "Usuario1"
                        },
                        new
                        {
                            Id = new Guid("b00946b8-93cd-4c24-9083-23f1cd3bc6c9"),
                            Apellido = "ApellidoB",
                            Direccion = "Dirección2",
                            Nombre = "Usuario2"
                        });
                });

            modelBuilder.Entity("Aplicacion.Dominio.Usuario", b =>
                {
                    b.HasOne("Aplicacion.Dominio.Domicilio", "Domicilio")
                        .WithMany()
                        .HasForeignKey("IdDomicilio");

                    b.Navigation("Domicilio");
                });
#pragma warning restore 612, 618
        }
    }
}
