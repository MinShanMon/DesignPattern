using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.AnlogBuilder
{
    public class BrickAndGlassHome : Home2
    {
        private Glass glass;
        private Brick brick;
        public BrickAndGlassHome()
        {
            glass = new Glass();
            brick = new Brick();
        }
        public void BuildDoor()
        {
            brick.BrickDoor="3 door";
        }

        public void BuildGlassDoor()
        {
            glass.GlassDoor = "2 door";
        }

        public void BuildGlassWall()
        {
            glass.GlassWall = " 6 walls";
        }

        public void BuildGlassWindow()
        {
            glass.GlassWindow = " 5 windows";
        }

        public void BuildLake()
        {
            brick.BrickLake = " 1 Lake";
        }

        public void BuildWall()
        {
            brick.BrickWall = "5 walls";
        }

        public void BuildWindow()
        {
            brick.BrickWindow = " 3 windows";
        }

        public Glass GetProduct1()
        {
            return glass;
        }

        public Brick product()
        {
            return brick;
        }
    }
}