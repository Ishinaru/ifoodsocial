﻿// <auto-generated />
using System;
using IfoodSocial.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IfoodSocial.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241128192709_AjustesDB")]
    partial class AjustesDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("IfoodSocial.Model.Bairro", b =>
                {
                    b.Property<int>("Cod_Bairro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Cod_Bairro"));

                    b.Property<int>("Cod_Cidade")
                        .HasColumnType("int");

                    b.Property<string>("Dcr_Bairro")
                        .HasColumnType("varchar(45)");

                    b.HasKey("Cod_Bairro");

                    b.HasIndex("Cod_Cidade");

                    b.ToTable("Bairro");
                });

            modelBuilder.Entity("IfoodSocial.Model.Categoria", b =>
                {
                    b.Property<int>("Cod_Categoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Cod_Categoria"));

                    b.Property<string>("Dcr_Categoria")
                        .HasColumnType("longtext");

                    b.Property<byte[]>("Img_Categoria")
                        .HasColumnType("longblob");

                    b.HasKey("Cod_Categoria");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("IfoodSocial.Model.Cidade", b =>
                {
                    b.Property<int>("Cod_Cidade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Cod_Cidade"));

                    b.Property<string>("Dcr_Cidade")
                        .HasColumnType("varchar(45)");

                    b.HasKey("Cod_Cidade");

                    b.ToTable("Cidade");
                });

            modelBuilder.Entity("IfoodSocial.Model.Cliente", b =>
                {
                    b.Property<int>("Cod_Cliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Cod_Cliente"));

                    b.Property<int>("Cod_Bairro")
                        .HasColumnType("int");

                    b.Property<int>("Cod_Cidade")
                        .HasColumnType("int");

                    b.Property<string>("Dcr_Complemento")
                        .HasColumnType("varchar(45)");

                    b.Property<string>("Dcr_Endereco")
                        .HasColumnType("varchar(45)");

                    b.Property<string>("Nome_Cliente")
                        .HasColumnType("varchar(45)");

                    b.Property<string>("Num_Cep")
                        .HasColumnType("varchar(10)");

                    b.HasKey("Cod_Cliente");

                    b.HasIndex("Cod_Bairro");

                    b.HasIndex("Cod_Cidade");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("IfoodSocial.Model.Empreedimento", b =>
                {
                    b.Property<int>("Cod_Empreedimento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Cod_Empreedimento"));

                    b.Property<int>("Bairro_Cod_Bairro")
                        .HasColumnType("int");

                    b.Property<int>("Cod_Cidade")
                        .HasColumnType("int");

                    b.Property<string>("Dcr_Complemento")
                        .HasColumnType("varchar(45)");

                    b.Property<string>("Dcr_Empreendimento")
                        .HasColumnType("varchar(45)");

                    b.Property<string>("Dcr_Endereco")
                        .HasColumnType("varchar(45)");

                    b.Property<string>("Dcr_Nome_Fantasia")
                        .HasColumnType("varchar(45)");

                    b.Property<byte[]>("Img_Empreendimento")
                        .HasColumnType("longblob");

                    b.Property<string>("Num_Cep")
                        .HasColumnType("varchar(45)");

                    b.HasKey("Cod_Empreedimento");

                    b.HasIndex("Bairro_Cod_Bairro");

                    b.HasIndex("Cod_Cidade");

                    b.ToTable("Empreendimento");
                });

            modelBuilder.Entity("IfoodSocial.Model.Produto", b =>
                {
                    b.Property<int>("CodProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CodProduto"));

                    b.Property<int>("Cod_Categoria")
                        .HasColumnType("int");

                    b.Property<int>("Cod_Empreedimento")
                        .HasColumnType("int");

                    b.Property<string>("Dcr_Produto")
                        .HasColumnType("varchar(45)");

                    b.Property<string>("Flag_Disponivel")
                        .HasColumnType("varchar(1)");

                    b.Property<byte[]>("Img_Produto")
                        .HasColumnType("longblob");

                    b.Property<decimal?>("Vlr_Produto")
                        .HasPrecision(9, 2)
                        .HasColumnType("decimal(9,2)");

                    b.HasKey("CodProduto");

                    b.HasIndex("Cod_Categoria");

                    b.HasIndex("Cod_Empreedimento");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("IfoodSocial.Model.Bairro", b =>
                {
                    b.HasOne("IfoodSocial.Model.Cidade", "Cidade")
                        .WithMany("Bairros")
                        .HasForeignKey("Cod_Cidade")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cidade");
                });

            modelBuilder.Entity("IfoodSocial.Model.Cliente", b =>
                {
                    b.HasOne("IfoodSocial.Model.Bairro", "Bairro")
                        .WithMany("Clientes")
                        .HasForeignKey("Cod_Bairro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IfoodSocial.Model.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("Cod_Cidade")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bairro");

                    b.Navigation("Cidade");
                });

            modelBuilder.Entity("IfoodSocial.Model.Empreedimento", b =>
                {
                    b.HasOne("IfoodSocial.Model.Bairro", "Bairro")
                        .WithMany()
                        .HasForeignKey("Bairro_Cod_Bairro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IfoodSocial.Model.Cidade", "Cidade")
                        .WithMany("Empreedimentos")
                        .HasForeignKey("Cod_Cidade")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bairro");

                    b.Navigation("Cidade");
                });

            modelBuilder.Entity("IfoodSocial.Model.Produto", b =>
                {
                    b.HasOne("IfoodSocial.Model.Categoria", "Categoria")
                        .WithMany("Produtos")
                        .HasForeignKey("Cod_Categoria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IfoodSocial.Model.Empreedimento", "Empreedimento")
                        .WithMany("Produtos")
                        .HasForeignKey("Cod_Empreedimento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Empreedimento");
                });

            modelBuilder.Entity("IfoodSocial.Model.Bairro", b =>
                {
                    b.Navigation("Clientes");
                });

            modelBuilder.Entity("IfoodSocial.Model.Categoria", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("IfoodSocial.Model.Cidade", b =>
                {
                    b.Navigation("Bairros");

                    b.Navigation("Empreedimentos");
                });

            modelBuilder.Entity("IfoodSocial.Model.Empreedimento", b =>
                {
                    b.Navigation("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
