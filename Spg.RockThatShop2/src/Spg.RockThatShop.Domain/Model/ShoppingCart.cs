using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.RockThatShop.Domain.Model
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public int ItemsCount { get; set; } = 0;
        public Customer CustomerNavigation { get; set; } = default!;
        public List<MusicInstrument> Instruments { get; set; } = default!;
        //public double getTotalPrice()
        //{
        //    return the total price of all Instruments that are currently placed in the ShoppingCart   
        //    return 0;
        //}
    }
}
