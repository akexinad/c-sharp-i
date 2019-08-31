using Section4Inheritance.AccessModifers;
using Section4Inheritance.Constructors;
using Section4Inheritance.UpCastingDownCasting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Section4Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var ferrari = new Car("aks-03t");


            // UPCASTING
            // =========

            var text = new Text();
            Shape shape = text;
            // We are going UP the inheritance chain and creating a shape object based off the derived text class.
            // Both shape and text are pointing to the same object in memory. When you UpCast and DownCast, it provides you
            //      with different views of that same object.

            text.Width = 200;
            shape.Width = 100;

            // Remember that text and shape are referencing a point in memory. So if you change the value in one or the other,
            //      it will change the value in memory.
            Console.WriteLine(text.Width);

            // Since StreamReader inherits from Stream. We can pass any class into this contstructor that derives from the stream class.
            // Memory stream will AUTOMATICALLY BE UPCASTED to stream.
            StreamReader reader = new StreamReader(new MemoryStream());

            ArrayList list = new ArrayList();
            // The list.Add method accepts anything that inherits from the object class.
            // This means that you can pass anything in here and it will IMPLICITLY CONVERTED TO THE OBJECT CLASS.
            list.Add(1);
            list.Add("hello");
            list.Add(new Text());

            var anotherList = new List<int>();



            // DOWNCASTING
            // ===========

            Shape shape2 = new Text();
            // The above approach of downcasting will only give us a limited view of the object because
            //      the object is downcasted at compile time not run time.

            // To cast it during compile time, we need to cast it.
            // Now we have access to the Text object properties.
            Text text2 = (Text)shape2;





            // EXERCISE ONE
            // ============

            var stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);


            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}
