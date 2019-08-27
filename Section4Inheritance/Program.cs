using Section4Inheritance.AccessModifers;
using Section4Inheritance.Constructors;
using Section4Inheritance.UpCastingDownCasting;

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
            System.Console.WriteLine(text.Width);
        }
    }
}
