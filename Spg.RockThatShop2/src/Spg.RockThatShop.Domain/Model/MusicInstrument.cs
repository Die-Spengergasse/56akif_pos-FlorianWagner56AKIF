namespace Spg.RockThatShop.Domain.Model
{
    public class MusicInstrument
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Price { get; set; } = 0;
        public double WeightInKg { get; set; } = 0;
        public int NumberStrings { get; set; } = 0;
        public int NumberKeys { get; set; } = 0;

        public List<MusicCategory> MusicCategories { get; set; } = default!;
        public Brand Brand { get; set; } = default!;
    }
}