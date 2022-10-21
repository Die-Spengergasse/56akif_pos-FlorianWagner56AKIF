using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.RockThatShop.Domain.Model
{
    public class Brand
    {
        public int Id { get; set; } //should have a global counter!!!

        public string Name
        { 
            get
            {
                return _name;
            }
            set
            {
                if (value.Length >= 3 && value != null)
                {
                    _name = value;
                    Abbreviation = value[..3].ToUpper();                 //range Parameter
                    //this.Abbreviation = value.Substring(0, 3).ToUpper();    //alternative Way with String.Substring() Method
                }
                else
                {
                    _name = "Unknown";
                    _abbreviation = "UNK";
                }
            }
        }
        private string _name = string.Empty;        

        public string Abbreviation
        {   get 
            {
                return this._abbreviation != null ? this._abbreviation : "UNK";
            }
            set
            {
                _abbreviation = this.Name.Substring(0, 3).ToUpper();
            }
        }
        private string _abbreviation = string.Empty;
        public List<MusicInstrument> MusicInstruments { get; set; } = default!;
    }
}
