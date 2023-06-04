using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
    public class ConcreteProductC : IProduct
    {
        public void Use()
        {
            Console.WriteLine("create Product C");
        }
    }
}