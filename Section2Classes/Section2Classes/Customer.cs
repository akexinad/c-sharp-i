using System.Collections.Generic;

namespace Section2Classes
{
    public class Customer
    {
        /*
        * CONSTRUCTORS
        * ============
        * 
        * - A constructor is a method that is called when an instance of a class is created.
        * - It's purpose is to put an object in an early state.
        * - The constructor have the same name as the class and do not have the return type.
        * - You can have a paramterless constructor, or .NET will create one for you.
        * 
        * 
        * CONSTRUCTOR OVERLOADING
        * =======================
        * 
        * - You can multiple constructors.
        * - Constuctor overloading makes initialization of the class easier.
        * 
        * 
        * WHEN TO USE CONSTRUCTORS
        * ========================
        * 
        * - NOTE that you would only use a constructor if you really want to initialize your class with an early state that is essential for the class to perform.
        * - See the order class below.
        * 
        * 
        * - In this section we learnt about:
        *       - Parameterless Constructors
        *       - Overloading Constructors
        *       - How we can use the `this` keyword to pass on the execution to other constructors.
        */

        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            // This is an example of the necessity of the constructor
            Orders = new List<Order>();
        }
        public Customer(int id)
            : this()
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id) // THIS LINE HEAR WILL CALL THE OTHER CONSTRUCTORS AND INITIALIZE THEIR VARIABLES.
        {
            this.Name = name;
        }


    }

    public class Order
    {

    }
}
