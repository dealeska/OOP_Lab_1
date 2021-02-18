using System;
using System.Collections.Generic;
using Lab_1.Menu;


namespace Lab_1
{
    class Program
    {       
        static void Main(string[] args)
        {            
            List<MenuItem> meals = new List<MenuItem>();
            meals.Add(new Drink("Rich"));
            meals.Add(new HotDrink("Latte"));
            meals.Add(new ColdDrink("Fanta"));
            meals.Add(new Dessert("Tiramissu"));
            meals.Add(new Cake("Terminator"));
            meals.Add(new IceCream("Chokolate treat"));
            meals.Add(new FastFood("Spicy chicken"));

            foreach (MenuItem meal in meals)
            {
                meal.GetHieratchy();
                Console.WriteLine("\n");
                meal.AskClient();
                meal.WriteDescription();                                
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
