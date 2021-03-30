﻿// <auto-generated />
using System;
using GoodsPackaging.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GoodsPackaging.Migrations
{
    [DbContext(typeof(GoodsPackagingContext))]
    partial class GoodsPackagingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GoodsPackaging.Models.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyId");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("GoodsPackaging.Models.CompanyGoodsPackage", b =>
                {
                    b.Property<int>("companyGoodsPackageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int>("GoodsTypeId")
                        .HasColumnType("int");

                    b.Property<int>("PackageTypeid")
                        .HasColumnType("int");

                    b.Property<DateTime>("PackagingDate")
                        .HasColumnType("datetime2");

                    b.HasKey("companyGoodsPackageId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("GoodsTypeId");

                    b.HasIndex("PackageTypeid");

                    b.ToTable("CompanyGoodsPackage");
                });

            modelBuilder.Entity("GoodsPackaging.Models.GoodsType", b =>
                {
                    b.Property<int>("GoodsTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GoodType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GoodsTypeId");

                    b.ToTable("GoodsType");
                });

            modelBuilder.Entity("GoodsPackaging.Models.PackageType", b =>
                {
                    b.Property<int>("PackageTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PackagingType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PackageTypeId");

                    b.ToTable("PackageType");
                });

            modelBuilder.Entity("GoodsPackaging.Models.CompanyGoodsPackage", b =>
                {
                    b.HasOne("GoodsPackaging.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GoodsPackaging.Models.GoodsType", "GoodsType")
                        .WithMany()
                        .HasForeignKey("GoodsTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GoodsPackaging.Models.PackageType", "PackageType")
                        .WithMany()
                        .HasForeignKey("PackageTypeid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
