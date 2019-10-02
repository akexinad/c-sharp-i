using Extensibility;
using Polymorphism;
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


            // In the program, we pass in a concrete implementation of the ILogger interface
            var migrator = new DbMigrator(new ConsoleLogger());
            migrator.Migrate();

            var dbMigrator = new DbMigrator(new FileLogger("C:/Users/cecd304/me/info.txt"));

            dbMigrator.Migrate();

            Console.Clear();

            var encoder = new VideoEncoder();

            encoder.RegisterNotificationChannel(new MailNotificationChannel());
            encoder.RegisterNotificationChannel(new SmsNotificationChannel());

            encoder.Encode(new Video());
        }
    }
}
