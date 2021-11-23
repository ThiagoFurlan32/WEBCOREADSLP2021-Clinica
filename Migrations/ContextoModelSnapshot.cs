﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WEBCORELP2021.Models;

namespace WEBCORELP2021.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WEBCORELP2021.Models.Dominio.Consulta", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descricao")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<int>("medicoID")
                        .HasColumnType("int");

                    b.Property<int>("pacienteID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("medicoID");

                    b.HasIndex("pacienteID");

                    b.ToTable("Consulta");
                });

            modelBuilder.Entity("WEBCORELP2021.Models.Dominio.Medico", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cidade")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("cpf")
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<string>("email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idade")
                        .HasColumnType("int");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("numero")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("id");

                    b.ToTable("Medico");
                });

            modelBuilder.Entity("WEBCORELP2021.Models.Dominio.Paciente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cidade")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("cpf")
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<string>("email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("endereco")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("idade")
                        .HasColumnType("int");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("numero")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("id");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("WEBCORELP2021.Models.Dominio.PlanoDeSaude", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descricao")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("pacienteID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("pacienteID");

                    b.ToTable("PlanoDeSaude");
                });

            modelBuilder.Entity("WEBCORELP2021.Models.Dominio.Consulta", b =>
                {
                    b.HasOne("WEBCORELP2021.Models.Dominio.Medico", "medico")
                        .WithMany("consultas")
                        .HasForeignKey("medicoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WEBCORELP2021.Models.Dominio.Paciente", "paciente")
                        .WithMany("consultas")
                        .HasForeignKey("pacienteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("medico");

                    b.Navigation("paciente");
                });

            modelBuilder.Entity("WEBCORELP2021.Models.Dominio.PlanoDeSaude", b =>
                {
                    b.HasOne("WEBCORELP2021.Models.Dominio.Paciente", "paciente")
                        .WithMany("planoDeSaude")
                        .HasForeignKey("pacienteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("paciente");
                });

            modelBuilder.Entity("WEBCORELP2021.Models.Dominio.Medico", b =>
                {
                    b.Navigation("consultas");
                });

            modelBuilder.Entity("WEBCORELP2021.Models.Dominio.Paciente", b =>
                {
                    b.Navigation("consultas");

                    b.Navigation("planoDeSaude");
                });
#pragma warning restore 612, 618
        }
    }
}
