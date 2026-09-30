using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PizzaDeliveryApp.Models;
using PizzaDeliveryApp.ViewModels;
using System.Collections.Generic;
using System;

namespace PizzaDeliveryApp.Controllers;

public class HomeController : Controller
{
    private readonly IPizzaRepository _pizzaRepository;
    public HomeController(IPizzaRepository pizzaRepository)
    {
        _pizzaRepository=pizzaRepository;
    }
    public IActionResult Index()
    {
        var homeViewModel=new HomeViewModel
        {
            PizzasOfTheWeek=_pizzaRepository.PizzasOfTheWeek
        };
        return View(homeViewModel);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Menu()
    {
        return View();
    }
    public IActionResult Create()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
