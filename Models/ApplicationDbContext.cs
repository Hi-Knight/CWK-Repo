using Microsoft.EntityFrameworkCore;
namespace PizzaDeliveryApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Pizza> Pizzas{get;set;}
        public DbSet<Category> Categories{get;set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(new Category{CategoryId=1,CategoryName="Cheese Pizza", Desc="A"});
            modelBuilder.Entity<Category>().HasData(new Category{CategoryId=2,CategoryName="Nuclear Pizza", Desc="B"});
            modelBuilder.Entity<Category>().HasData(new Category{CategoryId=3,CategoryName="Pepperoni Pizza", Desc="C"});

            modelBuilder.Entity<Pizza>().HasData(new Pizza
            {
                PizzaId=1,
                Name="Cheese Pizza",
                Price=8.95M,
                ShortDescription="Normal Cheese Pizza",
                LongDescription="A Long Description",
                CategoryId=1,
                ImageUrl="https://i.ibb.co/Y7qx1zzf/download.jpg",
                InStock=true,
                IsPizzaOfTheWeek=true
            });
            modelBuilder.Entity<Pizza>().HasData(new Pizza
            {
                PizzaId=2,
                Name="Nuclear Pizza",
                Price=12M,
                ShortDescription="Rip",
                LongDescription="Rest In Pizza",
                CategoryId=2,
                ImageUrl="https://i.ibb.co/LXWwpgtJ/Pizza-Nuke.png",
                InStock=true,
                IsPizzaOfTheWeek=true
            });
            modelBuilder.Entity<Pizza>().HasData(new Pizza
            {
                PizzaId=3,
                Name="Pepperoni Pizza",
                Price=10M,
                ShortDescription="Normal Pepperoni Pizza",
                LongDescription="A Longer Description",
                CategoryId=3,
                ImageUrl="https://i.ibb.co/4xmq9TD/Inverted-Pizza.png",
                InStock=true,
                IsPizzaOfTheWeek=true
            });
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("FileName=./pizzas.sqlite");
        }
    }
}