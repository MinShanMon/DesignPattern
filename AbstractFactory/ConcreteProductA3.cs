using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    public class ConcreteProductA3 : IAbstractProductA
    {
        public void Use()
        {
            Console.WriteLine("New Factory Product A3");
        }
    }
}