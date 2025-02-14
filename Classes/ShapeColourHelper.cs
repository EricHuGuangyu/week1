
using System;
using Week1ObjectOriented.Interfaces;

namespace Week1ObjectOriented.Classes
{
    public static class ShapeColourHelper
    {
        public static string[] colours = { "Yellow", "Red", "Blue", "Green", "Orange" };
        public static Shape AddColour(Shape s)
        {
            s.Colour = getNewColour();
            return s;
        }

        public static Shape ChangeColour(Shape s)
        {

            s.Colour = getNewColour();
            return s;
        }

        public static string getNewColour()
        {
            Random random = new Random();
            return colours[random.Next(colours.Length)];
        }

    }
}
