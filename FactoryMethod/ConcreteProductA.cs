using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
    public class ConcreteProductA : IProduct
    {
        public void Use()
        {
            Console.WriteLine("Using ConcreteProductA");
        }
    }
}