using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Lab1.Singleton
{
    public sealed class SingletonError
    {
        private static int counter = 0;
        private static SingletonError instance = null;
        public static SingletonError GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new SingletonError();
                return instance;
            }
        }
        private SingletonError()
        {
            counter++;
        }

        public void WrongInput()
        {
            Console.WriteLine("Wrong input, try again.");
        }
    }
}