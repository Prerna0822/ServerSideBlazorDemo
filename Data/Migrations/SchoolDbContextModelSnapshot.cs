﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ServerBlazorEF.Data.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    partial class SchoolDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Student", b =>
                {
                    b.Property<string>("StudentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("School")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = "c2c44821-a17b-44fa-9684-d77034abbe01",
                            FirstName = "Jane",
                            LastName = "Smith",
                            School = "Medicine"
                        },
                        new
                        {
                            StudentId = "647cb82b-53cc-438d-a58d-d73412df1d13",
                            FirstName = "John",
                            LastName = "Fisher",
                            School = "Engineering"
                        },
                        new
                        {
                            StudentId = "a3172925-28a0-4718-b176-e021016b4ca5",
                            FirstName = "Pamela",
                            LastName = "Baker",
                            School = "Food Science"
                        },
                        new
                        {
                            StudentId = "63f73a0e-b419-4772-992d-520c28f23f98",
                            FirstName = "Peter",
                            LastName = "Taylor",
                            School = "Mining"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
