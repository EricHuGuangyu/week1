using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1ObjectOriented.Interfaces;

namespace Week1ObjectOriented.Classes
{
    public class Circle : Shape,IShape
    {
        public int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }
        public override int GetArea()
        {
            return (int)Math.PI * radius * radius;
        }

        double IShape.GetArea()
        {
            return Math.PI * radius * radius;
        }
    }

}
