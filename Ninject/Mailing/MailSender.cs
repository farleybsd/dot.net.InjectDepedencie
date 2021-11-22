using Ninject.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ninject.Mailing
{
    public class MailSender : IMailSender
    {
        private readonly ILogging _logging;
        public MailSender(ILogging logging)
        {
            this._logging = logging;
        }
        public void Send(string tooAdress, string subject)
        {
            _logging.Debug("Sending mail");
            Console.WriteLine("Sending mail to [{0}] with subject [{1}]", tooAdress, subject);
        }
    }
}
