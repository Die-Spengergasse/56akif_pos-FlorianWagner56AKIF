using Microsoft.EntityFrameworkCore;
using Spg.RockThatShop.Domain.Model;
using Spg.RockThatShop2.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.RockThatShop2.Domain.Test
{
    public class ProductTest
    {

        private RockThatShopContext GenerateDb()
        {
            DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseSqlite("Data Source=RockThatShop_Test.db");

            RockThatShopContext db = new RockThatShopContext(optionsBuilder.Options);
            db.Database.EnsureDeleted(); //schmeiß alles weg, was da ist
            db.Database.EnsureCreated(); //erstell eine neue db
            return db;
        }

        //Annotation
        //[Fact], damit Der UNIT-Test erkannt wird!
        [Fact]
        public void MusicInstrument_Add_OneEntity_SuccessTest()
        {
            // AAA Pattern bei Unit-Tests! --> das ist immer gleich!
            //1. Arrange
            RockThatShopContext db = GenerateDb(); //Db wird erstellt
            MusicInstrument newMusicInstrument = new MusicInstrument("Testprodukt", 12.50, 3.0, 6, 0, new MusicCategory(), new InstrumentType(), new Brand(), new List<ShoppingCartItem>());
            //2. Act
            db.MusicInstruments.Add(newMusicInstrument);
            db.SaveChanges(); //Speichern der DB
            //3. Assert
            Assert.Equal(1, db.MusicInstruments.Count());
        }
    }
}
