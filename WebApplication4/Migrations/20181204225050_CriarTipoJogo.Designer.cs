﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication4.Models;

namespace WebApplication4.Migrations
{
    [DbContext(typeof(WebApplication4Context))]
    [Migration("20181204225050_CriarTipoJogo")]
    partial class CriarTipoJogo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication4.Data.Mesa", b =>
                {
                    b.Property<int>("MesaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Configuracao");

                    b.Property<string>("Estado");

                    b.Property<string>("Historico");

                    b.Property<DateTime>("Inicio");

                    b.Property<string>("Nome");

                    b.Property<int?>("TipoJogoId");

                    b.Property<DateTime>("UltimoLance");

                    b.HasKey("MesaId");

                    b.HasIndex("TipoJogoId");

                    b.ToTable("Mesas");
                });

            modelBuilder.Entity("WebApplication4.Data.MesaUsuario", b =>
                {
                    b.Property<int>("MesaId");

                    b.Property<int>("UsuarioId");

                    b.HasKey("MesaId", "UsuarioId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("MesasUsuarios");
                });

            modelBuilder.Entity("WebApplication4.Data.TipoJogo", b =>
                {
                    b.Property<int>("TipoJogoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MaxJogadores");

                    b.Property<int>("MinJogadores");

                    b.Property<string>("Nome");

                    b.Property<string>("Url");

                    b.HasKey("TipoJogoId");

                    b.ToTable("TipoJogo");
                });

            modelBuilder.Entity("WebApplication4.Data.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro");

                    b.Property<string>("Cep");

                    b.Property<string>("Cidade");

                    b.Property<string>("Complemento");

                    b.Property<string>("Cpf");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<int>("Derrotas")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<string>("Email");

                    b.Property<string>("Logradouro");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Numero");

                    b.Property<string>("Senha");

                    b.Property<int>("Tipo");

                    b.Property<string>("Uf");

                    b.Property<int>("Vitorias")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("WebApplication4.Data.Mesa", b =>
                {
                    b.HasOne("WebApplication4.Data.TipoJogo")
                        .WithMany("Mesas")
                        .HasForeignKey("TipoJogoId");
                });

            modelBuilder.Entity("WebApplication4.Data.MesaUsuario", b =>
                {
                    b.HasOne("WebApplication4.Data.Mesa", "Mesa")
                        .WithMany("MesasUsuarios")
                        .HasForeignKey("MesaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplication4.Data.Usuario", "Usuario")
                        .WithMany("MesasUsuarios")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
