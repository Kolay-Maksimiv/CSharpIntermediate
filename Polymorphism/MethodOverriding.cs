
namespace Polymorphism
{
    public static class MethodOverriding
    {
        public class Shape
        {
            public int Width { get; set; }
            public int Height { get; set; }
            public Position Position { get; set; }
            //public ShapeType Type { get; set; }

            public virtual void Draw()
            {
            }
        }

        public class Position
        {
        }

        public class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Draw a circle");
            }
        }

        public class Rectangle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Draw a rectangle");
            }
        }

        public class Triangle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Draw a triangle");
            }
        }

        //public enum ShapeType
        //{
        //    Circle,
        //    Rectangle,
        //    Triangle
        //}

        public class Canvas
        {
            public void DrawShapes(List<Shape> shapes)
            {
                foreach (var shape in shapes)
                {
                    //switch (shape.Type)
                    //{
                    //    case ShapeType.Circle:
                    //        Console.WriteLine("Draw a circle");
                    //        break;

                    //    case ShapeType.Rectangle:
                    //        Console.WriteLine("Draw a rectangle");
                    //        break;
                    //    case ShapeType.Triangle:
                    //        Console.WriteLine("Draw a triangle");
                    //        break;
                    //}

                    shape.Draw();
                }
            }
        }

        public static void MethodOverridingProgram()
        {
            var shapes = new List<Shape>();

            //shapes.Add(new Shape { Width = 100, Height = 100, Type = ShapeType.Circle });
            //shapes.Add(new Shape { Width = 100, Height = 30, Type = ShapeType.Rectangle });
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());
            shapes.Add(new Triangle());

            var convas = new Canvas();
            convas.DrawShapes(shapes);

            Console.WriteLine("-----------------------------------------------------------------------");
        }
    }
}