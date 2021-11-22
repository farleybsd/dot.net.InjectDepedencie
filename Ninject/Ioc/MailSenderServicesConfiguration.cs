using Microsoft.Extensions.DependencyInjection;
using Ninject.Handler;
using Ninject.Logging;
using Ninject.Mailing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ninject.Ioc
{
    public static class MailSenderServicesConfiguration
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddSingleton<IMailSender, MockMailSender>();
            services.AddSingleton<ILogging, MockLogging>();
            services.AddSingleton<IFormHandler, FormHandler>();
        }
    }
}
