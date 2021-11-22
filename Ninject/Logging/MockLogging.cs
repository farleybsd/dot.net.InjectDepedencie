using System;
using System.Collections.Generic;
using System.Text;

namespace Ninject.Logging
{
    public class MockLogging : ILogging
    {
        public void Debug(string message)
        {
            Console.WriteLine("Mock Debug: [{0}]", message);
        }
    }
}
