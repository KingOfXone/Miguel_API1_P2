﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable
namespace Miguel_API1_P2.Client.Migrations 
{ 

[DbContext(typeof(Contexto))]
partial class ContextoModelSnapshot : ModelSnapshot
{
    protected override void BuildModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
        modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

        modelBuilder.Entity("DetalleEmpacados", b =>
        {
            b.Property<int>("DetalleEmpacadosId")
                .ValueGeneratedOnAdd()
                .HasColumnType("INTEGER");

            b.Property<int>("Cantidad")
                .HasColumnType("INTEGER");

            b.Property<int>("EmpacadosId")
                .HasColumnType("INTEGER");

            b.Property<int>("ProductoId")
                .HasColumnType("INTEGER");

            b.HasKey("DetalleEmpacadosId");

            b.HasIndex("EmpacadosId");

            b.ToTable("DetalleEmpacados");
        });

        modelBuilder.Entity("Empacados", b =>
        {
            b.Property<int>("EmpacadoId")
                .ValueGeneratedOnAdd()
                .HasColumnType("INTEGER");

            b.Property<int>("CantidadProducida")
                .HasColumnType("INTEGER");

            b.Property<int>("CantidadUtilizada")
                .HasColumnType("INTEGER");

            b.Property<string>("Concepto")
                .IsRequired()
                .HasColumnType("TEXT");

            b.Property<DateOnly>("Fecha")
                .HasColumnType("TEXT");

            b.Property<int>("Producido")
                .HasColumnType("INTEGER");

            b.HasKey("EmpacadoId");

            b.ToTable("Empacados");
        });

        modelBuilder.Entity("Productos", b =>
        {
            b.Property<int>("ProductoId")
                .ValueGeneratedOnAdd()
                .HasColumnType("INTEGER");

            b.Property<string>("Categoria")
                .IsRequired()
                .HasColumnType("TEXT");

            b.Property<double>("Costo")
                .HasColumnType("REAL");

            b.Property<string>("Descripcion")
                .IsRequired()
                .HasColumnType("TEXT");

            b.Property<int>("Existencia")
                .HasColumnType("INTEGER");

            b.Property<double>("Precio")
                .HasColumnType("REAL");

            b.HasKey("ProductoId");

            b.ToTable("Productos");

            b.HasData(
                new
                {
                    ProductoId = 1,
                    Categoria = "Normal",
                    Costo = 10.0,
                    Descripcion = "Mani",
                    Existencia = 100,
                    Precio = 25.0
                },
                new
                {
                    ProductoId = 2,
                    Categoria = "Normal",
                    Costo = 50.0,
                    Descripcion = "Pistachos",
                    Existencia = 100,
                    Precio = 120.0
                },
                new
                {
                    ProductoId = 3,
                    Categoria = "Normal",
                    Costo = 25.0,
                    Descripcion = "Pasas",
                    Existencia = 100,
                    Precio = 50.0
                },
                new
                {
                    ProductoId = 4,
                    Categoria = "Normal",
                    Costo = 25.0,
                    Descripcion = "Ciruelas",
                    Existencia = 100,
                    Precio = 50.0
                },
                new
                {
                    ProductoId = 5,
                    Categoria = "Empacado",
                    Costo = 100.0,
                    Descripcion = "Mixto",
                    Existencia = 0,
                    Precio = 150.0
                },
                 new
                 {
                     ProductoId = 6,
                     Categoria = "Normal",
                     Costo = 25.0,
                     Descripcion = "Arandanos",
                     Existencia = 100,
                     Precio = 50.0

                 }
                );
        });

        modelBuilder.Entity("DetalleEmpacados", b =>
        {
            b.HasOne("Empacados", null)
                .WithMany("detalleEmpacados")
                .HasForeignKey("EmpacadosId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
        });

        modelBuilder.Entity("Empacados", b =>
        {
            b.Navigation("detalleEmpacados");
        });
#pragma warning restore 612, 618
    }
}
}
