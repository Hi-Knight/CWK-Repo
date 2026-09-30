using PizzaDeliveryApp.Models;
using System.Collections.Generic;

namespace PizzaDeliveryApp.ViewModels
{
    public class PizzaListViewModel
    {
        public IEnumerable<Pizza> Pizzas {get;set;}
        public string CurrentCategory{get; set;}
    }
}