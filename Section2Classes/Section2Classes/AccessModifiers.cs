using System;

namespace Section2Classes
{
    class AccessModifiers
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
         * - When declaring properties, the convention is to declare them in camelCase, prefixed with an underscore.
         * 
         * 
         * IMPORTANT NOTE ON OBJECTS AND OOP
         * 
         * - Remember that objects are about behaviour.
         * - An object's fields are its internals, it's implementation details, which should be hidden away from the outside world.
         * - In essence, OBJECTS SHOULD HIDE THEIR IMPLEMENTATION DETAIL AND ONLY REVEAL THEIR BEHAVIOUR.
         * 
         */

        public class Person
        {
            private DateTime _birthdate;

            // If a property is private and you need to set and access it, you will need to create public methods.

            public void SetBirthdate(DateTime birthdate)
            {
                _birthdate = birthdate;
            }

            public DateTime GetBirthdate()
            {
                return _birthdate;
            }


        }

    }

}
