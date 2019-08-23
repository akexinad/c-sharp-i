using System.Collections.Generic;

namespace Section2Classes
{
    public class Fields
    {

        /*
         * 
         * THE READONLY MODIFIER
         * =====================
         * 
         * - In a field declaration, readonly indicates that assignment to the field can only occur as part of the declaration or in a constructor in the same class. 
         * - A readonly field can be assigned and reassigned multiple times within the field declaration and constructor.
         * 
         * - Thus you cannot initialise Order outside of the constructor, because by doing so it will overwrite any initialization that happens when you instantiate
         *      Orders
         */
        public class Customer
        {
            public int Id;
            public string Name;
            public readonly List<Order> Orders = new List<Order>();

            public Customer(int id)
            {
                this.Id = id;
            }

            public Customer(int id, string name)
                :this(id)
            {
                this.Name = name;
            }
            public class Order
            {

            }
            public void Promote()
            {
                // Orders = new List<Order>(); // => Cannot this anymore since it is readonly. Initialization can only happen in the constructor.
            }




        }
    }
}
