﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPIAgendAI.Models;

namespace WebAPIAgendAI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230423003105_m00")]
    partial class m00
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAPIAgendAI.Models.Agendamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailInstitucional")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<string>("Turma")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmailInstitucional");

                    b.ToTable("Agendamentos");
                });

            modelBuilder.Entity("WebAPIAgendAI.Models.Equipamento", b =>
                {
                    b.Property<int>("NumeroSerie")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HostName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("NumeroSerie");

                    b.ToTable("Equipamentos");
                });

            modelBuilder.Entity("WebAPIAgendAI.Models.Funcionario", b =>
                {
                    b.Property<string>("EmailInstitucional")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Perfil")
                        .HasColumnType("int");

                    b.Property<string>("senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmailInstitucional");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("WebAPIAgendAI.Models.Agendamento", b =>
                {
                    b.HasOne("WebAPIAgendAI.Models.Funcionario", "Funcionario")
                        .WithMany("Agendamentos")
                        .HasForeignKey("EmailInstitucional")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funcionario");
                });

            modelBuilder.Entity("WebAPIAgendAI.Models.Funcionario", b =>
                {
                    b.Navigation("Agendamentos");
                });
#pragma warning restore 612, 618
        }
    }
}