
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Ninject.Handler;
using Ninject.Ioc;
using Ninject.Mailing;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Ninject
{
    class Program
    {
        static void Main(string[] args)
        {

            var host = Host.CreateDefaultBuilder(args)
                .ConfigureServices(sc =>
                {
                    sc.AddCustomServices();
                    sc.AddHostedService<Projeto>();

                })
                
                .Build();

            host.Run();
            //    IServiceCollection serviceCollection = new ServiceCollection();
            //var serviceprovider = serviceCollection.BuildServiceProvider();
            //https://dfederm.com/building-a-console-app-with-.net-generic-host/


        }
    }


    public class Projeto : IHostedService
    {
        public Projeto(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        private readonly IServiceProvider serviceProvider;

        public  Task StartAsync(CancellationToken cancellationToken)
        {
            //IMailSender mailSender = serviceProvider.GetService<IMailSender>();
            var formHandler = serviceProvider.GetService<IFormHandler>();
            // var formHandler = new FormHandler(mailSender);
             var teste = formHandler.Handle("test@test.com");
            Console.WriteLine(teste);
            Console.ReadKey();
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}

/*
 * //setup our DI
        var serviceProvider = new ServiceCollection()
            .AddLogging()
            .AddSingleton<IFooService, FooService>()
            .AddSingleton<IBarService, BarService>()
            .BuildServiceProvider();

        //configure console logging
        serviceProvider
            .GetService<ILoggerFactory>()
            .AddConsole(LogLevel.Debug);

        var logger = serviceProvider.GetService<ILoggerFactory>()
            .CreateLogger<Program>();
        logger.LogDebug("Starting application");

        //do the actual work here
        var bar = serviceProvider.GetService<IBarService>();
        bar.DoSomeRealWork();

        logger.LogDebug("All done!");
 * */