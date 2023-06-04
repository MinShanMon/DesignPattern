using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    public class ConcreteProductB2 : IAbstractProductB
    {
        public void Use()
        {
            Console.WriteLine("Using ConcreteProductB2");
        }
    }
}