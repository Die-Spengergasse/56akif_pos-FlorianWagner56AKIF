using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Parsable.Demo
{
    public class Person : IParsable<Person>
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }

        //protected, damit ein OR-Mapper später nicht ein leeres Objekt in die Datenbank schreiben kann
        protected Person()
        { }

        public Person(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        // Methode von IParsable
        public static Person Parse(string s, IFormatProvider? provider)
        {
            if (s is null)
            {
                throw new ArgumentNullException("Input war NULL!");
            }

            string[] result = s.Split(new char[] { ',', ';', '\t' });

            if(result.Length != 3)
            {
                throw new ArgumentException("Input muss bestehen aus: Firstname,LastName,BirthDate");
            }
            DateTime birthDate;
            if (!DateTime.TryParse(result[2], out birthDate))
            {
                throw new FormatException("Geburtsdatum hat falsches Format!");
            }
            return new Person(result[0].Trim(), result[1].Trim(), birthDate);
        }

        // Methode von IParsable

        public static bool TryParse([NotNullWhen(true)] string? s, 
            IFormatProvider? provider, 
            [MaybeNullWhen(false)] out Person result)
        {
            result = null;
            if(s is null)
            {
                return false;
            }
            try
            {
                result = Parse(s, provider);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"{FirstName}, {LastName}, {BirthDate}";
        }
    }
}
