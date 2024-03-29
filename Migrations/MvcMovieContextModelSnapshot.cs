﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcMovie.Models;

namespace MvcMovie.Migrations
{
    [DbContext(typeof(MvcMovieContext))]
    partial class MvcMovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MvcMovie.Models.Movie", b =>
            {
                b.Property<int>("ID")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Directors");

                b.Property<string>("Genre");

                b.Property<decimal>("Price")
                    .HasColumnType("decimal(18, 2)");

                b.Property<string>("Rating");

                b.Property<DateTime>("ReleaseDate");

                b.Property<int>("RunTime");

                b.Property<string>("Title");

                b.Property<string>("URL");

                b.HasKey("ID");

                b.ToTable("Movie");
            });
#pragma warning restore 612, 618
        }
    }
}
