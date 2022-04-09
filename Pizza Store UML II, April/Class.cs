using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Store_UML_II__April
{
    public class store
    {
        static int MainMenuChoice(List<string> menuItems)
        {
            Console.Clear();
            Console.WriteLine("-------------------");
            Console.WriteLine("| Pizza store |");
            Console.WriteLine("-------------------");
            Console.WriteLine();
            Console.WriteLine("Options:");

            foreach (string choice in menuItems) { Console.WriteLine(choice); }

            Console.Write("Enter option#: "); string input = Console.ReadKey().KeyChar.ToString();
           

            try { int result = Int32.Parse(input);  return result; }

            catch (FormatException) { Console.WriteLine($"Unable to parse '{input}'"); }
            return -1;
        }

        public void start() { test(); }

        public void test()
        {
            bool proceed = true;
            List<string> mainMenulist = new List<string>()
            {
                "0. Quit",
                "1. Show Menu",
                "2. Create A Pizza In The System",
                "3. Delete A Pizza In The System",
                "4. Update A Pizza In The System"
            };
            while (proceed)
            {
                int MenuChoice = MainMenuChoice(mainMenulist);
                Console.WriteLine();

                switch (MenuChoice)
                {
                    case 0:
                        proceed = false;
                        Console.WriteLine();
                        break;

                    case 1:
                        menucatalog.PrintMenu();
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine("Write The Name Of The Pizza");       string name = Console.ReadLine();
                        Console.WriteLine("Write The Price Of The Pizza");      double price = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Write The Number Of The Pizza");     int number = 0;
                       
                        string input = Console.ReadLine();

                        try {number = int.Parse(input); }

                        catch (FormatException) { Console.WriteLine($" '{input}' It Was In The Wrong Format, Has To Be A Number"); }

                        if (menucatalog.Pizzas.ContainsKey(number) == false)
                        { Pizza newPizza = new Pizza(number, name, price); menucatalog.createpizza(newPizza);}
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("Write The Number Of The Pizza Which U Want To Be Deleted"); int num = 0;
                        try { num = Convert.ToInt32(Console.ReadLine()); }

                        catch (FormatException) {  Console.WriteLine($" '{num}' It Was In The Wrong Format, Has To Be A Number"); }

                        if (menucatalog.Pizzas.ContainsKey(num - 1)) { menucatalog.deletepizza(num); }
                        Console.ReadKey();
                        break;

                    case 4:

                        int index = 0;
                        Console.WriteLine("The New Number Of The Pizza"); index = Convert.ToInt32(Console.ReadLine());
                        Pizza pizza = new Pizza(); pizza.Number = index;

                        Console.WriteLine("The New Name Of The Pizza"); pizza.Name = Console.ReadLine(); 
                        
                        Console.WriteLine("New Price"); pizza.Price = Convert.ToInt32(Console.ReadLine());
                        menucatalog.updatepizza(index, pizza);
                        break;
                    default:
                        continue;
                }
            }
        }
    }
}
