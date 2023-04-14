﻿// <auto-generated />
using System;
using CAPoliza.Infraestructura;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace PolizaAPI.Migrations
{
    [DbContext(typeof(PolizaDBcontext))]
    [Migration("20230414065517_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CAPoliza.Dominios.Poliza", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("CiudadResideCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CoberturasCubiertas")
                        .HasColumnType("int");

                    b.Property<string>("DireccionCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimientoCliente")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaPoliza")
                        .HasColumnType("datetime2");

                    b.Property<string>("IdentificacionCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Inspeccion")
                        .HasColumnType("bit");

                    b.Property<string>("NombreCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombrePlanPoliza")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlacaAuto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ValorMaxPoliza")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.ToTable("Polizas");
                });
#pragma warning restore 612, 618
        }
    }
}
