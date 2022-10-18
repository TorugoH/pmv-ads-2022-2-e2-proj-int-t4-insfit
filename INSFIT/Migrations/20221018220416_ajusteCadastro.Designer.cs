﻿// <auto-generated />
using System;
using INSFIT.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace INSFIT.Migrations
{
    [DbContext(typeof(INSFITContext))]
    [Migration("20221018220416_ajusteCadastro")]
    partial class ajusteCadastro
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("INSFIT.Models.Cadastro", b =>
                {
                    b.Property<int>("id_cadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_cadastro"), 1L, 1);

                    b.Property<int?>("IdUser")
                        .HasColumnType("int");

                    b.Property<int>("email")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("perfilId")
                        .HasColumnType("int");

                    b.Property<int>("senha")
                        .HasColumnType("int");

                    b.HasKey("id_cadastro");

                    b.HasIndex("perfilId");

                    b.ToTable("Cadastro");
                });

            modelBuilder.Entity("INSFIT.Models.Dieta", b =>
                {
                    b.Property<int>("Id_Dieta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Dieta"), 1L, 1);

                    b.Property<string>("CampoImgem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CampodePesquisa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataPublicacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdUser")
                        .HasColumnType("int");

                    b.Property<int>("perfilId")
                        .HasColumnType("int");

                    b.HasKey("Id_Dieta");

                    b.HasIndex("perfilId");

                    b.ToTable("Dieta");
                });

            modelBuilder.Entity("INSFIT.Models.Feed", b =>
                {
                    b.Property<int>("Id_Feed")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Feed"), 1L, 1);

                    b.Property<string>("CampoImgem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CampoTexto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CampodePesquisa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comentario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataPublicacao")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdUser")
                        .HasColumnType("int");

                    b.Property<int>("perfilId")
                        .HasColumnType("int");

                    b.HasKey("Id_Feed");

                    b.HasIndex("perfilId");

                    b.ToTable("Feed");
                });

            modelBuilder.Entity("INSFIT.Models.Mapa", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int?>("IdUser")
                        .HasColumnType("int");

                    b.Property<string>("localizacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("perfilId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("perfilId");

                    b.ToTable("Mapa");
                });

            modelBuilder.Entity("INSFIT.Models.Perfil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Altura")
                        .HasColumnType("float");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Peso")
                        .HasColumnType("float");

                    b.Property<int>("Telefone")
                        .HasColumnType("int");

                    b.Property<int>("Usuario")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("INSFIT.Models.Relatorio", b =>
                {
                    b.Property<int>("Id_relatorio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_relatorio"), 1L, 1);

                    b.Property<int?>("IdUser")
                        .HasColumnType("int");

                    b.Property<double>("altura")
                        .HasColumnType("float");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("perfilId")
                        .HasColumnType("int");

                    b.Property<double>("peso")
                        .HasColumnType("float");

                    b.HasKey("Id_relatorio");

                    b.HasIndex("perfilId");

                    b.ToTable("relatorio");
                });

            modelBuilder.Entity("INSFIT.Models.Cadastro", b =>
                {
                    b.HasOne("INSFIT.Models.Perfil", "perfil")
                        .WithMany()
                        .HasForeignKey("perfilId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("perfil");
                });

            modelBuilder.Entity("INSFIT.Models.Dieta", b =>
                {
                    b.HasOne("INSFIT.Models.Perfil", "perfil")
                        .WithMany("Dieta")
                        .HasForeignKey("perfilId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("perfil");
                });

            modelBuilder.Entity("INSFIT.Models.Feed", b =>
                {
                    b.HasOne("INSFIT.Models.Perfil", "perfil")
                        .WithMany("Feed")
                        .HasForeignKey("perfilId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("perfil");
                });

            modelBuilder.Entity("INSFIT.Models.Mapa", b =>
                {
                    b.HasOne("INSFIT.Models.Perfil", "perfil")
                        .WithMany("Mapa")
                        .HasForeignKey("perfilId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("perfil");
                });

            modelBuilder.Entity("INSFIT.Models.Relatorio", b =>
                {
                    b.HasOne("INSFIT.Models.Perfil", "perfil")
                        .WithMany("Relatorio")
                        .HasForeignKey("perfilId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("perfil");
                });

            modelBuilder.Entity("INSFIT.Models.Perfil", b =>
                {
                    b.Navigation("Dieta");

                    b.Navigation("Feed");

                    b.Navigation("Mapa");

                    b.Navigation("Relatorio");
                });
#pragma warning restore 612, 618
        }
    }
}
