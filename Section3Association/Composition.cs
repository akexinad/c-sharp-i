using System;

namespace Section3Association
{
    namespace Composition
    {
        /*
         * 
         * COMPOSITION is a kind of relationship between two classes that allows one to contain the other.
         * 
         * - The relationship is described as 'has-a', such as a car 'has-an' engine.
         * - Composition is far more flexible than inheritance.
         * 
         * - A simple example would be the how the Installer and DbMigrator class have a composition relationship with the LOGGER.
         *      - Both classes HAVE A logging method to provide you with information in the terminal during the installation process.
         * 
         */


        public class Logger
        {
            public void Log(string message)
            {
                Console.WriteLine(message);
            }
        }

        public class DbMigrator
        {
            private readonly Logger _logger;

            public DbMigrator(Logger logger)
            {
                _logger = logger;
            }

            public void Migrate()
            {
                _logger.Log("We are migrating");
            }
        }

        public class Installer
        {
            private readonly Logger _logger;

            public Installer(Logger logger)
            {
                _logger = logger;
            }

            public void Install()
            {
                _logger.Log("We are installing a program.");
            }
        }
    }
}
