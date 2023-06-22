using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.AnlogBuilder
{
    public class Glass
    {
        public string GlassWindow { get; set; }
        public string GlassDoor { get; set; }
        public string GlassWall { get; set; }

        public void Display(){
            Console.WriteLine($"PartA: {GlassWindow}");
            Console.WriteLine($"PartB: {GlassDoor}");
            Console.WriteLine($"PartC: {GlassWall}");
        }
    }
}