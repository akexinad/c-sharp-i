using System;

namespace Section4Inheritance
{
    namespace AccessModifers
    {
        public class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public void Promote()
            {
                var rating = CalculateRating(excludeOrders: true);
                if (rating == 0)
                {
                    Console.WriteLine("Promoted to level 1");
                }
                else
                {
                    Console.WriteLine("Promoted to level 2");
                }
            }


            /*
             * This is an example of where calculateRating() would be considered part of the
             * implementation and not the public interface, Therefore it should be tagged with the
             * private access modifier.
             * 
             * If someone was to reference this method outside of the class and then for some
             * reason the method had to change, it would break the app.
             * 
             * However, if it is made private, the only place where you would have to change the
             * code is within the class that utilizes the method.
             *
             */
            private int CalculateRating(bool excludeOrders)
            {
                return 0;
            }
        }

        public class GoldCustomer : Customer
        {
            // The GoldCustomer does not even have access to the CalculateRating method.
            // If you change its access modifier to protected, you can access it
            // HOWEVER, YOU ARE BREAKING ENCAPSULATION. Things can get hairy.
            public void OfferVoucher()
            {

            }
        }
    }
}
