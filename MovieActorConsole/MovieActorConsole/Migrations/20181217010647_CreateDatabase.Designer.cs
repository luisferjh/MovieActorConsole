﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieActorConsole;

namespace MovieActorConsole.Migrations
{
    [DbContext(typeof(MovieDbContext))]
    [Migration("20181217010647_CreateDatabase")]
    partial class CreateDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0-preview.18572.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MovieActorConsole.Actor", b =>
                {
                    b.Property<int>("ActorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("FirtsName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("ActorId");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("MovieActorConsole.Director", b =>
                {
                    b.Property<int>("DirectorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("FirtsName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("DirectorId");

                    b.ToTable("Directors");
                });

            modelBuilder.Entity("MovieActorConsole.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(120);

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("MovieId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("MovieActorConsole.MovieActor", b =>
                {
                    b.Property<int>("ActorId");

                    b.Property<int>("MovieId");

                    b.HasKey("ActorId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("MovieActor");
                });

            modelBuilder.Entity("MovieActorConsole.MovieDirector", b =>
                {
                    b.Property<int>("DirectorId");

                    b.Property<int>("MovieId");

                    b.HasKey("DirectorId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("MovieDirector");
                });

            modelBuilder.Entity("MovieActorConsole.MovieActor", b =>
                {
                    b.HasOne("MovieActorConsole.Actor", "Actor")
                        .WithMany("MovieActor")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MovieActorConsole.Movie", "Movie")
                        .WithMany("MovieActor")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MovieActorConsole.MovieDirector", b =>
                {
                    b.HasOne("MovieActorConsole.Director", "Director")
                        .WithMany("MovieDirector")
                        .HasForeignKey("DirectorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MovieActorConsole.Movie", "Movie")
                        .WithMany("MovieDirector")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}