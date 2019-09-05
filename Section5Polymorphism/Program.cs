using Section5Polymorphism.AbstractClasses;
using Section5Polymorphism.Exercises;
using Section5Polymorphism.MethodOverriding;
using System;
using System.Collections.Generic;

namespace Section5Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // OVERRIDING AND POLYMORPHISM

            var shapes = new List<Shape>();

            shapes.Add(new Circle());
            shapes.Add(new Rectangle());
            shapes.Add(new Triangle());

            var canvas = new Canvas();

            canvas.DrawShapes(shapes);

            var landCruiser = new FourWD();
            landCruiser.Start();

            Console.Clear();

            // EXERCISES
            // =========

            //var sqlConnection = new SqlConnection("connection string");
            var sqlConnection = new SqlConnection("hello world");

            //var dbCommands = new DbCommand(sqlConnection);
            var dbCommands = new DbCommand(sqlConnection);
            dbCommands.Execute();

            var mongoDBCommand = new DbCommand(new MongoDBConnection("to mongo atlas"));

            mongoDBCommand.Execute();
        }
    }
}
