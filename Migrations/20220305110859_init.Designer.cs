﻿// <auto-generated />
using System;
using aninja_anime_service.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace aninja_anime_service.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220305110859_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("aninja_browse_service.Models.Anime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Demographic")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("demographic");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("end_date");

                    b.Property<int>("EpisodeCount")
                        .HasColumnType("integer")
                        .HasColumnName("episode_count");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("text")
                        .HasColumnName("img_url");

                    b.Property<string>("OriginalTitle")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("original_title");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("start_date");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("status");

                    b.Property<string>("TranslatedTitle")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("translated_title");

                    b.HasKey("Id");

                    b.ToTable("animes", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
