
namespace Interface
{
    public class InterfacesAndExtensibility
    {
        public interface Ilogger
        {
            void LogError(string message);
            void LogInfo(string message);
        }

        public class ConsoleLogger : Ilogger
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

        public class FileLogger : Ilogger
        {
            private readonly string _path;

            public FileLogger(string path)
            {
                _path = path;
            }

            public void LogError(string message)
            {
                Log(message, "ERROR");
            }

            public void LogInfo(string message)
            {
                Log(message, "INFO");
            }

            private void Log(string message, string messageType)
            {
                using (var streamWriter = new StreamWriter(_path, true))
                {
                    streamWriter.WriteLine($"{messageType}: {message}");
                };
            }
        }


        public class DbMigrator
        {
            private readonly Ilogger _logger;

            public DbMigrator(Ilogger logger)
            {
                _logger = logger;
            }

            public void Migrate()
            {
                _logger.LogInfo("Migrationg started at {0}" + DateTime.Now);

                //Detail of migrating the datebase

                _logger.LogInfo("Migrationg finished at {0}" + DateTime.Now);
            }
        }

        public static void InterfacesAndExtensibilityProgram()
        {
            //var dbMigration = new DbMigrator(new ConsoleLogger());

            var dbMigration = new DbMigrator(new FileLogger("C:\\Users\\kolay\\source\\repos\\CSharpIntermediate\\Interface\\log.txt"));

            dbMigration.Migrate();

            Console.WriteLine("-----------------------------------------------------------------------");
        }
    }
}