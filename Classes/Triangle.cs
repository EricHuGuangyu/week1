using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1ObjectOriented.Interfaces;

namespace Week1ObjectOriented.Classes
{
    public class Triangle : Shape, IFaces, IShape
    {
        public int width,height;
        public override int GetArea()
        {
            throw new NotImplementedException();
        }

        public int GetFaces()
        {
            throw new NotImplementedException();
        }

        double IShape.GetArea()
        {
            return width * height / 2;
        }
    }
}
