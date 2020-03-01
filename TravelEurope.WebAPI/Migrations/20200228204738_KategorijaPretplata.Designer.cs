﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelEurope.WebAPI.Database;

namespace TravelEurope.WebAPI.Migrations
{
    [DbContext(typeof(TravelEurope_Context))]
    [Migration("20200228204738_KategorijaPretplata")]
    partial class KategorijaPretplata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TravelEurope.WebAPI.Database.Administrator", b =>
                {
                    b.Property<int>("AdministratorId");

                    b.Property<string>("IzjavaZastitaPodataka");

                    b.HasKey("AdministratorId");

                    b.ToTable("Administrator");
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.Drzava", b =>
                {
                    b.Property<int>("DrzavaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.HasKey("DrzavaId");

                    b.ToTable("Drzava");
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.Grad", b =>
                {
                    b.Property<int>("GradId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DrzavaId");

                    b.Property<string>("Naziv");

                    b.HasKey("GradId");

                    b.HasIndex("DrzavaId");

                    b.ToTable("Grad");
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.ItemKategorije", b =>
                {
                    b.Property<int>("ItemKategorijaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KategorijaId");

                    b.Property<int?>("TuristRutaId");

                    b.Property<int?>("VozacId");

                    b.Property<int?>("VoziloId");

                    b.HasKey("ItemKategorijaId");

                    b.HasIndex("KategorijaId");

                    b.HasIndex("TuristRutaId");

                    b.HasIndex("VozacId");

                    b.HasIndex("VoziloId");

                    b.ToTable("ItemKategorije");
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.Kategorije", b =>
                {
                    b.Property<int>("KategorijaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.HasKey("KategorijaId");

                    b.ToTable("Kategorije");
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.Klijent", b =>
                {
                    b.Property<int>("KlijentId");

                    b.Property<string>("BrVozackeDozvole");

                    b.Property<string>("BrojPasosa");

                    b.HasKey("KlijentId");

                    b.ToTable("Klijent");
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.Korisnici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa");

                    b.Property<DateTime>("DatumRodjenja")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<int>("GradId");

                    b.Property<string>("Ime");

                    b.Property<string>("Jmbg")
                        .HasColumnName("JMBG");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PasswordSalt");

                    b.Property<string>("Prezime");

                    b.Property<byte[]>("Slika");

                    b.Property<string>("Spol");

                    b.Property<string>("Telefon");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("GradId");

                    b.ToTable("Korisnici");
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.Lokacija", b =>
                {
                    b.Property<int>("LokacijaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DrzavaId");

                    b.Property<string>("Naziv");

                    b.HasKey("LokacijaId");

                    b.HasIndex("DrzavaId");

                    b.ToTable("Lokacija");
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.MarkaVozila", b =>
                {
                    b.Property<int>("MarkaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.HasKey("MarkaId");

                    b.ToTable("MarkaVozila");
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.NacinPlacanja", b =>
                {
                    b.Property<int>("NacinPlacanjaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.HasKey("NacinPlacanjaId");

                    b.ToTable("NacinPlacanja");
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.Pretplata", b =>
                {
                    b.Property<int>("PretplataId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KategorijaId");

                    b.Property<int>("KorisnikId");

                    b.HasKey("PretplataId");

                    b.HasIndex("KategorijaId");

                    b.HasIndex("KorisnikId");

                    b.ToTable("Pretplata");
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.Racun", b =>
                {
                    b.Property<int>("RacunId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CijenaUslugeSaPdvom")
                        .HasColumnName("CijenaUslugeSaPDVom");

                    b.Property<DateTime>("DatumIzdavanja");

                    b.Property<int>("NacinPlacanjaId");

                    b.Property<int>("RezervacijaId");

                    b.Property<int>("TrajanjeRentanjaDani");

                    b.HasKey("RacunId");

                    b.HasIndex("NacinPlacanjaId");

                    b.HasIndex("RezervacijaId");

                    b.ToTable("Racun");
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.Radnik", b =>
                {
                    b.Property<int>("RadnikId");

                    b.Property<int>("GodineStaza");

                    b.Property<string>("Pozicija");

                    b.HasKey("RadnikId");

                    b.ToTable("Radnik");
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.Rezervacija", b =>
                {
                    b.Property<int>("RezervacijaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("CijenaOsiguranja");

                    b.Property<double>("CijenaUslugePoDanu");

                    b.Property<DateTime>("DatumPreuzimanja");

                    b.Property<DateTime>("DatumVracanja");

                    b.Property<int>("KlijentId");

                    b.Property<int?>("RacunId");

                    b.Property<int>("RadnikId");

                    b.Property<int?>("TuristRutaId");

                    b.Property<int?>("VozacId");

                    b.Property<int?>("VoziloId");

                    b.HasKey("RezervacijaId");

                    b.HasIndex("KlijentId");

                    b.HasIndex("RacunId");

                    b.HasIndex("RadnikId");

                    b.HasIndex("TuristRutaId");

                    b.HasIndex("VozacId");

                    b.HasIndex("VoziloId");

                    b.ToTable("Rezervacija");
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.RuteSlike", b =>
                {
                    b.Property<int>("RuteSlikeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Opis");

                    b.Property<byte[]>("Slika");

                    b.Property<byte[]>("SlikaThumb");

                    b.Property<int>("TuristRutaId");

                    b.HasKey("RuteSlikeId");

                    b.HasIndex("TuristRutaId");

                    b.ToTable("RuteSlike");
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.StatusVozaca", b =>
                {
                    b.Property<int>("StatusVozacaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Dostupan");

                    b.HasKey("StatusVozacaId");

                    b.ToTable("StatusVozaca");
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.StatusVozila", b =>
                {
                    b.Property<int>("StatusVozilaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ispravnost");

                    b.Property<bool>("Rezervisano");

                    b.Property<string>("Status");

                    b.HasKey("StatusVozilaId");

                    b.ToTable("StatusVozila");
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.StraniJezik", b =>
                {
                    b.Property<int>("StraniJezikId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.HasKey("StraniJezikId");

                    b.ToTable("StraniJezik");
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.TipVozila", b =>
                {
                    b.Property<int>("TipId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.HasKey("TipId");

                    b.ToTable("TipVozila");
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.TuristickiVodic", b =>
                {
                    b.Property<int>("TuristickiVodicId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ime");

                    b.Property<string>("Prezime");

                    b.Property<int>("StraniJezikId");

                    b.HasKey("TuristickiVodicId");

                    b.HasIndex("StraniJezikId");

                    b.ToTable("TuristickiVodic");
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.TuristRuta", b =>
                {
                    b.Property<int>("TuristRutaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DrzavaId");

                    b.Property<string>("Naziv");

                    b.Property<string>("Opis");

                    b.Property<int>("TuristickiVodicId");

                    b.HasKey("TuristRutaId");

                    b.HasIndex("DrzavaId");

                    b.HasIndex("TuristickiVodicId");

                    b.ToTable("TuristRuta");
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.Vozac", b =>
                {
                    b.Property<int>("VozacId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrVozackeDozvole");

                    b.Property<string>("Ime");

                    b.Property<string>("Prezime");

                    b.Property<int>("StatusVozacaId");

                    b.HasKey("VozacId");

                    b.HasIndex("StatusVozacaId");

                    b.ToTable("Vozac");
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.Vozilo", b =>
                {
                    b.Property<int>("VoziloId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Boja");

                    b.Property<int>("BrojSjedista");

                    b.Property<int>("BrojVrata");

                    b.Property<int>("GodinaProizvodnje");

                    b.Property<int>("MarkaVozilaId");

                    b.Property<string>("Naziv");

                    b.Property<byte[]>("Slika");

                    b.Property<int>("StatusVozilaId");

                    b.Property<int>("TipVozilaId");

                    b.Property<int>("VrstaGorivaId");

                    b.HasKey("VoziloId");

                    b.HasIndex("MarkaVozilaId");

                    b.HasIndex("StatusVozilaId");

                    b.HasIndex("TipVozilaId");

                    b.HasIndex("VrstaGorivaId");

                    b.ToTable("Vozilo");
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.VrstaGoriva", b =>
                {
                    b.Property<int>("GorivoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.HasKey("GorivoId");

                    b.ToTable("VrstaGoriva");
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.Administrator", b =>
                {
                    b.HasOne("TravelEurope.WebAPI.Database.Korisnici", "AdministratorNavigation")
                        .WithOne("Administrator")
                        .HasForeignKey("TravelEurope.WebAPI.Database.Administrator", "AdministratorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.Grad", b =>
                {
                    b.HasOne("TravelEurope.WebAPI.Database.Drzava", "Drzava")
                        .WithMany("Grad")
                        .HasForeignKey("DrzavaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.ItemKategorije", b =>
                {
                    b.HasOne("TravelEurope.WebAPI.Database.Kategorije", "Kategorija")
                        .WithMany()
                        .HasForeignKey("KategorijaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TravelEurope.WebAPI.Database.TuristRuta", "TuristRuta")
                        .WithMany()
                        .HasForeignKey("TuristRutaId");

                    b.HasOne("TravelEurope.WebAPI.Database.Vozac", "Vozac")
                        .WithMany()
                        .HasForeignKey("VozacId");

                    b.HasOne("TravelEurope.WebAPI.Database.Vozilo", "Vozilo")
                        .WithMany()
                        .HasForeignKey("VoziloId");
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.Klijent", b =>
                {
                    b.HasOne("TravelEurope.WebAPI.Database.Korisnici", "KlijentNavigation")
                        .WithOne("Klijent")
                        .HasForeignKey("TravelEurope.WebAPI.Database.Klijent", "KlijentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.Korisnici", b =>
                {
                    b.HasOne("TravelEurope.WebAPI.Database.Grad", "Grad")
                        .WithMany("AspNetUsers")
                        .HasForeignKey("GradId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.Lokacija", b =>
                {
                    b.HasOne("TravelEurope.WebAPI.Database.Drzava", "Drzava")
                        .WithMany("Lokacija")
                        .HasForeignKey("DrzavaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.Pretplata", b =>
                {
                    b.HasOne("TravelEurope.WebAPI.Database.Kategorije", "Kategorija")
                        .WithMany()
                        .HasForeignKey("KategorijaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TravelEurope.WebAPI.Database.Korisnici", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.Racun", b =>
                {
                    b.HasOne("TravelEurope.WebAPI.Database.NacinPlacanja", "NacinPlacanja")
                        .WithMany("Racun")
                        .HasForeignKey("NacinPlacanjaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TravelEurope.WebAPI.Database.Rezervacija", "Rezervacija")
                        .WithMany("Racun")
                        .HasForeignKey("RezervacijaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.Radnik", b =>
                {
                    b.HasOne("TravelEurope.WebAPI.Database.Korisnici", "RadnikNavigation")
                        .WithOne("Radnik")
                        .HasForeignKey("TravelEurope.WebAPI.Database.Radnik", "RadnikId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.Rezervacija", b =>
                {
                    b.HasOne("TravelEurope.WebAPI.Database.Klijent", "Klijent")
                        .WithMany("Rezervacija")
                        .HasForeignKey("KlijentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TravelEurope.WebAPI.Database.Racun", "RacunNavigation")
                        .WithMany("RezervacijaNavigation")
                        .HasForeignKey("RacunId");

                    b.HasOne("TravelEurope.WebAPI.Database.Radnik", "Radnik")
                        .WithMany("Rezervacija")
                        .HasForeignKey("RadnikId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TravelEurope.WebAPI.Database.TuristRuta", "TuristRuta")
                        .WithMany("Rezervacija")
                        .HasForeignKey("TuristRutaId");

                    b.HasOne("TravelEurope.WebAPI.Database.Vozac", "Vozac")
                        .WithMany("Rezervacija")
                        .HasForeignKey("VozacId");

                    b.HasOne("TravelEurope.WebAPI.Database.Vozilo", "Vozilo")
                        .WithMany("Rezervacija")
                        .HasForeignKey("VoziloId");
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.RuteSlike", b =>
                {
                    b.HasOne("TravelEurope.WebAPI.Database.TuristRuta", "TuristRuta")
                        .WithMany()
                        .HasForeignKey("TuristRutaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.TuristickiVodic", b =>
                {
                    b.HasOne("TravelEurope.WebAPI.Database.StraniJezik", "StraniJezik")
                        .WithMany()
                        .HasForeignKey("StraniJezikId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.TuristRuta", b =>
                {
                    b.HasOne("TravelEurope.WebAPI.Database.Drzava", "Drzava")
                        .WithMany("TuristRuta")
                        .HasForeignKey("DrzavaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TravelEurope.WebAPI.Database.TuristickiVodic", "TuristickiVodic")
                        .WithMany()
                        .HasForeignKey("TuristickiVodicId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.Vozac", b =>
                {
                    b.HasOne("TravelEurope.WebAPI.Database.StatusVozaca", "StatusVozaca")
                        .WithMany("Vozac")
                        .HasForeignKey("StatusVozacaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.Vozilo", b =>
                {
                    b.HasOne("TravelEurope.WebAPI.Database.MarkaVozila", "MarkaVozila")
                        .WithMany("Vozilo")
                        .HasForeignKey("MarkaVozilaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TravelEurope.WebAPI.Database.StatusVozila", "StatusVozila")
                        .WithMany("Vozilo")
                        .HasForeignKey("StatusVozilaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TravelEurope.WebAPI.Database.TipVozila", "TipVozila")
                        .WithMany("Vozilo")
                        .HasForeignKey("TipVozilaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TravelEurope.WebAPI.Database.VrstaGoriva", "VrstaGoriva")
                        .WithMany("Vozilo")
                        .HasForeignKey("VrstaGorivaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
