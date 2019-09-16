using System;

namespace MultipleInheritance
{
    // In C#, a class can inherit only from one base class, but can implement multiple interfaces
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
            Console.WriteLine("Recieved focus.");
        }

    }

    public class Size
    {
        public int Height { get; set; }
        public int Width { get; set; }
    }

    public class Position
    {
        public int Top { get; set; }
        public int Bottom { get; set; }
        public int Left { get; set; }
        public int Right { get; set; }
    }

    public interface IDraggable
    {
        void Drag();
    }

    public interface IDroppable
    {
        void Drop();
    }
}
