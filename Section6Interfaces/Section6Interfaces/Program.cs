using Extensibility;
using Section6Interfaces;
using System;
using Testability;

namespace Section6Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator());

            var order = new Order
            {
                DatePlaced = DateTime.Now,
                TotalPrice = 100f
            };

            //orderProcessor.Process(order);

            Console.Clear();

            // In the program, we pass in a concrete implementation of the ILogger interface
            var migrator = new DbMigrator(new ConsoleLogger());
            migrator.Migrate();

            var dbMigrator = new DbMigrator(new FileLogger("C:/Users/cecd304/me/info.txt"));

            dbMigrator.Migrate();
        }
    }
}
