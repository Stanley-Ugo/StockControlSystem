﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StockControlSystem.StockControlContext;

namespace StockControlSystem.Migrations
{
    [DbContext(typeof(StockControlDBContext))]
    [Migration("20210424001623_Adding-St_Stkjournal-Table")]
    partial class AddingSt_StkjournalTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StockControlSystem.Models.St_Stkjournal", b =>
                {
                    b.Property<string>("Stk_Account")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Stk_Branch")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Stk_Coy")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Stk_Credit")
                        .HasColumnType("money");

                    b.Property<decimal>("Stk_Debit")
                        .HasColumnType("money");

                    b.Property<string>("Stk_Loc")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Stk_Month")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Stk_Period")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stk_Rem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stk_Type")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Stk_Update")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stk_Year")
                        .HasColumnType("nvarchar(450)");

                    b.HasIndex("Stk_Account")
                        .IsUnique()
                        .HasFilter("[Stk_Account] IS NOT NULL");

                    b.HasIndex("Stk_Branch")
                        .IsUnique()
                        .HasFilter("[Stk_Branch] IS NOT NULL");

                    b.HasIndex("Stk_Coy")
                        .IsUnique()
                        .HasFilter("[Stk_Coy] IS NOT NULL");

                    b.HasIndex("Stk_Loc")
                        .IsUnique()
                        .HasFilter("[Stk_Loc] IS NOT NULL");

                    b.HasIndex("Stk_Month")
                        .IsUnique()
                        .HasFilter("[Stk_Month] IS NOT NULL");

                    b.HasIndex("Stk_Type")
                        .IsUnique()
                        .HasFilter("[Stk_Type] IS NOT NULL");

                    b.HasIndex("Stk_Year")
                        .IsUnique()
                        .HasFilter("[Stk_Year] IS NOT NULL");

                    b.ToTable("St_Stkjournal");
                });

            modelBuilder.Entity("StockControlSystem.Models.Supplier", b =>
                {
                    b.Property<string>("Supcode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Sup_Last_Num")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Sup_Start_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Supcode");

                    b.ToTable("St_Supplier");
                });
#pragma warning restore 612, 618
        }
    }
}
