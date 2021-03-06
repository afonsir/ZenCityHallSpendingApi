// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ZenCityHallSpendingApi.Data;

namespace ZenCityHallSpendingApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210425211308_Seed")]
    partial class Seed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("ZenCityHallSpendingApi.Models.Empenho", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Acao")
                        .HasColumnType("text");

                    b.Property<string>("Aplicacao")
                        .HasColumnType("text");

                    b.Property<string>("Codigo")
                        .HasColumnType("text");

                    b.Property<string>("Credor")
                        .HasColumnType("text");

                    b.Property<DateTime>("DataEmpenho")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DataLiquidacao")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DataPagamento")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Descricao")
                        .HasColumnType("text");

                    b.Property<string>("FonteRecurso")
                        .HasColumnType("text");

                    b.Property<string>("Funcao")
                        .HasColumnType("text");

                    b.Property<string>("Natureza")
                        .HasColumnType("text");

                    b.Property<string>("NroDoctoFiscal")
                        .HasColumnType("text");

                    b.Property<string>("NumeroProcesso")
                        .HasColumnType("text");

                    b.Property<string>("Programa")
                        .HasColumnType("text");

                    b.Property<string>("SubFuncao")
                        .HasColumnType("text");

                    b.Property<string>("TipoDoctoFiscal")
                        .HasColumnType("text");

                    b.Property<string>("TipoLicitacao")
                        .HasColumnType("text");

                    b.Property<string>("UnidadeOrcamentaria")
                        .HasColumnType("text");

                    b.Property<decimal>("ValorEmpenhado")
                        .HasColumnType("numeric");

                    b.Property<decimal>("ValorLiquidacao")
                        .HasColumnType("numeric");

                    b.Property<decimal>("ValorPago")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Empenhos");
                });

            modelBuilder.Entity("ZenCityHallSpendingApi.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
