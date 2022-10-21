using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.RockThatShop.Domain.Model
{
    public enum Genders { Male, Female, Other }

    /* //andere Variante der enum:
     public enum Genders
    {
        Male = 0,
        Female = 1,
        Other = 2
    }
     */
    public class Customer
    {
        public int Id { get; set; }
        public Genders Gender { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; } //= DateTime.MinValue;     //muss man nicht machen
        public string Address { get; set; } = string.Empty;

        public string EMail { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        
        public DateTime RegistrationDateTime { get; set; }
    }
}
