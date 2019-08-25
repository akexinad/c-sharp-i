using System;

namespace Section3Association
{
    namespace Inheritance
        /*
         * 
         * INHERITANCE is a kind of relationship between two classes that allows one to inherit code from the other.
         * 
         * It is normally referred as an "is a" relationship, such as a car 'is a' vehicle.
         * 
         * 
         */
    {
        public class PresentationObject
        {
            public int Height { get; set; }
            public int Width { get; set; }

            public void Copy()
            {
                System.Console.WriteLine("Object copied to clipboard.");
            }

            public void Duplicate()
            {
                System.Console.WriteLine("Object was duplicated.");
            }
        }

        class Text : PresentationObject
        {
            public int FontSize { get; set; }
            public int FontName { get; set; }

            public void AddHyperlink(string url)
            {
                Console.WriteLine($"Add a link to { url }");
            }
        }
    }
}
