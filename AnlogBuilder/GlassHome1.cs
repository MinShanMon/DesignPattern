using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.AnlogBuilder
{
    public class GlassHome1 : Home
    {
        private Glass product1;
        public GlassHome1(){
            product1 = new Glass();
        }
        public void BuildWindow()
        {
            product1.GlassWindow = "3 windows";
        }

        public void BuildDoor()
        {
            product1.GlassDoor = "2 doors";
        }

        public void BuildWall()
        {
            product1.GlassWall = "4 walls";
        }

        public Glass GetProduct1()
        {
            return product1;
        }
    }
}