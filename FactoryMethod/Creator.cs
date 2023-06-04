using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        public void Operation(){
            IProduct product = FactoryMethod();
            product.use();
        }   
    }
}