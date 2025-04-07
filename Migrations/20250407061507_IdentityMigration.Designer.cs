﻿// <auto-generated />
using System;
using GRINPLAS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GRINPLAS.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250407061507_IdentityMigration")]
    partial class IdentityMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GRINPLAS.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<long>("ClienteId_Cliente")
                        .HasColumnType("bigint");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId_Cliente");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("GRINPLAS.Models.Carrito", b =>
                {
                    b.Property<long>("CarritoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("CarritoId"));

                    b.Property<DateTime>("Fec_cre")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("Id_Cliente")
                        .HasColumnType("bigint");

                    b.HasKey("CarritoId");

                    b.HasIndex("Id_Cliente");

                    b.ToTable("tb_Carrito");
                });

            modelBuilder.Entity("GRINPLAS.Models.CarritoDetalle", b =>
                {
                    b.Property<long>("DetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("DetalleId"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("integer");

                    b.Property<long>("CarritoId")
                        .HasColumnType("bigint");

                    b.Property<decimal>("Precio_Uni")
                        .HasColumnType("numeric");

                    b.Property<long>("ProductoId")
                        .HasColumnType("bigint");

                    b.HasKey("DetalleId");

                    b.HasIndex("CarritoId");

                    b.HasIndex("ProductoId");

                    b.ToTable("tb_CarritoDetalle");
                });

            modelBuilder.Entity("GRINPLAS.Models.Categoria", b =>
                {
                    b.Property<long>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("CategoriaId"));

                    b.Property<string>("Nombre")
                        .HasColumnType("text");

                    b.HasKey("CategoriaId");

                    b.ToTable("tb_Categoria");
                });

            modelBuilder.Entity("GRINPLAS.Models.Cliente", b =>
                {
                    b.Property<long>("Id_Cliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id_Cliente"));

                    b.Property<string>("Imagen")
                        .HasColumnType("text");

                    b.Property<string>("Nombre")
                        .HasColumnType("text");

                    b.Property<string>("NumDoc")
                        .HasColumnType("text");

                    b.Property<int>("Telefono")
                        .HasColumnType("integer");

                    b.Property<string>("Tipodoc")
                        .HasColumnType("text");

                    b.Property<string>("User_Id")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id_Cliente");

                    b.ToTable("tb_Cliente");
                });

            modelBuilder.Entity("GRINPLAS.Models.DetallePedido", b =>
                {
                    b.Property<long>("DetalleIdpe")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("DetalleIdpe"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("integer");

                    b.Property<long>("PedidoId")
                        .HasColumnType("bigint");

                    b.Property<decimal>("Precio_Uni")
                        .HasColumnType("numeric");

                    b.Property<long>("ProductoId")
                        .HasColumnType("bigint");

                    b.HasKey("DetalleIdpe");

                    b.HasIndex("PedidoId");

                    b.HasIndex("ProductoId");

                    b.ToTable("tb_DetallePedido");
                });

            modelBuilder.Entity("GRINPLAS.Models.Pedido", b =>
                {
                    b.Property<long>("PedidoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("PedidoId"));

                    b.Property<string>("Direccion")
                        .HasColumnType("text");

                    b.Property<string>("Estado")
                        .HasColumnType("text");

                    b.Property<DateTime>("Fec_emi")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("Fec_entre")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("Id_Cliente")
                        .HasColumnType("bigint");

                    b.Property<string>("Img_Boleta")
                        .HasColumnType("text");

                    b.Property<string>("Rut_Pdf")
                        .HasColumnType("text");

                    b.Property<decimal>("Total")
                        .HasColumnType("numeric");

                    b.HasKey("PedidoId");

                    b.HasIndex("Id_Cliente");

                    b.ToTable("tb_Pedido");
                });

            modelBuilder.Entity("GRINPLAS.Models.Producto", b =>
                {
                    b.Property<long>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ProductoId"));

                    b.Property<long>("CategoriaId")
                        .HasColumnType("bigint");

                    b.Property<string>("Descripcion")
                        .HasColumnType("text");

                    b.Property<string>("Imagen")
                        .HasColumnType("text");

                    b.Property<string>("Nombre")
                        .HasColumnType("text");

                    b.Property<decimal>("Precio_Uni")
                        .HasColumnType("numeric");

                    b.Property<int>("Stock")
                        .HasColumnType("integer");

                    b.HasKey("ProductoId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("tb_Producto");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("GRINPLAS.Models.ApplicationUser", b =>
                {
                    b.HasOne("GRINPLAS.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId_Cliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("GRINPLAS.Models.Carrito", b =>
                {
                    b.HasOne("GRINPLAS.Models.Cliente", "Cliente")
                        .WithMany("Carritos")
                        .HasForeignKey("Id_Cliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("GRINPLAS.Models.CarritoDetalle", b =>
                {
                    b.HasOne("GRINPLAS.Models.Carrito", "Carrito")
                        .WithMany("CarritoDetalles")
                        .HasForeignKey("CarritoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GRINPLAS.Models.Producto", "Producto")
                        .WithMany("CarritoDetalles")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carrito");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("GRINPLAS.Models.DetallePedido", b =>
                {
                    b.HasOne("GRINPLAS.Models.Pedido", "Pedido")
                        .WithMany("DetallesPedido")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GRINPLAS.Models.Producto", "Producto")
                        .WithMany("DetallesPedido")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("GRINPLAS.Models.Pedido", b =>
                {
                    b.HasOne("GRINPLAS.Models.Cliente", "Cliente")
                        .WithMany("Pedidos")
                        .HasForeignKey("Id_Cliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("GRINPLAS.Models.Producto", b =>
                {
                    b.HasOne("GRINPLAS.Models.Categoria", "Categoria")
                        .WithMany("Productos")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("GRINPLAS.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("GRINPLAS.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GRINPLAS.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("GRINPLAS.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GRINPLAS.Models.Carrito", b =>
                {
                    b.Navigation("CarritoDetalles");
                });

            modelBuilder.Entity("GRINPLAS.Models.Categoria", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("GRINPLAS.Models.Cliente", b =>
                {
                    b.Navigation("Carritos");

                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("GRINPLAS.Models.Pedido", b =>
                {
                    b.Navigation("DetallesPedido");
                });

            modelBuilder.Entity("GRINPLAS.Models.Producto", b =>
                {
                    b.Navigation("CarritoDetalles");

                    b.Navigation("DetallesPedido");
                });
#pragma warning restore 612, 618
        }
    }
}
