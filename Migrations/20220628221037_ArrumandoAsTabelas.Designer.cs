// <auto-generated />
using System;
using CadNotas.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CadNotas.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220628221037_ArrumandoAsTabelas")]
    partial class ArrumandoAsTabelas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("CadNotas.Models.Nota", b =>
                {
                    b.Property<long>("numCupom")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("canalCompra")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("dataCompra")
                        .HasColumnType("TEXT");

                    b.HasKey("numCupom");

                    b.ToTable("Notas");
                });

            modelBuilder.Entity("CadNotas.Models.Produto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
