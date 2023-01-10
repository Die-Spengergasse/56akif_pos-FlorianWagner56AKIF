namespace ExCollection.App
{
    public class SchoolClass
    {
        // TODO: Erstelle ein Property Schuelers, welches alle Schüler der Klasse in einer
        //       Liste speichert.
        public List<Student> Schuelers { get; set; } = new();
        public string Name { get; set; } = string.Empty;
        public string KV { get; set; } = string.Empty;
        /// <summary>
        /// Fügt den Schüler zur Liste hinzu und setzt das Property KlasseNavigation
        /// des Schülers korrekt auf die aktuelle Instanz.
        /// </summary>
        /// <param name="s"></param>
        public void AddSchueler(Student s)
        {
            // HIER DEN CODE EINFÜGEN

            // nachfolgend ist die Methode ein bissl anders implementiert aber auch richtig implementiert --> Lösung von Schrutek

            //if(s is null)
            //{
            //    throw new ArgumentNullException("Schüler war NULL!");
            //}
            //if(Schuelers.Contains(s))
            //{
            //    throw new ArgumentException("Schüler ist bereits in der Klasse!");
            //}
            //s.KlasseNavigation = this;
            //Schuelers.Add(s);

            if (s != null && s.LastName.Trim().Length >= 2 && s.FirstName.Trim().Length >= 2 && !Schuelers.Contains(s)) //schnelle Parameterprüfung der Schueler
            {
                s.KlasseNavigation = this;
                Schuelers.Add(s);
            }
        }
    }
}
