using PizzaDeliveryApp.Models;
using System.Collections.Generic;

namespace PizzaDeliveryApp.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pizza> PizzasOfTheWeek {get;set;}
    }
}