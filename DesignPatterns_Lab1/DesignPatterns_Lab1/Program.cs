using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns_Lab1.Food.Models.Interface;
using DesignPatterns_Lab1.Food.Factory;
using DesignPatterns_Lab1.Singleton;


namespace DesignPatterns_Lab1
{
    class Program
    {
        public static List<IFood> foodList = new List<IFood>();
        static void Main(string[] args)
        {

            bool work = true;
            Console.WriteLine(" Select what food you want to order ");
            while (work)
            {
                Console.WriteLine("1 Make Pizza");
                Console.WriteLine("2 Make Hamburger");
                Console.WriteLine("3 Make Pasta");
                Console.WriteLine("4 See your order");
                Console.WriteLine("q Quit");
                string input = Console.ReadLine();


                // Factory Design Pattern
                if (input == "1")
                {
                    IFood food = new PizzaFactory().CreateFood();
                    foodList.Add(food);
                    Console.WriteLine("Pizza Baked");
                }
                else if (input == "2")
                {
                    IFood food = new BurgerFactory().CreateFood();
                    foodList.Add(food);
                    Console.WriteLine("Burger Made");
                }
                else if (input == "3")
                {
                    IFood food = new PastaFactory().CreateFood();
                    foodList.Add(food);
                    Console.WriteLine("Pasta Made");
                }

                else if (input == "4")
                {

                    if (foodList != null)
                    {
                        foreach (var food in foodList)
                        {
                            var objName = food.GetType();
                            Console.WriteLine("Type: " + objName.Name + ", Topping: " + food.GetKindOfTopping().ToString());
                        }
                    }
                }
                else if (input == "q")
                {
                    Environment.Exit(1);
                }
                else
                {

                    SingletonError errorMessage = SingletonError.GetInstance;
                    errorMessage.WrongInput();
                }

            }

        }
    }
}