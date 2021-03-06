// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TekniskTestCentricAPI.DataModels;

#nullable disable

namespace TekniskTestCentricAPI.Migrations
{
    [DbContext(typeof(ContinentAdminContext))]
    [Migration("20220619165351_Initial Migrations")]
    partial class InitialMigrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TekniskTestCentricAPI.DataModels.Continent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Continent");
                });

            modelBuilder.Entity("TekniskTestCentricAPI.DataModels.Country", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ContinentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContinentId")
                        .IsUnique();

                    b.ToTable("Country");
                });

            modelBuilder.Entity("TekniskTestCentricAPI.DataModels.Country", b =>
                {
                    b.HasOne("TekniskTestCentricAPI.DataModels.Continent", "Continent")
                        .WithOne("Country")
                        .HasForeignKey("TekniskTestCentricAPI.DataModels.Country", "ContinentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Continent");
                });

            modelBuilder.Entity("TekniskTestCentricAPI.DataModels.Continent", b =>
                {
                    b.Navigation("Country")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
