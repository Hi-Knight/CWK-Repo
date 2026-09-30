using System.Collections.Generic;

namespace PizzaDeliveryApp.Models
{
    public interface IPizzaRepository
    {
        IEnumerable<Pizza> AllPizzas{get;}
        IEnumerable<Pizza> PizzasOfTheWeek{get;}
        Pizza GetPizzaById(int PizzaId);
    }
}