using System;
using System.Collections.Generic;

namespace HungryNinja.Model
{
    public class Ninja
    {
        private int CalorieIntake;
        public List<Food> FoodHistory;

        public bool Full;

        public bool IsFull
        {
            get
            {
                if (CalorieIntake > 1200)
                {
                    return true;
                }
                else { return false; }
            }
        }

        public Ninja(int CalorieIntake = 0)
        {
            FoodHistory = new List<Food>();
            this.CalorieIntake = CalorieIntake;
            Full = false;
        }

        public void Eat(Food item)
        {
            if (IsFull == false)
            {
                CalorieIntake += item.Calories;
                FoodHistory.Add(item);
                Console.WriteLine($"Ninja ate {item.Name}");
                if (item.IsSpicy && item.IsSweet)
                {
                    Console.WriteLine("It was sweet and spicy.");
                }
                else if (item.IsSpicy && !item.IsSweet)
                {
                    Console.WriteLine("It was spicy.");
                }
                else if (!item.IsSpicy && item.IsSweet)
                {
                    Console.WriteLine("It was sweet.");
                }
                else
                {
                    Console.WriteLine("It wasn't sweet or spicy.");
                }
            }
            else
            {
                Full = true;
                Console.WriteLine("Ninja is full. He couldn't take another bite!");
            }
        }
    }
}