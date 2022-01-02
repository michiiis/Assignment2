using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory
{
    public static class Factory2
    {
        public static IFactory GetFactory(string factoryType)
        {
            if (factoryType == "Dog")
            {
                return new DogFactory();
            }
            else if (factoryType == "Cat")
            {
                return new CatFactory();
            }
            return null;
        }
    }
}