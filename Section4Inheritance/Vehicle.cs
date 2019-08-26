using System;

namespace Section4Inheritance
{
    namespace Constructors
    {
        public class Vehicle
        {
            private readonly string _registrationNumber;

            //public Vehicle()
            //{
            //    Console.WriteLine("Vehicle is being initialised");
            //}

            // REMEMBER? You can have multiple constructors. The first is the default and the others can take an option of parameters.
            public Vehicle(string registrationNumber)
            {
                _registrationNumber = registrationNumber;

                Console.WriteLine("Vehicle is being initialised {0}", registrationNumber);

            }
        }

        public class Car : Vehicle
        {
            public Car(string registrationNumber)
                : base(registrationNumber)
            {
                Console.WriteLine("Car is being initialised: {0}", registrationNumber);
            }
        }
    }
}
