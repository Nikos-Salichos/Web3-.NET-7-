﻿// <auto-generated />
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221218063252_DB Initialize")]
    partial class DBInitialize
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Models.SmartContract", b =>
                {
                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AbiSerialized")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Abi");

                    b.Property<string>("Bytecode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParametersSerialized")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Parameters");

                    b.HasKey("Address");

                    b.ToTable("SmartContract");
                });
#pragma warning restore 612, 618
        }
    }
}
