using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns_Lab1.Food.Models.Interface;

namespace DesignPatterns_Lab1.Food.Factory.Interface
{
    public abstract class FoodFactory
    {
        protected abstract IFood MakeFood();
        public IFood CreateFood()
        {
            return MakeFood();
        }
    }
}
