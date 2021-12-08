﻿// <auto-generated />
using CS_final.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CS_final.Migrations
{
    [DbContext(typeof(ClubDbContext))]
    [Migration("20211206214028_Change dtypes")]
    partial class Changedtypes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("CS_final.Models.Customer", b =>
                {
                    b.Property<long>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Full_name")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(13)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CS_final.Models.Equipment", b =>
                {
                    b.Property<long>("EquipmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("EquipmentId");

                    b.ToTable("Equipments");
                });

            modelBuilder.Entity("CS_final.Models.EquipmentUsage", b =>
                {
                    b.Property<long>("EquipmentUsageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long>("EquipmentId")
                        .HasColumnType("bigint");

                    b.Property<long>("GameId")
                        .HasColumnType("bigint");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<decimal>("SnapPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("EquipmentUsageId");

                    b.HasIndex("EquipmentId");

                    b.HasIndex("GameId");

                    b.ToTable("EquipmentUsages");
                });

            modelBuilder.Entity("CS_final.Models.Game", b =>
                {
                    b.Property<long>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long>("CustomerId")
                        .HasColumnType("bigint");

                    b.Property<long>("LocationId")
                        .HasColumnType("bigint");

                    b.Property<int>("PlayersCount")
                        .HasColumnType("int");

                    b.HasKey("GameId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("LocationId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("CS_final.Models.Location", b =>
                {
                    b.Property<long>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<int>("MaxPlayers")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("CS_final.Models.EquipmentUsage", b =>
                {
                    b.HasOne("CS_final.Models.Equipment", "Equipment")
                        .WithMany()
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CS_final.Models.Game", null)
                        .WithMany("EquipmentUsages")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipment");
                });

            modelBuilder.Entity("CS_final.Models.Game", b =>
                {
                    b.HasOne("CS_final.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CS_final.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("CS_final.Models.Game", b =>
                {
                    b.Navigation("EquipmentUsages");
                });
#pragma warning restore 612, 618
        }
    }
}
