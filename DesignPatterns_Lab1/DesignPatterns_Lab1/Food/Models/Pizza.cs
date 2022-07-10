using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns_Lab1.Food.Models.Interface;


namespace DesignPatterns_Lab1.Food.Models
{
    class Pizza : IFood
    {
        public string Topping { get; set; }

        public Pizza()
        {
            Topping = menu();
        }
        public string GetKindOfTopping()
        {
            return Topping;
        }

        public static string menu()
        {
            bool run = true;

            Console.WriteLine("Choose Toppings");
            Console.WriteLine("1. Cheese And Bacon");
            Console.WriteLine("2. Onions");
            Console.WriteLine("3. Mushrooms");
            try
            {
                while (run)
                {
                    string input = Console.ReadLine();

                  
                }
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }

        public int GetNumberOfToppings()
        {
            throw new NotImplementedException();
        }
    }
}