﻿// <auto-generated />
using CadastroDeVeiculo.Data.Contexto;
using CadastroDeVeiculo.Dominio.Modelos.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CadastroDeVeiculo.Data.Migrations
{
    [DbContext(typeof(Banco))]
    partial class BancoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasPostgresEnum(null, "e_status", new[] { "ativo", "inativo" })
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("CadastroDeVeiculo.Dominio.Modelos.Proprietario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Documento")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("documento")
                        .HasComment("Indica infomrações de registro da pessoa dono do carro");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)")
                        .HasColumnName("email")
                        .HasComment("Email para mandar informações para o proprietario");

                    b.Property<string>("Endereco")
                        .HasColumnType("text")
                        .HasColumnName("endereco")
                        .HasComment("Indica onde o proprietario mora");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("nome")
                        .HasComment("Indica informações sobre o nome de nascimento da pessoa");

                    b.Property<EStatus>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("e_status")
                        .HasDefaultValue(EStatus.ATIVO)
                        .HasColumnName("status")
                        .HasComment("Indica se essa classe esta ativa ou nao");

                    b.HasKey("Id");

                    b.ToTable("proprietarios");
                });
#pragma warning restore 612, 618
        }
    }
}