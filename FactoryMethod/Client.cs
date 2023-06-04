using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
    public class Client
    {
        public void apply(){
            Creator creatorA = new ConcreteCreatorA();
            creatorA.Operation();

            Creator creatorB = new ConcreteCreatorB();
            creatorB.Operation();
        }
    }
}