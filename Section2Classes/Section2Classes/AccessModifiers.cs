using System;

namespace Section2Classes
{
    namespace AccessModifiers
    {
        /*
         * - An access modifier is a way to control access to a class and/or its members.
         * - It creates safety in our applications.
         * 
         * - The purpose of managing access is fundamental to OOP. Which is built upon 3 main pillars.
         *      - 1. ENCAPSULATION/INFORMATION HIDING
         *      - 2. INHERITANCE
         *      - 3. POLYMORPHISM
         * 
         * 
         * ENCASPULATION
         * 
         * - In practice, this is done by defining your fields as private,
         * - and providing your getter and setter fields as public.
         * 
         * - When declaring fields, the convention is to declare them in camelCase, prefixed with an underscore.
         * 
         * 
         * IMPORTANT NOTE ON OBJECTS AND OOP
         * 
         * - Remember that objects are about behaviour.
         * - An object's fields are its internals, it's implementation details, which should be hidden away from the outside world.
         * - In essence, OBJECTS SHOULD HIDE THEIR IMPLEMENTATION DETAIL AND ONLY REVEAL THEIR BEHAVIOUR.
         * - YOUR CLASSES SHOULD ALWAYS BE IN A VALID STATE.
         * 
         * 
         * PROPERTIES
         * 
         * - A property is a class member that encapsulates a getter/setter for accessing a field.
         * - What is the main purpose of a property?
         *      - To create a getter/seter with less code.
         * - 
         * - 
         * 
         */

        public class Person
        {
            private DateTime _birthdate;

            // If a field is private and you need to set and access it, you will need to create public methods.

            public void SetBirthdate(DateTime birthdate)
            {
                _birthdate = birthdate;
            }

            public DateTime GetBirthdate()
            {
                return _birthdate;
            }
        }

        public class Man
        {

            // PROPERTIES FIRST
            // THEN THE CONSTRUCTOR
            // AND THEN CALCULATED PROPERTIES/PROPERTIES THAT HAVE LOGIC.

            // With this expression, .NET will create the private field as well the getters and setters for us.
            // If we make the setter private, then the only way to set the properties is via the constructor.
            public DateTime BirthDate { get; private set; }
            public string Username { get; set; }
            public string Name { get; set; }

            public Man(DateTime birthdate)
            {
                BirthDate = birthdate;
            }

            public int Age
            {
                get
                {
                    var timeSpan = DateTime.Today - BirthDate;
                    var years = timeSpan.Days / 365;
                    return years;
                }
            }
        }
    }
}
