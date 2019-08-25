using Section3Association.Inheritance;
using System;

namespace Section3Association
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            // Note that the methods that come for free when you create your classes and its derivations are the from the OBJECT CLASS.
            // All classes automatically inherit from the OBJECT class.

            text.Width = 100;
            text.Copy();
        }
    }    
}
