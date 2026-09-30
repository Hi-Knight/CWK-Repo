using Microsoft.AspNetCore.Mvc;
using PizzaDeliveryApp.Models;
using PizzaDeliveryApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaDeliveryApp.Controllers
{
    public class PizzaController : Controller
    {
        private readonly IPizzaRepository _pizzaRepository;
        private readonly ICategoryRepository _categoryRepository;
        public PizzaController(IPizzaRepository pizzaRepository, ICategoryRepository categoryReposiotory)
        {
            _pizzaRepository=pizzaRepository;
            _categoryRepository=categoryReposiotory;
        }

        public IActionResult List()
        {
            PizzaListViewModel pizzaListViewModel=new PizzaListViewModel();
            pizzaListViewModel.Pizzas=_pizzaRepository.AllPizzas;
            pizzaListViewModel.CurrentCategory="Meat Pizza";

            return View(pizzaListViewModel);
        }

        public IActionResult Details(int id)
        {
            var pizza=_pizzaRepository.GetPizzaById(id);
            if (pizza == null)
            {
                return NotFound();
            }
            return View(pizza);
        }
    }
}