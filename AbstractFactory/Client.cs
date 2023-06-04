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

        private IAbstractProductC productC;

        public Client(IAbstractFactory factory){
            productA = factory.CreateProductA();
            productB = factory.CreateProductB();
            productC = factory.CreateProductC();
        }

        public void UseProducts(){
            productA.Use();
            productB.Use();
            productC.Use();
        }
    }
}