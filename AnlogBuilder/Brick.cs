using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.AnlogBuilder
{
    public class Brick
    {
        public string BrickWindow { get; set; }
        public string BrickDoor { get; set; }
        public string BrickWall { get; set; }
        public string BrickLake {get; set;}

        public void Display(){
            Console.WriteLine($"PartA: {BrickWindow}");
            Console.WriteLine($"PartB: {BrickDoor}");
            Console.WriteLine($"PartC: {BrickWall}");
            Console.WriteLine($"PartC: {BrickLake}");
        }
    }
}