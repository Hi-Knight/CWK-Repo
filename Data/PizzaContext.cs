using Microsoft.EntityFrameworkCore;
using PizzaDeliveryApp.Models;

namespace PizzaDeliveryApp.Data
{
    public class PizzaContext : DbContext
    {
        public PizzaContext(DbContextOptions<PizzaContext> options) : base(options)
        {
        
        }
        public DbSet<Pizza> Pizzas => Set<Pizza>();
    }
}