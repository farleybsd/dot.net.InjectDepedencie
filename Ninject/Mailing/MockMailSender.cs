using Ninject.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ninject.Mailing
{
    public class MockMailSender : IMailSender
    {
        private readonly ILogging _logging;

        public MockMailSender(ILogging logging)
        {
            this._logging = logging;
        }

        public void Send(string toAddress, string subject)
        {
            _logging.Debug("Sending mail");
            Console.WriteLine("Mocking mail to [{0}] with subject [{1}]", toAddress, subject);
        }
    }
}
