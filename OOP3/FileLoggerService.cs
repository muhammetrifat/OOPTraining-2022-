using System;

namespace OOP3
{
    public class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya log kaydı yapıldı.");
        }
    }
}
