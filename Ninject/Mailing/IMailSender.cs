using System;
using System.Collections.Generic;
using System.Text;

namespace Ninject.Mailing
{
    public interface IMailSender
    {
        void Send(string tooAdress, string subject);
    }
}
