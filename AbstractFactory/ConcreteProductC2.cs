using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    public class ConcreteProductC2 : IAbstractProductC
    {
        public void Use()
        {
            Console.WriteLine("New Product C2");
        }
    }
}