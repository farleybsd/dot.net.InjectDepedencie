using System;
using System.Collections.Generic;
using System.Text;

namespace Ninject.Handler
{
    interface IFormHandler
    {
        string Handle(string toAddress);
    }
}
