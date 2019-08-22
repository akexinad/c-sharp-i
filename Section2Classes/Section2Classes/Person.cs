using System;

namespace Section2Classes
{

    public class Person
    {
        /*
         * 
        * THE BASICS OF A CLASS
        * =====================
        * 
        * - A class is simply a building block of a software application.
        * 
        * - Think of a blog. There are 3 layers:
        *      - Presentation            = The PostView Class
        *      - Business Logic/Domain   = Post Class
        *      - Data Access/Persistence = PostRepository Class
        *      
        * 
        * CLASS ANATOMY
        * 
        * - Data (represented by fields/attributes)
        * - Behaviour (repredented by methods/functions)
        * 
        * 
        * - NB: An OBJECT is in essence an instance of a class in memory.
        * 
        * 
        * CLASS MEMBERS
        * 
        * - Instance: accessible from an object.
        * - Static: Accessible from the class.
        * 
        * - Static methods are helpful so we do not have to instantiate a class multiple times and have it hogging memory
        * 
        */

        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();

            person.Name = str;

            return person;
        }
    }
}
