namespace Spg.RockThatShop.Domain.Model
{
    
    public class MusicCategory
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<MusicInstrument> MusicInstruments { get; set; } = default!;
    }
}