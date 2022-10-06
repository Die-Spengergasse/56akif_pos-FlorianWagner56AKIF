using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung2_Properties
{
    internal class Rechteck
    {
        //Attribute werden in C# mit Kleinbuchstaben geschrieben --> Properties mit Großbuchstaben
        private int _laenge = 0;
        private int _breite = 0;

        public int Laenge {
            get { return _laenge; }
            set { _laenge = (value >= 0) ? value : throw new ArgumentException("Ungültige Länge!"); }
        }
        public int Breite {
            get { return _breite; }
            set { _breite = (value >= 0) ? value : throw new ArgumentException("Ungültige Breite!"); } 
        }

        //Readonly, da kein setter definiert wurde.
        public int Flaeche { 
            get { return _laenge * _breite; }
        }
    }
}
