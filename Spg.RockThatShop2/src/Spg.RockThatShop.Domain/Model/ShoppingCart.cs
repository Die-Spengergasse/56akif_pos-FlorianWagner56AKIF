using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.RockThatShop.Domain.Model
{

    public enum ShoppingCartStates { Active = 0, Sent = 1, Unknown = 99 }
    public class ShoppingCart
    {
        public int Id { get; private set; }
        public string Name { get; set; } = string.Empty;
        public int ItemsCount { get; }
        public int CustomerNavigationId { get; set; } //Abwärtskompatibilität
        public Customer CustomerNavigation { get; set; } = default!; //default! ist dasselbe wie null! --> nicht mit new() instanzieren, nur Listen mit new() instanzieren
        public decimal Summary { get; }
        public ShoppingCartStates ShoppingCartState { get; set; }

        private List<ShoppingCartItem> _shoppingCartItems = new();
        public IReadOnlyList<ShoppingCartItem> ShoppingCartItems => _shoppingCartItems; //Man erlaubt mit IReadOnly nur lesenden Zugriff!

        //public double getTotalPrice()
        //{
        //    return the total price of all Instruments that are currently placed in the ShoppingCart   
        //    return 0;
        //}

        protected ShoppingCart()
        { }

        public ShoppingCart(Customer customerNavigation, decimal sum, ShoppingCartStates shoppingCartState, List<ShoppingCartItem> shoppingCartItems)
        {
            CustomerNavigation = customerNavigation;
            Summary = sum;
            ShoppingCartState = shoppingCartState;
            _shoppingCartItems = shoppingCartItems;
        }
    }
}