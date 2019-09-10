using System;
using System.IO;

namespace Extensibility
{
    public interface ILogger
    {
        void LogError(string message);
        void LogInfo(string message);
    }

    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }
    }

    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }

        public void LogError(string message)
        {
            // Since the stream writer is not managed by the CLR, we need to wrap this expression in
                // a using block so the app knows when to dispose of it when it has run.
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(message);
            }
        }

        public void LogInfo(string message)
        {
            throw new NotImplementedException();
        }
    }

    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo($"Migration started at {DateTime.Now}");

            // Details regarding the db migration

            _logger.LogInfo($"Migration finished at {DateTime.Now}");
        }
    }
}
