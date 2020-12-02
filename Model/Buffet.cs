using System;
using System.Collections.Generic;

namespace HungryNinja.Model
{
    public class Buffet
    {
        public List<Food> Menu;
        public Buffet()
        {
            Menu = new List<Food>()
        {
            new Food("Coffee",  300, false, false),
            new Food("Pizza",   600, true,  false),
            new Food("Wings",   500, true,  false),
            new Food("Cake",    600, false, true),
            new Food("Apple",   200, false, true),
            new Food("Pasta",   400, false, false),
            new Food("Burger",  400, false, false)
        };
        }

        public Food Serve()
        {
            Random rand = new Random();

            Food use = Menu[rand.Next(0, Menu.Count)];

            return use;
        }
    }
}