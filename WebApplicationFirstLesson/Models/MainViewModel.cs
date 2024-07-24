using System.Collections.Generic;
using WebApplicationFirstLesson.Entities;

namespace WebApplicationFirstLesson.Models
{
    public class MainViewModel
    {
        public List<Drinks> Drinkss { get; set; }
        public List<FastFoods> FastFoodss { get; set; }
        public List<HotMeals> HotMealss { get; set; }
    }
}
