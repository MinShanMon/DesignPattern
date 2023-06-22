using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.AnlogBuilder
{
    public interface Home
    {
        void BuildWindow();
        void BuildDoor();
        void BuildWall();
        Glass GetProduct1();
    }
}