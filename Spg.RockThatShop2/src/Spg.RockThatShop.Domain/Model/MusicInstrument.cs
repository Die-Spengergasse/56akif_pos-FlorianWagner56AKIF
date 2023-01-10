namespace Spg.RockThatShop.Domain.Model
{
    public class MusicInstrument
    {
        public string Name { get; private set; } = string.Empty; //Name ist hier der Primarykey --> in URL gut spengershop.at/MusicIntstruments/Duesenberg59        public string Description { get; set; } = string.Empty;
        public double Price { get; set; } = 0;
        public double WeightInKg { get; set; } = 0;
        public int NumberStrings { get; set; } = 0;
        public int NumberKeys { get; set; } = 0;

        public MusicCategory MusicCategory { get; set; } = default!;
        public InstrumentType InstrumentType { get; set; } = default!;
        public Brand Brand { get; set; } = default!;

        private List<ShoppingCartItem> _shoppingCartItems = new(); //Backing-Field
        public IReadOnlyList<ShoppingCartItem> ShoppingCartItems => _shoppingCartItems; //Man erlaubt mit IReadOnly nur lesenden Zugriff!

        protected MusicInstrument()
        { }
        public MusicInstrument(string name, double price, double weightInKg, int numberStrings, int numberKeys, MusicCategory musicCategory, InstrumentType instrumentType, Brand brand, List<ShoppingCartItem> shoppingCartItems)
        {
            Name = name;
            Price = price;
            WeightInKg = weightInKg;
            NumberStrings = numberStrings;
            NumberKeys = numberKeys;
            MusicCategory = musicCategory;
            InstrumentType = instrumentType;
            Brand = brand;
            _shoppingCartItems = shoppingCartItems;
        }   
    }
}