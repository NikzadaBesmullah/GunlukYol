﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GorevTakipApi.Migrations
{
    [DbContext(typeof(GorevContext))]
    [Migration("20250707121658_IlkOlusturma")]
    partial class IlkOlusturma
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.6");

            modelBuilder.Entity("Gorev", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Baslik")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("TamamlandiMi")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Gorevler");
                });
#pragma warning restore 612, 618
        }
    }
}
