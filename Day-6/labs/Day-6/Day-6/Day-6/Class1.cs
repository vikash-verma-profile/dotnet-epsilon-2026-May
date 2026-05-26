using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    class FileLogger : StreamWriter,IDisposable
    {
        private bool _disposed = false;
        public FileLogger(string filePath):base(filePath)
        {
                
        }
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;
            
            if (disposing)
            {
                // Free managed resources
            }

            // Free unmanaged resources
            _disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        ~FileLogger()
        {
            Dispose(false);
        }
    }
    internal class Class1
    {
        public static void Main2()
        {
            using (var log = new FileLogger("app.log"))
            {
                Console.WriteLine("Hello I am from file logger");
            }

            Console.WriteLine("I am afrer filelogger");
        }
    }
}
