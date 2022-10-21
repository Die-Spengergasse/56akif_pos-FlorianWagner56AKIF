using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.RockThatShop.Domain.Model
{
    public class Brands
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public List<Brand> brands { get; set; } = default!;

    }
}
