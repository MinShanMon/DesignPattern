using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryGuru
{
    public class ConcreteProductB1 : IAbstractProductB
    {
        public string AnotherUserfulFunctionB(IAbstractProductA collaborator)
        {
            String result = collaborator.UsefulFunctionA();

            return $"The result of the B1 collaborating with the ({result})";
        }

        public string UsefulFunctionB()
        {
            return "The result of the product B1.";
        }
    }
}