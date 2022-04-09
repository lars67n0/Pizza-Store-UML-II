using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Store_UML_II__April
{
    public class menucatalog
    {
        public static Dictionary<int, Pizza> Pizzas { get { return pizzas; } }

        private static Dictionary<int, Pizza> pizzas = new Dictionary<int, Pizza>()
        {
            {1 , new Pizza(1, "CalaZonio", 85) },
            {2 , new Pizza(2, "Cool Beanio", 100) },
            {3 , new Pizza(3, "Mariata", 80)}
        };

        public static void createpizza(Pizza pizza) { pizzas.Add(pizza.Number, pizza); }

        public static void deletepizza(int num) { pizzas.Remove(num); }

        public static void updatepizza(int index, Pizza pizza)
        {
            pizzas[index] = pizza;
        }

        public static void ReadPizza()
        {
            Console.WriteLine("Choose A Pizza");
            Console.Write("Pizza Number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (pizzas.ContainsKey(number))
            {
                Console.WriteLine();
                Console.WriteLine($"Printing Pizza {number}");
                Console.WriteLine(pizzas[number]);
            }
            else
            { Console.WriteLine($"Pizza Number {number}"); Console.WriteLine("Pizza Not Listed In Menu"); }
        }

        public static void PrintMenu() { foreach (var pizza in pizzas) { Console.WriteLine(pizza); } }
    }
}
