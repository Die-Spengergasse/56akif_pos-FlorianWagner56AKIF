using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ExCollection.App
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, SchoolClass> klassen = new Dictionary<string, SchoolClass>();
            klassen.Add("3AHIF", new SchoolClass() { Name = "3AHIF", KV = "KV1" });
            klassen.Add("3BHIF", new SchoolClass() { Name = "3BHIF", KV = "KV2" });
            klassen.Add("3CHIF", new SchoolClass() { Name = "3CHIF", KV = "KV3" });
            klassen["3AHIF"].AddSchueler(new Student() { Id = 1001, FirstName = "VN1", LastName = "ZN1", MaximaleStudiendauer = 5 });
            klassen["3AHIF"].AddSchueler(new Student() { Id = 1002, FirstName = "VN2", LastName = "ZN2", MaximaleStudiendauer = 2 });
            klassen["3AHIF"].AddSchueler(new Student() { Id = 1003, FirstName = "VN3", LastName = "ZN3", MaximaleStudiendauer = 3 });
            klassen["3BHIF"].AddSchueler(new Student() { Id = 1011, FirstName = "VN4", LastName = "ZN4", MaximaleStudiendauer = 1 });
            klassen["3BHIF"].AddSchueler(new Student() { Id = 1012, FirstName = "VN5", LastName = "ZN5", MaximaleStudiendauer = 7 });
            klassen["3BHIF"].AddSchueler(new Student() { Id = 1013, FirstName = "VN6", LastName = "ZN6", MaximaleStudiendauer = 2 });

            Student s = klassen["3AHIF"].Schuelers[0];
            Console.WriteLine($"s sitzt in der Klasse {s.KlasseNavigation.Name} mit dem KV {s.KlasseNavigation.KV}.");
            Console.WriteLine("3AHIF vor ChangeKlasse:");
            Console.WriteLine(JsonConvert.SerializeObject(klassen["3AHIF"].Schuelers));
            s.ChangeKlasse(klassen["3BHIF"]);
            Console.WriteLine("3AHIF nach ChangeKlasse:");
            Console.WriteLine(JsonConvert.SerializeObject(klassen["3AHIF"].Schuelers));
            Console.WriteLine("3BHIF nach ChangeKlasse:");
            Console.WriteLine(JsonConvert.SerializeObject(klassen["3BHIF"].Schuelers));
            Console.WriteLine($"s sitzt in der Klasse {s.KlasseNavigation.Name} mit dem KV {s.KlasseNavigation.KV}.");

            KuerzesteStudiendauer(klassen["3AHIF"]);
            KuerzesteStudiendauer(klassen["3BHIF"]);
        }

        private static void KuerzesteStudiendauer(SchoolClass k)
        {
            //1.  Initialisierung mit Maximalwert
            //2.  Prüfung, ob die nächste Dauer kleiner oder größer ist.
            //2.1 Wenn größer: nichts zu tun; zum nächsten Schüler gehen
            //2.2 Wenn kleiner: überschreiben wir den ersten Werten mit dem neuen Minimum

            int minWert = 7;
            foreach (Student item in k.Schuelers)
            {
                if (item.MaximaleStudiendauer < minWert)
                {
                    minWert = item.MaximaleStudiendauer;
                }
            }
            Console.WriteLine($"Minimale Studiendauer in dieser {k?.Name ?? "unbekannt"} ist: {minWert}");
        }
    }
}
