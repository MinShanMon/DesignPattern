using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
    public class ConcreteCreatorC : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProductC();
        }
    }
}