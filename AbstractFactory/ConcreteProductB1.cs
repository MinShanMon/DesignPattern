using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    public class ConcreteProductB1 : IAbstractProductB
    {
        public void Use()
        {
            Console.WriteLine("Using ConcreteProductB1");
        }
    }
}