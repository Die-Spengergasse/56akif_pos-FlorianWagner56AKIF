namespace Spg.RockThatShop.Domain.Model
{
    
    public class MusicCategory
    {
        public int Id { get; private set; }
        public string Name { get; set; } = string.Empty;
        public List<InstrumentType> InstrumentTypes { get; set; } = new();
        public List<MusicInstrument> MusicInstruments { get; set; } = new();

        public MusicCategory()
        { }

        public MusicCategory(string name)
        {
            Name = name;
        }
    }
}