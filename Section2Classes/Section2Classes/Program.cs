using Section2Classes.Indexers;
using Section2Classes.Fields;
using System;

namespace Section2Classes
{
    partial class Program
    {

        static void Main(string[] args)
        {
            var person = new Person()
            {
                Name = "Benigni"
            };

            person.Introduce("Fellini");

            var p = Person.Parse("Pasolini");
            p.Introduce("Luca");


            //var customer = new Customer();

            //var order = new Order();
            //customer.Orders.Add(order);


            //UseOverloadsPoints();

            UseParamsCalculator();



            Customer customer = new Customer(44);
            customer.Orders.Add(new Customer.Order());
            customer.Orders.Add(new Customer.Order());
            customer.Orders.Add(new Customer.Order());

            customer.Promote();

            Console.WriteLine(customer.Orders.Count);


            var privatePerson = new AccessModifiers.Person();
            privatePerson.SetBirthdate(new DateTime(1990, 4, 4));
            Console.WriteLine(privatePerson.GetBirthdate());

            var me = new AccessModifiers.Man(new DateTime(1990, 4, 4));
            Console.WriteLine(me.Age);

            Console.Clear();

            // INDEXERS
            var cookie = new HttpCookie();
            cookie["name"] = "fellini";
            Console.WriteLine(cookie["name"]);


        }

        static void UseOverloadsPoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine($"{ point.X }, { point.Y }");

                point.Move(100, 200);
                Console.WriteLine($"{ point.X }, { point.Y }");
            }
            catch (Exception)
            {
                Console.WriteLine("newLocation cannot be null \n A try catch block will stop your application from running.");
            }

        }

        static void UseParamsCalculator()
        {
            var calculator = new Calculator();

            // With the params keyword in the Add method, you can pass a varying amount of keywords.

            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3, 4, 5, 6));

            // You can also call a new array, but there is no need to.
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3 }));

        }
    }
}
