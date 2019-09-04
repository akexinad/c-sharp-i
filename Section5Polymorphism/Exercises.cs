using System;

namespace Section5Polymorphism
{
    namespace Exercises
    {
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
                this.ConnectionString = connectionString;
                this.Timeout = TimeSpan.FromSeconds(5);
                this.CreatedAt = DateTime.Now;
            }

            public override void Open()
            {
                var connectionOpened = DateTime.Now;

                if (connectionOpened > this.CreatedAt + this.Timeout)
                    throw new Exception("Connection has timed out");

                Console.WriteLine("Connection is open");
            }

            public override void Close()
            {
                Console.WriteLine("Connection is closed");
            }
        }
    }
}
