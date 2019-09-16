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

    // Instead of logging messages to the console, we want to log them to a file:
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            // The dependency injection in this instance would be a path to the file.
            _path = path;
        }
        
        public void Log(string message, string messageType)
        {
            // Since the stream writer uses something called a FILE RESOURCE, and this is not managed by the CLR, we need to wrap this expression in
            // a using block so the app knows when to dispose of it when it has run.
            // Behind the scenes in this using block, an exception handler is executed and the compiler is reminded to call the dispose method on
            //  streamwriter.
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messageType + ": " + message);
                streamWriter.Dispose();
            }
        }

        public void LogError(string message)
        {
            Log(message, "ERROR");
        }

        public void LogInfo(string message)
        {
            Log(message, "INFO");
        }
    }

    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            // THIS IS AN EXAMPLE OF DEPENDENCY INJECTION
            // Note how the db migrator knows nothing about the console. It is just referencing an interface.
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
