using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Spg.RockThatShop.Domain.Model;
using Spg.RockThatShop2.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.RockThatShop2.Infrastructure
{
    // 1.: Diese Klasse muss von DbContext ableiten
    public class RockThatShopContext : DbContext
    {
        //2.: Die Tabellen der Datenbank als Properties auflisten / alles getter mit Lamba unten
        public DbSet<Customer> Customers  => Set<Customer>();
        public DbSet<MusicInstrument> MusicInstruments => Set<MusicInstrument>();
        public DbSet<ShoppingCart> ShoppingCarts => Set<ShoppingCart>();
        public DbSet<ShoppingCartItem> ShoppingCartItems => Set<ShoppingCartItem>();

        //3.: Konstruktoren (leer und einer, der Options entgegennimmt und der Basisklasse DbContext weitergibt)
        public RockThatShopContext()
        { }

        //Mit Options wird festgelegt, welche Datenbank es ist usw.
        public RockThatShopContext(DbContextOptions options)
            : base(options)
        { }

        //4.: OnConfiguring-Methode aus der Basisklasse --> Konfiguration vor DB-Erstellung
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //SqLite NugetPackage wurde installiert, deswegen wird es einem vorgeschlagen
            //wenn man eine oracle DB verwenden möchte, muss man ein dementsprechendes NugetPackage installieren
            //dann schlägt es einem useOracle vor!!

            //Die Methode use... verlangt den Connection-String der verwendeten Datenbank (in Sqlite ist der wie folgt)
            //if(!optionsBuilder.IsConfigured)
            //{
            //    //Connection String kommt in die 
            //    optionsBuilder.UseSqlite("Data Source = RockThatShop2.db");
            //}
        }
        
        //5.: OnModelCreating-Methode aus der Basisklasse --> Konfiguration während der DB-Erstellung
        //(zB.: Daten, Constraints, Relationen)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MusicInstrument>().Property(p => p.Name).IsRequired(); //OK

            //Gut aber unnötig, weil Convention over Config
            //modelBuilder.Entity<MusicInstrument>().HasMany(p => p.ShoppingCartItems); 

            //primary Keys definieren
            modelBuilder.Entity<Customer>().HasKey(c => c.Id);
            modelBuilder.Entity<MusicInstrument>().HasKey(p => p.Name);
            modelBuilder.Entity<MusicCategory>().HasKey(mc => mc.Id);
            modelBuilder.Entity<ShoppingCart>().HasKey(sh => sh.Id);

            //Value Object Address mit HasOne() definieren
            modelBuilder.Entity<Customer>().OwnsOne(c => c.Address);
        }
    }
}
