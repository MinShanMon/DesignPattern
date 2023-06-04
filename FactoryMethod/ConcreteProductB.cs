using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
    public class ConcreteProductB : IProduct
    {
        public void use()
        {
            Console.WriteLine("Using ConcreteProductB");
        }
    }
}