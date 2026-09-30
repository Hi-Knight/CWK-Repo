using System.Collections.Generic;

namespace PizzaDeliveryApp.Models
{
    public class ICategoryRepository
    {
        IEnumerable<Category> AllCategories{get;}
    }
}