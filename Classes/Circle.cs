using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1ObjectOriented.Classes
{
    public class Circle : Shape
    {
        public int radius;
        public override int GetArea()
        {
            return radius;
        }
    }

}
