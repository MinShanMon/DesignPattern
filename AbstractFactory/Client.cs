using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    public class Client
    {
        private IAbstractProductA productA;
        private IAbstractProductB productB;

        public Client(IAbstractFactory factory){
            productA = factory.CreateProductA();
            productB = factory.CreateProductB();
        }

        public void UseProducts(){
            productA.Use();
            productB.Use();
        }
    }
}