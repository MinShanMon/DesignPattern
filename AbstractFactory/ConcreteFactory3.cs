using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    public class ConcreteFactory3 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA3();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB3();
        }

        public IAbstractProductC CreateProductC()
        {
            return new ConcreteProductC3();
        }
        
    }
}