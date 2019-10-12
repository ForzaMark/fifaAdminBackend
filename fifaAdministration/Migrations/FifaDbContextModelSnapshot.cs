﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using fifaAdministration.Models;

namespace fifaAdministration.Migrations
{
    [DbContext(typeof(FifaDbContext))]
    partial class FifaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("fifaAdministration.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AwayGoals");

                    b.Property<int>("HomeGoals");

                    b.Property<int?>("HomePlayerId");

                    b.HasKey("Id");

                    b.HasIndex("HomePlayerId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("fifaAdministration.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("fifaAdministration.Models.Game", b =>
                {
                    b.HasOne("fifaAdministration.Models.Player", "HomePlayer")
                        .WithMany("Games")
                        .HasForeignKey("HomePlayerId");
                });
#pragma warning restore 612, 618
        }
    }
}
