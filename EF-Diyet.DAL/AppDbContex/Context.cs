using EF_Diyet_UI.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EF_Diyet_UI.AppDbContex
{
    public class Context:DbContext
    {
       
        public DbSet<BesinBilgileri> BesinBilgi { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<KullaniciHedefBilgileri> KullaniciHedef { get; set; }
        public DbSet<Makaleler> Makale { get; set; }
        public DbSet<Tarifler> Tarif { get; set; }
        public DbSet<TuketilenBesin> TuketilenBesinler { get; set; }
        public DbSet<VucutAnalizi> VucutAnalizleri { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-8L0ANR7N\\SQLKODLAB;Database=HS12-EF-DiyetUygulama ;Trusted_Connection=True;");
     
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<KullaniciHedefBilgileri>().HasOne(k => k.kullanici).WithOne(kh => kh.KullaniciHedefBilgileri)
            .HasForeignKey<KullaniciHedefBilgileri>(kh => kh.KullaniciId);
            modelBuilder.Entity<VucutAnalizi>().HasOne(k => k.kullanici).WithOne(kh => kh.VucutAnalizi).HasForeignKey<VucutAnalizi>(f => f.KullaniciId);
            modelBuilder.Entity<Kullanici>().HasMany(k => k.TuketilenBesinler).WithOne(kh => kh.Kullanici).HasForeignKey(f => f.KullaniciID);

            modelBuilder.Entity<BesinBilgileri>().HasMany(b=>b.TuketilenBesinler).WithOne(t=>t.BesinBilgileri).HasForeignKey(f => f.BesinBilgileriID);
            modelBuilder.Entity<Kullanici>().Property(k => k.KullaniciAdi).HasColumnType("nvarchar(50)");
            modelBuilder.Entity<Kullanici>().Property(k => k.KullaniciSoyadi).HasColumnType("nvarchar(50)");
            base.OnModelCreating(modelBuilder);
        }
    }
}
