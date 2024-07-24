using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplicationFirstLesson.Entities;
using WebApplicationFirstLesson.Models;

namespace WebApplicationFirstLesson.Controllers
{
    public class HomeController : Controller
    {
        private List<Drinks> GetDrinks()
        {
            return new List<Drinks>()
            {
                new Drinks { Id = 1, Name = "Coca-Cola", Description = "Refreshing soda", Price = 2.50m },
                new Drinks { Id = 2, Name = "Pepsi", Description = "Popular cola drink", Price = 2.40m },
                new Drinks { Id = 3, Name = "Sprite", Description = "Lemon-lime soda", Price = 2.50m },
                new Drinks { Id = 4, Name = "Fanta", Description = "Orange flavored soda", Price = 2.50m },
                new Drinks { Id = 5, Name = "Mountain Dew", Description = "Citrus flavored soda", Price = 2.60m },
                new Drinks { Id = 5, Name = "Mochito", Description = "Citrus soda", Price = 8.50m },
            };
        }

        private List<FastFoods> GetFastFoods()
        {
            return new List<FastFoods>()
            {
                new FastFoods { Id = 1, Name = "Burger", Description = "Beef burger with cheese", Price = 5.70m },
                new FastFoods { Id = 2, Name = "Pizza", Description = "Pizza with cheese", Price = 8.60m },
                new FastFoods { Id = 3, Name = "Hot Dog", Description = "Hot dog with mustard", Price = 3.50m },
                new FastFoods { Id = 4, Name = "Fries", Description = "Crispy French fries", Price = 2.30m },
                new FastFoods { Id = 5, Name = "Chicken Nuggets", Description = "Chicken nuggets with sauce", Price = 4.50m },
                new FastFoods { Id = 5, Name = "Sezar", Description = "Chicken with sauce", Price = 17.50m },
            };
        }

        private List<HotMeals> GetHotMeals()
        {
            return new List<HotMeals>()
            {
                new HotMeals { Id = 1, Name = "Lasagna", Description = "Baked lasagna with meat and cheese", Price = 9.50m },
                new HotMeals { Id = 2, Name = "Spaghetti Bolognese", Description = "Spaghetti with a rich meat sauce", Price = 8.60m },
                new HotMeals { Id = 3, Name = "Grilled Chicken", Description = "Grilled chicken breast with herbs", Price = 11.50m },
                new HotMeals { Id = 4, Name = "Beef Stroganoff", Description = "Beef in creamy mushroom sauce", Price = 12.30m },
                new HotMeals { Id = 5, Name = "Chicken Alfredo", Description = "Pasta with creamy Alfredo sauce", Price = 10.50m },
                new HotMeals { Id = 5, Name = "Faxitos ", Description = "Chicken", Price = 20.50m },
            };
        }

        public IActionResult Index()
        {
            var viewModel = new MainViewModel
            {
                Drinkss = GetDrinks(),
                FastFoodss = GetFastFoods(),
                HotMealss = GetHotMeals()
            };

            return View(viewModel);
        }

        public IActionResult Drinks()
        {
            var drinks = GetDrinks();
            return View(drinks);
        }

        public IActionResult FastFoods()
        {
            var fastFoods = GetFastFoods();
            return View(fastFoods);
        }

        public IActionResult HotMeals()
        {
            var hotMeals = GetHotMeals();
            return View(hotMeals);
        }
    }
}
