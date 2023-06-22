using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.AnlogBuilder
{
    public class Directory
    {
        private Home home;
        private BrickAndGlassHome home1;

        public Directory(Home home)
        {
            this.home = home;
        }

        public Directory(BrickAndGlassHome home)
        {
            home1 = home;
        }

        public void Construct(){
            home.BuildWindow();
            home.BuildDoor();
            home.BuildWall();
        }

        public void ConstructBrick(){
            home1.BuildWindow();
            home1.BuildDoor();
            home1.BuildWall();
            home1.BuildLake();
            home1.BuildGlassDoor();
            home1.BuildGlassWall();
            home1.BuildGlassWindow();
        }
    }
}