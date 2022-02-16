using System;

namespace OOP3
{
    class FileLogggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya Loglandı..");
        }
    }
}
