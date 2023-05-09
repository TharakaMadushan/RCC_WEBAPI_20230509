﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WEBAPI.PERSISTANCE;

#nullable disable

namespace WEBAPI.PERSISTANCE.Migrations
{
    [DbContext(typeof(DataAccess))]
    [Migration("20220921170617_202209211036")]
    partial class _202209211036
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WEBAPI.MODELS.CustomerProject", b =>
                {
                    b.Property<string>("ProjectCode")
                        .HasMaxLength(210)
                        .HasColumnType("nvarchar(210)");

                    b.Property<bool>("ActiveProject")
                        .HasColumnType("bit");

                    b.Property<int>("ProjectLink")
                        .HasColumnType("int");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("ProjectCode");

                    b.ToTable("tblRefProject");
                });

            modelBuilder.Entity("WEBAPI.MODELS.DayType", b =>
                {
                    b.Property<string>("DayTypeCode")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("DayTypeName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("DayTypeCode");

                    b.ToTable("tblRefDayType");
                });

            modelBuilder.Entity("WEBAPI.MODELS.Designation", b =>
                {
                    b.Property<string>("DesigCode")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DesigDes")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("DesigCode");

                    b.ToTable("tblRefDesignation");
                });

            modelBuilder.Entity("WEBAPI.MODELS.Employee", b =>
                {
                    b.Property<string>("EmployeeCode")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DesignationCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("EPFNumber")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("datetime2");

                    b.Property<string>("EmployeeDes")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Fax")
                        .HasMaxLength(20)
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NIC")
                        .HasMaxLength(20)
                        .HasColumnType("datetime2");

                    b.Property<string>("SkillTypeCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("TPNo1")
                        .HasMaxLength(20)
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TPNo2")
                        .HasMaxLength(20)
                        .HasColumnType("datetime2");

                    b.HasKey("EmployeeCode");

                    b.ToTable("tblRefEmployee");
                });

            modelBuilder.Entity("WEBAPI.MODELS.SkillType", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Code");

                    b.ToTable("tblRefSkillType");
                });
#pragma warning restore 612, 618
        }
    }
}
