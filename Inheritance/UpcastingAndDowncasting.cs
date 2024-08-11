namespace Inheritance
{
    public static class UpcastingAndDowncasting
    {
        public class Shape
        {
            public int Width { get; set; }
            public int Height { get; set; }

            public int X { get; set; }
            public int Y { get; set; }

            public void Draw()
            {

            }
        }

        public class Text : Shape
        {
            public int FontSize { get; set; }
            public string FontName { get; set; }
        }

        public static void UpcastingAndDowncastingProgram()
        {
            //Upcasting
            Text text = new Text();
            Shape shape = text;

            text.Width = 200;
            shape.Width = 100;

            Console.WriteLine(text.Width);

            //Downcasting
            Shape shape1 = new Text();
            Text text1 = (Text)shape1;


            Console.WriteLine("-----------------------------------------------------------------------");
        }
    }
}
