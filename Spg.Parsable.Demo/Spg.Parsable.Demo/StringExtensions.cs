using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Parsable.Demo
{
    //ExtensionMethods sind immer statisch!!!!!!
    public static class StringExtensions
    {
        public static int CountWords(this string s) //Mit this wird definiert, welcher Datentyp erweitert wird.
        {
            return s.Split(" ").Length;
        }

        public static T Parse<T>(this string s)
            where T : IParsable<T> //checke, ob T das IParsable Interface implementiert hat
        {
            return T.Parse(s, null);
        }
    }
}
