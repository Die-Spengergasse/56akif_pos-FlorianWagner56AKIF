using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.RockThatShop.Domain.Model
{
    public class InstrumentType
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public MusicCategory Category { get; set; } = default!;
        public List<MusicInstrument> MusicInstruments { get; set; } = new();
    }
}
