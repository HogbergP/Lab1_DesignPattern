using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Lab1.Food.Models.Interface
{
    public interface IFood
    {
        int GetNumberOfToppings();
        string GetKindOfTopping();
    }
}
