using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    public class ConcreteProductC3 : IAbstractProductC
    {
        public void Use()
        {
            Console.WriteLine("new Factory Product C3");
        }
    }
}