﻿// <auto-generated />
using System;
using AgendamentoAPI.Model.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AgendamentoAPI.Migrations
{
    [DbContext(typeof(MySQLContext))]
    partial class MySQLContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AgendamentoAPI.Model.Agendamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("data");

                    b.Property<int>("OficinaId")
                        .HasColumnType("int");

                    b.Property<string>("TipoServico")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("tipoServico");

                    b.Property<int?>("UnidadeTrabalhoServico")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("unidadeTrabalhoServico");

                    b.HasKey("Id");

                    b.HasIndex("OficinaId");

                    b.ToTable("agendamento");
                });

            modelBuilder.Entity("AgendamentoAPI.Model.Oficina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("CargaTrabalhoDiaria")
                        .HasColumnType("int")
                        .HasColumnName("cargaTrabalhoDiaria");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("cnpj");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("nome");

                    b.Property<byte[]>("SenhaHash")
                        .IsRequired()
                        .HasColumnType("longblob")
                        .HasColumnName("senhaHash");

                    b.HasKey("Id");

                    b.ToTable("oficina");
                });

            modelBuilder.Entity("AgendamentoAPI.Model.Agendamento", b =>
                {
                    b.HasOne("AgendamentoAPI.Model.Oficina", "Oficina")
                        .WithMany("Agendamentos")
                        .HasForeignKey("OficinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Oficina");
                });

            modelBuilder.Entity("AgendamentoAPI.Model.Oficina", b =>
                {
                    b.Navigation("Agendamentos");
                });
#pragma warning restore 612, 618
        }
    }
}
