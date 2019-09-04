using System;

namespace Section5Polymorphism
{
    namespace Exercises
    {
        // EXERCISE 1
        public abstract class DBConnection
        {
            public string ConnectionString { get; set; }
            public TimeSpan Timeout { get; set; }
            public DateTime CreatedAt { get; set; }

            public abstract void Open();

            public abstract void Close();

        }

        public class SqlConnection : DBConnection
        {
            public SqlConnection(string connectionString)
            {
                ConnectionString = connectionString;

                if (String.IsNullOrEmpty(ConnectionString))
                    throw new NullReferenceException("SQL Connection string cannot be null.");

                Timeout = TimeSpan.FromSeconds(5);
                CreatedAt = DateTime.Now;
            }

            public override void Open()
            {
                var connectionOpened = DateTime.Now;

                if (connectionOpened > this.CreatedAt + this.Timeout)
                    throw new Exception("Connection has timed out");

                Console.WriteLine("SQL Connection is open");
            }

            public override void Close()
            {
                Console.WriteLine("SQL Connection is closed");
            }
        }

        public class MongoDBConnection : DBConnection
        {
            public MongoDBConnection(string connectionString)
            {
                ConnectionString = connectionString;

                if (String.IsNullOrEmpty(ConnectionString))
                    throw new NullReferenceException("SQL Connection string cannot be null.");

                Timeout = TimeSpan.FromSeconds(5);
                CreatedAt = DateTime.Now;
            }

            public override void Open()
            {
                var connectionOpened = DateTime.Now;

                if (connectionOpened > this.CreatedAt + this.Timeout)
                    throw new Exception("Connection has timed out");

                Console.WriteLine("MONGODB Connection is open");
            }

            public override void Close()
            {
                Console.WriteLine("MONGODB Connection is closed");
            }
        }



        // EXERCISE 2
        public class DbCommand
        {
            public DBConnection DBConnection { get; set; }

            public DbCommand(DBConnection dbConnection)
            {
                DBConnection = dbConnection;

                if (dbConnection == null)
                    throw new NullReferenceException("You must have a database connection in order to execute db commands.");
            }

            public void Execute()
            {
                DBConnection.Open();
                Console.WriteLine("Executing database command.");
                DBConnection.Close();
            }
        }
    }
}
