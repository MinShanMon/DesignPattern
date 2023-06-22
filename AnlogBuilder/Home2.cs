using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.AnlogBuilder
{
    public interface Home2
    {
        void BuildWindow();
        void BuildDoor();
        void BuildWall();

        void BuildLake();
        Brick product();

        void BuildGlassWindow();
        void BuildGlassDoor();
        void BuildGlassWall();
        Glass GetProduct1();
    }
}