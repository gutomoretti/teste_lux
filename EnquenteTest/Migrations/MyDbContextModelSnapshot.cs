﻿// <auto-generated />
using System;
using EnquenteTest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EnquenteTest.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EnquenteTest.Models.Enquente_Pergunta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EnqueteId");

                    b.Property<string>("Option_Description");

                    b.HasKey("Id");

                    b.HasIndex("EnqueteId");

                    b.ToTable("Enquente_Pergunta");
                });

            modelBuilder.Entity("EnquenteTest.Models.Enquete", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Poll_Description");

                    b.HasKey("Id");

                    b.ToTable("Enquete");
                });

            modelBuilder.Entity("EnquenteTest.Models.Enquete_Alternativa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EnquentePerguntaId");

                    b.Property<int?>("Enquente_PerguntaId");

                    b.Property<string>("Option_Description");

                    b.HasKey("Id");

                    b.HasIndex("Enquente_PerguntaId");

                    b.ToTable("Enquete_Alternativa");
                });

            modelBuilder.Entity("EnquenteTest.Models.Enquete_Resposta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Enquente_PerguntaId");

                    b.Property<int>("Enquete_AlternativaId");

                    b.HasKey("Id");

                    b.HasIndex("Enquente_PerguntaId");

                    b.HasIndex("Enquete_AlternativaId");

                    b.ToTable("Enquete_Resposta");
                });

            modelBuilder.Entity("EnquenteTest.Models.Enquente_Pergunta", b =>
                {
                    b.HasOne("EnquenteTest.Models.Enquete", "Enquete")
                        .WithMany("Perguntas")
                        .HasForeignKey("EnqueteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EnquenteTest.Models.Enquete_Alternativa", b =>
                {
                    b.HasOne("EnquenteTest.Models.Enquente_Pergunta", "Enquente_Pergunta")
                        .WithMany()
                        .HasForeignKey("Enquente_PerguntaId");
                });

            modelBuilder.Entity("EnquenteTest.Models.Enquete_Resposta", b =>
                {
                    b.HasOne("EnquenteTest.Models.Enquente_Pergunta")
                        .WithMany("Respostas")
                        .HasForeignKey("Enquente_PerguntaId");

                    b.HasOne("EnquenteTest.Models.Enquete_Alternativa", "Enquete_Alternativa")
                        .WithMany()
                        .HasForeignKey("Enquete_AlternativaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
