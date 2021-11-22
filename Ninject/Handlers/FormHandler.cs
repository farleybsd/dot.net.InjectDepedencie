using Ninject.Mailing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ninject.Handler
{
    public class FormHandler : IFormHandler
    {
        private readonly IMailSender _mailSender;
        public FormHandler(IMailSender mailSender)
        {
            this._mailSender = mailSender;
        }
        public string Handle(string toAddress)
        {
            _mailSender.Send(toAddress, "Sending a mail");
            return "Passei Aqui";
        }
    }
}
