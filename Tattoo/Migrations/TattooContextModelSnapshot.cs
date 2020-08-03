﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tattoo.Models;

namespace Tattoo.Migrations
{
    [DbContext(typeof(TattooContext))]
    partial class TattooContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Tattoo.Models.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("About");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Specialty");

                    b.HasKey("ArtistId");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("Tattoo.Models.ArtistClient", b =>
                {
                    b.Property<int>("ArtistClientId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ArtistId");

                    b.Property<int>("ClientId");

                    b.HasKey("ArtistClientId");

                    b.HasIndex("ArtistId");

                    b.HasIndex("ClientId");

                    b.ToTable("ArtistClient");
                });

            modelBuilder.Entity("Tattoo.Models.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApptDate");

                    b.Property<int>("ArtistId");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Services");

                    b.HasKey("ClientId");

                    b.HasIndex("ArtistId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Tattoo.Models.ArtistClient", b =>
                {
                    b.HasOne("Tattoo.Models.Artist", "Artist")
                        .WithMany("Clients")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Tattoo.Models.Client", "Client")
                        .WithMany("Artists")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Tattoo.Models.Client", b =>
                {
                    b.HasOne("Tattoo.Models.Artist", "Artist")
                        .WithMany()
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
