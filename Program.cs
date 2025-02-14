// See https://aka.ms/new-console-template for more information
using Week1ObjectOriented.Classes;

var square = new Square(10);
var circle = new Circle(10);

try
{
    square.SetArea(2);
    Console.WriteLine("The area is " + square.GetArea());
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

//var circle = new Circle();

ShapeColourHelper.AddColour(circle);

ShapeColourHelper.AddColour(square);

Console.WriteLine(square.Colour);

ShapeColourHelper.ChangeColour(square);

Console.WriteLine(square.Colour);

List<Shape> shapes = new List<Shape>();
int radius = 10;

foreach (var colour in ShapeColourHelper.colours)
{
    var circleItem = new Circle(radius);
    circleItem.Colour = colour;
    circleItem.Name = "Circle";
    circleItem.radius = radius;
    radius++;
    shapes.Add(circleItem);
}

foreach (var shape in shapes) {  Console.WriteLine(shape.Name+ ":" + shape.Colour + ":"+ shape.GetArea()); }


Console.ReadLine();




