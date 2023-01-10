using Spg.RockThatShop2.Domain.Model;
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
        //Globale ID soll die DB vergeben
        //ID ist am besten eine GUID auf www.guidgen.com erstellen lassen -- URLS sollten nie verhasht werden!!!!
        public int Id { get; private set; } //private set, weil nur OR Mapper setten darf
        public string CustomerNumber { get; } = string.Empty;
        public Genders Gender { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; } //= DateTime.MinValue; --> muss man nicht machen
        public Address? Address { get; set; } = default!;

        public string EMail { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public DateTime RegistrationDateTime { get; }

        private List<ShoppingCart> _shoppingCarts = new(); //Backing-Field
        public IReadOnlyList<ShoppingCart> ShoppingCarts => _shoppingCarts;

        //OR-Mapper benötigt den Leerkonstruktor! --> sonst sollte man eher keine Leerkonstruktoren erstellen
        //Protected --> bleibt in Vererbungshierarchie
        protected Customer()
        { }
        
        //Constructor --> da kommen nur die notwendigen Properties hinein, Dinge, die null sein können sollen hier nicht rein!
        public Customer(
            Genders gender, 
            string firstName, 
            string lastName, 
            DateTime birthDate,
            string eMail, 
            string password, 
            DateTime registrationDateTime)
        {
            Gender = gender;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            EMail = eMail;
            Password = password;
            RegistrationDateTime = registrationDateTime;
        }
    }
}
