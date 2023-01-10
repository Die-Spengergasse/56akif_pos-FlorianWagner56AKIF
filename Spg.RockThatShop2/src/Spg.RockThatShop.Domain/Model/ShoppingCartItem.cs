using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.RockThatShop.Domain.Model
{
    public class ShoppingCartItem
    {
        public int Id { get; set; }
        //Navigations sind Foreignkeys
        public ShoppingCart ShoppingCartNavigation { get; set; } = default!;
        public int MusicInstrumentNavigationId { get; set; } //das ist nur zur Abwärtskompatibilität
        public MusicInstrument MusicInstrumentNavigation { get; set; } = default!;
        protected ShoppingCartItem()
        { }
    }
}
