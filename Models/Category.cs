using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaDeliveryApp.Models
{
    public class Category
    {
        public int CategoryId{get;set;}
        public string CategoryName{get;set;}
        public string Desc{get;set;}
        public List<Pizza> Pizzas{get;set;}
    }
}