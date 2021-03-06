﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TesteCapgeminiWebApi.Data;

namespace TesteCapgeminiWebApi.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("TesteCapgeminiWebApi.Models.Excel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DtEntrega")
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeProduto")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorUnitario")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Excel");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DtEntrega = new DateTime(2020, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NomeProduto = "Descrição 1",
                            Quantidade = 1,
                            ValorUnitario = 10m
                        },
                        new
                        {
                            Id = 2,
                            DtEntrega = new DateTime(2020, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NomeProduto = "Descrição 2",
                            Quantidade = 2,
                            ValorUnitario = 11m
                        },
                        new
                        {
                            Id = 3,
                            DtEntrega = new DateTime(2020, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NomeProduto = "Descrição 3",
                            Quantidade = 3,
                            ValorUnitario = 12m
                        },
                        new
                        {
                            Id = 4,
                            DtEntrega = new DateTime(2020, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NomeProduto = "Descrição 4",
                            Quantidade = 4,
                            ValorUnitario = 13m
                        },
                        new
                        {
                            Id = 5,
                            DtEntrega = new DateTime(2020, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NomeProduto = "Descrição 5",
                            Quantidade = 5,
                            ValorUnitario = 14m
                        },
                        new
                        {
                            Id = 6,
                            DtEntrega = new DateTime(2020, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NomeProduto = "Descrição 6",
                            Quantidade = 6,
                            ValorUnitario = 15m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
