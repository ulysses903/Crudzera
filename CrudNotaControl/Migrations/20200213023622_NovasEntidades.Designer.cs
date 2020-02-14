﻿// <auto-generated />
using System;
using CrudNotaControl.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CrudNotaControl.Migrations
{
    [DbContext(typeof(CrudNotaControlContext))]
    [Migration("20200213023622_NovasEntidades")]
    partial class NovasEntidades
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CrudNotaControl.Models.Cidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EstadoId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("EstadoId");

                    b.ToTable("Cidade");
                });

            modelBuilder.Entity("CrudNotaControl.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro");

                    b.Property<int?>("CidadeId");

                    b.Property<string>("Logradouro");

                    b.Property<int>("Numero");

                    b.HasKey("Id");

                    b.HasIndex("CidadeId");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("CrudNotaControl.Models.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cpf");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Email");

                    b.Property<int?>("EnderecoId");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Pessoa");
                });

            modelBuilder.Entity("CrudNotaControl.Models.ViewModels.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Estado");
                });

            modelBuilder.Entity("CrudNotaControl.Models.Cidade", b =>
                {
                    b.HasOne("CrudNotaControl.Models.ViewModels.Estado", "Estado")
                        .WithMany()
                        .HasForeignKey("EstadoId");
                });

            modelBuilder.Entity("CrudNotaControl.Models.Endereco", b =>
                {
                    b.HasOne("CrudNotaControl.Models.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeId");
                });

            modelBuilder.Entity("CrudNotaControl.Models.Pessoa", b =>
                {
                    b.HasOne("CrudNotaControl.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId");
                });
#pragma warning restore 612, 618
        }
    }
}
