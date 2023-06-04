using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    public class ConcreteProductA2 : IAbstractProductA
    {
        public void Use()
        {
            Console.WriteLine("Using ConcreteProductA2");
        }
    }
}