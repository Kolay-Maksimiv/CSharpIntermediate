
namespace Polymorphism
{
    public static class MethodOverriding
    {
        public class Shape
        {
            public int Width { get; set; }
            public int Height { get; set; }
            public Position Position { get; set; }
            public ShapeType Type { get; set; }
        }

        public class Position
        {
        }

        public enum ShapeType
        {
            Circle,
            Rectangle,
            Triangle
        }

        public class Canvas
        {
            public void DrawShapes(List<Shape> shapes)
            {
                foreach (var shape in shapes)
                {
                    switch (shape.Type)
                    {
                        case ShapeType.Circle:
                            Console.WriteLine("Draw a circle");
                            break;

                        case ShapeType.Rectangle:
                            Console.WriteLine("Draw a rectangle");
                            break;
                        case ShapeType.Triangle:
                            Console.WriteLine("Draw a triangle");
                            break;
                    }
                }
            }
        }

        public static void MethodOverridingProgram()
        {

            Console.WriteLine("-----------------------------------------------------------------------");
        }
    }
}