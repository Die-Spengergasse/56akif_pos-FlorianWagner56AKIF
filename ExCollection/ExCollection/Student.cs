using Newtonsoft.Json;

namespace ExCollection.App
{
    public class Student
    {
        // TODO: Erstelle ein Property KlasseNavigation vom Typ Klasse, welches auf
        //       die Klasse des Schülers zeigt.
        // Füge dann über das Property die Zeile
        // [JsonIgnore]
        // ein, damit der JSON Serializer das Objekt ausgeben kann.
        [JsonIgnore]
        public SchoolClass KlasseNavigation { get; set; } = new();
        public int Id { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        /// <summary>
        /// Ändert die Klassenzugehörigkeit, indem der Schüler
        /// aus der alten Klasse, die in KlasseNavigation gespeichert ist, entfernt wird.
        /// Danach wird der Schüler in die neue Klasse mit der korrekten Navigation eingefügt.
        /// </summary>
        /// <param name="k"></param>
        public void ChangeKlasse(SchoolClass k)
        {
            // HIER DEN CODE EINFÜGEN


            if (k != null && KlasseNavigation.Schuelers.Contains(this))
            {
                KlasseNavigation.Schuelers.Remove(this);
                k.AddSchueler(this);
            }
        }

        public string FullName
        {
            get
            {
                return $"Full Name: {FirstName} {LastName}";
            }
        }
        public int MaximaleStudiendauer
        {
            get { return _maximaleStudiendauer; }
            set
            {
                if(value >= 1 && value <= 7)
                {
                    _maximaleStudiendauer = value;
                }
                else
                {
                    throw new ArgumentException("Studiendauer liegt nicht im gültigen Bereich!");
                }
            }
        }
        public int _maximaleStudiendauer;
    }
}
