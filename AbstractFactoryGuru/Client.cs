using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern.AbstractFactory;

namespace DesignPattern.AbstractFactoryGuru
{
    public class Client
    {
        public void ClientMethod(IAbstractFactory factory){
            IAbstractProductA productA = factory.CreateProductA();
            IAbstractProductB productB = factory.CreateProductB();

            System.Console.WriteLine(productB.UsefulFunctionB());
            System.Console.WriteLine(productB.AnotherUserfulFunctionB(productA));
        }
        public void Main(){
            System.Console.WriteLine("Client: Testing client code with the first factory type....");
            ClientMethod(new ConcreteFactory1());
            System.Console.WriteLine();

            System.Console.WriteLine("Client: Testing the same client code with the second factory type....");
            ClientMethod(new ConcreteFactory2());
        }
    }
}