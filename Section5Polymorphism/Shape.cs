using System;
using System.Collections.Generic;

namespace Section5Polymorphism
{
    namespace MethodOverriding
    {
        public class Shape
        {
            public int Width { get; set; }
            public int Height { get; set; }
            

            public virtual void Draw()
            {

            }

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


        public class Canvas
        {
            public void DrawShapes(List<Shape> shapes)
            {
                foreach (var shape in shapes)
                {
                    // by using the override modifier on the Draw method, when we a iterate through a list of shapes that are of type shape,
                    //      you are able to invoke the logic of the draw method that is related to the derived shape being iterated.

                    // THIS IS AN EXAMPLE OF POLYMORPHISM
                    shape.Draw();
                }
            }
        }
    }
}
