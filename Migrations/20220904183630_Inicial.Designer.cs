﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tarea1.DAL;

#nullable disable

namespace Tarea1.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20220904183630_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.8");

            modelBuilder.Entity("Tarea1.Models.Ocupaciones", b =>
                {
                    b.Property<int>("OcupacionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float?>("Salario")
                        .HasColumnType("REAL");

                    b.HasKey("OcupacionId");

                    b.ToTable("Ocupaciones");
                });
#pragma warning restore 612, 618
        }
    }
}