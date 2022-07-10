using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns_Lab1.Food.Models;
using DesignPatterns_Lab1.Food.Models.Interface;
using DesignPatterns_Lab1.Food.Factory.Interface;

namespace DesignPatterns_Lab1.Food.Factory
{
    class PastaFactory : FoodFactory
    {
        protected override IFood MakeFood()
        {
            IFood food = new Pasta();
            return food;
        }
    }
}
