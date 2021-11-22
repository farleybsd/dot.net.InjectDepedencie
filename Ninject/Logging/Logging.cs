using System;
using System.Collections.Generic;
using System.Text;

namespace Ninject.Logging
{
    public class Logging : ILogging
    {
        public void Debug(string message)
        {
            Console.WriteLine("Debug: [{0}]", message);
        }
    }
}
