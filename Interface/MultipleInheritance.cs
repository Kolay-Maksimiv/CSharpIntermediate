
namespace Interface
{
    public static class MultipleInheritance
    {
        public class UiControl
        {
            public string Id { get; set; }
            public Size Size { get; set; }
            public Position TopLeft { get; set; }
        
            public virtual void Draw()
            {
            }

            public void Focus()
            {
                Console.WriteLine("Received focus.");
            }
        }

        public class Size
        {
        }

        public class Position
        {
        }

        public interface IDroppable
        {
            void Drop();
        }

        public interface IDraggable
        {
            void Drag();
        }

        public class TextBox : UiControl, IDraggable, IDroppable
        {
            public void Drag()
            {
                throw new NotImplementedException();
            }

            public void Drop()
            {
                throw new NotImplementedException();
            }
        }

        public static void MultipleInheritanceProgram()
        {
            Console.WriteLine("-----------------------------------------------------------------------");
        }
    }
}