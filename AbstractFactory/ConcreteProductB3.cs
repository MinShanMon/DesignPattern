using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    public class ConcreteProductB3 : IAbstractProductB
    {
        public void Use()
        {
            Console.WriteLine("new Factory Product B3");
        }
    }
}