using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung2_Properties
{
    internal class Lehrer
    {
        private decimal? _bruttogehalt = null;
        public string? Zuname { get; set; }
        public string Vorname { get; set; } = "";
        public decimal? Bruttogehalt
        {
            get { return _bruttogehalt; } // ich hätte besser gefunden: get { return _bruttogehalt ?? 0; } ,da hier gleich eine 
                                          // Prüfung stattfindet für evtl. nachfolgende Methoden
            set { 
                if (_bruttogehalt == null) { 
                    _bruttogehalt = value;
                }
            }
        }
        public string Kuerzel { 
            get { return Zuname?.Substring(0, 3).ToUpper() ?? ""; } 
        }

        public decimal? Nettogehalt { 
            get {
                return Bruttogehalt*0.8M ?? 0;
            }
        }
    }
}
